using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace fxcore2.com
{
    partial class Transport
    {
        /// <summary>
        /// default ctor to allow create this class from COM client
        /// </summary>
        public Transport()
        {
            mNetObj = null;
        }
    }

    partial interface ITableColumnCollection
    {
        [DispId(0x60040002)]
        ITableColumn Item(int index);

        [DispId(0x60040003)]
        ITableColumn ItemByID(string columnId);
    }

    partial class TableColumnCollection
    {
        public ITableColumn Item(int index)
        {
            ITableColumn result = (ITableColumn)Utils.CheckWrapperForNativeNull(new TableColumn(mNetObj[index], mSession));
            return result;
        }

        public ITableColumn ItemByID(string id)
        {
            ITableColumn result = (ITableColumn)Utils.CheckWrapperForNativeNull(new TableColumn(mNetObj[id], mSession));
            return result;
        }
    }

    partial class SessionDescriptorCollection
    {
        public ISessionDescriptor Item(int index)
        {
            ISessionDescriptor result = (ISessionDescriptor)Utils.CheckWrapperForNativeNull(new SessionDescriptor(mNetObj[index], mSession));
            return result;
        }
    
    }

    partial class CommissionDescriptionsCollection
    {
        public ICommissionDescription Item(int index)
        {
            ICommissionDescription result = (ICommissionDescription)Utils.CheckWrapperForNativeNull(new CommissionDescription(mNetObj[index], mSession));
            return result;
        }

    }

    [ComVisible(true)]
    [Guid("432EA17D-C55B-4FBC-982D-ECF343FABBDB")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ISessionCallback //: ISessionStatus, IChartSessionStatus, ITableManagerListener, IResponseListener
    {
        [DispId(0x60020201)]
        void SessionStatusChanged(
            SessionStatusCode status
            );

        [DispId(0x60020002)]
        void LoginFailed(
            string error
            );

        [DispId(0x60020101)]
        void ManagerStatusChanged(
            TableManagerStatus status, [MarshalAs(UnmanagedType.IDispatch)]ITableManager tableManagerObj
            );

        [DispId(0x60020401)]
        void RequestCompleted(
            string paramRequestID, [MarshalAs(UnmanagedType.IDispatch)]IResponse responseObj
            );

        [DispId(0x60020402)]
        void RequestFailed(
            string paramRequestID, string error
            );

        [DispId(0x60020403)]
        void TablesUpdates(
            [MarshalAs(UnmanagedType.IDispatch)]IResponse responseObj
            );

        [DispId(0x60020404)]
        void ChartSessionStatusChanged(
            ChartSessionStatusCode status
            );

        [DispId(0x60020405)]
        void ChartSessionLoginFailed(
            string error
            );

    }

    [ComSourceInterfaces(typeof(ISessionCallback))] //, typeof(ISessionStatus), typeof(IChartSessionStatus), typeof(ITableManagerListener), typeof(IResponseListener))]
    //[ClassInterface(ClassInterfaceType.AutoDual)]
    partial class Session
    {
        private volatile bool mSessionReady = false;

        private fxcore2.IO2GTableManagerListener mNativeTableManagerListener = null;

        private EventsSynchronizationContext mSyncContext;

        private const int SESSION_TIMEOUT = 30000;
        private const int REQUEST_TIMEOUT = 120000;

        private EventWaitHandle mSessionWaitHandle;
        private string mSessionId;
        private string mPin;
        private SessionStatusCode mSessionStatusCode;        
        private string mLoginError;
        private bool mIsSessionSync;

        private ChartSessionStatusCode mChartSessionStatusCode;
        private string mChartLoginError;

        private EventWaitHandle mResponseWaitHandle;
        private List<string> mSyncRequestIDs;
        private List<IResponse> mResponses;
        private Dictionary<string, string> mSyncRequestErrors;

        public void subscribeResponse(IResponseListener listenerObj)
        {
            fxcore2.IO2GResponseListener listenerNative = (fxcore2.IO2GResponseListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeResponse(listenerNative);
        }

        public void unsubscribeResponse(IResponseListener listenerObj)
        {
            object nativeListener = NativeListenersManager.GetNativeListener(listenerObj);
            if (nativeListener != null)
            {
                mNetObj.unsubscribeResponse((fxcore2.IO2GResponseListener)nativeListener);
                NativeListenersManager.DisposeListener(listenerObj);
            }
        }

        public void subscribeSessionStatus(ISessionStatus listenerObj)
        {
            fxcore2.IO2GSessionStatus listenerNative = (fxcore2.IO2GSessionStatus)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeSessionStatus(listenerNative);
        }

        public void unsubscribeSessionStatus(ISessionStatus listenerObj)
        {
            object nativeListener = NativeListenersManager.GetNativeListener(listenerObj);
            if (nativeListener != null)
            {
                mNetObj.unsubscribeSessionStatus((fxcore2.IO2GSessionStatus)nativeListener);
                NativeListenersManager.DisposeListener(listenerObj);
            }
        }

        public void subscribeChartSessionStatus(IChartSessionStatus listenerObj)
        {
            fxcore2.IO2GChartSessionStatus listenerNative = (fxcore2.IO2GChartSessionStatus)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeChartSessionStatus(listenerNative);
        }

        public void unsubscribeChartSessionStatus(IChartSessionStatus listenerObj)
        {
            object nativeListener = NativeListenersManager.GetNativeListener(listenerObj);
            if (nativeListener != null)
            {
                mNetObj.unsubscribeChartSessionStatus((fxcore2.IO2GChartSessionStatus)nativeListener);
                NativeListenersManager.DisposeListener(listenerObj);
            }
        }

        public void useTableManager(TableManagerMode mode, ITableManagerListener listener)
        {
            if (mNativeTableManagerListener != null)
                NativeListenersManager.DisposeListener(mNativeTableManagerListener);
            mNativeTableManagerListener = null;
            if(listener != null)
                mNativeTableManagerListener = (fxcore2.IO2GTableManagerListener)NativeListenersManager.CreateListener(listener, this);
            mNetObj.useTableManager((fxcore2.O2GTableManagerMode)(int)mode, mNativeTableManagerListener);
        }

        void OnInitialize()
        {
            mSyncContext = EventsSynchronizationContext.GetSyncContext;

            mSessionId = string.Empty;
            mPin = string.Empty;

            mSessionWaitHandle = new AutoResetEvent(false);
            mResponseWaitHandle = new AutoResetEvent(false);

            mSyncRequestIDs = new List<string>();
            mResponses = new List<IResponse>();
            mSyncRequestErrors = new Dictionary<string, string>();

            mNetObj.SessionStatusChanged+=new EventHandler<SessionStatusEventArgs>(mNetObj_SessionStatusChanged);
            mNetObj.LoginFailed += new EventHandler<LoginFailedEventArgs>(mNetObj_LoginFailed);

            mNetObj.ChartSessionStatusChanged += new EventHandler<ChartSessionStatusEventArgs>(mNetObj_ChartSessionStatusChanged);
            mNetObj.ChartSessionLoginFailed += new EventHandler<ChartSessionLoginFailedEventArgs>(mNetObj_ChartSessionLoginFailed);

            mNetObj.RequestCompleted += new EventHandler<RequestCompletedEventArgs>(mNetObj_RequestCompleted);
            mNetObj.RequestFailed += new EventHandler<RequestFailedEventArgs>(mNetObj_RequestFailed);
            mNetObj.TablesUpdates += new EventHandler<TablesUpdatesEventArgs>(mNetObj_TablesUpdates);
            
            mNetObj.TableManagerStatusChanged += new EventHandler<TableManagerStatusChangedEventArgs>(mNetObj_TableManagerStatusChanged);
        }

        void OnDispose()
        {
            mNetObj.SessionStatusChanged -= new EventHandler<SessionStatusEventArgs>(mNetObj_SessionStatusChanged);
            mNetObj.LoginFailed -= new EventHandler<LoginFailedEventArgs>(mNetObj_LoginFailed);

            mNetObj.ChartSessionStatusChanged -= new EventHandler<ChartSessionStatusEventArgs>(mNetObj_ChartSessionStatusChanged);
            mNetObj.ChartSessionLoginFailed -= new EventHandler<ChartSessionLoginFailedEventArgs>(mNetObj_ChartSessionLoginFailed);

            mNetObj.RequestCompleted -= new EventHandler<RequestCompletedEventArgs>(mNetObj_RequestCompleted);
            mNetObj.RequestFailed -= new EventHandler<RequestFailedEventArgs>(mNetObj_RequestFailed);
            mNetObj.TablesUpdates -= new EventHandler<TablesUpdatesEventArgs>(mNetObj_TablesUpdates);

            mNetObj.TableManagerStatusChanged -= new EventHandler<TableManagerStatusChangedEventArgs>(mNetObj_TableManagerStatusChanged);

            if (mNativeTableManagerListener != null)
                NativeListenersManager.DisposeListener(mNativeTableManagerListener);
            mNativeTableManagerListener = null;
            
            mSyncContext.Dispose();
            mSyncContext = null;
        }

        public event IO2GTableManagerListener_onStatusChangedHandler ManagerStatusChanged;
        void mNetObj_TableManagerStatusChanged(object sender, TableManagerStatusChangedEventArgs e)
        {
            if (ManagerStatusChanged != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        if (mSessionReady)
                        {
                            TableManagerStatusChangedEventArgs evArgs = (TableManagerStatusChangedEventArgs)data;
                            if (ManagerStatusChanged != null)
                                ManagerStatusChanged((TableManagerStatus)(int)evArgs.Status, new TableManager(evArgs.TableManager, this));
                        }
                    }, (object)e);
            }
        }

        public event IO2GResponseListener_onTablesUpdatesHandler TablesUpdates;
        void mNetObj_TablesUpdates(object sender, TablesUpdatesEventArgs e)
        {
            if (TablesUpdates != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        if (mSessionReady)
                        {
                            TablesUpdatesEventArgs evArgs = (TablesUpdatesEventArgs)data;
                            if (TablesUpdates != null)
                                TablesUpdates(new Response(evArgs.Response, this));
                        }
                    }, (object)e);
            }
        }

        public event IO2GResponseListener_onRequestFailedHandler RequestFailed;
        void mNetObj_RequestFailed(object sender, RequestFailedEventArgs e)
        {
            bool bIsRequestSync;
            lock (mSyncRequestIDs)
                bIsRequestSync = mSyncRequestIDs.Contains(e.RequestID);
            if (bIsRequestSync)
            {
                lock (mSyncRequestErrors)
                    mSyncRequestErrors.Add(e.RequestID, e.Error);
                lock (mSyncRequestIDs)
                    mSyncRequestIDs.Remove(e.RequestID);
                mResponseWaitHandle.Set();
            }
            else
            {
                if (RequestFailed != null)
                {
                    mSyncContext.Post(delegate(object data)
                        {
                            if (mSessionReady)
                            {
                                RequestFailedEventArgs evArgs = (RequestFailedEventArgs)data;
                                if (RequestFailed != null)
                                    RequestFailed(evArgs.RequestID, evArgs.Error);
                            }
                        }, (object)e);
                }
            }
        }

        public event IO2GResponseListener_onRequestCompletedHandler RequestCompleted;
        void mNetObj_RequestCompleted(object sender, RequestCompletedEventArgs e)
        {                        
            bool bIsRequestSync;
            lock (mSyncRequestIDs)
                bIsRequestSync = mSyncRequestIDs.Contains(e.RequestID);
            if (bIsRequestSync)
            {                
                lock (mResponses)
                    mResponses.Add(new Response(e.Response, this));
                lock (mSyncRequestIDs)
                    mSyncRequestIDs.Remove(e.RequestID);
                mResponseWaitHandle.Set();
            }
            else
            {                
                if (RequestCompleted != null)
                {                    
                    mSyncContext.Post(delegate(object data)
                        {
                            if (mSessionReady)
                            {
                                RequestCompletedEventArgs evArgs = (RequestCompletedEventArgs)data;
                                if (RequestCompleted != null)                                                                    
                                    RequestCompleted(evArgs.RequestID, new Response(evArgs.Response, this));                                                                    
                            }
                        }, (object)e);
                }
            }
        }
        
        public event IO2GSessionStatus_onLoginFailedHandler LoginFailed;
        void mNetObj_LoginFailed(object sender, LoginFailedEventArgs e)
        {
            mLoginError = e.Error;
            if (LoginFailed != null)
            {
                SendOrPostCallback callback = delegate(object data)
                    {
                        LoginFailedEventArgs evArgs = (LoginFailedEventArgs)data;
                        if (LoginFailed != null)
                            LoginFailed(evArgs.Error);
                    };
                if (mIsSessionSync)
                {
                    mSyncContext.Post(callback, (object)e);
                }
                else
                {
                    mSyncContext.Send(callback, (object)e);
                }
            }
        }

        public event IO2GSessionStatus_onSessionStatusChangedHandler SessionStatusChanged;
        void mNetObj_SessionStatusChanged(object sender, SessionStatusEventArgs e)
        {
            mSessionStatusCode = (SessionStatusCode)(int)e.SessionStatus;

            mSessionReady = (e.SessionStatus == O2GSessionStatusCode.Connected);

            if (mIsSessionSync)
            {
                switch (e.SessionStatus)
                {
                    case O2GSessionStatusCode.Connected:
                        mSessionWaitHandle.Set();
                        break;
                    case O2GSessionStatusCode.Disconnected:
                        mSessionWaitHandle.Set();
                        break;
                    case O2GSessionStatusCode.TradingSessionRequested:
                        this.setTradingSession(mSessionId, mPin);
                        return;
                }
            }

            if (SessionStatusChanged != null)
            {
                SendOrPostCallback callback = delegate(object data)
                    {
                        SessionStatusEventArgs evArgs = (SessionStatusEventArgs)data;
                        if (SessionStatusChanged != null)
                            SessionStatusChanged((SessionStatusCode)(int)evArgs.SessionStatus);
                    };
                if (mIsSessionSync)
                {
                    mSyncContext.Post(callback, (object)e);
                }
                else
                {
                    mSyncContext.Send(callback, (object)e);
                }
            }
        }

        public event IO2GChartSessionStatus_onChartSessionLoginFailedHandler ChartSessionLoginFailed;
        void mNetObj_ChartSessionLoginFailed(object sender, ChartSessionLoginFailedEventArgs e)
        {
            mLoginError = e.Error;
            if (ChartSessionLoginFailed != null)
            {
                SendOrPostCallback callback = delegate(object data)
                    {
                        ChartSessionLoginFailedEventArgs evArgs = (ChartSessionLoginFailedEventArgs)data;
                        if (ChartSessionLoginFailed != null)
                            ChartSessionLoginFailed(evArgs.Error);
                    };
                if (mIsSessionSync)
                {
                    mSyncContext.Post(callback, (object)e);
                }
                else
                {
                    mSyncContext.Send(callback, (object)e);
                }
            }
        }

        public event IO2GChartSessionStatus_onChartSessionStatusChangedHandler ChartSessionStatusChanged;
        void mNetObj_ChartSessionStatusChanged(object sender, ChartSessionStatusEventArgs e)
        {
            mChartSessionStatusCode = (ChartSessionStatusCode)(int)e.ChartSessionStatus;
            
            if (mIsSessionSync)
            {
                switch (e.ChartSessionStatus)
                {
                    case O2GChartSessionStatusCode.Connected:
                        mSessionWaitHandle.Set();
                        break;
                    case O2GChartSessionStatusCode.Disconnected:
                        mSessionWaitHandle.Set();
                        break;                   
                }
            }

            if (ChartSessionStatusChanged != null)
            {
                SendOrPostCallback callback = delegate(object data)
                    {
                        ChartSessionStatusEventArgs evArgs = (ChartSessionStatusEventArgs)data;
                        if (ChartSessionStatusChanged != null)
                            ChartSessionStatusChanged((ChartSessionStatusCode)(int)evArgs.ChartSessionStatus);
                    };
                if (mIsSessionSync)
                {
                    mSyncContext.Post(callback, (object)e);
                }
                else
                {
                    mSyncContext.Send(callback, (object)e);
                }
            }
        }

        public SessionStatusCode loginSync(string user, string pwd, string url, string connection, string sessionId, string pin, out string errorMessage)
        {
            mSessionId = sessionId;
            mPin = pin;
            mIsSessionSync = true;
            mLoginError = string.Empty;
            login(user, pwd, url, connection);
            bool bIsTimeOutExpired = false;
            if (!mSessionWaitHandle.WaitOne(SESSION_TIMEOUT))
            {
                bIsTimeOutExpired = true;
            }
            if (bIsTimeOutExpired)
            {
                errorMessage = Properties.Resources.ERROR_SESSION_TIMEOUT_EXPIRED;
                mSessionStatusCode = SessionStatusCode.Unknown;
            }
            else
            {
                errorMessage = mLoginError;
            }
            mSessionId = string.Empty;
            mPin = string.Empty;
            mIsSessionSync = false;
            return mSessionStatusCode;
        }

        public SessionStatusCode logoutSync(out string errorMessage)
        {
            mIsSessionSync = true;
            logout();
            bool bIsTimeOutExpired = false;
            if (!mSessionWaitHandle.WaitOne(SESSION_TIMEOUT))
            {
                bIsTimeOutExpired = true;
            }
            if (bIsTimeOutExpired)
            {
                errorMessage = Properties.Resources.ERROR_SESSION_TIMEOUT_EXPIRED;
                mSessionStatusCode = SessionStatusCode.Unknown;
            }
            else
            {
                errorMessage = string.Empty;
            }
            mIsSessionSync = false;
            return mSessionStatusCode;
        }

        public IResponse sendRequestSync([MarshalAs(UnmanagedType.IDispatch)]IRequest requestObj, out string errorMessage)
        {
            IResponse resultResponse = null;
            string sRequestID = requestObj.RequestID;

            lock (mSyncRequestIDs)
                mSyncRequestIDs.Add(sRequestID);

            sendRequest(requestObj);

            bool bIsRequestProcessed = false;
            while (!bIsRequestProcessed)
            {
                if (!mResponseWaitHandle.WaitOne(REQUEST_TIMEOUT))
                {
                    errorMessage = Properties.Resources.ERROR_REQUEST_TIMEOUT_EXPIRED;
                    return null;
                }
                lock (mSyncRequestIDs)
                    bIsRequestProcessed = (!mSyncRequestIDs.Contains(sRequestID));
            }

            bool bIsRequestFailed;
            lock (mSyncRequestErrors)
                bIsRequestFailed = mSyncRequestErrors.ContainsKey(sRequestID);

            if (bIsRequestFailed)
            {
                errorMessage = mSyncRequestErrors[sRequestID];
                lock (mSyncRequestErrors)
                    mSyncRequestErrors.Remove(sRequestID);
            }
            else
            {
                errorMessage = string.Empty;
                foreach (IResponse response in mResponses)
                {
                    if (response.RequestID == sRequestID)
                    {
                        resultResponse = response;
                        break;
                    }
                }
                lock (mResponses)
                    mResponses.Remove(resultResponse);
            }
            return resultResponse;
        }
    }

    partial interface ITable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();
        
        [DispId(0x60040209)]
        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperatorObj, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        [DispId(0x60040210)]
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        [DispId(0x60040211)]
        bool getNextGenericRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
    }
    


    [ComVisible(true)]
    [Guid("390927A4-6A96-4d32-8170-C101B7838B16")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ITableCallback //:ITableListener, IEachRowListener
    {
        [DispId(0x60020001)]
        void Added(
            string rowID, [MarshalAs(UnmanagedType.IDispatch)]IRow rowDataObj
            );

        [DispId(0x60020002)]
        void Changed(
            string rowID, [MarshalAs(UnmanagedType.IDispatch)]IRow rowDataObj
            );

        [DispId(0x60020003)]
        void Deleted(
            string rowID, [MarshalAs(UnmanagedType.IDispatch)]IRow rowDataObj
            );

        [DispId(0x60020004)]
        void StatusChanged(
            TableStatus status
            );

        [DispId(0x60020301)]
        void EachRow(
            string rowID, [MarshalAs(UnmanagedType.IDispatch)]IRow rowDataObj
            );

    }

    [ComSourceInterfaces(typeof(ITableCallback))] //, typeof(ITableListener), typeof(IEachRowListener))]
    //[ClassInterface(ClassInterfaceType.AutoDual)]
    partial class Table
    {
        private EventsSynchronizationContext mSyncContext;

        public void subscribeUpdate(TableUpdateType updateType, ITableListener listenerObj)
        {
            fxcore2.IO2GTableListener listenerNative = (fxcore2.IO2GTableListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeUpdate((fxcore2.O2GTableUpdateType)(int)updateType, listenerNative);
        }

        public void unsubscribeUpdate(TableUpdateType updateType, ITableListener listenerObj)
        {
            NativeListenersManager.DisposeListener(listenerObj);
        }

        public void subscribeStatus(ITableListener listenerObj)
        {
            fxcore2.IO2GTableListener listenerNative = (fxcore2.IO2GTableListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeStatus(listenerNative);
        }

        public void unsubscribeStatus(ITableListener listenerObj)
        {
            NativeListenersManager.DisposeListener(listenerObj);
        }

        public void forEachRow(IEachRowListener listenerObj)
        {
            fxcore2.IO2GEachRowListener listenerNative = (fxcore2.IO2GEachRowListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.forEachRow(listenerNative);
            NativeListenersManager.DisposeListener(listenerNative);
        }

        public void forEachRow()
        {
            mNetObj.forEachRow(onEachRow);
        }

        public ITableIterator CreateTableIterator()
        {
            return new TableIterator(new fxcore2.O2GTableIterator(), mSession);
        }

        public bool getNextGenericRow(ITableIterator iteratorObj, out IRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GRow rowNative;
            bool result = mNetObj.getNextGenericRow(iteratorNative, out  rowNative);
            rowObj = RowConverter.WrapAsRow(rowNative, mSession);

            return result;
        }

        public bool getNextGenericRowByColumnValue(string columnID, object columnValue, ITableIterator iteratorObj, out IRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GRow rowNative;
            bool result = mNetObj.getNextGenericRowByColumnValue(columnID, columnValue, iteratorNative, out  rowNative);
            rowObj = RowConverter.WrapAsRow(rowNative, mSession);

            return result;
        }

        public bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out IRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextGenericRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = RowConverter.WrapAsRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextGenericRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = RowConverter.WrapAsRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextGenericRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextGenericRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = RowConverter.WrapAsRow(rowNative, mSession);
            }
            return result;
        }
        
        void OnInitialize()
        {
            mSyncContext = EventsSynchronizationContext.GetSyncContext;

            mNetObj.RowAdded += new EventHandler<RowEventArgs>(mNetObj_RowAdded);
            mNetObj.RowChanged += new EventHandler<RowEventArgs>(mNetObj_RowChanged);
            mNetObj.RowDeleted += new EventHandler<RowEventArgs>(mNetObj_RowDeleted);
            mNetObj.StatusChanged += new EventHandler<StatusChangedEventArgs>(mNetObj_StatusChanged);
        }

        void OnDispose()
        {
            mNetObj.RowAdded -= new EventHandler<RowEventArgs>(mNetObj_RowAdded);
            mNetObj.RowChanged -= new EventHandler<RowEventArgs>(mNetObj_RowChanged);
            mNetObj.RowDeleted -= new EventHandler<RowEventArgs>(mNetObj_RowDeleted);
            mNetObj.StatusChanged -= new EventHandler<StatusChangedEventArgs>(mNetObj_StatusChanged);
            
            mSyncContext.Dispose();
            mSyncContext = null;
        }

        
        event IO2GTableListener_onStatusChangedHandler StatusChanged;
        void mNetObj_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            if (StatusChanged != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        StatusChangedEventArgs evArgs = (StatusChangedEventArgs)data;
                        if (StatusChanged != null)
                            StatusChanged((TableStatus)(int)evArgs.Status);
                    }, (object)e);
            }
        }
        
        event IO2GTableListener_onDeletedHandler Deleted;
        void mNetObj_RowDeleted(object sender, RowEventArgs e)
        {
            if (Deleted != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        RowEventArgs evArgs = (RowEventArgs)data;
                        if (Deleted != null)
                            Deleted(evArgs.RowID, RowConverter.WrapAsRow(evArgs.RowData, mSession));
                    }, (object)e);
            }
        }

        event IO2GTableListener_onChangedHandler Changed;
        void mNetObj_RowChanged(object sender, RowEventArgs e)
        {
            if (Changed != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        RowEventArgs evArgs = (RowEventArgs)data;
                        if (Changed != null)
                            Changed(evArgs.RowID, RowConverter.WrapAsRow(evArgs.RowData, mSession));
                    }, (object)e);
            }
        }
        
        event IO2GTableListener_onAddedHandler Added;
        void mNetObj_RowAdded(object sender, RowEventArgs e)
        {
            if (Added != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        RowEventArgs evArgs = (RowEventArgs)data;
                        if (Added != null)
                            Added(evArgs.RowID, RowConverter.WrapAsRow(evArgs.RowData, mSession));
                    }, (object)e);
            }
        }

        event IO2GEachRowListener_onEachRowHandler EachRow;
        void onEachRow(string rowID, fxcore2.O2GRow row)
        {
            if (EachRow != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        RowEventArgs evArgs = (RowEventArgs)data;
                        if (EachRow != null)
                            EachRow(evArgs.RowID, new Row(evArgs.RowData, mSession));
                    }, (object)new RowEventArgs(rowID, row));
            }
        }

        public O2GTableEventsFilter getTableEventsFilter()
        {
            return mNetObj.getTableEventsFilter() == fxcore2.O2GTableEventsFilter.AllEvents ? fxcore2.com.O2GTableEventsFilter.AllEvents : fxcore2.com.O2GTableEventsFilter.ServerOnly;
        }

        public void setTableEventsFilter(O2GTableEventsFilter tableFilterType)
        {
            mNetObj.setTableEventsFilter(tableFilterType == fxcore2.com.O2GTableEventsFilter.AllEvents ? fxcore2.O2GTableEventsFilter.AllEvents : fxcore2.O2GTableEventsFilter.ServerOnly);
        }
        
    }
    
    //[ClassInterface(ClassInterfaceType.AutoDual)]
    partial class Constants
    {
        /// <summary>
        /// default ctor to allow create this class from COM client
        /// </summary>
        public Constants()
        {
            mSession = null;
        }

        public int INIFINITE_NUMBER_OF_RECONNECTIONS
        {
            get
            {
                int result = Convert.ToInt32(fxcore2.Constants.INFINITE_NUMBER_OF_RECONNECTIONS);
                return result;
            }

        }

        public ICommands Commands 
        { 
            get 
            {
                if (mCommands == null)
                    mCommands = new Commands(mSession);
                return mCommands;
            
            } 
        }
        private ICommands mCommands = null;

        public IOrders Orders
        {
            get
            {
                if (mOrders == null)
                    mOrders = new Orders(mSession);
                return mOrders;

            }
        }
        private IOrders mOrders = null;

        public IPeg Peg
        {
            get
            {
                if (mPeg == null)
                    mPeg = new Peg(mSession);
                return mPeg;

            }
        }
        private IPeg mPeg = null;

        public ISystemProperties SystemProperties
        {
            get
            {
                if (mSystemProperties == null)
                    mSystemProperties = new SystemProperties(mSession);
                return mSystemProperties;

            }
        }
        private ISystemProperties mSystemProperties = null;

        public ITIF TIF
        {
            get
            {
                if (mTIF == null)
                    mTIF = new TIF(mSession);
                return mTIF;

            }
        }
        private ITIF mTIF = null;

        public IKeyType KeyType
        {
            get 
            {
                if (mKeyType == null)
                    mKeyType = new KeyType(mSession);
                return mKeyType;
            }
        }
        private IKeyType mKeyType;
    
    }

    partial class UpdateEventQueue
    {
        public void subscribeOnPutInQueue(IUpdateEventQueueListener listenerObj)
        {
            fxcore2.IO2GUpdateEventQueueListener listenerNative = (fxcore2.IO2GUpdateEventQueueListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeOnPutInQueue(listenerNative);
        }

        public void unsubscribeOnPutInQueue(IUpdateEventQueueListener listenerObj)
        {
            NativeListenersManager.DisposeListener(listenerObj);
        }
    }
    
    partial class AllEventQueue
    {
        public void subscribeOnPutInQueue(IAllEventQueueListener listenerObj)
        {
            fxcore2.IO2GAllEventQueueListener listenerNative = (fxcore2.IO2GAllEventQueueListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeOnPutInQueue(listenerNative);
        }

        public void unsubscribeOnPutInQueue(IAllEventQueueListener listenerObj)
        {
            NativeListenersManager.DisposeListener(listenerObj);
        }
    }

    partial class TableManager
    {
        private EventsSynchronizationContext mSyncContext;
    
        public object getTable(TableType tableType)
        {
            ITable result = TableConverter.WrapAsTable(mNetObj.getTable((fxcore2.O2GTableType)(int)tableType), mSession);

            return result;
        }
        
        void OnInitialize()
        {
            mSyncContext = EventsSynchronizationContext.GetSyncContext;

            mNetObj.UpdatesProcessStatusChanged += new EventHandler<UpdatesProcessStatusChangedEventArgs>(mNetObj_UpdatesProcessStatusChanged);
        }

        void OnDispose()
        {
            mNetObj.UpdatesProcessStatusChanged -= new EventHandler<UpdatesProcessStatusChangedEventArgs>(mNetObj_UpdatesProcessStatusChanged);
            
            mSyncContext.Dispose();
            mSyncContext = null;
        }
        
        public void subscribeUpdatesProcessStatus(IUpdatesProcessStatusListener listenerObj)
        {
            fxcore2.IO2GUpdatesProcessStatusListener listenerNative = (fxcore2.IO2GUpdatesProcessStatusListener)NativeListenersManager.CreateListener(listenerObj, mSession);
            mNetObj.subscribeUpdatesProcessStatus(listenerNative);
        }

        public void unsubscribeUpdatesProcessStatus(IUpdatesProcessStatusListener listenerObj)
        {
            NativeListenersManager.DisposeListener(listenerObj);
        }
        
        event IO2GUpdatesProcessStatusListener_onUpdatesProcessStatusChangedHandler UpdatesProcessStatusChanged;
        void mNetObj_UpdatesProcessStatusChanged(object sender, UpdatesProcessStatusChangedEventArgs e)
        {
            if (UpdatesProcessStatusChanged != null)
            {
                mSyncContext.Post(delegate(object data)
                    {
                        UpdatesProcessStatusChangedEventArgs evArgs = (UpdatesProcessStatusChangedEventArgs)data;
                        if (UpdatesProcessStatusChanged != null)
                            UpdatesProcessStatusChanged((UpdatesProcessStatus)(int)evArgs.Status);
                    }, (object)e);
            }
        }
    }

    partial class GenericTableResponseReader
    {
        public object getGenericRow(int row)
        {
            IRow result = RowConverter.WrapAsRow(mNetObj.getGenericRow(row), mSession);
            return result;
        }
    }

    partial interface ITimeframeCollection
    {
        [DispId(0x60020002)]
        ITimeframe getByID(string timeFrameID);

        [DispId(0x60020003)]
        ITimeframe get(int index);
    }

    partial class TimeframeCollection : ITimeframeCollection
    {
        
        public ITimeframe getByID(string timeFrameID)
        {
            return (ITimeframe)Utils.CheckWrapperForNativeNull(new Timeframe(mNetObj[timeFrameID], mSession));
        }

        public ITimeframe get(int index)
        {
            return (ITimeframe)Utils.CheckWrapperForNativeNull(new Timeframe(mNetObj[index], mSession));
        }
    }


    partial interface IOfferTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();
        
        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOfferTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOfferTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOfferTableRow rowObj);
    }

    partial class OfferTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out IOfferTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GOfferTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new OfferTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IOfferTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GOfferTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new OfferTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IOfferTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GOfferTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new OfferTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface IAccountTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();

        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IAccountTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IAccountTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IAccountTableRow rowObj);
    }

    partial class AccountTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out IAccountTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GAccountTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new AccountTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IAccountTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GAccountTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new AccountTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IAccountTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GAccountTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new AccountTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface IOrderTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();

        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOrderTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOrderTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOrderTableRow rowObj);
    }

    partial class OrderTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out IOrderTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GOrderTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new OrderTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IOrderTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GOrderTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new OrderTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IOrderTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GOrderTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new OrderTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface ITradeTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();

        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ITradeTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ITradeTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ITradeTableRow rowObj);
    }

    partial class TradeTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out ITradeTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GTradeTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new TradeTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out ITradeTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GTradeTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new TradeTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out ITradeTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GTradeTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new TradeTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface IClosedTradeTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();

        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IClosedTradeTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IClosedTradeTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IClosedTradeTableRow rowObj);
    }

    partial class ClosedTradeTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out IClosedTradeTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GClosedTradeTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new ClosedTradeTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IClosedTradeTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GClosedTradeTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new ClosedTradeTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IClosedTradeTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GClosedTradeTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new ClosedTradeTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface IMessageTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();

        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IMessageTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IMessageTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IMessageTableRow rowObj);
    }

    partial class MessageTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out IMessageTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GMessageTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new MessageTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IMessageTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GMessageTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new MessageTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out IMessageTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GMessageTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new MessageTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface ISummariesTable
    {
        [DispId(0x60040508)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        ITableIterator CreateTableIterator();

        bool getNextGenericRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextGenericRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
        bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ISummariesTableRow rowObj);
        bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ISummariesTableRow rowObj);
        bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ISummariesTableRow rowObj);
    }

    partial class SummariesTable
    {
        public bool getNextRowByMultiColumnValues(int columnCount, object columnNames, object conditions, object columnValues, LogicOperators logicOperator, ITableIterator iteratorObj, out ISummariesTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GSummaryTableRow rowNative = null;
            rowObj = null;
            string[] names = Utils.LoadComObjectIntoStringArray(columnNames);
            int[] intConditions = Utils.LoadComObjectIntoIntegerArray(conditions);
            fxcore2.O2GRelationalOperators[] enumConditions = new fxcore2.O2GRelationalOperators[intConditions.Length];
            for (int i = 0; i < intConditions.Length; i++)
            {
                enumConditions[i] = (fxcore2.O2GRelationalOperators)intConditions[i];
            }
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByMultiColumnValues(names, enumConditions, values, (fxcore2.O2GLogicOperators)(int)logicOperator, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new SummariesTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByColumnValues(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out ISummariesTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GSummaryTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByColumnValues(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new SummariesTableRow(rowNative, mSession);
            }
            return result;
        }
        
        public bool getNextRowByCondition(string columnName, RelationalOperators condition, object columnValues, ITableIterator iteratorObj, out ISummariesTableRow rowObj)
        {
            fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
            fxcore2.O2GSummaryTableRow rowNative = null;
            rowObj = null;
            object[] values = Utils.LoadComObjectIntoObjectArray(columnValues);
            bool result = mNetObj.getNextRowByCondition(columnName, (fxcore2.O2GRelationalOperators)(int)condition, values, iteratorNative, out rowNative);
            if (rowNative != null)
            {
                rowObj = new SummariesTableRow(rowNative, mSession);
            }
            return result;
        }
    }

    partial interface ISystemPropertiesReader
    {
        [DispId(0x60020010)]
        string findProperty(string property);

        [DispId(0x60020020)]
        string getProperty(int index, out string value);
    
    }

    partial class SystemPropertiesReader
    {
        public string findProperty(string property)
        {
            return mNetObj.Properties[property];
        }

        public string getProperty(int index, out string value)
        {
            int ii = 0;
            foreach (KeyValuePair<string,string> pair in mNetObj.Properties)
            {
                if (index == ii)
                {
                    value = pair.Value;
                    return pair.Key;
                }
                ii++;
            }
            throw new IndexOutOfRangeException();
        }
    }

    partial interface ISession
    {
        [DispId(0x60020021)]
        SessionStatusCode loginSync(string user, string pwd, string url, string connection, string sessionId, string pin, out string errorMessage);

        [DispId(0x60020022)]
        SessionStatusCode logoutSync(out string errorMessage);

        [DispId(0x60020023)]
        IResponse sendRequestSync([MarshalAs(UnmanagedType.IDispatch)]IRequest requestObj, out string errorMessage);
    }

}
