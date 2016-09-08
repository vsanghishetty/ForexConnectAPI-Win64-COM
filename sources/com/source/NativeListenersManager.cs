using System;
using System.Collections.Generic;
using System.Text;
using fxcore2;

namespace fxcore2.com
{    
    /// <summary>
    /// Generate NET listeners and wrap COMListeners that implemented by external client and passed to wrapper to subscribe
    /// </summary>
    internal static class NativeListenersManager
    {
        static Dictionary<object, object> mReferences = new Dictionary<object, object>();

        public static object CreateListener(object oCOMCallbackInterface, Session session)
        { 
            if(oCOMCallbackInterface is ITableListener)
            {
                object objInstance = null;
                if (mReferences.TryGetValue(oCOMCallbackInterface, out objInstance))
                    ((ManagedReferenceListener)objInstance).AddRef();
                else
                {
                    objInstance = new NativeTableListener((ITableListener)oCOMCallbackInterface, session);
                    mReferences.Add(oCOMCallbackInterface, objInstance); //save reference
                }
                return objInstance;
            }
            else if (oCOMCallbackInterface is ISessionStatus)
            {
                object objInstance = null;
                if (mReferences.TryGetValue(oCOMCallbackInterface, out objInstance))
                    ((ManagedReferenceListener)objInstance).AddRef();
                else
                {
                    objInstance = new NativeSessionStatusListener((ISessionStatus)oCOMCallbackInterface, session);
                    mReferences.Add(oCOMCallbackInterface, objInstance); //save reference
                }
                return objInstance;
            }
            else if (oCOMCallbackInterface is IChartSessionStatus)
            {
                object objInstance = null;
                if (mReferences.TryGetValue(oCOMCallbackInterface, out objInstance))
                    ((ManagedReferenceListener)objInstance).AddRef();
                else
                {
                    objInstance = new NativeChartSessionStatusListener((IChartSessionStatus)oCOMCallbackInterface, session);
                    mReferences.Add(oCOMCallbackInterface, objInstance); //save reference
                }
                return objInstance;
            }
            else if (oCOMCallbackInterface is IResponseListener)
            {
                object objInstance = null;
                if (mReferences.TryGetValue(oCOMCallbackInterface, out objInstance))
                    ((ManagedReferenceListener)objInstance).AddRef();
                else
                {
                    objInstance = new NativeResponseListener((IResponseListener)oCOMCallbackInterface, session);
                    mReferences.Add(oCOMCallbackInterface, objInstance); //save reference
                }
                return objInstance;
            }
            else if (oCOMCallbackInterface is ITableManagerListener)
            {
                object objInstance = null;
                if (mReferences.TryGetValue(oCOMCallbackInterface, out objInstance))
                    ((ManagedReferenceListener)objInstance).AddRef();
                else
                {
                    objInstance = new NativeTableManagerListener((ITableManagerListener)oCOMCallbackInterface, session);
                    mReferences.Add(oCOMCallbackInterface, objInstance); //save reference
                }
                return objInstance;
            }
            else if (oCOMCallbackInterface is IEachRowListener)
            {
                object objInstance = null;
                if (mReferences.TryGetValue(oCOMCallbackInterface, out objInstance))
                    ((ManagedReferenceListener)objInstance).AddRef();
                else
                {
                    objInstance = new NativeEachRowListener((IEachRowListener)oCOMCallbackInterface, session);
                    mReferences.Add(oCOMCallbackInterface, objInstance); //save reference
                }
                return objInstance;
            }
            else  //TODO for other callback interfaces
                return null;
        }
        
        public static void DisposeListener(object externalListener)
        {
            object obj;
            if (mReferences.TryGetValue(externalListener, out obj))
            {
                ManagedReferenceListener mrl = (ManagedReferenceListener)obj;
                if(mrl.Release()<1)
                    mReferences.Remove(externalListener);
            }
        }

        public static object GetNativeListener(object externalListener)
        {
            object obj;
            if (mReferences.TryGetValue(externalListener, out obj))
                return obj;
            else
                return null;
        }

    }

    internal class ManagedListenerBase
    {
        internal EventsSynchronizationContext SyncContext
        {
            get 
            {
                return EventsSynchronizationContext.GetSyncContext;
            }
        }
    }

    internal class ManagedReferenceListener:ManagedListenerBase
    {
        private int mCount = 1;

        public int Count { get{return mCount;} }

