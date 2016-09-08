using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.ComponentModel;
using System.Collections;

namespace fxcore2.com
{
    /// <summary>
    /// Helper class to synchronize for sink events consuming
    /// </summary>
    internal class EventsSynchronizationContext : SynchronizationContext, IDisposable
    {
        public static EventsSynchronizationContext GetSyncContext
        {
            get
            {
                if (msSyncContext == null)
                    msSyncContext = new EventsSynchronizationContext();
                return msSyncContext;
            }
        }
        private static EventsSynchronizationContext msSyncContext = null;

        private ISynchronizeInvoke mSyncInvoke = null;
        private System.Windows.Forms.Form mFrm = null;
        private Thread mWorkerThread = null;
        private EventWaitHandle mPostEventWaitHandle = null;
        private TwoLockQueue<IAction> mPostQueue = null;

        /// <summary>
        /// ctor
        /// </summary>
        private EventsSynchronizationContext()
        {
            //create form to have sync context
            mFrm = new System.Windows.Forms.Form();
            mFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mFrm.Width = 1;
            mFrm.Height = 1;
            mFrm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            mFrm.Visible = false;
            mFrm.ShowInTaskbar = false;
            mFrm.Show();
            mSyncInvoke = mFrm;

            //create one thread for async Post queue
            mPostQueue = new TwoLockQueue<IAction>();
            mPostEventWaitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
            mWorkerThread = new Thread(PostWorkerProc);
            mWorkerThread.IsBackground = true;
            mWorkerThread.Start();
        }

        /// <summary>
        /// Post thread procedure
        /// </summary>
        private void PostWorkerProc()
        {
            try
            {
                while (!mIsDisposed)
                {
                    while (mPostQueue.Count > 0)
                    {
                        IAction action = mPostQueue.Dequeue();
                        try
                        {
                            action.GetActionDelegate().Invoke(); //will sync with mSynkInvoke
                        }
                        catch
                        {
                            //IGNORE ???
                        }
                        if (mIsDisposed)
                            break;
                    }

                    mPostEventWaitHandle.WaitOne(); //queue is empty, wait enqueue
                }
            }
            finally
            {
                mPostEventWaitHandle.Close();
                mPostEventWaitHandle = null;
            }
        }

        ~EventsSynchronizationContext()
        {
            this.Dispose();
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            mPostQueue.Enqueue(new Action(delegate()
            {
                this.Send(d, state);
            }));
            mPostEventWaitHandle.Set();
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            if (mSyncInvoke == null)
                return;
            OperationStarted();
            if (mSyncInvoke.InvokeRequired)
                mSyncInvoke.Invoke(d, new object[] { state });
            else
                d.Invoke(state);
            OperationCompleted();
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (mFrm != null)
            {
                if (mSyncInvoke.InvokeRequired)
                    mSyncInvoke.Invoke((SendOrPostCallback)delegate(object state) { mFrm.Close(); }, new object[] { });
                else
                    mFrm.Close();
                mFrm = null;
            }
            if (mSyncInvoke != null)
                mSyncInvoke = null;
            mIsDisposed = true;
        }
        private volatile bool mIsDisposed = false;

        #endregion

    }

    internal delegate void PostAction();

    internal interface IAction
    {
        PostAction GetActionDelegate();
    }

    internal class Action : IAction
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="action"></param>
        public Action(PostAction action)
        {
            mAction = action;
        }

        #region IAction Members

        public PostAction GetActionDelegate()
        {
            return mAction;
        }
        private PostAction mAction;

        #endregion
    }

    /// <summary>
    /// Two-Lock Concurrent Queue Algorithm
    ///http://www.cs.rochester.edu/u/scott/...de/queues.html
    /// </summary>
    internal class TwoLockQueue<T> where T : IAction
    {
        private Node<T> head;
        private Node<T> tail;
        private readonly object headLock;
        private readonly object tailLock;
        private int count;

        /// <summary>
        /// ctor
        /// </summary>
        public TwoLockQueue()
        {
            headLock = new object();
            tailLock = new object();
            T nullObj = default(T);
            Node<T> node = new Node<T>(nullObj);
            head = tail = node;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public ArrayList Values
        {
            get
            {
                lock (headLock)
                {
                    lock (tailLock)
                    {
                        ArrayList values = new ArrayList();
                        Node<T> node = head.next;
                        while (node != null)
                        {
                            values.Add(node.value);
                            node = node.next;
                        }
                        return values;
                    }
                }
            }
        }

        private class Node<TData> where TData : IAction
        {
            internal TData value;
            internal Node<TData> next;

            internal Node(TData value)
            {
                this.value = value;
                next = null;
            }
        }

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            lock (tailLock)
            {
                tail.next = node; // Link node at the end of the linked list.
                tail = node; // Swing Tail to new node.
                Interlocked.Increment(ref count);
            }
        }

        public T Dequeue()
        {
            T value = default(T);
            lock (headLock)
            {
                Node<T> first = head.next; // Get pointer to first object or null if empty.
                if (first != null) // Have object to dequeue?
                {
                    value = first.value; // We have an object.
                    head = first; // Set head to next object.
                    head.value = default(T); // Clear value so we don't hold a reference.
                    Interlocked.Decrement(ref count);
                }
                return value;
            }
        }
    }
}