        public int AddRef()
        {
            mCount++;
            return mCount;
        }

        public int Release()
        {
            mCount--;
            return mCount;
        }
    }

    internal class NativeTableListener : ManagedReferenceListener, fxcore2.IO2GTableListener
    {
        ITableListener mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeTableListener(ITableListener comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }

        #region IO2GTableListener Members

        public void onAdded(string rowID, O2GRow rowData)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.Added(evState.RowID, new Row(evState.Row, evState.Session));
                    }
                }, new EvState(rowID, rowData, mSession));
        }

        public void onChanged(string rowID, O2GRow rowData)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.Changed(evState.RowID, new Row(evState.Row, evState.Session));
                    }
                }, new EvState(rowID, rowData, mSession));

        }

        public void onDeleted(string rowID, O2GRow rowData)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.Deleted(evState.RowID, new Row(evState.Row, evState.Session));
                    }
                }, new EvState(rowID, rowData, mSession));
        }

        public void onStatusChanged(O2GTableStatus status)
        {            
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        O2GTableStatus evState = (O2GTableStatus)state;
                        mComListener.StatusChanged((TableStatus)(int)evState);
                    }
                }, status);
        }

        #endregion

        private class EvState
        {
            public EvState(string rowID, O2GRow row, Session session)
            {
                mRowID = rowID;
                mRow = row;
                mSession = session;
            }

            public string RowID
            {
                get { return mRowID; }
            }
            private string mRowID;

            public O2GRow Row
            {
                get { return mRow; }
            }
            private O2GRow mRow;

            public Session Session
            {
                get { return mSession; }
            }
            private Session mSession;
        }
    }
    
    internal class NativeUpdatesProcessStatusListener : ManagedReferenceListener, fxcore2.IO2GUpdatesProcessStatusListener
    {
        IUpdatesProcessStatusListener mComListener;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeUpdatesProcessStatusListener(IUpdatesProcessStatusListener comListener, Session session)
        {
            mComListener = comListener;
        }

        #region IO2GUpdatesProcessStatusListener Members

        public void onUpdatesProcessStatusChanged(O2GUpdatesProcessStatus status)
        {            
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        O2GUpdatesProcessStatus evState = (O2GUpdatesProcessStatus)state;
                        mComListener.ManagerUpdatesProcessStatusChanged((UpdatesProcessStatus)(int)evState);
                    }
                }, status);
        }

        #endregion

    }
    
    internal class NativeUpdateEventQueueListener : ManagedReferenceListener, fxcore2.IO2GUpdateEventQueueListener
    {
        IUpdateEventQueueListener mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeUpdateEventQueueListener(IUpdateEventQueueListener comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }

        #region IO2GUpdatesProcessStatusListener Members
        
        public void onPutInQueue(O2GRow rowData)
        {            
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.UpdateEventQueuePutInQueue(new Row(evState.Row, evState.Session));
                    }
                }, new EvState(rowData, mSession));
        }

        #endregion

        private class EvState
        {
            public EvState(O2GRow row, Session session)
            {
                mRow = row;
                mSession = session;
            }

            public O2GRow Row
            {
                get { return mRow; }
            }
            private O2GRow mRow;

            public Session Session
            {
                get { return mSession; }
            }
            private Session mSession;
        }
        
    }

    internal class NativeEachRowListener : ManagedReferenceListener, fxcore2.IO2GEachRowListener
    {
        IEachRowListener mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeEachRowListener(IEachRowListener comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }
    
        #region IO2GEachRowListener Members

        public void  onEachRow(string rowID, O2GRow rowData)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.EachRow(evState.RowID, new Row(evState.Row, evState.Session));
                    }
                }, new EvState(rowID, rowData, mSession));
        }

        #endregion

        private class EvState
        {
            public EvState(string rowID, O2GRow row, Session session)
            {
                mRowID = rowID;
                mRow = row;
                mSession = session;
            }

            public string RowID
            {
                get { return mRowID; }
            }
            private string mRowID;

            public O2GRow Row
            {
                get { return mRow; }
            }
            private O2GRow mRow;

            public Session Session
            {
                get { return mSession; }
            }
            private Session mSession;
        }
    }

    internal class NativeResponseListener : ManagedReferenceListener, fxcore2.IO2GResponseListener
    {
        IResponseListener mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeResponseListener(IResponseListener comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }
        

        #region IO2GResponseListener Members

        public void onRequestCompleted(string requestId, O2GResponse response)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.RequestCompleted(evState.RequestId, new Response(evState.Response, evState.Session));
                    }
                }, new EvState(requestId, response, mSession));
        }

        public void onRequestFailed(string requestId, string error)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.RequestFailed(evState.RequestId, evState.Error);
                    }
                }, new EvState(requestId, error, mSession));
        }

        public void onTablesUpdates(O2GResponse data)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        EvState evState = (EvState)state;
                        mComListener.TablesUpdates(new Response(evState.Response, evState.Session));
                    }
                }, new EvState(null, data, mSession));
        }

        #endregion

        private class EvState
        {
            public EvState(string requestId, O2GResponse response, Session session)
            {
                mRequestId = requestId;
                mResponse = response;
                mSession = session;
                mError = null;
            }
            public EvState(string requestId, string error, Session session)
            {
                mRequestId = requestId;
                mSession = session;
                mError = error;
            }

            public string Error
            {
                get { return mError; }
            }
            private string mError;

            public string RequestId
            {
                get { return mRequestId; }
            }
            private string mRequestId;

            public O2GResponse Response
            {
                get { return mResponse; }
            }
            private O2GResponse mResponse;

            public Session Session
            {
                get { return mSession; }
            }
            private Session mSession;
        }
    }

    internal class NativeSessionStatusListener : ManagedReferenceListener, fxcore2.IO2GSessionStatus
    {
        ISessionStatus mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeSessionStatusListener(ISessionStatus comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }

        #region IO2GSessionStatus Members

        public void onLoginFailed(string error)
        {
            SyncContext.Post(delegate(object state)
                {
                    string evState = (string)state;
                    if (mComListener != null)
                        mComListener.LoginFailed(evState);
                }, error);
        }

        public void onSessionStatusChanged(O2GSessionStatusCode status)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        O2GSessionStatusCode evState = (O2GSessionStatusCode)state;
                        mComListener.SessionStatusChanged((SessionStatusCode)(int)evState);
                    }
                }, status);
        }

        #endregion
    }

    internal class NativeChartSessionStatusListener : ManagedReferenceListener, fxcore2.IO2GChartSessionStatus
    {
        IChartSessionStatus mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeChartSessionStatusListener(IChartSessionStatus comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }

        #region IO2GChartSessionStatus Members

        public void onChartSessionLoginFailed(string error)
        {
            SyncContext.Post(delegate(object state)
                {
                    string evState = (string)state;
                    if (mComListener != null)
                        mComListener.ChartSessionLoginFailed(evState);
                }, error);
        }

        public void onChartSessionStatusChanged(O2GChartSessionStatusCode status)
        {
            SyncContext.Post(delegate(object state)
                {
                    if (mComListener != null)
                    {
                        O2GChartSessionStatusCode evState = (O2GChartSessionStatusCode)state;
                        mComListener.ChartSessionStatusChanged((ChartSessionStatusCode)(int)evState);
                    }
                }, status);
        }

        #endregion
    }

    internal class NativeTableManagerListener : ManagedReferenceListener, fxcore2.IO2GTableManagerListener
    {
        ITableManagerListener mComListener;
        Session mSession;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comListener"></param>
        public NativeTableManagerListener(ITableManagerListener comListener, Session session)
        {
            mComListener = comListener;
            mSession = session;
        }

        #region IO2GTableManagerListener Members

        public void onStatusChanged(O2GTableManagerStatus status, O2GTableManager tableManager)
        {
                SyncContext.Post(delegate(object state)
                    {
                        if (mComListener != null)
                        {
                            EvState evState = (EvState)state;
                            mComListener.ManagerStatusChanged((TableManagerStatus)(int)evState.Status, (ITableManager)Utils.CheckWrapperForNativeNull(new TableManager(evState.TableManager, evState.Session)));
                        }
                    }, new EvState(status, tableManager, mSession));
        }

        #endregion

        private class EvState
        {
            public EvState(O2GTableManagerStatus status, O2GTableManager tableManager, Session session)
            {
                mStatus = status;
                mTableManager = tableManager;
                mSession = session;
            }

            public Session Session
            {
                get { return mSession; }
            }
            private Session mSession;

            public O2GTableManagerStatus Status
            {
                get { return mStatus; }
            }
            private O2GTableManagerStatus mStatus;

            public O2GTableManager TableManager
            {
                get { return mTableManager; }
            }
            private O2GTableManager mTableManager;
        }
    }
}
