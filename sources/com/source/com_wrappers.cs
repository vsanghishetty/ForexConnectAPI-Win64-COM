
//====================================================================================
//  CAUTION:
//  Do not change anything in this source code because it was automatically generated
//  from classes descriptions in COMMap.xml and ClassLib.xml.
//====================================================================================
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace fxcore2.com
{

    
        
        [ComVisible(true)]
        [Guid("FF720BB6-00E7-4d39-AC95-17B36C91E685")]
        public enum RequestParamsEnum
        {
            AccountID = fxcore2.O2GRequestParamsEnum.AccountID,
            AccountName = fxcore2.O2GRequestParamsEnum.AccountName,
            Amount = fxcore2.O2GRequestParamsEnum.Amount,
            BuySell = fxcore2.O2GRequestParamsEnum.BuySell,
            ClientRate = fxcore2.O2GRequestParamsEnum.ClientRate,
            Command = fxcore2.O2GRequestParamsEnum.Command,
            ContingencyGroupType = fxcore2.O2GRequestParamsEnum.ContingencyGroupType,
            ContingencyID = fxcore2.O2GRequestParamsEnum.ContingencyID,
            CustomID = fxcore2.O2GRequestParamsEnum.CustomID,
            Id = fxcore2.O2GRequestParamsEnum.Id,
            Key = fxcore2.O2GRequestParamsEnum.Key,
            NetQuantity = fxcore2.O2GRequestParamsEnum.NetQuantity,
            OfferID = fxcore2.O2GRequestParamsEnum.OfferID,
            OrderID = fxcore2.O2GRequestParamsEnum.OrderID,
            OrderType = fxcore2.O2GRequestParamsEnum.OrderType,
            PegOffset = fxcore2.O2GRequestParamsEnum.PegOffset,
            PegOffsetLimit = fxcore2.O2GRequestParamsEnum.PegOffsetLimit,
            PegOffsetStop = fxcore2.O2GRequestParamsEnum.PegOffsetStop,
            PegType = fxcore2.O2GRequestParamsEnum.PegType,
            PegTypeLimit = fxcore2.O2GRequestParamsEnum.PegTypeLimit,
            PegTypeStop = fxcore2.O2GRequestParamsEnum.PegTypeStop,
            PrimaryQID = fxcore2.O2GRequestParamsEnum.PrimaryQID,
            Rate = fxcore2.O2GRequestParamsEnum.Rate,
            RateLimit = fxcore2.O2GRequestParamsEnum.RateLimit,
            RateMax = fxcore2.O2GRequestParamsEnum.RateMax,
            RateMin = fxcore2.O2GRequestParamsEnum.RateMin,
            RateStop = fxcore2.O2GRequestParamsEnum.RateStop,
            SubscriptionStatus = fxcore2.O2GRequestParamsEnum.SubscriptionStatus,
            Symbol = fxcore2.O2GRequestParamsEnum.Symbol,
            TimeInForce = fxcore2.O2GRequestParamsEnum.TimeInForce,
            TradeID = fxcore2.O2GRequestParamsEnum.TradeID,
            TrailStep = fxcore2.O2GRequestParamsEnum.TrailStep,
            TrailStepStop = fxcore2.O2GRequestParamsEnum.TrailStepStop,
            UnknownParam = fxcore2.O2GRequestParamsEnum.UnknownParam,
            ExpireDateTime = fxcore2.O2GRequestParamsEnum.ExpireDateTime
            
        }
    
        
        [ComVisible(true)]
        [Guid("996926BC-C528-444c-ADF0-CF8C23A34A68")]
        public enum TimeframeUnit
        {
            Day = fxcore2.O2GTimeframeUnit.Day,
            Hour = fxcore2.O2GTimeframeUnit.Hour,
            Min = fxcore2.O2GTimeframeUnit.Min,
            Month = fxcore2.O2GTimeframeUnit.Month,
            Tick = fxcore2.O2GTimeframeUnit.Tick,
            Week = fxcore2.O2GTimeframeUnit.Week,
            Year = fxcore2.O2GTimeframeUnit.Year
            
        }
    
        
        [ComVisible(true)]
        [Guid("1C2A8A50-39FD-4b6b-8AEF-28A963F05229")]
        public enum TimeConverterTimeZone
        {
            EST = fxcore2.O2GTimeConverterTimeZone.EST,
            Local = fxcore2.O2GTimeConverterTimeZone.Local,
            Server = fxcore2.O2GTimeConverterTimeZone.Server,
            UTC = fxcore2.O2GTimeConverterTimeZone.UTC
            
        }
    
        
        [ComVisible(true)]
        [Guid("D44C13F6-4504-4740-822E-D2C2A8FA2B3D")]
        public enum PermissionStatus
        {
            PermissionDisabled = fxcore2.O2GPermissionStatus.PermissionDisabled,
            PermissionEnabled = fxcore2.O2GPermissionStatus.PermissionEnabled,
            PermissionHidden = fxcore2.O2GPermissionStatus.PermissionHidden
            
        }
    
        
        [ComVisible(true)]
        [Guid("B55D7F29-D97F-4a5e-B098-CFD3E2E8D6B9")]
        public enum MarketStatus
        {
            MarketStatusClosed = fxcore2.O2GMarketStatus.MarketStatusClosed,
            MarketStatusOpen = fxcore2.O2GMarketStatus.MarketStatusOpen
            
        }
    
        
        [ComVisible(true)]
        [Guid("B394762F-132A-452f-8AFC-E80204758CBB")]
        public enum PriceUpdateMode
        {
            Default = fxcore2.O2GPriceUpdateMode.Default,
            NoPrice = fxcore2.O2GPriceUpdateMode.NoPrice
            
        }
    
        
        [ComVisible(true)]
        [Guid("79F69645-22CE-403a-ACCE-8818C32E00B1")]
        public enum TableManagerMode
        {
            No = fxcore2.O2GTableManagerMode.No,
            Yes = fxcore2.O2GTableManagerMode.Yes
            
        }
    
        
        [ComVisible(true)]
        [Guid("71DF570C-FF73-4063-962D-05848A8F574E")]
        public enum TableManagerStatus
        {
            TablesLoaded = fxcore2.O2GTableManagerStatus.TablesLoaded,
            TablesLoadFailed = fxcore2.O2GTableManagerStatus.TablesLoadFailed,
            TablesLoading = fxcore2.O2GTableManagerStatus.TablesLoading
            
        }
    
        
        [ComVisible(true)]
        [Guid("BFEFFABD-88B0-451c-B830-D268CEA1204E")]
        public enum ResponseType
        {
            CommandResponse = fxcore2.O2GResponseType.CommandResponse,
            CreateOrderResponse = fxcore2.O2GResponseType.CreateOrderResponse,
            GetSystemProperties = fxcore2.O2GResponseType.GetSystemProperties,
            MarginRequirementsResponse = fxcore2.O2GResponseType.MarginRequirementsResponse,
            MarketDataSnapshot = fxcore2.O2GResponseType.MarketDataSnapshot,
            ResponseUnknown = fxcore2.O2GResponseType.ResponseUnknown,
            GetLastOrderUpdate = fxcore2.O2GResponseType.GetLastOrderUpdate,
            GetAccounts = fxcore2.O2GResponseType.GetAccounts,
            GetClosedTrades = fxcore2.O2GResponseType.GetClosedTrades,
            GetMessages = fxcore2.O2GResponseType.GetMessages,
            GetOffers = fxcore2.O2GResponseType.GetOffers,
            GetOrders = fxcore2.O2GResponseType.GetOrders,
            GetTrades = fxcore2.O2GResponseType.GetTrades
            
        }
    
        
        [ComVisible(true)]
        [Guid("8944126D-4FBE-47b0-9610-B84F917023A4")]
        public enum TableColumnType
        {
            Boolean = fxcore2.O2GTableColumnType.Boolean,
            Date = fxcore2.O2GTableColumnType.Date,
            Double = fxcore2.O2GTableColumnType.Double,
            Integer = fxcore2.O2GTableColumnType.Integer,
            String = fxcore2.O2GTableColumnType.String
            
        }
    
        
        [ComVisible(true)]
        [Guid("E4C14A17-16E6-4d21-ACF9-7E949550D5FF")]
        public enum TableType
        {
            Accounts = fxcore2.O2GTableType.Accounts,
            ClosedTrades = fxcore2.O2GTableType.ClosedTrades,
            Messages = fxcore2.O2GTableType.Messages,
            Offers = fxcore2.O2GTableType.Offers,
            Orders = fxcore2.O2GTableType.Orders,
            Summary = fxcore2.O2GTableType.Summary,
            Trades = fxcore2.O2GTableType.Trades,
            TableUnknown = fxcore2.O2GTableType.TableUnknown
            
        }
    
        
        [ComVisible(true)]
        [Guid("92E7B85A-7C6D-41d6-8E9D-F8B16E6D7E79")]
        public enum TableUpdateType
        {
            Delete = fxcore2.O2GTableUpdateType.Delete,
            Insert = fxcore2.O2GTableUpdateType.Insert,
            Update = fxcore2.O2GTableUpdateType.Update,
            UpdateUnknown = fxcore2.O2GTableUpdateType.UpdateUnknown
            
        }
    
        
        [ComVisible(true)]
        [Guid("9B660635-E1D1-4df0-ABA6-5EF020BA158B")]
        public enum SessionStatusCode
        {
            Connected = fxcore2.O2GSessionStatusCode.Connected,
            Connecting = fxcore2.O2GSessionStatusCode.Connecting,
            Disconnected = fxcore2.O2GSessionStatusCode.Disconnected,
            Disconnecting = fxcore2.O2GSessionStatusCode.Disconnecting,
            PriceSessionReconnecting = fxcore2.O2GSessionStatusCode.PriceSessionReconnecting,
            Reconnecting = fxcore2.O2GSessionStatusCode.Reconnecting,
            SessionLost = fxcore2.O2GSessionStatusCode.SessionLost,
            TradingSessionRequested = fxcore2.O2GSessionStatusCode.TradingSessionRequested,
            Unknown = fxcore2.O2GSessionStatusCode.Unknown
            
        }
    
        
        [ComVisible(true)]
        [Guid("1F5ABADF-80A6-45BF-924A-493B569F3C65")]
        public enum ChartSessionStatusCode
        {
            Connected = fxcore2.O2GChartSessionStatusCode.Connected,
            Connecting = fxcore2.O2GChartSessionStatusCode.Connecting,
            Disconnected = fxcore2.O2GChartSessionStatusCode.Disconnected,
            Disconnecting = fxcore2.O2GChartSessionStatusCode.Disconnecting,
            Reconnecting = fxcore2.O2GChartSessionStatusCode.Reconnecting,
            SessionLost = fxcore2.O2GChartSessionStatusCode.SessionLost,
            Unknown = fxcore2.O2GChartSessionStatusCode.Unknown
            
        }
    
        
        [ComVisible(true)]
        [Guid("37E0EF4E-12EC-4a40-87EB-74FA0FB1AD30")]
        public enum TableStatus
        {
            Failed = fxcore2.O2GTableStatus.Failed,
            Initial = fxcore2.O2GTableStatus.Initial,
            Refreshed = fxcore2.O2GTableStatus.Refreshed,
            Refreshing = fxcore2.O2GTableStatus.Refreshing
            
        }
    
        
        [ComVisible(true)]
        [Guid("160F5786-3EE6-4FF5-B7E9-BF0FCCCA1CAB")]
        public enum RelationalOperators
        {
            Between = fxcore2.O2GRelationalOperators.Between,
            EqualTo = fxcore2.O2GRelationalOperators.EqualTo,
            NotEqualTo = fxcore2.O2GRelationalOperators.NotEqualTo,
            GreaterThan = fxcore2.O2GRelationalOperators.GreaterThan,
            LessThan = fxcore2.O2GRelationalOperators.LessThan,
            GreaterThanOrEqualTo = fxcore2.O2GRelationalOperators.GreaterThanOrEqualTo,
            LessThanOrEqualTo = fxcore2.O2GRelationalOperators.LessThanOrEqualTo
            
        }
    
        
        [ComVisible(true)]
        [Guid("C1ECE383-77E3-4606-B831-E46F40CA47CA")]
        public enum LogicOperators
        {
            And = fxcore2.O2GLogicOperators.And,
            Or = fxcore2.O2GLogicOperators.Or
            
        }
    
        
        [ComVisible(true)]
        [Guid("25F66F95-09E7-4041-81E5-6B0E1FF2A313")]
        public enum UpdatesProcessStatus
        {
            UnknownProcessStatus = fxcore2.O2GUpdatesProcessStatus.UnknownProcessStatus,
            BeginTablesUpdate = fxcore2.O2GUpdatesProcessStatus.BeginTablesUpdate,
            EndTablesUpdate = fxcore2.O2GUpdatesProcessStatus.EndTablesUpdate
            
        }
    
        
        [ComVisible(true)]
        [Guid("1B455FCF-AF8A-487D-AE78-4D684F4AF3DF")]
        public enum CandleOpenPriceMode
        {
            PreviousClose = fxcore2.O2GCandleOpenPriceMode.PreviousClose,
            FirstTick = fxcore2.O2GCandleOpenPriceMode.FirstTick
            
        }
    
        
        [ComVisible(true)]
        [Guid("49E494BA-94FB-41F5-B9A1-78980560A591")]
        public enum O2GTableEventsFilter
        {
            AllEvents = fxcore2.O2GTableEventsFilter.AllEvents,
            ServerOnly = fxcore2.O2GTableEventsFilter.ServerOnly
            
        }
    
        
        [ComVisible(true)]
        [Guid("AC9E94C0-96C7-42A3-B098-28627E671ABC")]
        public enum ChartSessionMode
        {
            NoChartSession = fxcore2.O2GChartSessionMode.NoChartSession,
            Attached = fxcore2.O2GChartSessionMode.Attached,
            Detached = fxcore2.O2GChartSessionMode.Detached
            
        }
    
        
        [ComVisible(true)]
        [Guid("64AF63C3-9B37-4644-B1F9-BB56694299C4")]
        public enum CommissionStage
        {
            CommissionStageUnknown = fxcore2.O2GCommissionStage.CommissionStageUnknown,
            OpenCommission = fxcore2.O2GCommissionStage.OpenCommission,
            CloseCommission = fxcore2.O2GCommissionStage.CloseCommission,
            AnyDealCommission = fxcore2.O2GCommissionStage.AnyDealCommission
            
        }
    
        
        [ComVisible(true)]
        [Guid("E2D7FCB1-3B85-43D7-BBB1-A1E40EDFFDB0")]
        public enum CommissionUnitType
        {
            CommissionTypeUnknown = fxcore2.O2GCommissionUnitType.CommissionTypeUnknown,
            CommissionPerLot = fxcore2.O2GCommissionUnitType.CommissionPerLot,
            CommissionPerLotConv = fxcore2.O2GCommissionUnitType.CommissionPerLotConv,
            CommissionPerTrade = fxcore2.O2GCommissionUnitType.CommissionPerTrade,
            CommissionPerOrder = fxcore2.O2GCommissionUnitType.CommissionPerOrder,
            CommissionPerOrderConv = fxcore2.O2GCommissionUnitType.CommissionPerOrderConv,
            CommissionPerBasisPoints = fxcore2.O2GCommissionUnitType.CommissionPerBasisPoints
            
        }
    
        
        [ComVisible(true)]
        [Guid("6248D060-4C90-4883-9B31-0A7B817117D6")]
        public enum O2GCommissionStatus
        {
            CommissionStatusDisabled = fxcore2.O2GCommissionStatus.CommissionStatusDisabled,
            CommissionStatusLoading = fxcore2.O2GCommissionStatus.CommissionStatusLoading,
            CommissionStatusReady = fxcore2.O2GCommissionStatus.CommissionStatusReady,
            CommissionStatusFailToLoad = fxcore2.O2GCommissionStatus.CommissionStatusFailToLoad
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GTableListener_onAddedHandler(
                    string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GTableListener_onChangedHandler(
                    string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GTableListener_onDeletedHandler(
                    string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GTableListener_onStatusChangedHandler(
                    TableStatus paramStatus
                    );
        
            
        [ComVisible(true)]
        [Guid("83D42EA5-2C18-46eb-823B-262D62DF8CF1")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface ITableListener
        {
            
            [DispId(0x60020001)]
            void  Added(
                string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                );
            
            [DispId(0x60020002)]
            void  Changed(
                string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                );
            
            [DispId(0x60020003)]
            void  Deleted(
                string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                );
            
            [DispId(0x60020004)]
            void  StatusChanged(
                TableStatus paramStatus
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GTableManagerListener_onStatusChangedHandler(
                    TableManagerStatus paramStatus, [MarshalAs(UnmanagedType.IDispatch)]ITableManager paramTableManagerObj
                    );
        
            
        [ComVisible(true)]
        [Guid("839399CA-423F-4fab-A543-97D68FF8ED35")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface ITableManagerListener
        {
            
            [DispId(0x60020101)]
            void  ManagerStatusChanged(
                TableManagerStatus paramStatus, [MarshalAs(UnmanagedType.IDispatch)]ITableManager paramTableManagerObj
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GSessionStatus_onSessionStatusChangedHandler(
                    SessionStatusCode status
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GSessionStatus_onLoginFailedHandler(
                    string paramError
                    );
        
            
        [ComVisible(true)]
        [Guid("A67B15F3-162D-4b6c-ACEC-CDDB177C5B18")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface ISessionStatus
        {
            
            [DispId(0x60020201)]
            void  SessionStatusChanged(
                SessionStatusCode status
                );
            
            [DispId(0x60020002)]
            void  LoginFailed(
                string paramError
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GEachRowListener_onEachRowHandler(
                    string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                    );
        
            
        [ComVisible(true)]
        [Guid("97DAC051-1506-4a79-BBC2-9666971367BB")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface IEachRowListener
        {
            
            [DispId(0x60020301)]
            void  EachRow(
                string paramRowID, [MarshalAs(UnmanagedType.IDispatch)]IRow paramRowDataObj
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GResponseListener_onRequestCompletedHandler(
                    string paramRequestID, [MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GResponseListener_onRequestFailedHandler(
                    string paramRequestID, string paramError
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GResponseListener_onTablesUpdatesHandler(
                    [MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj
                    );
        
            
        [ComVisible(true)]
        [Guid("ABC29F08-B628-4747-BA9E-469D408E57B9")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface IResponseListener
        {
            
            [DispId(0x60020401)]
            void  RequestCompleted(
                string paramRequestID, [MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj
                );
            
            [DispId(0x60020402)]
            void  RequestFailed(
                string paramRequestID, string paramError
                );
            
            [DispId(0x60020403)]
            void  TablesUpdates(
                [MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GUpdatesProcessStatusListener_onUpdatesProcessStatusChangedHandler(
                    UpdatesProcessStatus status
                    );
        
            
        [ComVisible(true)]
        [Guid("E0940CA6-14E4-48F5-A7FE-7E9F7ED41605")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface IUpdatesProcessStatusListener
        {
            
            [DispId(0x60020501)]
            void  ManagerUpdatesProcessStatusChanged(
                UpdatesProcessStatus status
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GUpdateEventQueueListener_onPutInQueueHandler(
                    [MarshalAs(UnmanagedType.IDispatch)]IRow rowDataObj
                    );
        
            
        [ComVisible(true)]
        [Guid("E03CDF35-A025-46AE-8776-CFCB8D537C57")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface IUpdateEventQueueListener
        {
            
            [DispId(0x60020601)]
            void  UpdateEventQueuePutInQueue(
                [MarshalAs(UnmanagedType.IDispatch)]IRow rowDataObj
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GAllEventQueueListener_onPutInQueueHandler(
                    [MarshalAs(UnmanagedType.IDispatch)]IAllEventQueueItem rowDataObj
                    );
        
            
        [ComVisible(true)]
        [Guid("8D5F2D14-66B6-4B2D-BA57-F84A9DE6E34D")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface IAllEventQueueListener
        {
            
            [DispId(0x60020701)]
            void  AllEventQueuePutInQueue(
                [MarshalAs(UnmanagedType.IDispatch)]IAllEventQueueItem rowDataObj
                );
            
        }
    
        [ComVisible(false)]
        public delegate void  IO2GChartSessionStatus_onChartSessionStatusChangedHandler(
                    ChartSessionStatusCode status
                    );
        
        [ComVisible(false)]
        public delegate void  IO2GChartSessionStatus_onChartSessionLoginFailedHandler(
                    string paramError
                    );
        
            
        [ComVisible(true)]
        [Guid("08D2EA7A-E2A7-4BE0-9063-34A55CEDEAA6")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public interface IChartSessionStatus
        {
            
            [DispId(0x60020501)]
            void  ChartSessionStatusChanged(
                ChartSessionStatusCode status
                );
            
            [DispId(0x60020502)]
            void  ChartSessionLoginFailed(
                string paramError
                );
            
        }
    
        [ComVisible(true)]
        [Guid("8E2F3578-9587-42b9-A8C6-FDAC7EFA1E40")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IAccountTable
        {
            
            IAccountTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IAccountTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out IAccountTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IAccountTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("A6ADC3AA-B179-4a64-A8DF-CA72D5F3E762")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IAccountTable))]
        public  partial class AccountTable
            : Table, ITable, IAccountTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GAccountsTable mNetObj = null;
            
            private Session mSession;
            internal AccountTable(fxcore2.O2GAccountsTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GAccountsTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IAccountTableRow getRow(int index)
                {
                IAccountTableRow result = (IAccountTableRow)Utils.CheckWrapperForNativeNull(new AccountTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out IAccountTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GAccountTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new AccountTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out IAccountTableRow rowObj)
                {
                fxcore2.O2GAccountTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new AccountTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out IAccountTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GAccountTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new AccountTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("EB881BF3-1864-4456-9981-0DCE8ACB797A")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITradeTable
        {
            
            ITradeTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ITradeTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out ITradeTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ITradeTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("FEF7151F-04E0-4af1-8763-CC3933B09997")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ITradeTable))]
        public  partial class TradeTable
            : Table, ITable, ITradeTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GTradesTable mNetObj = null;
            
            private Session mSession;
            internal TradeTable(fxcore2.O2GTradesTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GTradesTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public ITradeTableRow getRow(int index)
                {
                ITradeTableRow result = (ITradeTableRow)Utils.CheckWrapperForNativeNull(new TradeTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out ITradeTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GTradeTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new TradeTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out ITradeTableRow rowObj)
                {
                fxcore2.O2GTradeTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new TradeTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out ITradeTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GTradeTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new TradeTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("24DD7F8A-F096-440f-9F2C-F2F8D2AC1B35")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IClosedTradeTable
        {
            
            IClosedTradeTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IClosedTradeTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out IClosedTradeTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IClosedTradeTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("21486003-78D5-4ab2-AEFE-7B258551A6B5")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IClosedTradeTable))]
        public  partial class ClosedTradeTable
            : Table, ITable, IClosedTradeTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GClosedTradesTable mNetObj = null;
            
            private Session mSession;
            internal ClosedTradeTable(fxcore2.O2GClosedTradesTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GClosedTradesTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IClosedTradeTableRow getRow(int index)
                {
                IClosedTradeTableRow result = (IClosedTradeTableRow)Utils.CheckWrapperForNativeNull(new ClosedTradeTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out IClosedTradeTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GClosedTradeTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new ClosedTradeTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out IClosedTradeTableRow rowObj)
                {
                fxcore2.O2GClosedTradeTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new ClosedTradeTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out IClosedTradeTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GClosedTradeTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new ClosedTradeTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("69335835-38EA-4DEB-AF3B-A7B17B804832")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOfferTable
        {
            
            IOfferTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOfferTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out IOfferTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOfferTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("B477768F-302E-4d68-B805-204165D56AEB")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IOfferTable))]
        public  partial class OfferTable
            : Table, ITable, IOfferTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GOffersTable mNetObj = null;
            
            private Session mSession;
            internal OfferTable(fxcore2.O2GOffersTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOffersTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IOfferTableRow getRow(int index)
                {
                IOfferTableRow result = (IOfferTableRow)Utils.CheckWrapperForNativeNull(new OfferTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out IOfferTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GOfferTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new OfferTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out IOfferTableRow rowObj)
                {
                fxcore2.O2GOfferTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new OfferTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out IOfferTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GOfferTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new OfferTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("9ED1E200-0C25-4db4-9FD8-B5D66A33A0B1")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOrderTable
        {
            
            IOrderTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOrderTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out IOrderTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IOrderTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("06CA1909-EAF0-4c15-A86C-701BEBF16E94")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IOrderTable))]
        public  partial class OrderTable
            : Table, ITable, IOrderTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GOrdersTable mNetObj = null;
            
            private Session mSession;
            internal OrderTable(fxcore2.O2GOrdersTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOrdersTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IOrderTableRow getRow(int index)
                {
                IOrderTableRow result = (IOrderTableRow)Utils.CheckWrapperForNativeNull(new OrderTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out IOrderTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GOrderTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new OrderTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out IOrderTableRow rowObj)
                {
                fxcore2.O2GOrderTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new OrderTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out IOrderTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GOrderTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new OrderTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("04BFE6DF-7B97-4827-83B4-0AD61DAAAD5D")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IMessageTable
        {
            
            IMessageTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IMessageTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out IMessageTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IMessageTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("E311C7D3-A6A5-4205-A24B-EA291FA67726")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IMessageTable))]
        public  partial class MessageTable
            : Table, ITable, IMessageTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GMessagesTable mNetObj = null;
            
            private Session mSession;
            internal MessageTable(fxcore2.O2GMessagesTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GMessagesTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IMessageTableRow getRow(int index)
                {
                IMessageTableRow result = (IMessageTableRow)Utils.CheckWrapperForNativeNull(new MessageTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out IMessageTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GMessageTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new MessageTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out IMessageTableRow rowObj)
                {
                fxcore2.O2GMessageTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new MessageTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out IMessageTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GMessageTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new MessageTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("39238C90-526E-4a90-B44E-D50B91169BD9")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISummariesTable
        {
            
            ISummariesTableRow getRow(int index);
            bool getNextRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ISummariesTableRow rowObj);
            bool findRow(string id, [MarshalAs(UnmanagedType.IDispatch)]out ISummariesTableRow rowObj);
            bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator iteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out ISummariesTableRow rowObj);
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("BF938A18-C3CB-4112-B67D-F9E6A302D075")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ISummariesTable))]
        public  partial class SummariesTable
            : Table, ITable, ISummariesTable, 
              IWrapperBase
        {
            
            private fxcore2.O2GSummaryTable mNetObj = null;
            
            private Session mSession;
            internal SummariesTable(fxcore2.O2GSummaryTable netObj, Session session)
            : base((fxcore2.O2GTable )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GSummaryTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public ISummariesTableRow getRow(int index)
                {
                ISummariesTableRow result = (ISummariesTableRow)Utils.CheckWrapperForNativeNull(new SummariesTableRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            public bool getNextRow(ITableIterator iteratorObj, out ISummariesTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GSummaryTableRow rowNative;
                    bool result = mNetObj.getNextRow( iteratorNative , out  rowNative );
                rowObj = new SummariesTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool findRow(string id, out ISummariesTableRow rowObj)
                {
                fxcore2.O2GSummaryTableRow rowNative;
                    bool result = mNetObj.findRow( 
                                    (string)
                                        id, out  rowNative );
                rowObj = new SummariesTableRow(rowNative, mSession);
                    
                return result;
                }
                
            public bool getNextRowByColumnValue(string columnID, object columnValueAsVariant, ITableIterator iteratorObj, out ISummariesTableRow rowObj)
                {
                fxcore2.O2GTableIterator iteratorNative = (fxcore2.O2GTableIterator)((TableIterator)iteratorObj).NativeObject;
                    fxcore2.O2GSummaryTableRow rowNative;
                    bool result = mNetObj.getNextRowByColumnValue( 
                                    (string)
                                        columnID,  
                                    (object)
                                        columnValueAsVariant,  iteratorNative , out  rowNative );
                rowObj = new SummariesTableRow(rowNative, mSession);
                    
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("D5CCABEE-A749-4ae6-BCFE-6120A567BE08")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IAccountRow
        {
            
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            double Balance
            {
                get;
            }
            double NonTradeEquity
            {
                get;
            }
            double M2MEquity
            {
                get;
            }
            double UsedMargin
            {
                get;
            }
            double UsedMargin3
            {
                get;
            }
            string MarginCallFlag
            {
                get;
            }
            DateTime LastMarginCallDate
            {
                get;
            }
            string MaintenanceType
            {
                get;
            }
            int AmountLimit
            {
                get;
            }
            int BaseUnitSize
            {
                get;
            }
            bool MaintenanceFlag
            {
                get;
            }
            string ManagerAccountID
            {
                get;
            }
            string LeverageProfileID
            {
                get;
            }
            double HadgeMarginPCT
            {
                get;
            }
            string ATPID
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("6EA4D3D0-4244-4450-996F-874DBC8DE7EE")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IAccountRow))]
        public  partial class AccountRow
            : Row, IRow, IAccountRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GAccountRow mNetObj = null;
            
            private Session mSession;
            internal AccountRow(fxcore2.O2GAccountRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GAccountRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string AccountID
            {
                get
                {
                string result = mNetObj.AccountID;
                
                return result;
                }
                
            }
            public string AccountName
            {
                get
                {
                string result = mNetObj.AccountName;
                
                return result;
                }
                
            }
            public string AccountKind
            {
                get
                {
                string result = mNetObj.AccountKind;
                
                return result;
                }
                
            }
            public double Balance
            {
                get
                {
                double result = mNetObj.Balance;
                
                return result;
                }
                
            }
            public double NonTradeEquity
            {
                get
                {
                double result = mNetObj.NonTradeEquity;
                
                return result;
                }
                
            }
            public double M2MEquity
            {
                get
                {
                double result = mNetObj.M2MEquity;
                
                return result;
                }
                
            }
            public double UsedMargin
            {
                get
                {
                double result = mNetObj.UsedMargin;
                
                return result;
                }
                
            }
            public double UsedMargin3
            {
                get
                {
                double result = mNetObj.UsedMargin3;
                
                return result;
                }
                
            }
            public string MarginCallFlag
            {
                get
                {
                string result = mNetObj.MarginCallFlag;
                
                return result;
                }
                
            }
            public DateTime LastMarginCallDate
            {
                get
                {
                DateTime result = mNetObj.LastMarginCallDate;
                
                return result;
                }
                
            }
            public string MaintenanceType
            {
                get
                {
                string result = mNetObj.MaintenanceType;
                
                return result;
                }
                
            }
            public int AmountLimit
            {
                get
                {
                int result = mNetObj.AmountLimit;
                
                return result;
                }
                
            }
            public int BaseUnitSize
            {
                get
                {
                int result = mNetObj.BaseUnitSize;
                
                return result;
                }
                
            }
            public bool MaintenanceFlag
            {
                get
                {
                bool result = mNetObj.MaintenanceFlag;
                
                return result;
                }
                
            }
            public string ManagerAccountID
            {
                get
                {
                string result = mNetObj.ManagerAccountID;
                
                return result;
                }
                
            }
            public string LeverageProfileID
            {
                get
                {
                string result = mNetObj.LeverageProfileID;
                
                return result;
                }
                
            }
            public double HadgeMarginPCT
            {
                get
                {
                double result = mNetObj.HadgeMarginPCT;
                
                return result;
                }
                
            }
            public string ATPID
            {
                get
                {
                string result = mNetObj.ATPID;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("EA98E739-947C-4ed6-9AF8-9DEB9147018B")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITradeRow
        {
            
            string TradeID
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            string OfferID
            {
                get;
            }
            int Amount
            {
                get;
            }
            string BuySell
            {
                get;
            }
            double OpenRate
            {
                get;
            }
            DateTime OpenTime
            {
                get;
            }
            string OpenQuoteID
            {
                get;
            }
            string OpenOrderID
            {
                get;
            }
            string OpenOrderReqID
            {
                get;
            }
            string OpenOrderRequestTXT
            {
                get;
            }
            double Commission
            {
                get;
            }
            double RolloverInterest
            {
                get;
            }
            string TradeIDOrigin
            {
                get;
            }
            double UsedMargin
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            string Parties
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("01863DC1-E9AC-4b4c-AA8C-2A2FC9A55460")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ITradeRow))]
        public  partial class TradeRow
            : Row, IRow, ITradeRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GTradeRow mNetObj = null;
            
            private Session mSession;
            internal TradeRow(fxcore2.O2GTradeRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GTradeRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string TradeID
            {
                get
                {
                string result = mNetObj.TradeID;
                
                return result;
                }
                
            }
            public string AccountID
            {
                get
                {
                string result = mNetObj.AccountID;
                
                return result;
                }
                
            }
            public string AccountName
            {
                get
                {
                string result = mNetObj.AccountName;
                
                return result;
                }
                
            }
            public string AccountKind
            {
                get
                {
                string result = mNetObj.AccountKind;
                
                return result;
                }
                
            }
            public string OfferID
            {
                get
                {
                string result = mNetObj.OfferID;
                
                return result;
                }
                
            }
            public int Amount
            {
                get
                {
                int result = mNetObj.Amount;
                
                return result;
                }
                
            }
            public string BuySell
            {
                get
                {
                string result = mNetObj.BuySell;
                
                return result;
                }
                
            }
            public double OpenRate
            {
                get
                {
                double result = mNetObj.OpenRate;
                
                return result;
                }
                
            }
            public DateTime OpenTime
            {
                get
                {
                DateTime result = mNetObj.OpenTime;
                
                return result;
                }
                
            }
            public string OpenQuoteID
            {
                get
                {
                string result = mNetObj.OpenQuoteID;
                
                return result;
                }
                
            }
            public string OpenOrderID
            {
                get
                {
                string result = mNetObj.OpenOrderID;
                
                return result;
                }
                
            }
            public string OpenOrderReqID
            {
                get
                {
                string result = mNetObj.OpenOrderReqID;
                
                return result;
                }
                
            }
            public string OpenOrderRequestTXT
            {
                get
                {
                string result = mNetObj.OpenOrderRequestTXT;
                
                return result;
                }
                
            }
            public double Commission
            {
                get
                {
                double result = mNetObj.Commission;
                
                return result;
                }
                
            }
            public double RolloverInterest
            {
                get
                {
                double result = mNetObj.RolloverInterest;
                
                return result;
                }
                
            }
            public string TradeIDOrigin
            {
                get
                {
                string result = mNetObj.TradeIDOrigin;
                
                return result;
                }
                
            }
            public double UsedMargin
            {
                get
                {
                double result = mNetObj.UsedMargin;
                
                return result;
                }
                
            }
            public string ValueDate
            {
                get
                {
                string result = mNetObj.ValueDate;
                
                return result;
                }
                
            }
            public string Parties
            {
                get
                {
                string result = mNetObj.Parties;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("8B73C267-6B4D-4789-8AC0-787A297E9306")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IClosedTradeRow
        {
            
            string TradeID
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            string OfferID
            {
                get;
            }
            int Amount
            {
                get;
            }
            string BuySell
            {
                get;
            }
            double GrossPL
            {
                get;
            }
            double Commission
            {
                get;
            }
            double RolloverInterest
            {
                get;
            }
            double OpenRate
            {
                get;
            }
            string OpenQuoteID
            {
                get;
            }
            DateTime OpenTime
            {
                get;
            }
            string OpenOrderID
            {
                get;
            }
            string OpenOrderReqID
            {
                get;
            }
            string OpenOrderRequestTXT
            {
                get;
            }
            string OpenOrderParties
            {
                get;
            }
            double CloseRate
            {
                get;
            }
            string CloseQuoteID
            {
                get;
            }
            DateTime CloseTime
            {
                get;
            }
            string CloseOrderID
            {
                get;
            }
            string CloseOrderReqID
            {
                get;
            }
            string CloseOrderRequestTXT
            {
                get;
            }
            string CloseOrderParties
            {
                get;
            }
            string TradeIDOrigin
            {
                get;
            }
            string TradeIDRemain
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("C23FF165-AAAD-4565-A466-DD396E36CA71")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IClosedTradeRow))]
        public  partial class ClosedTradeRow
            : Row, IRow, IClosedTradeRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GClosedTradeRow mNetObj = null;
            
            private Session mSession;
            internal ClosedTradeRow(fxcore2.O2GClosedTradeRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GClosedTradeRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string TradeID
            {
                get
                {
                string result = mNetObj.TradeID;
                
                return result;
                }
                
            }
            public string AccountID
            {
                get
                {
                string result = mNetObj.AccountID;
                
                return result;
                }
                
            }
            public string AccountName
            {
                get
                {
                string result = mNetObj.AccountName;
                
                return result;
                }
                
            }
            public string AccountKind
            {
                get
                {
                string result = mNetObj.AccountKind;
                
                return result;
                }
                
            }
            public string OfferID
            {
                get
                {
                string result = mNetObj.OfferID;
                
                return result;
                }
                
            }
            public int Amount
            {
                get
                {
                int result = mNetObj.Amount;
                
                return result;
                }
                
            }
            public string BuySell
            {
                get
                {
                string result = mNetObj.BuySell;
                
                return result;
                }
                
            }
            public double GrossPL
            {
                get
                {
                double result = mNetObj.GrossPL;
                
                return result;
                }
                
            }
            public double Commission
            {
                get
                {
                double result = mNetObj.Commission;
                
                return result;
                }
                
            }
            public double RolloverInterest
            {
                get
                {
                double result = mNetObj.RolloverInterest;
                
                return result;
                }
                
            }
            public double OpenRate
            {
                get
                {
                double result = mNetObj.OpenRate;
                
                return result;
                }
                
            }
            public string OpenQuoteID
            {
                get
                {
                string result = mNetObj.OpenQuoteID;
                
                return result;
                }
                
            }
            public DateTime OpenTime
            {
                get
                {
                DateTime result = mNetObj.OpenTime;
                
                return result;
                }
                
            }
            public string OpenOrderID
            {
                get
                {
                string result = mNetObj.OpenOrderID;
                
                return result;
                }
                
            }
            public string OpenOrderReqID
            {
                get
                {
                string result = mNetObj.OpenOrderReqID;
                
                return result;
                }
                
            }
            public string OpenOrderRequestTXT
            {
                get
                {
                string result = mNetObj.OpenOrderRequestTXT;
                
                return result;
                }
                
            }
            public string OpenOrderParties
            {
                get
                {
                string result = mNetObj.OpenOrderParties;
                
                return result;
                }
                
            }
            public double CloseRate
            {
                get
                {
                double result = mNetObj.CloseRate;
                
                return result;
                }
                
            }
            public string CloseQuoteID
            {
                get
                {
                string result = mNetObj.CloseQuoteID;
                
                return result;
                }
                
            }
            public DateTime CloseTime
            {
                get
                {
                DateTime result = mNetObj.CloseTime;
                
                return result;
                }
                
            }
            public string CloseOrderID
            {
                get
                {
                string result = mNetObj.CloseOrderID;
                
                return result;
                }
                
            }
            public string CloseOrderReqID
            {
                get
                {
                string result = mNetObj.CloseOrderReqID;
                
                return result;
                }
                
            }
            public string CloseOrderRequestTXT
            {
                get
                {
                string result = mNetObj.CloseOrderRequestTXT;
                
                return result;
                }
                
            }
            public string CloseOrderParties
            {
                get
                {
                string result = mNetObj.CloseOrderParties;
                
                return result;
                }
                
            }
            public string TradeIDOrigin
            {
                get
                {
                string result = mNetObj.TradeIDOrigin;
                
                return result;
                }
                
            }
            public string TradeIDRemain
            {
                get
                {
                string result = mNetObj.TradeIDRemain;
                
                return result;
                }
                
            }
            public string ValueDate
            {
                get
                {
                string result = mNetObj.ValueDate;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("F668E8CF-EC88-4090-8F95-30FB99DC5E2F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOfferRow
        {
            
            string OfferID
            {
                get;
            }
            string Instrument
            {
                get;
            }
            string QuoteID
            {
                get;
            }
            double Bid
            {
                get;
            }
            double Ask
            {
                get;
            }
            double Low
            {
                get;
            }
            double High
            {
                get;
            }
            int Volume
            {
                get;
            }
            DateTime Time
            {
                get;
            }
            string BidTradable
            {
                get;
            }
            string AskTradable
            {
                get;
            }
            double SellInterest
            {
                get;
            }
            double BuyInterest
            {
                get;
            }
            string ContractCurrency
            {
                get;
            }
            int Digits
            {
                get;
            }
            double PointSize
            {
                get;
            }
            string SubscriptionStatus
            {
                get;
            }
            int InstrumentType
            {
                get;
            }
            double ContractMultiplier
            {
                get;
            }
            string TradingStatus
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            string BidID
            {
                get;
            }
            string AskID
            {
                get;
            }
            DateTime BidExpireDate
            {
                get;
            }
            DateTime AskExpireDate
            {
                get;
            }
            bool isOfferIDValid
            {
                get;
            }
            bool isInstrumentValid
            {
                get;
            }
            bool isQuoteIDValid
            {
                get;
            }
            bool isBidValid
            {
                get;
            }
            bool isAskValid
            {
                get;
            }
            bool isLowValid
            {
                get;
            }
            bool isHighValid
            {
                get;
            }
            bool isVolumeValid
            {
                get;
            }
            bool isTimeValid
            {
                get;
            }
            bool isBidTradableValid
            {
                get;
            }
            bool isAskTradableValid
            {
                get;
            }
            bool isSellInterestValid
            {
                get;
            }
            bool isBuyInterestValid
            {
                get;
            }
            bool isContractCurrencyValid
            {
                get;
            }
            bool isDigitsValid
            {
                get;
            }
            bool isPointSizeValid
            {
                get;
            }
            bool isSubscriptionStatusValid
            {
                get;
            }
            bool isInstrumentTypeValid
            {
                get;
            }
            bool isContractMultiplierValid
            {
                get;
            }
            bool isTradingStatusValid
            {
                get;
            }
            bool isValueDateValid
            {
                get;
            }
            bool isBidIDValid
            {
                get;
            }
            bool isAskIDValid
            {
                get;
            }
            bool isBidExpireDateValid
            {
                get;
            }
            bool isAskExpireDateValid
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("E934CAC3-7A3D-4ef8-B528-E93DD270D20C")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IOfferRow))]
        public  partial class OfferRow
            : Row, IRow, IOfferRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GOfferRow mNetObj = null;
            
            private Session mSession;
            internal OfferRow(fxcore2.O2GOfferRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOfferRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string OfferID
            {
                get
                {
                string result = mNetObj.OfferID;
                
                return result;
                }
                
            }
            public string Instrument
            {
                get
                {
                string result = mNetObj.Instrument;
                
                return result;
                }
                
            }
            public string QuoteID
            {
                get
                {
                string result = mNetObj.QuoteID;
                
                return result;
                }
                
            }
            public double Bid
            {
                get
                {
                double result = mNetObj.Bid;
                
                return result;
                }
                
            }
            public double Ask
            {
                get
                {
                double result = mNetObj.Ask;
                
                return result;
                }
                
            }
            public double Low
            {
                get
                {
                double result = mNetObj.Low;
                
                return result;
                }
                
            }
            public double High
            {
                get
                {
                double result = mNetObj.High;
                
                return result;
                }
                
            }
            public int Volume
            {
                get
                {
                int result = mNetObj.Volume;
                
                return result;
                }
                
            }
            public DateTime Time
            {
                get
                {
                DateTime result = mNetObj.Time;
                
                return result;
                }
                
            }
            public string BidTradable
            {
                get
                {
                string result = mNetObj.BidTradable;
                
                return result;
                }
                
            }
            public string AskTradable
            {
                get
                {
                string result = mNetObj.AskTradable;
                
                return result;
                }
                
            }
            public double SellInterest
            {
                get
                {
                double result = mNetObj.SellInterest;
                
                return result;
                }
                
            }
            public double BuyInterest
            {
                get
                {
                double result = mNetObj.BuyInterest;
                
                return result;
                }
                
            }
            public string ContractCurrency
            {
                get
                {
                string result = mNetObj.ContractCurrency;
                
                return result;
                }
                
            }
            public int Digits
            {
                get
                {
                int result = mNetObj.Digits;
                
                return result;
                }
                
            }
            public double PointSize
            {
                get
                {
                double result = mNetObj.PointSize;
                
                return result;
                }
                
            }
            public string SubscriptionStatus
            {
                get
                {
                string result = mNetObj.SubscriptionStatus;
                
                return result;
                }
                
            }
            public int InstrumentType
            {
                get
                {
                int result = mNetObj.InstrumentType;
                
                return result;
                }
                
            }
            public double ContractMultiplier
            {
                get
                {
                double result = mNetObj.ContractMultiplier;
                
                return result;
                }
                
            }
            public string TradingStatus
            {
                get
                {
                string result = mNetObj.TradingStatus;
                
                return result;
                }
                
            }
            public string ValueDate
            {
                get
                {
                string result = mNetObj.ValueDate;
                
                return result;
                }
                
            }
            public string BidID
            {
                get
                {
                string result = mNetObj.BidID;
                
                return result;
                }
                
            }
            public string AskID
            {
                get
                {
                string result = mNetObj.AskID;
                
                return result;
                }
                
            }
            public DateTime BidExpireDate
            {
                get
                {
                DateTime result = mNetObj.BidExpireDate;
                
                return result;
                }
                
            }
            public DateTime AskExpireDate
            {
                get
                {
                DateTime result = mNetObj.AskExpireDate;
                
                return result;
                }
                
            }
            public bool isOfferIDValid
            {
                get
                {
                bool result = mNetObj.isOfferIDValid;
                
                return result;
                }
                
            }
            public bool isInstrumentValid
            {
                get
                {
                bool result = mNetObj.isInstrumentValid;
                
                return result;
                }
                
            }
            public bool isQuoteIDValid
            {
                get
                {
                bool result = mNetObj.isQuoteIDValid;
                
                return result;
                }
                
            }
            public bool isBidValid
            {
                get
                {
                bool result = mNetObj.isBidValid;
                
                return result;
                }
                
            }
            public bool isAskValid
            {
                get
                {
                bool result = mNetObj.isAskValid;
                
                return result;
                }
                
            }
            public bool isLowValid
            {
                get
                {
                bool result = mNetObj.isLowValid;
                
                return result;
                }
                
            }
            public bool isHighValid
            {
                get
                {
                bool result = mNetObj.isHighValid;
                
                return result;
                }
                
            }
            public bool isVolumeValid
            {
                get
                {
                bool result = mNetObj.isVolumeValid;
                
                return result;
                }
                
            }
            public bool isTimeValid
            {
                get
                {
                bool result = mNetObj.isTimeValid;
                
                return result;
                }
                
            }
            public bool isBidTradableValid
            {
                get
                {
                bool result = mNetObj.isBidTradableValid;
                
                return result;
                }
                
            }
            public bool isAskTradableValid
            {
                get
                {
                bool result = mNetObj.isAskTradableValid;
                
                return result;
                }
                
            }
            public bool isSellInterestValid
            {
                get
                {
                bool result = mNetObj.isSellInterestValid;
                
                return result;
                }
                
            }
            public bool isBuyInterestValid
            {
                get
                {
                bool result = mNetObj.isBuyInterestValid;
                
                return result;
                }
                
            }
            public bool isContractCurrencyValid
            {
                get
                {
                bool result = mNetObj.isContractCurrencyValid;
                
                return result;
                }
                
            }
            public bool isDigitsValid
            {
                get
                {
                bool result = mNetObj.isDigitsValid;
                
                return result;
                }
                
            }
            public bool isPointSizeValid
            {
                get
                {
                bool result = mNetObj.isPointSizeValid;
                
                return result;
                }
                
            }
            public bool isSubscriptionStatusValid
            {
                get
                {
                bool result = mNetObj.isSubscriptionStatusValid;
                
                return result;
                }
                
            }
            public bool isInstrumentTypeValid
            {
                get
                {
                bool result = mNetObj.isInstrumentTypeValid;
                
                return result;
                }
                
            }
            public bool isContractMultiplierValid
            {
                get
                {
                bool result = mNetObj.isContractMultiplierValid;
                
                return result;
                }
                
            }
            public bool isTradingStatusValid
            {
                get
                {
                bool result = mNetObj.isTradingStatusValid;
                
                return result;
                }
                
            }
            public bool isValueDateValid
            {
                get
                {
                bool result = mNetObj.isValueDateValid;
                
                return result;
                }
                
            }
            public bool isBidIDValid
            {
                get
                {
                bool result = mNetObj.isBidIDValid;
                
                return result;
                }
                
            }
            public bool isAskIDValid
            {
                get
                {
                bool result = mNetObj.isAskIDValid;
                
                return result;
                }
                
            }
            public bool isBidExpireDateValid
            {
                get
                {
                bool result = mNetObj.isBidExpireDateValid;
                
                return result;
                }
                
            }
            public bool isAskExpireDateValid
            {
                get
                {
                bool result = mNetObj.isAskExpireDateValid;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("64EF714A-4B2E-4973-9A1F-878A120BB4AD")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOrderRow
        {
            
            string OrderID
            {
                get;
            }
            string RequestID
            {
                get;
            }
            double Rate
            {
                get;
            }
            double ExecutionRate
            {
                get;
            }
            double RateMin
            {
                get;
            }
            double RateMax
            {
                get;
            }
            string TradeID
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string OfferID
            {
                get;
            }
            bool NetQuantity
            {
                get;
            }
            string BuySell
            {
                get;
            }
            string Stage
            {
                get;
            }
            string Type
            {
                get;
            }
            string Status
            {
                get;
            }
            DateTime StatusTime
            {
                get;
            }
            int Amount
            {
                get;
            }
            double Lifetime
            {
                get;
            }
            double AtMarket
            {
                get;
            }
            int TrailStep
            {
                get;
            }
            double TrailRate
            {
                get;
            }
            string TimeInForce
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            string RequestTXT
            {
                get;
            }
            string ContingentOrderID
            {
                get;
            }
            int ContingencyType
            {
                get;
            }
            string PrimaryID
            {
                get;
            }
            int OriginAmount
            {
                get;
            }
            int FilledAmount
            {
                get;
            }
            bool WorkingIndicator
            {
                get;
            }
            string PegType
            {
                get;
            }
            double PegOffset
            {
                get;
            }
            double PegOffsetMin
            {
                get;
            }
            double PegOffsetMax
            {
                get;
            }
            DateTime ExpireDate
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            string Parties
            {
                get;
            }
            int Side
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("1C0B1E76-6FF4-402f-BF42-DB0B7A9209DE")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IOrderRow))]
        public  partial class OrderRow
            : Row, IRow, IOrderRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GOrderRow mNetObj = null;
            
            private Session mSession;
            internal OrderRow(fxcore2.O2GOrderRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOrderRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string OrderID
            {
                get
                {
                string result = mNetObj.OrderID;
                
                return result;
                }
                
            }
            public string RequestID
            {
                get
                {
                string result = mNetObj.RequestID;
                
                return result;
                }
                
            }
            public double Rate
            {
                get
                {
                double result = mNetObj.Rate;
                
                return result;
                }
                
            }
            public double ExecutionRate
            {
                get
                {
                double result = mNetObj.ExecutionRate;
                
                return result;
                }
                
            }
            public double RateMin
            {
                get
                {
                double result = mNetObj.RateMin;
                
                return result;
                }
                
            }
            public double RateMax
            {
                get
                {
                double result = mNetObj.RateMax;
                
                return result;
                }
                
            }
            public string TradeID
            {
                get
                {
                string result = mNetObj.TradeID;
                
                return result;
                }
                
            }
            public string AccountID
            {
                get
                {
                string result = mNetObj.AccountID;
                
                return result;
                }
                
            }
            public string AccountName
            {
                get
                {
                string result = mNetObj.AccountName;
                
                return result;
                }
                
            }
            public string OfferID
            {
                get
                {
                string result = mNetObj.OfferID;
                
                return result;
                }
                
            }
            public bool NetQuantity
            {
                get
                {
                bool result = mNetObj.NetQuantity;
                
                return result;
                }
                
            }
            public string BuySell
            {
                get
                {
                string result = mNetObj.BuySell;
                
                return result;
                }
                
            }
            public string Stage
            {
                get
                {
                string result = mNetObj.Stage;
                
                return result;
                }
                
            }
            public string Type
            {
                get
                {
                string result = mNetObj.Type;
                
                return result;
                }
                
            }
            public string Status
            {
                get
                {
                string result = mNetObj.Status;
                
                return result;
                }
                
            }
            public DateTime StatusTime
            {
                get
                {
                DateTime result = mNetObj.StatusTime;
                
                return result;
                }
                
            }
            public int Amount
            {
                get
                {
                int result = mNetObj.Amount;
                
                return result;
                }
                
            }
            public double Lifetime
            {
                get
                {
                double result = mNetObj.Lifetime;
                
                return result;
                }
                
            }
            public double AtMarket
            {
                get
                {
                double result = mNetObj.AtMarket;
                
                return result;
                }
                
            }
            public int TrailStep
            {
                get
                {
                int result = mNetObj.TrailStep;
                
                return result;
                }
                
            }
            public double TrailRate
            {
                get
                {
                double result = mNetObj.TrailRate;
                
                return result;
                }
                
            }
            public string TimeInForce
            {
                get
                {
                string result = mNetObj.TimeInForce;
                
                return result;
                }
                
            }
            public string AccountKind
            {
                get
                {
                string result = mNetObj.AccountKind;
                
                return result;
                }
                
            }
            public string RequestTXT
            {
                get
                {
                string result = mNetObj.RequestTXT;
                
                return result;
                }
                
            }
            public string ContingentOrderID
            {
                get
                {
                string result = mNetObj.ContingentOrderID;
                
                return result;
                }
                
            }
            public int ContingencyType
            {
                get
                {
                int result = mNetObj.ContingencyType;
                
                return result;
                }
                
            }
            public string PrimaryID
            {
                get
                {
                string result = mNetObj.PrimaryID;
                
                return result;
                }
                
            }
            public int OriginAmount
            {
                get
                {
                int result = mNetObj.OriginAmount;
                
                return result;
                }
                
            }
            public int FilledAmount
            {
                get
                {
                int result = mNetObj.FilledAmount;
                
                return result;
                }
                
            }
            public bool WorkingIndicator
            {
                get
                {
                bool result = mNetObj.WorkingIndicator;
                
                return result;
                }
                
            }
            public string PegType
            {
                get
                {
                string result = mNetObj.PegType;
                
                return result;
                }
                
            }
            public double PegOffset
            {
                get
                {
                double result = mNetObj.PegOffset;
                
                return result;
                }
                
            }
            public double PegOffsetMin
            {
                get
                {
                double result = mNetObj.PegOffsetMin;
                
                return result;
                }
                
            }
            public double PegOffsetMax
            {
                get
                {
                double result = mNetObj.PegOffsetMax;
                
                return result;
                }
                
            }
            public DateTime ExpireDate
            {
                get
                {
                DateTime result = mNetObj.ExpireDate;
                
                return result;
                }
                
            }
            public string ValueDate
            {
                get
                {
                string result = mNetObj.ValueDate;
                
                return result;
                }
                
            }
            public string Parties
            {
                get
                {
                string result = mNetObj.Parties;
                
                return result;
                }
                
            }
            public int Side
            {
                get
                {
                int result = mNetObj.Side;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("46763FDB-E891-4e43-8B3C-07030C86404F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IMessageRow
        {
            
            string MsgID
            {
                get;
            }
            DateTime Time
            {
                get;
            }
            string From
            {
                get;
            }
            string Type
            {
                get;
            }
            string Feature
            {
                get;
            }
            string Text
            {
                get;
            }
            string Subject
            {
                get;
            }
            bool HTMLFragmentFlag
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("1E228E0D-AC03-4967-9159-24D1F466395C")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IMessageRow))]
        public  partial class MessageRow
            : Row, IRow, IMessageRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GMessageRow mNetObj = null;
            
            private Session mSession;
            internal MessageRow(fxcore2.O2GMessageRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GMessageRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string MsgID
            {
                get
                {
                string result = mNetObj.MsgID;
                
                return result;
                }
                
            }
            public DateTime Time
            {
                get
                {
                DateTime result = mNetObj.Time;
                
                return result;
                }
                
            }
            public string From
            {
                get
                {
                string result = mNetObj.From;
                
                return result;
                }
                
            }
            public string Type
            {
                get
                {
                string result = mNetObj.Type;
                
                return result;
                }
                
            }
            public string Feature
            {
                get
                {
                string result = mNetObj.Feature;
                
                return result;
                }
                
            }
            public string Text
            {
                get
                {
                string result = mNetObj.Text;
                
                return result;
                }
                
            }
            public string Subject
            {
                get
                {
                string result = mNetObj.Subject;
                
                return result;
                }
                
            }
            public bool HTMLFragmentFlag
            {
                get
                {
                bool result = mNetObj.HTMLFragmentFlag;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("9271BCFC-0E86-4ec5-8F47-B5B99657C116")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISummariesRow
        {
            
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("92712D10-DA1A-4265-992C-ACD256D02B84")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ISummariesRow))]
        public  partial class SummariesRow
            : Row, IRow, ISummariesRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GSummaryRow mNetObj = null;
            
            private Session mSession;
            internal SummariesRow(fxcore2.O2GSummaryRow netObj, Session session)
            : base((fxcore2.O2GRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GSummaryRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            
        }
    
        [ComVisible(true)]
        [Guid("AB2B9728-1093-4036-B06F-8E9937EBF6BE")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IAccountTableRow
        {
            
            double Equity
            {
                get;
            }
            double DayPL
            {
                get;
            }
            double UsableMargin
            {
                get;
            }
            double GrossPL
            {
                get;
            }
            int UsableMarginInPercentage
            {
                get;
            }
            int UsableMaintMarginInPercentage
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            double Balance
            {
                get;
            }
            double NonTradeEquity
            {
                get;
            }
            double M2MEquity
            {
                get;
            }
            double UsedMargin
            {
                get;
            }
            double UsedMargin3
            {
                get;
            }
            string MarginCallFlag
            {
                get;
            }
            DateTime LastMarginCallDate
            {
                get;
            }
            string MaintenanceType
            {
                get;
            }
            int AmountLimit
            {
                get;
            }
            int BaseUnitSize
            {
                get;
            }
            bool MaintenanceFlag
            {
                get;
            }
            string ManagerAccountID
            {
                get;
            }
            string LeverageProfileID
            {
                get;
            }
            double HadgeMarginPCT
            {
                get;
            }
            string ATPID
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("8DDE7821-6EA8-41a8-A469-101F520D057A")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IAccountTableRow))]
        public  partial class AccountTableRow
            : AccountRow, IAccountRow, IAccountTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GAccountTableRow mNetObj = null;
            
            private Session mSession;
            internal AccountTableRow(fxcore2.O2GAccountTableRow netObj, Session session)
            : base((fxcore2.O2GAccountRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GAccountTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public double Equity
            {
                get
                {
                double result = mNetObj.Equity;
                
                return result;
                }
                
            }
            public double DayPL
            {
                get
                {
                double result = mNetObj.DayPL;
                
                return result;
                }
                
            }
            public double UsableMargin
            {
                get
                {
                double result = mNetObj.UsableMargin;
                
                return result;
                }
                
            }
            public double GrossPL
            {
                get
                {
                double result = mNetObj.GrossPL;
                
                return result;
                }
                
            }
            public int UsableMarginInPercentage
            {
                get
                {
                int result = mNetObj.UsableMarginInPercentage;
                
                return result;
                }
                
            }
            public int UsableMaintMarginInPercentage
            {
                get
                {
                int result = mNetObj.UsableMaintMarginInPercentage;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("2DAD1FF9-9FD0-4d1b-931F-0CD73808C506")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITradeTableRow
        {
            
            double PL
            {
                get;
            }
            double GrossPL
            {
                get;
            }
            double Close
            {
                get;
            }
            double Stop
            {
                get;
            }
            double Limit
            {
                get;
            }
            string StopOrderID
            {
                get;
            }
            string LimitOrderID
            {
                get;
            }
            string Instrument
            {
                get;
            }
            double TrailRate
            {
                get;
            }
            double TrailStep
            {
                get;
            }
            double CloseCommission
            {
                get;
            }
            string TradeID
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            string OfferID
            {
                get;
            }
            int Amount
            {
                get;
            }
            string BuySell
            {
                get;
            }
            double OpenRate
            {
                get;
            }
            DateTime OpenTime
            {
                get;
            }
            string OpenQuoteID
            {
                get;
            }
            string OpenOrderID
            {
                get;
            }
            string OpenOrderReqID
            {
                get;
            }
            string OpenOrderRequestTXT
            {
                get;
            }
            double Commission
            {
                get;
            }
            double RolloverInterest
            {
                get;
            }
            string TradeIDOrigin
            {
                get;
            }
            double UsedMargin
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            string Parties
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("B0A751E8-1531-4cdf-8B0E-8BDEBF8084D4")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ITradeTableRow))]
        public  partial class TradeTableRow
            : TradeRow, ITradeRow, ITradeTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GTradeTableRow mNetObj = null;
            
            private Session mSession;
            internal TradeTableRow(fxcore2.O2GTradeTableRow netObj, Session session)
            : base((fxcore2.O2GTradeRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GTradeTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public double PL
            {
                get
                {
                double result = mNetObj.PL;
                
                return result;
                }
                
            }
            public double GrossPL
            {
                get
                {
                double result = mNetObj.GrossPL;
                
                return result;
                }
                
            }
            public double Close
            {
                get
                {
                double result = mNetObj.Close;
                
                return result;
                }
                
            }
            public double Stop
            {
                get
                {
                double result = mNetObj.Stop;
                
                return result;
                }
                
            }
            public double Limit
            {
                get
                {
                double result = mNetObj.Limit;
                
                return result;
                }
                
            }
            public string StopOrderID
            {
                get
                {
                string result = mNetObj.StopOrderID;
                
                return result;
                }
                
            }
            public string LimitOrderID
            {
                get
                {
                string result = mNetObj.LimitOrderID;
                
                return result;
                }
                
            }
            public string Instrument
            {
                get
                {
                string result = mNetObj.Instrument;
                
                return result;
                }
                
            }
            public double TrailRate
            {
                get
                {
                double result = mNetObj.TrailRate;
                
                return result;
                }
                
            }
            public double TrailStep
            {
                get
                {
                double result = mNetObj.TrailStep;
                
                return result;
                }
                
            }
            public double CloseCommission
            {
                get
                {
                double result = mNetObj.CloseCommission;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("7FB2DA66-6697-448d-BEFC-948F6E59992E")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IClosedTradeTableRow
        {
            
            double PL
            {
                get;
            }
            string Instrument
            {
                get;
            }
            double NetPL
            {
                get;
            }
            string TradeID
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            string OfferID
            {
                get;
            }
            int Amount
            {
                get;
            }
            string BuySell
            {
                get;
            }
            double GrossPL
            {
                get;
            }
            double Commission
            {
                get;
            }
            double RolloverInterest
            {
                get;
            }
            double OpenRate
            {
                get;
            }
            string OpenQuoteID
            {
                get;
            }
            DateTime OpenTime
            {
                get;
            }
            string OpenOrderID
            {
                get;
            }
            string OpenOrderReqID
            {
                get;
            }
            string OpenOrderRequestTXT
            {
                get;
            }
            string OpenOrderParties
            {
                get;
            }
            double CloseRate
            {
                get;
            }
            string CloseQuoteID
            {
                get;
            }
            DateTime CloseTime
            {
                get;
            }
            string CloseOrderID
            {
                get;
            }
            string CloseOrderReqID
            {
                get;
            }
            string CloseOrderRequestTXT
            {
                get;
            }
            string CloseOrderParties
            {
                get;
            }
            string TradeIDOrigin
            {
                get;
            }
            string TradeIDRemain
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("02BC502A-C688-4561-8977-B5C561C67E11")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IClosedTradeTableRow))]
        public  partial class ClosedTradeTableRow
            : ClosedTradeRow, IClosedTradeRow, IClosedTradeTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GClosedTradeTableRow mNetObj = null;
            
            private Session mSession;
            internal ClosedTradeTableRow(fxcore2.O2GClosedTradeTableRow netObj, Session session)
            : base((fxcore2.O2GClosedTradeRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GClosedTradeTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public double PL
            {
                get
                {
                double result = mNetObj.PL;
                
                return result;
                }
                
            }
            public string Instrument
            {
                get
                {
                string result = mNetObj.Instrument;
                
                return result;
                }
                
            }
            public double NetPL
            {
                get
                {
                double result = mNetObj.NetPL;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("08A1D5CC-43FF-4F51-BD22-F6625517D0D5")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOfferTableRow
        {
            
            double PipCost
            {
                get;
            }
            int BidChangeDirection
            {
                get;
            }
            int AskChangeDirection
            {
                get;
            }
            int HiChangeDirection
            {
                get;
            }
            int LowChangeDirection
            {
                get;
            }
            int DefaultSortOrder
            {
                get;
            }
            int FractionalPipSize
            {
                get;
            }
            bool isBidChangeDirectionValid
            {
                get;
            }
            bool isAskChangeDirectionValid
            {
                get;
            }
            bool isHiChangeDirectionValid
            {
                get;
            }
            bool isLowChangeDirectionValid
            {
                get;
            }
            bool isDefaultSortOrderValid
            {
                get;
            }
            bool isFractionalPipSizeValid
            {
                get;
            }
            string OfferID
            {
                get;
            }
            string Instrument
            {
                get;
            }
            string QuoteID
            {
                get;
            }
            double Bid
            {
                get;
            }
            double Ask
            {
                get;
            }
            double Low
            {
                get;
            }
            double High
            {
                get;
            }
            int Volume
            {
                get;
            }
            DateTime Time
            {
                get;
            }
            string BidTradable
            {
                get;
            }
            string AskTradable
            {
                get;
            }
            double SellInterest
            {
                get;
            }
            double BuyInterest
            {
                get;
            }
            string ContractCurrency
            {
                get;
            }
            int Digits
            {
                get;
            }
            double PointSize
            {
                get;
            }
            string SubscriptionStatus
            {
                get;
            }
            int InstrumentType
            {
                get;
            }
            double ContractMultiplier
            {
                get;
            }
            string TradingStatus
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            string BidID
            {
                get;
            }
            string AskID
            {
                get;
            }
            DateTime BidExpireDate
            {
                get;
            }
            DateTime AskExpireDate
            {
                get;
            }
            bool isOfferIDValid
            {
                get;
            }
            bool isInstrumentValid
            {
                get;
            }
            bool isQuoteIDValid
            {
                get;
            }
            bool isBidValid
            {
                get;
            }
            bool isAskValid
            {
                get;
            }
            bool isLowValid
            {
                get;
            }
            bool isHighValid
            {
                get;
            }
            bool isVolumeValid
            {
                get;
            }
            bool isTimeValid
            {
                get;
            }
            bool isBidTradableValid
            {
                get;
            }
            bool isAskTradableValid
            {
                get;
            }
            bool isSellInterestValid
            {
                get;
            }
            bool isBuyInterestValid
            {
                get;
            }
            bool isContractCurrencyValid
            {
                get;
            }
            bool isDigitsValid
            {
                get;
            }
            bool isPointSizeValid
            {
                get;
            }
            bool isSubscriptionStatusValid
            {
                get;
            }
            bool isInstrumentTypeValid
            {
                get;
            }
            bool isContractMultiplierValid
            {
                get;
            }
            bool isTradingStatusValid
            {
                get;
            }
            bool isValueDateValid
            {
                get;
            }
            bool isBidIDValid
            {
                get;
            }
            bool isAskIDValid
            {
                get;
            }
            bool isBidExpireDateValid
            {
                get;
            }
            bool isAskExpireDateValid
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("6E0C8C5C-CC7C-4AA0-815C-74F322ABE2B0")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IOfferTableRow))]
        public  partial class OfferTableRow
            : OfferRow, IOfferRow, IOfferTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GOfferTableRow mNetObj = null;
            
            private Session mSession;
            internal OfferTableRow(fxcore2.O2GOfferTableRow netObj, Session session)
            : base((fxcore2.O2GOfferRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOfferTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public double PipCost
            {
                get
                {
                double result = mNetObj.PipCost;
                
                return result;
                }
                
            }
            public int BidChangeDirection
            {
                get
                {
                int result = mNetObj.BidChangeDirection;
                
                return result;
                }
                
            }
            public int AskChangeDirection
            {
                get
                {
                int result = mNetObj.AskChangeDirection;
                
                return result;
                }
                
            }
            public int HiChangeDirection
            {
                get
                {
                int result = mNetObj.HiChangeDirection;
                
                return result;
                }
                
            }
            public int LowChangeDirection
            {
                get
                {
                int result = mNetObj.LowChangeDirection;
                
                return result;
                }
                
            }
            public int DefaultSortOrder
            {
                get
                {
                int result = mNetObj.DefaultSortOrder;
                
                return result;
                }
                
            }
            public int FractionalPipSize
            {
                get
                {
                int result = mNetObj.FractionalPipSize;
                
                return result;
                }
                
            }
            public bool isBidChangeDirectionValid
            {
                get
                {
                bool result = mNetObj.isBidChangeDirectionValid;
                
                return result;
                }
                
            }
            public bool isAskChangeDirectionValid
            {
                get
                {
                bool result = mNetObj.isAskChangeDirectionValid;
                
                return result;
                }
                
            }
            public bool isHiChangeDirectionValid
            {
                get
                {
                bool result = mNetObj.isHiChangeDirectionValid;
                
                return result;
                }
                
            }
            public bool isLowChangeDirectionValid
            {
                get
                {
                bool result = mNetObj.isLowChangeDirectionValid;
                
                return result;
                }
                
            }
            public bool isDefaultSortOrderValid
            {
                get
                {
                bool result = mNetObj.isDefaultSortOrderValid;
                
                return result;
                }
                
            }
            public bool isFractionalPipSizeValid
            {
                get
                {
                bool result = mNetObj.isFractionalPipSizeValid;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("890225BF-E801-460d-8F74-A167D27690C5")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOrderTableRow
        {
            
            double Stop
            {
                get;
            }
            double Limit
            {
                get;
            }
            string StopOrderID
            {
                get;
            }
            string LimitOrderID
            {
                get;
            }
            int TypeStop
            {
                get;
            }
            int TypeLimit
            {
                get;
            }
            int StopTrailStep
            {
                get;
            }
            double StopTrailRate
            {
                get;
            }
            string OrderID
            {
                get;
            }
            string RequestID
            {
                get;
            }
            double Rate
            {
                get;
            }
            double ExecutionRate
            {
                get;
            }
            double RateMin
            {
                get;
            }
            double RateMax
            {
                get;
            }
            string TradeID
            {
                get;
            }
            string AccountID
            {
                get;
            }
            string AccountName
            {
                get;
            }
            string OfferID
            {
                get;
            }
            bool NetQuantity
            {
                get;
            }
            string BuySell
            {
                get;
            }
            string Stage
            {
                get;
            }
            string Type
            {
                get;
            }
            string Status
            {
                get;
            }
            DateTime StatusTime
            {
                get;
            }
            int Amount
            {
                get;
            }
            double Lifetime
            {
                get;
            }
            double AtMarket
            {
                get;
            }
            int TrailStep
            {
                get;
            }
            double TrailRate
            {
                get;
            }
            string TimeInForce
            {
                get;
            }
            string AccountKind
            {
                get;
            }
            string RequestTXT
            {
                get;
            }
            string ContingentOrderID
            {
                get;
            }
            int ContingencyType
            {
                get;
            }
            string PrimaryID
            {
                get;
            }
            int OriginAmount
            {
                get;
            }
            int FilledAmount
            {
                get;
            }
            bool WorkingIndicator
            {
                get;
            }
            string PegType
            {
                get;
            }
            double PegOffset
            {
                get;
            }
            double PegOffsetMin
            {
                get;
            }
            double PegOffsetMax
            {
                get;
            }
            DateTime ExpireDate
            {
                get;
            }
            string ValueDate
            {
                get;
            }
            string Parties
            {
                get;
            }
            int Side
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("46D96A22-9EEC-4f5a-A562-93C6587D8EF7")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IOrderTableRow))]
        public  partial class OrderTableRow
            : OrderRow, IOrderRow, IOrderTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GOrderTableRow mNetObj = null;
            
            private Session mSession;
            internal OrderTableRow(fxcore2.O2GOrderTableRow netObj, Session session)
            : base((fxcore2.O2GOrderRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOrderTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public double Stop
            {
                get
                {
                double result = mNetObj.Stop;
                
                return result;
                }
                
            }
            public double Limit
            {
                get
                {
                double result = mNetObj.Limit;
                
                return result;
                }
                
            }
            public string StopOrderID
            {
                get
                {
                string result = mNetObj.StopOrderID;
                
                return result;
                }
                
            }
            public string LimitOrderID
            {
                get
                {
                string result = mNetObj.LimitOrderID;
                
                return result;
                }
                
            }
            public int TypeStop
            {
                get
                {
                int result = mNetObj.TypeStop;
                
                return result;
                }
                
            }
            public int TypeLimit
            {
                get
                {
                int result = mNetObj.TypeLimit;
                
                return result;
                }
                
            }
            public int StopTrailStep
            {
                get
                {
                int result = mNetObj.StopTrailStep;
                
                return result;
                }
                
            }
            public double StopTrailRate
            {
                get
                {
                double result = mNetObj.StopTrailRate;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("83591893-BA7A-4441-BB87-5991A6EFF891")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IMessageTableRow
        {
            
            string MsgID
            {
                get;
            }
            DateTime Time
            {
                get;
            }
            string From
            {
                get;
            }
            string Type
            {
                get;
            }
            string Feature
            {
                get;
            }
            string Text
            {
                get;
            }
            string Subject
            {
                get;
            }
            bool HTMLFragmentFlag
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("439547FE-3050-46c6-B3EF-282183BF430B")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IMessageTableRow))]
        public  partial class MessageTableRow
            : MessageRow, IMessageRow, IMessageTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GMessageTableRow mNetObj = null;
            
            private Session mSession;
            internal MessageTableRow(fxcore2.O2GMessageTableRow netObj, Session session)
            : base((fxcore2.O2GMessageRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GMessageTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            
        }
    
        [ComVisible(true)]
        [Guid("C36FDF11-3747-44fc-892B-96B4E617D159")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISummariesTableRow
        {
            
            string OfferID
            {
                get;
            }
            int DefaultSortOrder
            {
                get;
            }
            string Instrument
            {
                get;
            }
            double SellNetPL
            {
                get;
            }
            double SellNetPLPip
            {
                get;
            }
            double SellAmount
            {
                get;
            }
            double SellAvgOpen
            {
                get;
            }
            double BuyClose
            {
                get;
            }
            double SellClose
            {
                get;
            }
            double BuyAvgOpen
            {
                get;
            }
            double BuyAmount
            {
                get;
            }
            double BuyNetPL
            {
                get;
            }
            double BuyNetPLPip
            {
                get;
            }
            double Amount
            {
                get;
            }
            double GrossPL
            {
                get;
            }
            double NetPL
            {
                get;
            }
            double RolloverInterestSum
            {
                get;
            }
            double UsedMargin
            {
                get;
            }
            double UsedMarginBuy
            {
                get;
            }
            double UsedMarginSell
            {
                get;
            }
            double Commission
            {
                get;
            }
            double CloseCommission
            {
                get;
            }
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("04800D40-915B-4b64-A53C-8241FA7DC4A8")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ISummariesTableRow))]
        public  partial class SummariesTableRow
            : SummariesRow, ISummariesRow, ISummariesTableRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GSummaryTableRow mNetObj = null;
            
            private Session mSession;
            internal SummariesTableRow(fxcore2.O2GSummaryTableRow netObj, Session session)
            : base((fxcore2.O2GSummaryRow )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GSummaryTableRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string OfferID
            {
                get
                {
                string result = mNetObj.OfferID;
                
                return result;
                }
                
            }
            public int DefaultSortOrder
            {
                get
                {
                int result = mNetObj.DefaultSortOrder;
                
                return result;
                }
                
            }
            public string Instrument
            {
                get
                {
                string result = mNetObj.Instrument;
                
                return result;
                }
                
            }
            public double SellNetPL
            {
                get
                {
                double result = mNetObj.SellNetPL;
                
                return result;
                }
                
            }
            public double SellNetPLPip
            {
                get
                {
                double result = mNetObj.SellNetPLPip;
                
                return result;
                }
                
            }
            public double SellAmount
            {
                get
                {
                double result = mNetObj.SellAmount;
                
                return result;
                }
                
            }
            public double SellAvgOpen
            {
                get
                {
                double result = mNetObj.SellAvgOpen;
                
                return result;
                }
                
            }
            public double BuyClose
            {
                get
                {
                double result = mNetObj.BuyClose;
                
                return result;
                }
                
            }
            public double SellClose
            {
                get
                {
                double result = mNetObj.SellClose;
                
                return result;
                }
                
            }
            public double BuyAvgOpen
            {
                get
                {
                double result = mNetObj.BuyAvgOpen;
                
                return result;
                }
                
            }
            public double BuyAmount
            {
                get
                {
                double result = mNetObj.BuyAmount;
                
                return result;
                }
                
            }
            public double BuyNetPL
            {
                get
                {
                double result = mNetObj.BuyNetPL;
                
                return result;
                }
                
            }
            public double BuyNetPLPip
            {
                get
                {
                double result = mNetObj.BuyNetPLPip;
                
                return result;
                }
                
            }
            public double Amount
            {
                get
                {
                double result = mNetObj.Amount;
                
                return result;
                }
                
            }
            public double GrossPL
            {
                get
                {
                double result = mNetObj.GrossPL;
                
                return result;
                }
                
            }
            public double NetPL
            {
                get
                {
                double result = mNetObj.NetPL;
                
                return result;
                }
                
            }
            public double RolloverInterestSum
            {
                get
                {
                double result = mNetObj.RolloverInterestSum;
                
                return result;
                }
                
            }
            public double UsedMargin
            {
                get
                {
                double result = mNetObj.UsedMargin;
                
                return result;
                }
                
            }
            public double UsedMarginBuy
            {
                get
                {
                double result = mNetObj.UsedMarginBuy;
                
                return result;
                }
                
            }
            public double UsedMarginSell
            {
                get
                {
                double result = mNetObj.UsedMarginSell;
                
                return result;
                }
                
            }
            public double Commission
            {
                get
                {
                double result = mNetObj.Commission;
                
                return result;
                }
                
            }
            public double CloseCommission
            {
                get
                {
                double result = mNetObj.CloseCommission;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("9D363973-53AE-4ef7-9542-8AB492059011")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IAccountTableReader
        {
            
            IAccountRow getRow(int index);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        internal  partial class AccountTableReader
            : GenericTableResponseReader, IGenericTableResponseReader, IAccountTableReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GAccountsTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal AccountTableReader(fxcore2.O2GAccountsTableResponseReader netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GAccountsTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IAccountRow getRow(int index)
                {
                IAccountRow result = (IAccountRow)Utils.CheckWrapperForNativeNull(new AccountRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("95CD6022-970D-4f55-BD85-6D2E02858985")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITradeTableReader
        {
            
            ITradeRow getRow(int index);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        internal  partial class TradeTableReader
            : GenericTableResponseReader, IGenericTableResponseReader, ITradeTableReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GTradesTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal TradeTableReader(fxcore2.O2GTradesTableResponseReader netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GTradesTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public ITradeRow getRow(int index)
                {
                ITradeRow result = (ITradeRow)Utils.CheckWrapperForNativeNull(new TradeRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("61726769-1496-467b-B0BF-1D693120F5CE")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IClosedTableReader
        {
            
            IClosedTradeRow getRow(int index);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        internal  partial class ClosedTableReader
            : GenericTableResponseReader, IGenericTableResponseReader, IClosedTableReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GClosedTradesTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal ClosedTableReader(fxcore2.O2GClosedTradesTableResponseReader netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GClosedTradesTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IClosedTradeRow getRow(int index)
                {
                IClosedTradeRow result = (IClosedTradeRow)Utils.CheckWrapperForNativeNull(new ClosedTradeRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("C5C49D30-D245-4d80-ACEC-C18DD2ED2E1F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOfferTableReader
        {
            
            IOfferRow getRow(int index);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        internal  partial class OfferTableReader
            : GenericTableResponseReader, IGenericTableResponseReader, IOfferTableReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GOffersTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal OfferTableReader(fxcore2.O2GOffersTableResponseReader netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOffersTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IOfferRow getRow(int index)
                {
                IOfferRow result = (IOfferRow)Utils.CheckWrapperForNativeNull(new OfferRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("E12CF74F-D324-4381-B4D9-E68B90D34493")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOrderTableReader
        {
            
            IOrderRow getRow(int index);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        internal  partial class OrderTableReader
            : GenericTableResponseReader, IGenericTableResponseReader, IOrderTableReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GOrdersTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal OrderTableReader(fxcore2.O2GOrdersTableResponseReader netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GOrdersTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IOrderRow getRow(int index)
                {
                IOrderRow result = (IOrderRow)Utils.CheckWrapperForNativeNull(new OrderRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("D19AEC41-8BCE-44ed-ABA4-AD804299ACD3")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IMessageTableReader
        {
            
            IMessageRow getRow(int index);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        internal  partial class MessageTableReader
            : GenericTableResponseReader, IGenericTableResponseReader, IMessageTableReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GMessagesTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal MessageTableReader(fxcore2.O2GMessagesTableResponseReader netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GMessagesTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IMessageRow getRow(int index)
                {
                IMessageRow result = (IMessageRow)Utils.CheckWrapperForNativeNull(new MessageRow(mNetObj.getRow( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("838C6756-2178-436F-87BA-79A86641068B")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IAllEventQueueItem
        {
            
            
            [DispId(0x60020001)]
            IRow RowData
            {
                get;
            }
            
            [DispId(0x60020002)]
            TableUpdateType EventType
            {
                get;
            }
            
            [DispId(0x60020003)]
            UpdatesProcessStatus ProcessStatus
            {
                get;
            }
        }

        internal  partial class AllEventQueueItem
            : IAllEventQueueItem, 
              IWrapperBase
        {
            
            private fxcore2.O2GAllEventQueueItem mNetObj = null;
            
            private Session mSession;
            internal AllEventQueueItem(fxcore2.O2GAllEventQueueItem netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GAllEventQueueItem NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IRow RowData
            {
                get
                {
                IRow result = (IRow)Utils.CheckWrapperForNativeNull(new Row(mNetObj.RowData , mSession));
                
                return result;
                }
                
            }
            public TableUpdateType EventType
            {
                get
                {
                TableUpdateType result = (TableUpdateType)(int)mNetObj.EventType;
                
                return result;
                }
                
            }
            public UpdatesProcessStatus ProcessStatus
            {
                get
                {
                UpdatesProcessStatus result = (UpdatesProcessStatus)(int)mNetObj.ProcessStatus;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("BF596901-322D-4D53-B714-5A4E5C18960E")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IUpdateEventQueue
        {
            
            
            [DispId(0x60020001)]
            bool isEmpty();
            
            [DispId(0x60020002)]
            void  deleteAllEvents();
            
            [DispId(0x60020003)]
            bool tryGet([MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
            
            [DispId(0x60020004)]
            void  waitGet([MarshalAs(UnmanagedType.IDispatch)]out IRow rowObj);
            
            [DispId(0x60020005)]
            void  breakableWaitGet([MarshalAs(UnmanagedType.IDispatch)]out IRow dataObj, bool isNeedToContinueWait);
            
            [DispId(0x60020006)]
            bool timedWaitGet([MarshalAs(UnmanagedType.IDispatch)]out IRow dataObj, int milliseconds);
            
            [DispId(0x60020007)]
            TableUpdateType EventsType
            {
                get;
            }
            
            [DispId(0x60020008)]
            TableType BelongTableType
            {
                get;
            }
        }

        internal  partial class UpdateEventQueue
            : IUpdateEventQueue, 
              IWrapperBase
        {
            
            private fxcore2.O2GUpdateEventQueue mNetObj = null;
            
            private Session mSession;
            internal UpdateEventQueue(fxcore2.O2GUpdateEventQueue netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GUpdateEventQueue NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public bool isEmpty()
                {
                bool result = mNetObj.isEmpty();
                
                return result;
                }
                
            public void  deleteAllEvents()
                {
                mNetObj.deleteAllEvents();
                
                }
                
            public bool tryGet(out IRow rowObj)
                {
                fxcore2.O2GRow rowNative;
                    bool result = mNetObj.tryGet(out  rowNative );
                rowObj = new Row(rowNative, mSession);
                    
                return result;
                }
                
            public void  waitGet(out IRow rowObj)
                {
                fxcore2.O2GRow rowNative;
                    mNetObj.waitGet(out  rowNative );
                rowObj = new Row(rowNative, mSession);
                    
                }
                
            public void  breakableWaitGet(out IRow dataObj, bool isNeedToContinueWait)
                {
                fxcore2.O2GRow dataNative;
                    mNetObj.breakableWaitGet(out  dataNative ,  
                                    (bool)
                                        isNeedToContinueWait);
                dataObj = new Row(dataNative, mSession);
                    
                }
                
            public bool timedWaitGet(out IRow dataObj, int milliseconds)
                {
                fxcore2.O2GRow dataNative;
                    bool result = mNetObj.timedWaitGet(out  dataNative ,  
                                    (int)
                                        milliseconds);
                dataObj = new Row(dataNative, mSession);
                    
                return result;
                }
                
            public TableUpdateType EventsType
            {
                get
                {
                TableUpdateType result = (TableUpdateType)(int)mNetObj.EventsType;
                
                return result;
                }
                
            }
            public TableType BelongTableType
            {
                get
                {
                TableType result = (TableType)(int)mNetObj.BelongTableType;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("0E22329A-5D99-4D92-89AE-0D89992B140B")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IAllEventQueue
        {
            
            
            [DispId(0x60020001)]
            bool isEmpty();
            
            [DispId(0x60020002)]
            void  deleteAllEvents();
            
            [DispId(0x60020003)]
            bool tryGet([MarshalAs(UnmanagedType.IDispatch)]out IAllEventQueueItem rowObj);
            
            [DispId(0x60020004)]
            void  waitGet([MarshalAs(UnmanagedType.IDispatch)]out IAllEventQueueItem rowObj);
            
            [DispId(0x60020005)]
            void  breakableWaitGet([MarshalAs(UnmanagedType.IDispatch)]out IAllEventQueueItem dataObj, bool isNeedToContinueWait);
            
            [DispId(0x60020006)]
            bool timedWaitGet([MarshalAs(UnmanagedType.IDispatch)]out IAllEventQueueItem dataObj, int milliseconds);
            
            [DispId(0x60020007)]
            TableUpdateType EventsType
            {
                get;
            }
            
            [DispId(0x60020008)]
            TableType BelongTableType
            {
                get;
            }
        }

        internal  partial class AllEventQueue
            : IAllEventQueue, 
              IWrapperBase
        {
            
            private fxcore2.O2GAllEventQueue mNetObj = null;
            
            private Session mSession;
            internal AllEventQueue(fxcore2.O2GAllEventQueue netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GAllEventQueue NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public bool isEmpty()
                {
                bool result = mNetObj.isEmpty();
                
                return result;
                }
                
            public void  deleteAllEvents()
                {
                mNetObj.deleteAllEvents();
                
                }
                
            public bool tryGet(out IAllEventQueueItem rowObj)
                {
                fxcore2.O2GAllEventQueueItem rowNative;
                    bool result = mNetObj.tryGet(out  rowNative );
                rowObj = new AllEventQueueItem(rowNative, mSession);
                    
                return result;
                }
                
            public void  waitGet(out IAllEventQueueItem rowObj)
                {
                fxcore2.O2GAllEventQueueItem rowNative;
                    mNetObj.waitGet(out  rowNative );
                rowObj = new AllEventQueueItem(rowNative, mSession);
                    
                }
                
            public void  breakableWaitGet(out IAllEventQueueItem dataObj, bool isNeedToContinueWait)
                {
                fxcore2.O2GAllEventQueueItem dataNative;
                    mNetObj.breakableWaitGet(out  dataNative ,  
                                    (bool)
                                        isNeedToContinueWait);
                dataObj = new AllEventQueueItem(dataNative, mSession);
                    
                }
                
            public bool timedWaitGet(out IAllEventQueueItem dataObj, int milliseconds)
                {
                fxcore2.O2GAllEventQueueItem dataNative;
                    bool result = mNetObj.timedWaitGet(out  dataNative ,  
                                    (int)
                                        milliseconds);
                dataObj = new AllEventQueueItem(dataNative, mSession);
                    
                return result;
                }
                
            public TableUpdateType EventsType
            {
                get
                {
                TableUpdateType result = (TableUpdateType)(int)mNetObj.EventsType;
                
                return result;
                }
                
            }
            public TableType BelongTableType
            {
                get
                {
                TableType result = (TableType)(int)mNetObj.BelongTableType;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("B92EFB9D-EBD5-4a5b-8ADD-4DA0B177470D")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITimeConverter
        {
            
            
            [DispId(0x60020001)]
            DateTime convert(DateTime paramDate, TimeConverterTimeZone paramFrom, TimeConverterTimeZone paramTo);
        }

        internal  partial class TimeConverter
            : ITimeConverter, 
              IWrapperBase
        {
            
            private fxcore2.O2GTimeConverter mNetObj = null;
            
            private Session mSession;
            internal TimeConverter(fxcore2.O2GTimeConverter netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTimeConverter NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public DateTime convert(DateTime paramDate, TimeConverterTimeZone paramFrom, TimeConverterTimeZone paramTo)
                {
                DateTime result = mNetObj.convert( 
                                    (DateTime)
                                        paramDate,  (
                fxcore2.O2GTimeConverterTimeZone)(int)paramFrom,  (
                fxcore2.O2GTimeConverterTimeZone)(int)paramTo);
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("4CC4D651-F85E-4441-980D-508CB8BD479A")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ILoginRules
        {
            
            
            [DispId(0x60020004)]
            bool isTableLoadedByDefault(TableType paramTable);
            
            [DispId(0x60020005)]
            IResponse getTableRefreshResponse(TableType paramTable);
            
            [DispId(0x60020001)]
            IResponse getSystemPropertiesResponse();
            
            [DispId(0x60020002)]
            IPermissionChecker getPermissionChecker();
            
            [DispId(0x60020003)]
            ITradingSettingsProvider getTradingSettingsProvider();
        }

        internal  partial class LoginRules
            : ILoginRules, 
              IWrapperBase
        {
            
            private fxcore2.O2GLoginRules mNetObj = null;
            
            private Session mSession;
            internal LoginRules(fxcore2.O2GLoginRules netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GLoginRules NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public bool isTableLoadedByDefault(TableType paramTable)
                {
                bool result = mNetObj.isTableLoadedByDefault( (
                fxcore2.O2GTableType)(int)paramTable);
                
                return result;
                }
                
            public IResponse getTableRefreshResponse(TableType paramTable)
                {
                IResponse result = (IResponse)Utils.CheckWrapperForNativeNull(new Response(mNetObj.getTableRefreshResponse( (
                fxcore2.O2GTableType)(int)paramTable) , mSession));
                
                return result;
                }
                
            public IResponse getSystemPropertiesResponse()
                {
                IResponse result = (IResponse)Utils.CheckWrapperForNativeNull(new Response(mNetObj.getSystemPropertiesResponse() , mSession));
                
                return result;
                }
                
            public IPermissionChecker getPermissionChecker()
                {
                IPermissionChecker result = (IPermissionChecker)Utils.CheckWrapperForNativeNull(new PermissionChecker(mNetObj.getPermissionChecker() , mSession));
                
                return result;
                }
                
            public ITradingSettingsProvider getTradingSettingsProvider()
                {
                ITradingSettingsProvider result = (ITradingSettingsProvider)Utils.CheckWrapperForNativeNull(new TradingSettingsProvider(mNetObj.getTradingSettingsProvider() , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("0D308230-150D-4dd8-9AFE-C4EBCA50C32F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITradingSettingsProvider
        {
            
            
            [DispId(0x60020001)]
            int getCondDistStopForTrade(string paramInstrument);
            
            [DispId(0x60020002)]
            int getCondDistLimitForTrade(string paramInstrument);
            
            [DispId(0x60020003)]
            int getCondDistEntryStop(string paramInstrument);
            
            [DispId(0x60020004)]
            int getCondDistEntryLimit(string paramInstrument);
            
            [DispId(0x60020005)]
            int getMinQuantity(string paramInstrument, [MarshalAs(UnmanagedType.IDispatch)]IAccountRow paramAccountRowObj);
            
            [DispId(0x60020006)]
            int getMaxQuantity(string paramInstrument, [MarshalAs(UnmanagedType.IDispatch)]IAccountRow paramAccountRowObj);
            
            [DispId(0x60020007)]
            int getBaseUnitSize(string paramInstrument, [MarshalAs(UnmanagedType.IDispatch)]IAccountRow paramAccountRowObj);
            
            [DispId(0x60020008)]
            MarketStatus getMarketStatus(string paramInstrument);
            
            [DispId(0x60020009)]
            int getMinTrailingStep();
            
            [DispId(0x60020010)]
            int getMaxTrailingStep();
            
            [DispId(0x60020011)]
            double getMMR(string paramInstrument, [MarshalAs(UnmanagedType.IDispatch)]IAccountRow paramAccountRowObj);
            
            [DispId(0x60020012)]
            bool getMargins(string paramInstrument, [MarshalAs(UnmanagedType.IDispatch)]IAccountRow paramAccountRowObj, ref double paramMMR, ref double paramEMR, ref double paramLMR);
        }

        internal  partial class TradingSettingsProvider
            : ITradingSettingsProvider, 
              IWrapperBase
        {
            
            private fxcore2.O2GTradingSettingsProvider mNetObj = null;
            
            private Session mSession;
            internal TradingSettingsProvider(fxcore2.O2GTradingSettingsProvider netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTradingSettingsProvider NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int getCondDistStopForTrade(string paramInstrument)
                {
                int result = mNetObj.getCondDistStopForTrade( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public int getCondDistLimitForTrade(string paramInstrument)
                {
                int result = mNetObj.getCondDistLimitForTrade( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public int getCondDistEntryStop(string paramInstrument)
                {
                int result = mNetObj.getCondDistEntryStop( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public int getCondDistEntryLimit(string paramInstrument)
                {
                int result = mNetObj.getCondDistEntryLimit( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public int getMinQuantity(string paramInstrument, IAccountRow paramAccountRowObj)
                {
                fxcore2.O2GAccountRow paramAccountRowNative = (fxcore2.O2GAccountRow)((AccountRow)paramAccountRowObj).NativeObject;
                    int result = mNetObj.getMinQuantity( 
                                    (string)
                                        paramInstrument,  paramAccountRowNative );
                
                return result;
                }
                
            public int getMaxQuantity(string paramInstrument, IAccountRow paramAccountRowObj)
                {
                fxcore2.O2GAccountRow paramAccountRowNative = (fxcore2.O2GAccountRow)((AccountRow)paramAccountRowObj).NativeObject;
                    int result = mNetObj.getMaxQuantity( 
                                    (string)
                                        paramInstrument,  paramAccountRowNative );
                
                return result;
                }
                
            public int getBaseUnitSize(string paramInstrument, IAccountRow paramAccountRowObj)
                {
                fxcore2.O2GAccountRow paramAccountRowNative = (fxcore2.O2GAccountRow)((AccountRow)paramAccountRowObj).NativeObject;
                    int result = mNetObj.getBaseUnitSize( 
                                    (string)
                                        paramInstrument,  paramAccountRowNative );
                
                return result;
                }
                
            public MarketStatus getMarketStatus(string paramInstrument)
                {
                MarketStatus result = (MarketStatus)(int)mNetObj.getMarketStatus( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public int getMinTrailingStep()
                {
                int result = mNetObj.getMinTrailingStep();
                
                return result;
                }
                
            public int getMaxTrailingStep()
                {
                int result = mNetObj.getMaxTrailingStep();
                
                return result;
                }
                
            public double getMMR(string paramInstrument, IAccountRow paramAccountRowObj)
                {
                fxcore2.O2GAccountRow paramAccountRowNative = (fxcore2.O2GAccountRow)((AccountRow)paramAccountRowObj).NativeObject;
                    double result = mNetObj.getMMR( 
                                    (string)
                                        paramInstrument,  paramAccountRowNative );
                
                return result;
                }
                
            public bool getMargins(string paramInstrument, IAccountRow paramAccountRowObj, ref double paramMMR, ref double paramEMR, ref double paramLMR)
                {
                fxcore2.O2GAccountRow paramAccountRowNative = (fxcore2.O2GAccountRow)((AccountRow)paramAccountRowObj).NativeObject;
                    bool result = mNetObj.getMargins( 
                                    (string)
                                        paramInstrument,  paramAccountRowNative , ref  paramMMR, ref  paramEMR, ref  paramLMR);
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("66A51B26-7767-41c0-A274-93263F834D1F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IPermissionChecker
        {
            
            
            [DispId(0x60020001)]
            PermissionStatus canCreateMarketOpenOrder(string paramInstrument);
            
            [DispId(0x60020002)]
            PermissionStatus canChangeMarketOpenOrder(string paramInstrument);
            
            [DispId(0x60020003)]
            PermissionStatus canDeleteMarketOpenOrder(string paramInstrument);
            
            [DispId(0x60020004)]
            PermissionStatus canCreateMarketCloseOrder(string paramInstrument);
            
            [DispId(0x60020005)]
            PermissionStatus canChangeMarketCloseOrder(string paramInstrument);
            
            [DispId(0x60020006)]
            PermissionStatus canDeleteMarketCloseOrder(string paramInstrument);
            
            [DispId(0x60020007)]
            PermissionStatus canCreateEntryOrder(string paramInstrument);
            
            [DispId(0x60020008)]
            PermissionStatus canChangeEntryOrder(string paramInstrument);
            
            [DispId(0x60020009)]
            PermissionStatus canDeleteEntryOrder(string paramInstrument);
            
            [DispId(0x60020010)]
            PermissionStatus canCreateStopLimitOrder(string paramInstrument);
            
            [DispId(0x60020011)]
            PermissionStatus canChangeStopLimitOrder(string paramInstrument);
            
            [DispId(0x60020012)]
            PermissionStatus canDeleteStopLimitOrder(string paramInstrument);
            
            [DispId(0x60020013)]
            PermissionStatus canRequestQuote(string paramInstrument);
            
            [DispId(0x60020014)]
            PermissionStatus canAcceptQuote(string paramInstrument);
            
            [DispId(0x60020015)]
            PermissionStatus canDeleteQuote(string paramInstrument);
            
            [DispId(0x60020016)]
            PermissionStatus canCreateOCO(string paramInstrument);
            
            [DispId(0x60020017)]
            PermissionStatus canCreateOTO(string paramInstrument);
            
            [DispId(0x60020018)]
            PermissionStatus canJoinToNewContingencyGroup(string paramInstrument);
            
            [DispId(0x60020019)]
            PermissionStatus canJoinToExistingContingencyGroup(string paramInstrument);
            
            [DispId(0x60020020)]
            PermissionStatus canRemoveFromContingencyGroup(string paramInstrument);
            
            [DispId(0x60020021)]
            PermissionStatus canChangeOfferSubscription(string paramInstrument);
            
            [DispId(0x60020022)]
            PermissionStatus canCreateNetCloseOrder(string paramInstrument);
            
            [DispId(0x60020023)]
            PermissionStatus canChangeNetCloseOrder(string paramInstrument);
            
            [DispId(0x60020024)]
            PermissionStatus canDeleteNetCloseOrder(string paramInstrument);
            
            [DispId(0x60020025)]
            PermissionStatus canCreateNetStopLimitOrder(string paramInstrument);
            
            [DispId(0x60020026)]
            PermissionStatus canChangeNetStopLimitOrder(string paramInstrument);
            
            [DispId(0x60020027)]
            PermissionStatus canDeleteNetStopLimitOrder(string paramInstrument);
            
            [DispId(0x60020028)]
            PermissionStatus canUseDynamicTrailingForStop();
            
            [DispId(0x60020029)]
            PermissionStatus canUseDynamicTrailingForLimit();
            
            [DispId(0x60020030)]
            PermissionStatus canUseDynamicTrailingForEntryStop();
            
            [DispId(0x60020031)]
            PermissionStatus canUseDynamicTrailingForEntryLimit();
            
            [DispId(0x60020032)]
            PermissionStatus canUseFluctuateTrailingForStop();
            
            [DispId(0x60020033)]
            PermissionStatus canUseFluctuateTrailingForLimit();
            
            [DispId(0x60020034)]
            PermissionStatus canUseFluctuateTrailingForEntryStop();
            
            [DispId(0x60020035)]
            PermissionStatus canUseFluctuateTrailingForEntryLimit();
        }

        internal  partial class PermissionChecker
            : IPermissionChecker, 
              IWrapperBase
        {
            
            private fxcore2.O2GPermissionChecker mNetObj = null;
            
            private Session mSession;
            internal PermissionChecker(fxcore2.O2GPermissionChecker netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GPermissionChecker NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public PermissionStatus canCreateMarketOpenOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateMarketOpenOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeMarketOpenOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeMarketOpenOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteMarketOpenOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteMarketOpenOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateMarketCloseOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateMarketCloseOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeMarketCloseOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeMarketCloseOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteMarketCloseOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteMarketCloseOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateEntryOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateEntryOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeEntryOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeEntryOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteEntryOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteEntryOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateStopLimitOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateStopLimitOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeStopLimitOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeStopLimitOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteStopLimitOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteStopLimitOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canRequestQuote(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canRequestQuote( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canAcceptQuote(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canAcceptQuote( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteQuote(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteQuote( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateOCO(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateOCO( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateOTO(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateOTO( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canJoinToNewContingencyGroup(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canJoinToNewContingencyGroup( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canJoinToExistingContingencyGroup(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canJoinToExistingContingencyGroup( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canRemoveFromContingencyGroup(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canRemoveFromContingencyGroup( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeOfferSubscription(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeOfferSubscription( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateNetCloseOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateNetCloseOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeNetCloseOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeNetCloseOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteNetCloseOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteNetCloseOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canCreateNetStopLimitOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canCreateNetStopLimitOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canChangeNetStopLimitOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canChangeNetStopLimitOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canDeleteNetStopLimitOrder(string paramInstrument)
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canDeleteNetStopLimitOrder( 
                                    (string)
                                        paramInstrument);
                
                return result;
                }
                
            public PermissionStatus canUseDynamicTrailingForStop()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseDynamicTrailingForStop();
                
                return result;
                }
                
            public PermissionStatus canUseDynamicTrailingForLimit()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseDynamicTrailingForLimit();
                
                return result;
                }
                
            public PermissionStatus canUseDynamicTrailingForEntryStop()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseDynamicTrailingForEntryStop();
                
                return result;
                }
                
            public PermissionStatus canUseDynamicTrailingForEntryLimit()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseDynamicTrailingForEntryLimit();
                
                return result;
                }
                
            public PermissionStatus canUseFluctuateTrailingForStop()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseFluctuateTrailingForStop();
                
                return result;
                }
                
            public PermissionStatus canUseFluctuateTrailingForLimit()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseFluctuateTrailingForLimit();
                
                return result;
                }
                
            public PermissionStatus canUseFluctuateTrailingForEntryStop()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseFluctuateTrailingForEntryStop();
                
                return result;
                }
                
            public PermissionStatus canUseFluctuateTrailingForEntryLimit()
                {
                PermissionStatus result = (PermissionStatus)(int)mNetObj.canUseFluctuateTrailingForEntryLimit();
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("89B098EC-936C-4b49-ACD7-2D9731C4EB9C")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IValueMap
        {
            
            
            [DispId(0x60020001)]
            void  setString(RequestParamsEnum paramName, string paramValue);
            
            [DispId(0x60020002)]
            void  setDouble(RequestParamsEnum paramName, double paramValue);
            
            [DispId(0x60020003)]
            void  setInt(RequestParamsEnum paramName, int paramValue);
            
            [DispId(0x60020004)]
            void  setBoolean(RequestParamsEnum paramName, bool paramValue);
            
            [DispId(0x60020005)]
            IValueMap clone();
            
            [DispId(0x60020006)]
            void  clear();
            
            [DispId(0x60020007)]
            int ChildrenCount
            {
                get;
            }
            
            [DispId(0x60020008)]
            IValueMap getChild(int paramIndex);
            
            [DispId(0x60020009)]
            void  appendChild([MarshalAs(UnmanagedType.IDispatch)]IValueMap paramValueMapObj);
        }

        internal  partial class ValueMap
            : IValueMap, 
              IWrapperBase
        {
            
            private fxcore2.O2GValueMap mNetObj = null;
            
            private Session mSession;
            internal ValueMap(fxcore2.O2GValueMap netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GValueMap NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public void  setString(RequestParamsEnum paramName, string paramValue)
                {
                mNetObj.setString( (
                fxcore2.O2GRequestParamsEnum)(int)paramName,  
                                    (string)
                                        paramValue);
                
                }
                
            public void  setDouble(RequestParamsEnum paramName, double paramValue)
                {
                mNetObj.setDouble( (
                fxcore2.O2GRequestParamsEnum)(int)paramName,  
                                    (double)
                                        paramValue);
                
                }
                
            public void  setInt(RequestParamsEnum paramName, int paramValue)
                {
                mNetObj.setInt( (
                fxcore2.O2GRequestParamsEnum)(int)paramName,  
                                    (int)
                                        paramValue);
                
                }
                
            public void  setBoolean(RequestParamsEnum paramName, bool paramValue)
                {
                mNetObj.setBoolean( (
                fxcore2.O2GRequestParamsEnum)(int)paramName,  
                                    (bool)
                                        paramValue);
                
                }
                
            public IValueMap clone()
                {
                IValueMap result = (IValueMap)Utils.CheckWrapperForNativeNull(new ValueMap(mNetObj.clone() , mSession));
                
                return result;
                }
                
            public void  clear()
                {
                mNetObj.clear();
                
                }
                
            public int ChildrenCount
            {
                get
                {
                int result = mNetObj.ChildrenCount;
                
                return result;
                }
                
            }
            public IValueMap getChild(int paramIndex)
                {
                IValueMap result = (IValueMap)Utils.CheckWrapperForNativeNull(new ValueMap(mNetObj.getChild( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            public void  appendChild(IValueMap paramValueMapObj)
                {
                fxcore2.O2GValueMap paramValueMapNative = (fxcore2.O2GValueMap)((ValueMap)paramValueMapObj).NativeObject;
                    mNetObj.appendChild( paramValueMapNative );
                
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("C76E9FF8-F3AB-4838-A717-CC97A2CC66C0")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IRequest
        {
            
            
            [DispId(0x60020001)]
            string RequestID
            {
                get;
            }
            
            [DispId(0x60020002)]
            int ChildrenCount
            {
                get;
            }
            
            [DispId(0x60020003)]
            IRequest getChildRequest(int index);
        }

        internal  partial class Request
            : IRequest, 
              IWrapperBase
        {
            
            private fxcore2.O2GRequest mNetObj = null;
            
            private Session mSession;
            internal Request(fxcore2.O2GRequest netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GRequest NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string RequestID
            {
                get
                {
                string result = mNetObj.RequestID;
                
                return result;
                }
                
            }
            public int ChildrenCount
            {
                get
                {
                int result = mNetObj.ChildrenCount;
                
                return result;
                }
                
            }
            public IRequest getChildRequest(int index)
                {
                IRequest result = (IRequest)Utils.CheckWrapperForNativeNull(new Request(mNetObj.getChildRequest( 
                                    (int)
                                        index) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("7F8040CD-F25C-4022-A717-97567C6F619E")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISystemPropertiesReader
        {
            
            
            [DispId(0x60020001)]
            int Count
            {
                get;
            }
        }

        internal  partial class SystemPropertiesReader
            : ISystemPropertiesReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GSystemPropertiesReader mNetObj = null;
            
            private Session mSession;
            internal SystemPropertiesReader(fxcore2.O2GSystemPropertiesReader netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GSystemPropertiesReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("B9DBC090-F2E3-469c-BB1A-9EA0F04B17F7")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IRequestFactory
        {
            
            
            [DispId(0x60020001)]
            IRequest createMarketDataSnapshotRequestInstrument(string paramInstrument, [MarshalAs(UnmanagedType.IDispatch)]ITimeframe paramTimeframeObj, int paramMaxBars);
            
            [DispId(0x60020002)]
            void  fillMarketDataSnapshotRequestTime([MarshalAs(UnmanagedType.IDispatch)]IRequest paramRequestObj, DateTime paramDateFrom, DateTime paramDateTo, bool paramIsIncludeWeekends, CandleOpenPriceMode candleOpenPriceMode);
            
            [DispId(0x60020003)]
            ITimeframeCollection Timeframes
            {
                get;
            }
            
            [DispId(0x60020004)]
            IRequest createOrderRequest([MarshalAs(UnmanagedType.IDispatch)]IValueMap paramValueMapObj);
            
            [DispId(0x60020005)]
            IValueMap createValueMap();
            
            [DispId(0x60020006)]
            string getLastError();
            
            [DispId(0x60020007)]
            DateTime ZERODATE
            {
                get;
            }
            
            [DispId(0x60020008)]
            IRequest createRefreshTableRequest(TableType paramTable);
            
            [DispId(0x60020009)]
            IRequest createRefreshTableRequestByAccount(TableType paramTable, string paramAccount);
        }

        internal  partial class RequestFactory
            : IRequestFactory, 
              IWrapperBase
        {
            
            private fxcore2.O2GRequestFactory mNetObj = null;
            
            private Session mSession;
            internal RequestFactory(fxcore2.O2GRequestFactory netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GRequestFactory NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IRequest createMarketDataSnapshotRequestInstrument(string paramInstrument, ITimeframe paramTimeframeObj, int paramMaxBars)
                {
                fxcore2.O2GTimeframe paramTimeframeNative = (fxcore2.O2GTimeframe)((Timeframe)paramTimeframeObj).NativeObject;
                    IRequest result = (IRequest)Utils.CheckWrapperForNativeNull(new Request(mNetObj.createMarketDataSnapshotRequestInstrument( 
                                    (string)
                                        paramInstrument,  paramTimeframeNative ,  
                                    (int)
                                        paramMaxBars) , mSession));
                
                return result;
                }
                
            public void  fillMarketDataSnapshotRequestTime(IRequest paramRequestObj, DateTime paramDateFrom, DateTime paramDateTo, bool paramIsIncludeWeekends, CandleOpenPriceMode candleOpenPriceMode)
                {
                fxcore2.O2GRequest paramRequestNative = (fxcore2.O2GRequest)((Request)paramRequestObj).NativeObject;
                    mNetObj.fillMarketDataSnapshotRequestTime( paramRequestNative ,  
                                    (DateTime)
                                        paramDateFrom,  
                                    (DateTime)
                                        paramDateTo,  
                                    (bool)
                                        paramIsIncludeWeekends,  (
                fxcore2.O2GCandleOpenPriceMode)(int)candleOpenPriceMode);
                
                }
                
            public ITimeframeCollection Timeframes
            {
                get
                {
                ITimeframeCollection result = (ITimeframeCollection)Utils.CheckWrapperForNativeNull(new TimeframeCollection(mNetObj.Timeframes , mSession));
                
                return result;
                }
                
            }
            public IRequest createOrderRequest(IValueMap paramValueMapObj)
                {
                fxcore2.O2GValueMap paramValueMapNative = (fxcore2.O2GValueMap)((ValueMap)paramValueMapObj).NativeObject;
                    IRequest result = (IRequest)Utils.CheckWrapperForNativeNull(new Request(mNetObj.createOrderRequest( paramValueMapNative ) , mSession));
                
                return result;
                }
                
            public IValueMap createValueMap()
                {
                IValueMap result = (IValueMap)Utils.CheckWrapperForNativeNull(new ValueMap(mNetObj.createValueMap() , mSession));
                
                return result;
                }
                
            public string getLastError()
                {
                string result = mNetObj.getLastError();
                
                return result;
                }
                
            public DateTime ZERODATE
            {
                get
                {
                DateTime result = mNetObj.ZERODATE;
                
                return result;
                }
                
            }
            public IRequest createRefreshTableRequest(TableType paramTable)
                {
                IRequest result = (IRequest)Utils.CheckWrapperForNativeNull(new Request(mNetObj.createRefreshTableRequest( (
                fxcore2.O2GTableType)(int)paramTable) , mSession));
                
                return result;
                }
                
            public IRequest createRefreshTableRequestByAccount(TableType paramTable, string paramAccount)
                {
                IRequest result = (IRequest)Utils.CheckWrapperForNativeNull(new Request(mNetObj.createRefreshTableRequestByAccount( (
                fxcore2.O2GTableType)(int)paramTable,  
                                    (string)
                                        paramAccount) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("4757E00C-5251-4fc5-9F60-87B96FFFD8C1")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITimeframe
        {
            
            
            [DispId(0x60020001)]
            TimeframeUnit Unit
            {
                get;
            }
            
            [DispId(0x60020002)]
            int Size
            {
                get;
            }
            
            [DispId(0x60020003)]
            string ID
            {
                get;
            }
        }

        internal  partial class Timeframe
            : ITimeframe, 
              IWrapperBase
        {
            
            private fxcore2.O2GTimeframe mNetObj = null;
            
            private Session mSession;
            internal Timeframe(fxcore2.O2GTimeframe netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTimeframe NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public TimeframeUnit Unit
            {
                get
                {
                TimeframeUnit result = (TimeframeUnit)(int)mNetObj.Unit;
                
                return result;
                }
                
            }
            public int Size
            {
                get
                {
                int result = mNetObj.Size;
                
                return result;
                }
                
            }
            public string ID
            {
                get
                {
                string result = mNetObj.ID;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("B3E85D82-820D-43e9-A5C6-C1F5211C21F0")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITimeframeCollection
        {
            
            
            [DispId(0x60020001)]
            int Count
            {
                get;
            }
        }

        internal  partial class TimeframeCollection
            : ITimeframeCollection, 
              IWrapperBase
        {
            
            private fxcore2.O2GTimeframeCollection mNetObj = null;
            
            private Session mSession;
            internal TimeframeCollection(fxcore2.O2GTimeframeCollection netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTimeframeCollection NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("0ED280CA-EE9C-490d-97D6-B65BFB75D8F3")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IMarketDataSnapshotResponseReader
        {
            
            
            [DispId(0x60020001)]
            bool isBar
            {
                get;
            }
            
            [DispId(0x60020002)]
            int Count
            {
                get;
            }
            
            [DispId(0x60020003)]
            DateTime getDate(int paramIndex);
            
            [DispId(0x60020005)]
            int getVolume(int paramIndex);
            
            [DispId(0x60020006)]
            double getBid(int paramIndex);
            
            [DispId(0x60020007)]
            double getAsk(int paramIndex);
            
            [DispId(0x60020008)]
            double getBidOpen(int paramIndex);
            
            [DispId(0x60020009)]
            double getBidHigh(int paramIndex);
            
            [DispId(0x60020010)]
            double getBidLow(int paramIndex);
            
            [DispId(0x60020011)]
            double getBidClose(int paramIndex);
            
            [DispId(0x60020012)]
            double getAskOpen(int paramIndex);
            
            [DispId(0x60020013)]
            double getAskHigh(int paramIndex);
            
            [DispId(0x60020014)]
            double getAskLow(int paramIndex);
            
            [DispId(0x60020015)]
            double getAskClose(int paramIndex);
            
            [DispId(0x60020016)]
            int getLastBarVolume();
            
            [DispId(0x60020017)]
            DateTime getLastBarTime();
        }

        internal  partial class MarketDataSnapshotResponseReader
            : IMarketDataSnapshotResponseReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GMarketDataSnapshotResponseReader mNetObj = null;
            
            private Session mSession;
            internal MarketDataSnapshotResponseReader(fxcore2.O2GMarketDataSnapshotResponseReader netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GMarketDataSnapshotResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public bool isBar
            {
                get
                {
                bool result = mNetObj.isBar;
                
                return result;
                }
                
            }
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            public DateTime getDate(int paramIndex)
                {
                DateTime result = mNetObj.getDate( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public int getVolume(int paramIndex)
                {
                int result = mNetObj.getVolume( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getBid(int paramIndex)
                {
                double result = mNetObj.getBid( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getAsk(int paramIndex)
                {
                double result = mNetObj.getAsk( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getBidOpen(int paramIndex)
                {
                double result = mNetObj.getBidOpen( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getBidHigh(int paramIndex)
                {
                double result = mNetObj.getBidHigh( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getBidLow(int paramIndex)
                {
                double result = mNetObj.getBidLow( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getBidClose(int paramIndex)
                {
                double result = mNetObj.getBidClose( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getAskOpen(int paramIndex)
                {
                double result = mNetObj.getAskOpen( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getAskHigh(int paramIndex)
                {
                double result = mNetObj.getAskHigh( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getAskLow(int paramIndex)
                {
                double result = mNetObj.getAskLow( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public double getAskClose(int paramIndex)
                {
                double result = mNetObj.getAskClose( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public int getLastBarVolume()
                {
                int result = mNetObj.getLastBarVolume();
                
                return result;
                }
                
            public DateTime getLastBarTime()
                {
                DateTime result = mNetObj.getLastBarTime();
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("490AFDE8-A215-4FFC-AF73-125896938EEA")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITransport
        {
            
            ISession createSession();
            void  setProxy(string paramHost, int paramPort, string paramUser, string paramPassword);
            void  setNumberOfReconnections(int iNumber);
            void  setClosedHistorySize(int iSize);
        }

        
        [ComVisible(true)]
        [Guid("A2C4399C-E507-4974-807C-025C0A0E40F5")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ITransport))]
        public  partial class Transport
            : ITransport, 
              IWrapperBase
        {
            
            private fxcore2.O2GTransport mNetObj = null;
            

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTransport NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public ISession createSession()
                {
                ISession result = (ISession)Utils.CheckWrapperForNativeNull(new Session(
                        fxcore2.O2GTransport.createSession()));
                
                return result;
                }
                
            public void  setProxy(string paramHost, int paramPort, string paramUser, string paramPassword)
                {
                
                        fxcore2.O2GTransport.setProxy( 
                                    (string)
                                        paramHost,  
                                    (int)
                                        paramPort,  
                                    (string)
                                        paramUser,  
                                    (string)
                                        paramPassword);
                
                }
                
            public void  setNumberOfReconnections(int iNumber)
                {
                
                        fxcore2.O2GTransport.setNumberOfReconnections( 
                                    (int)
                                        iNumber);
                
                }
                
            public void  setClosedHistorySize(int iSize)
                {
                
                        fxcore2.O2GTransport.setClosedHistorySize( 
                                    (int)
                                        iSize);
                
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("9FAAF8C7-A3F1-44FD-BDBF-B25E115DECAB")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISession
        {
            
            
            [DispId(0x60020001)]
            ILoginRules getLoginRules();
            
            [DispId(0x60020002)]
            void  login(string paramUser, string paramPassword, string paramURL, string paramConnection);
            
            [DispId(0x60020003)]
            void  logout();
            
            [DispId(0x60020004)]
            void  subscribeSessionStatus([MarshalAs(UnmanagedType.IDispatch)]ISessionStatus paramListenerObj);
            
            [DispId(0x60020005)]
            void  unsubscribeSessionStatus([MarshalAs(UnmanagedType.IDispatch)]ISessionStatus paramListenerObj);
            
            [DispId(0x60020026)]
            void  subscribeChartSessionStatus([MarshalAs(UnmanagedType.IDispatch)]IChartSessionStatus paramListenerObj);
            
            [DispId(0x60020027)]
            void  unsubscribeChartSessionStatus([MarshalAs(UnmanagedType.IDispatch)]IChartSessionStatus paramListenerObj);
            
            [DispId(0x60020006)]
            ISessionDescriptorCollection getTradingSessionDescriptors();
            
            [DispId(0x60020030)]
            IO2GCommissionsProvider getCommissionsProvider();
            
            [DispId(0x60020007)]
            void  setTradingSession(string paramSessionId, string paramPIN);
            
            [DispId(0x60020008)]
            void  subscribeResponse([MarshalAs(UnmanagedType.IDispatch)]IResponseListener paramListenerObj);
            
            [DispId(0x60020009)]
            void  unsubscribeResponse([MarshalAs(UnmanagedType.IDispatch)]IResponseListener paramListenerObj);
            
            [DispId(0x60020010)]
            IRequestFactory getRequestFactory();
            
            [DispId(0x60020011)]
            IResponseReaderFactory getResponseReaderFactory();
            
            [DispId(0x60020012)]
            void  sendRequest([MarshalAs(UnmanagedType.IDispatch)]IRequest paramRequestObj);
            
            [DispId(0x60020013)]
            ITimeConverter getTimeConverter();
            
            [DispId(0x60020014)]
            PriceUpdateMode getPriceUpdateMode();
            
            [DispId(0x60020015)]
            void  setPriceUpdateMode(PriceUpdateMode paramMode);
            
            [DispId(0x60020016)]
            ITableManager getTableManager();
            
            [DispId(0x60020017)]
            ITableManager getTableManagerByAccount(string paramAccountID);
            
            [DispId(0x60020018)]
            void  useTableManager(TableManagerMode paramMode, [MarshalAs(UnmanagedType.IDispatch)]ITableManagerListener paramListenerObj);
            
            [DispId(0x60020019)]
            DateTime getServerTime();
            
            [DispId(0x60020031)]
            int getPriceRefreshRate();
            
            [DispId(0x60020032)]
            int getMinPriceRefreshRate();
            
            [DispId(0x60020033)]
            int getMaxPriceRefreshRate();
            
            [DispId(0x60020034)]
            bool setPriceRefreshRate(int priceRefreshRate);
            
            [DispId(0x60020020)]
            string getReportURL([MarshalAs(UnmanagedType.IDispatch)]IAccountRow paramAccountObj, DateTime paramDateFrom, DateTime paramDateTo, string paramFormat, string paramReportType, string paramLangID, int paramAnsiCP);
            
            [DispId(0x60020024)]
            SessionStatusCode getSessionStatus();
            
            [DispId(0x60020025)]
            ChartSessionStatusCode getChartSessionStatus();
            
            [DispId(0x60020028)]
            ChartSessionMode getChartSessionMode();
            
            [DispId(0x60020029)]
            void  setChartSessionMode(ChartSessionMode paramMode);
        }

        
        [ComVisible(true)]
        [Guid("652EF5B3-FF60-4F33-B4E4-CF88798D63E8")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ISession))]
        public  partial class Session
            : ISession, 
              IWrapperBase
        {
            
            private fxcore2.O2GSession mNetObj = null;
            
            private Session mSession;
            internal Session(fxcore2.O2GSession netObj)
            
            {
                
                        mSession = this;
                    
                    mNetObj = netObj;
                
                    OnInitialize();
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GSession NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public ILoginRules getLoginRules()
                {
                ILoginRules result = (ILoginRules)Utils.CheckWrapperForNativeNull(new LoginRules(mNetObj.getLoginRules() , mSession));
                
                return result;
                }
                
            public void  login(string paramUser, string paramPassword, string paramURL, string paramConnection)
                {
                mNetObj.login( 
                                    (string)
                                        paramUser,  
                                    (string)
                                        paramPassword,  
                                    (string)
                                        paramURL,  
                                    (string)
                                        paramConnection);
                
                }
                
            public void  logout()
                {
                mNetObj.logout();
                
                }
                
            public ISessionDescriptorCollection getTradingSessionDescriptors()
                {
                ISessionDescriptorCollection result = (ISessionDescriptorCollection)Utils.CheckWrapperForNativeNull(new SessionDescriptorCollection(mNetObj.getTradingSessionDescriptors() , mSession));
                
                return result;
                }
                
            public IO2GCommissionsProvider getCommissionsProvider()
                {
                IO2GCommissionsProvider result = (IO2GCommissionsProvider)Utils.CheckWrapperForNativeNull(new O2GCommissionsProvider(mNetObj.getCommissionsProvider() , mSession));
                
                return result;
                }
                
            public void  setTradingSession(string paramSessionId, string paramPIN)
                {
                mNetObj.setTradingSession( 
                                    (string)
                                        paramSessionId,  
                                    (string)
                                        paramPIN);
                
                }
                
            public IRequestFactory getRequestFactory()
                {
                IRequestFactory result = (IRequestFactory)Utils.CheckWrapperForNativeNull(new RequestFactory(mNetObj.getRequestFactory() , mSession));
                
                return result;
                }
                
            public IResponseReaderFactory getResponseReaderFactory()
                {
                IResponseReaderFactory result = (IResponseReaderFactory)Utils.CheckWrapperForNativeNull(new ResponseReaderFactory(mNetObj.getResponseReaderFactory() , mSession));
                
                return result;
                }
                
            public void  sendRequest(IRequest paramRequestObj)
                {
                fxcore2.O2GRequest paramRequestNative = (fxcore2.O2GRequest)((Request)paramRequestObj).NativeObject;
                    mNetObj.sendRequest( paramRequestNative );
                
                }
                
            public ITimeConverter getTimeConverter()
                {
                ITimeConverter result = (ITimeConverter)Utils.CheckWrapperForNativeNull(new TimeConverter(mNetObj.getTimeConverter() , mSession));
                
                return result;
                }
                
            public PriceUpdateMode getPriceUpdateMode()
                {
                PriceUpdateMode result = (PriceUpdateMode)(int)mNetObj.getPriceUpdateMode();
                
                return result;
                }
                
            public void  setPriceUpdateMode(PriceUpdateMode paramMode)
                {
                mNetObj.setPriceUpdateMode( (
                fxcore2.O2GPriceUpdateMode)(int)paramMode);
                
                }
                
            public ITableManager getTableManager()
                {
                ITableManager result = (ITableManager)Utils.CheckWrapperForNativeNull(new TableManager(mNetObj.getTableManager() , mSession));
                
                return result;
                }
                
            public ITableManager getTableManagerByAccount(string paramAccountID)
                {
                ITableManager result = (ITableManager)Utils.CheckWrapperForNativeNull(new TableManager(mNetObj.getTableManagerByAccount( 
                                    (string)
                                        paramAccountID) , mSession));
                
                return result;
                }
                
            public DateTime getServerTime()
                {
                DateTime result = mNetObj.getServerTime();
                
                return result;
                }
                
            public int getPriceRefreshRate()
                {
                int result = mNetObj.getPriceRefreshRate();
                
                return result;
                }
                
            public int getMinPriceRefreshRate()
                {
                int result = mNetObj.getMinPriceRefreshRate();
                
                return result;
                }
                
            public int getMaxPriceRefreshRate()
                {
                int result = mNetObj.getMaxPriceRefreshRate();
                
                return result;
                }
                
            public bool setPriceRefreshRate(int priceRefreshRate)
                {
                bool result = mNetObj.setPriceRefreshRate( 
                                    (int)
                                        priceRefreshRate);
                
                return result;
                }
                
            public string getReportURL(IAccountRow paramAccountObj, DateTime paramDateFrom, DateTime paramDateTo, string paramFormat, string paramReportType, string paramLangID, int paramAnsiCP)
                {
                fxcore2.O2GAccountRow paramAccountNative = (fxcore2.O2GAccountRow)((AccountRow)paramAccountObj).NativeObject;
                    string result = mNetObj.getReportURL( paramAccountNative ,  
                                    (DateTime)
                                        paramDateFrom,  
                                    (DateTime)
                                        paramDateTo,  
                                    (string)
                                        paramFormat,  
                                    (string)
                                        paramReportType,  
                                    (string)
                                        paramLangID,  
                                    (int)
                                        paramAnsiCP);
                
                return result;
                }
                
            public SessionStatusCode getSessionStatus()
                {
                SessionStatusCode result = (SessionStatusCode)(int)mNetObj.getSessionStatus();
                
                return result;
                }
                
            public ChartSessionStatusCode getChartSessionStatus()
                {
                ChartSessionStatusCode result = (ChartSessionStatusCode)(int)mNetObj.getChartSessionStatus();
                
                return result;
                }
                
            public ChartSessionMode getChartSessionMode()
                {
                ChartSessionMode result = (ChartSessionMode)(int)mNetObj.getChartSessionMode();
                
                return result;
                }
                
            public void  setChartSessionMode(ChartSessionMode paramMode)
                {
                mNetObj.setChartSessionMode( (
                fxcore2.O2GChartSessionMode)(int)paramMode);
                
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("58B8BEF6-5E86-483c-AC34-201F825844EF")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITableManager
        {
            
            
            [DispId(0x60020001)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getTable(TableType paramTableType);
            
            [DispId(0x60020002)]
            TableManagerStatus getStatus();
            
            [DispId(0x60020003)]
            void  lockUpdates();
            
            [DispId(0x60020004)]
            void  unlockUpdates();
            
            [DispId(0x60020005)]
            void  subscribeUpdatesProcessStatus([MarshalAs(UnmanagedType.IDispatch)]IUpdatesProcessStatusListener listenerObj);
            
            [DispId(0x60020006)]
            void  unsubscribeUpdatesProcessStatus([MarshalAs(UnmanagedType.IDispatch)]IUpdatesProcessStatusListener listenerObj);
        }

        
        [ComVisible(true)]
        [Guid("182ACB6D-AC5B-45c9-8BE4-3F2FDCDC2C8C")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ITableManager))]
        public  partial class TableManager
            : ITableManager, 
              IWrapperBase
        {
            
            private fxcore2.O2GTableManager mNetObj = null;
            
            private Session mSession;
            internal TableManager(fxcore2.O2GTableManager netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTableManager NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public TableManagerStatus getStatus()
                {
                TableManagerStatus result = (TableManagerStatus)(int)mNetObj.getStatus();
                
                return result;
                }
                
            public void  lockUpdates()
                {
                mNetObj.lockUpdates();
                
                }
                
            public void  unlockUpdates()
                {
                mNetObj.unlockUpdates();
                
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("B9BB8093-6750-4642-BA23-3D508827BBD6")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITableIterator
        {
            
            void  reset();
        }

        internal  partial class TableIterator
            : ITableIterator, 
              IWrapperBase
        {
            
            private fxcore2.O2GTableIterator mNetObj = null;
            
            private Session mSession;
            internal TableIterator(fxcore2.O2GTableIterator netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTableIterator NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public void  reset()
                {
                mNetObj.reset();
                
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("5CAF414A-531D-41f1-A4BE-1C625191382F")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITable
        {
            
            
            [DispId(0x60040201)]
            void  subscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040202)]
            void  unsubscribeUpdate(TableUpdateType paramUpdateType, [MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040203)]
            void  subscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040204)]
            void  unsubscribeStatus([MarshalAs(UnmanagedType.IDispatch)]ITableListener paramListenerObj);
            
            [DispId(0x60040205)]
            void  forEachRow([MarshalAs(UnmanagedType.IDispatch)]IEachRowListener paramListenerObj);
            
            [DispId(0x60040206)]
            bool isCellChanged(int paramRow, int paramColumn);
            
            [DispId(0x60040207)]
            bool getNextGenericRow([MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040208)]
            bool getNextGenericRowByColumnValue(string columnID, object columnValue, [MarshalAs(UnmanagedType.IDispatch)]ITableIterator paramIteratorObj, [MarshalAs(UnmanagedType.IDispatch)]out IRow paramRowObj);
            
            [DispId(0x60040212)]
            O2GTableEventsFilter getTableEventsFilter();
            
            [DispId(0x60040213)]
            void  setTableEventsFilter(O2GTableEventsFilter tableFilterType);
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("6E7BEF1B-899F-4332-82BE-4CED3F172C1A")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(ITable))]
        public  partial class Table
            : GenericTableResponseReader, IGenericTableResponseReader, ITable, 
              IWrapperBase
        {
            
            private fxcore2.O2GTable mNetObj = null;
            
            private Session mSession;
            internal Table(fxcore2.O2GTable netObj, Session session)
            : base((fxcore2.O2GGenericTableResponseReader )netObj, session)
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
                    OnInitialize();
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal  new fxcore2.O2GTable NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public bool isCellChanged(int paramRow, int paramColumn)
                {
                bool result = mNetObj.isCellChanged( 
                                    (int)
                                        paramRow,  
                                    (int)
                                        paramColumn);
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("BCE3C743-96E0-4141-9E07-2BB05656C608")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IRow
        {
            
            
            [DispId(0x60040001)]
            object getCell(int paramColumn);
            
            [DispId(0x60040002)]
            bool isCellChanged(int paramColumn);
            
            [DispId(0x60040003)]
            TableType TableType
            {
                get;
            }
            
            [DispId(0x60040004)]
            ITableColumnCollection Columns
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("D7104B08-780C-448b-8E0D-6A3BB1F060C8")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IRow))]
        public  partial class Row
            : IRow, 
              IWrapperBase
        {
            
            private fxcore2.O2GRow mNetObj = null;
            
            private Session mSession;
            internal Row(fxcore2.O2GRow netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GRow NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public object getCell(int paramColumn)
                {
                object result = mNetObj.getCell( 
                                    (int)
                                        paramColumn);
                
                return result;
                }
                
            public bool isCellChanged(int paramColumn)
                {
                bool result = mNetObj.isCellChanged( 
                                    (int)
                                        paramColumn);
                
                return result;
                }
                
            public TableType TableType
            {
                get
                {
                TableType result = (TableType)(int)mNetObj.TableType;
                
                return result;
                }
                
            }
            public ITableColumnCollection Columns
            {
                get
                {
                ITableColumnCollection result = (ITableColumnCollection)Utils.CheckWrapperForNativeNull(new TableColumnCollection(mNetObj.Columns , mSession));
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("A6E13B3A-A2AE-49ce-84C2-081A3034CF45")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITableColumn
        {
            
            string ID
            {
                get;
            }
            TableColumnType ColumnType
            {
                get;
            }
        }

        internal  partial class TableColumn
            : ITableColumn, 
              IWrapperBase
        {
            
            private fxcore2.O2GTableColumn mNetObj = null;
            
            private Session mSession;
            internal TableColumn(fxcore2.O2GTableColumn netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTableColumn NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string ID
            {
                get
                {
                string result = mNetObj.ID;
                
                return result;
                }
                
            }
            public TableColumnType ColumnType
            {
                get
                {
                TableColumnType result = (TableColumnType)(int)mNetObj.ColumnType;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("65154888-9079-4f1c-9AAD-15A4C907CDED")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITableColumnCollection
        {
            
            int Count
            {
                get;
            }
        }

        internal  partial class TableColumnCollection
            : ITableColumnCollection, 
              IWrapperBase
        {
            
            private fxcore2.O2GTableColumnCollection mNetObj = null;
            
            private Session mSession;
            internal TableColumnCollection(fxcore2.O2GTableColumnCollection netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTableColumnCollection NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("C8B15ACD-41AD-4ee1-8612-33025D0FFFBF")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISessionDescriptor
        {
            
            string Id
            {
                get;
            }
            string Name
            {
                get;
            }
            string Description
            {
                get;
            }
            bool RequiresPin
            {
                get;
            }
        }

        internal  partial class SessionDescriptor
            : ISessionDescriptor, 
              IWrapperBase
        {
            
            private fxcore2.O2GSessionDescriptor mNetObj = null;
            
            private Session mSession;
            internal SessionDescriptor(fxcore2.O2GSessionDescriptor netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GSessionDescriptor NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string Id
            {
                get
                {
                string result = mNetObj.Id;
                
                return result;
                }
                
            }
            public string Name
            {
                get
                {
                string result = mNetObj.Name;
                
                return result;
                }
                
            }
            public string Description
            {
                get
                {
                string result = mNetObj.Description;
                
                return result;
                }
                
            }
            public bool RequiresPin
            {
                get
                {
                bool result = mNetObj.RequiresPin;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("4BD2E1B5-307B-414c-A255-2041511ED1B8")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISessionDescriptorCollection
        {
            
            int Count
            {
                get;
            }
            ISessionDescriptor Item(int paramIndex);
        }

        internal  partial class SessionDescriptorCollection
            : ISessionDescriptorCollection, 
              IWrapperBase
        {
            
            private fxcore2.O2GSessionDescriptorCollection mNetObj = null;
            
            private Session mSession;
            internal SessionDescriptorCollection(fxcore2.O2GSessionDescriptorCollection netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GSessionDescriptorCollection NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("2420D877-4EC4-4220-B4D8-329D0A20CE1D")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IO2GCommissionsProvider
        {
            
        }

        internal  partial class O2GCommissionsProvider
            : IO2GCommissionsProvider, 
              IWrapperBase
        {
            
            private fxcore2.O2GCommissionsProvider mNetObj = null;
            
            private Session mSession;
            internal O2GCommissionsProvider(fxcore2.O2GCommissionsProvider netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GCommissionsProvider NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            
        }
    
        [ComVisible(true)]
        [Guid("EF6F2D50-EFDB-4452-AB75-20D5564FF5F3")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ICommissionDescription
        {
            
            CommissionStage Stage
            {
                get;
            }
            CommissionUnitType UnitType
            {
                get;
            }
            double CommissionValue
            {
                get;
            }
            double MinCommission
            {
                get;
            }
        }

        internal  partial class CommissionDescription
            : ICommissionDescription, 
              IWrapperBase
        {
            
            private fxcore2.O2GCommissionDescription mNetObj = null;
            
            private Session mSession;
            internal CommissionDescription(fxcore2.O2GCommissionDescription netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GCommissionDescription NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public CommissionStage Stage
            {
                get
                {
                CommissionStage result = (CommissionStage)(int)mNetObj.Stage;
                
                return result;
                }
                
            }
            public CommissionUnitType UnitType
            {
                get
                {
                CommissionUnitType result = (CommissionUnitType)(int)mNetObj.UnitType;
                
                return result;
                }
                
            }
            public double CommissionValue
            {
                get
                {
                double result = mNetObj.CommissionValue;
                
                return result;
                }
                
            }
            public double MinCommission
            {
                get
                {
                double result = mNetObj.MinCommission;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("57F08B35-9F48-4F13-8BB6-4843565CEAC2")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ICommissionDescriptionsCollection 
        {
            
            int Count
            {
                get;
            }
            ICommissionDescription Item(int paramIndex);
        }

        internal  partial class CommissionDescriptionsCollection 
            : ICommissionDescriptionsCollection , 
              IWrapperBase
        {
            
            private fxcore2.O2GCommissionDescriptionsCollection mNetObj = null;
            
            private Session mSession;
            internal CommissionDescriptionsCollection (fxcore2.O2GCommissionDescriptionsCollection netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GCommissionDescriptionsCollection NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("085B817F-1C41-4473-80F2-1625377658F4")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IResponse
        {
            
            
            [DispId(0x60020004)]
            string RequestID
            {
                get;
            }
            
            [DispId(0x60020005)]
            ResponseType Type
            {
                get;
            }
        }

        internal  partial class Response
            : IResponse, 
              IWrapperBase
        {
            
            private fxcore2.O2GResponse mNetObj = null;
            
            private Session mSession;
            internal Response(fxcore2.O2GResponse netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GResponse NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string RequestID
            {
                get
                {
                string result = mNetObj.RequestID;
                
                return result;
                }
                
            }
            public ResponseType Type
            {
                get
                {
                ResponseType result = (ResponseType)(int)mNetObj.Type;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("30BD4301-192D-4cdc-B636-E22F08ED33A4")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IResponseReaderFactory
        {
            
            ITablesUpdatesReader createTablesUpdatesReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IOfferTableReader createOffersTableReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IAccountTableReader createAccountsTableReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IOrderTableReader createOrdersTableReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            ITradeTableReader createTradesTableReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IClosedTableReader createClosedTradesTableReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IMessageTableReader createMessagesTableReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IMarketDataSnapshotResponseReader createMarketDataSnapshotReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            IOrderResponseReader createOrderResponseReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            ISystemPropertiesReader createSystemPropertiesReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            bool processMarginRequirementsResponse([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
            ILastOrderUpdateResponseReader createLastOrderUpdateResponseReader([MarshalAs(UnmanagedType.IDispatch)]IResponse paramResponseObj);
        }

        internal  partial class ResponseReaderFactory
            : IResponseReaderFactory, 
              IWrapperBase
        {
            
            private fxcore2.O2GResponseReaderFactory mNetObj = null;
            
            private Session mSession;
            internal ResponseReaderFactory(fxcore2.O2GResponseReaderFactory netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GResponseReaderFactory NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public ITablesUpdatesReader createTablesUpdatesReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    ITablesUpdatesReader result = (ITablesUpdatesReader)Utils.CheckWrapperForNativeNull(new TablesUpdatesReader(mNetObj.createTablesUpdatesReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IOfferTableReader createOffersTableReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IOfferTableReader result = (IOfferTableReader)Utils.CheckWrapperForNativeNull(new OfferTableReader(mNetObj.createOffersTableReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IAccountTableReader createAccountsTableReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IAccountTableReader result = (IAccountTableReader)Utils.CheckWrapperForNativeNull(new AccountTableReader(mNetObj.createAccountsTableReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IOrderTableReader createOrdersTableReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IOrderTableReader result = (IOrderTableReader)Utils.CheckWrapperForNativeNull(new OrderTableReader(mNetObj.createOrdersTableReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public ITradeTableReader createTradesTableReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    ITradeTableReader result = (ITradeTableReader)Utils.CheckWrapperForNativeNull(new TradeTableReader(mNetObj.createTradesTableReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IClosedTableReader createClosedTradesTableReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IClosedTableReader result = (IClosedTableReader)Utils.CheckWrapperForNativeNull(new ClosedTableReader(mNetObj.createClosedTradesTableReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IMessageTableReader createMessagesTableReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IMessageTableReader result = (IMessageTableReader)Utils.CheckWrapperForNativeNull(new MessageTableReader(mNetObj.createMessagesTableReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IMarketDataSnapshotResponseReader createMarketDataSnapshotReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IMarketDataSnapshotResponseReader result = (IMarketDataSnapshotResponseReader)Utils.CheckWrapperForNativeNull(new MarketDataSnapshotResponseReader(mNetObj.createMarketDataSnapshotReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public IOrderResponseReader createOrderResponseReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    IOrderResponseReader result = (IOrderResponseReader)Utils.CheckWrapperForNativeNull(new OrderResponseReader(mNetObj.createOrderResponseReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public ISystemPropertiesReader createSystemPropertiesReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    ISystemPropertiesReader result = (ISystemPropertiesReader)Utils.CheckWrapperForNativeNull(new SystemPropertiesReader(mNetObj.createSystemPropertiesReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            public bool processMarginRequirementsResponse(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    bool result = mNetObj.processMarginRequirementsResponse( paramResponseNative );
                
                return result;
                }
                
            public ILastOrderUpdateResponseReader createLastOrderUpdateResponseReader(IResponse paramResponseObj)
                {
                fxcore2.O2GResponse paramResponseNative = (fxcore2.O2GResponse)((Response)paramResponseObj).NativeObject;
                    ILastOrderUpdateResponseReader result = (ILastOrderUpdateResponseReader)Utils.CheckWrapperForNativeNull(new LastOrderUpdateResponseReader(mNetObj.createLastOrderUpdateResponseReader( paramResponseNative ) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("20072AAD-F7BB-4d10-9F0B-70B27A54D791")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ILastOrderUpdateResponseReader
        {
            
            IOrderRow Order
            {
                get;
            }
            TableUpdateType UpdateType
            {
                get;
            }
        }

        internal  partial class LastOrderUpdateResponseReader
            : ILastOrderUpdateResponseReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GLastOrderUpdateResponseReader mNetObj = null;
            
            private Session mSession;
            internal LastOrderUpdateResponseReader(fxcore2.O2GLastOrderUpdateResponseReader netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GLastOrderUpdateResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public IOrderRow Order
            {
                get
                {
                IOrderRow result = (IOrderRow)Utils.CheckWrapperForNativeNull(new OrderRow(mNetObj.Order , mSession));
                
                return result;
                }
                
            }
            public TableUpdateType UpdateType
            {
                get
                {
                TableUpdateType result = (TableUpdateType)(int)mNetObj.UpdateType;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("5071EA8F-373D-4837-8464-FCF5855E4D80")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOrderResponseReader
        {
            
            string OrderID
            {
                get;
            }
            bool isUnderDealerIntervention();
        }

        internal  partial class OrderResponseReader
            : IOrderResponseReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GOrderResponseReader mNetObj = null;
            
            private Session mSession;
            internal OrderResponseReader(fxcore2.O2GOrderResponseReader netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GOrderResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public string OrderID
            {
                get
                {
                string result = mNetObj.OrderID;
                
                return result;
                }
                
            }
            public bool isUnderDealerIntervention()
                {
                bool result = mNetObj.isUnderDealerIntervention();
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("1379DE44-5632-4579-A597-C90ADE27B841")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITablesUpdatesReader
        {
            
            int Count
            {
                get;
            }
            DateTime ServerTime
            {
                get;
            }
            TableUpdateType getUpdateType(int paramIndex);
            TableType getUpdateTable(int paramIndex);
            IOfferRow getOfferRow(int paramIndex);
            IAccountRow getAccountRow(int paramIndex);
            IOrderRow getOrderRow(int paramIndex);
            ITradeRow getTradeRow(int paramIndex);
            IClosedTradeRow getClosedTradeRow(int paramIndex);
            IMessageRow getMessageRow(int paramIndex);
        }

        internal  partial class TablesUpdatesReader
            : ITablesUpdatesReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GTablesUpdatesReader mNetObj = null;
            
            private Session mSession;
            internal TablesUpdatesReader(fxcore2.O2GTablesUpdatesReader netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GTablesUpdatesReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            public DateTime ServerTime
            {
                get
                {
                DateTime result = mNetObj.ServerTime;
                
                return result;
                }
                
            }
            public TableUpdateType getUpdateType(int paramIndex)
                {
                TableUpdateType result = (TableUpdateType)(int)mNetObj.getUpdateType( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public TableType getUpdateTable(int paramIndex)
                {
                TableType result = (TableType)(int)mNetObj.getUpdateTable( 
                                    (int)
                                        paramIndex);
                
                return result;
                }
                
            public IOfferRow getOfferRow(int paramIndex)
                {
                IOfferRow result = (IOfferRow)Utils.CheckWrapperForNativeNull(new OfferRow(mNetObj.getOfferRow( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            public IAccountRow getAccountRow(int paramIndex)
                {
                IAccountRow result = (IAccountRow)Utils.CheckWrapperForNativeNull(new AccountRow(mNetObj.getAccountRow( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            public IOrderRow getOrderRow(int paramIndex)
                {
                IOrderRow result = (IOrderRow)Utils.CheckWrapperForNativeNull(new OrderRow(mNetObj.getOrderRow( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            public ITradeRow getTradeRow(int paramIndex)
                {
                ITradeRow result = (ITradeRow)Utils.CheckWrapperForNativeNull(new TradeRow(mNetObj.getTradeRow( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            public IClosedTradeRow getClosedTradeRow(int paramIndex)
                {
                IClosedTradeRow result = (IClosedTradeRow)Utils.CheckWrapperForNativeNull(new ClosedTradeRow(mNetObj.getClosedTradeRow( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            public IMessageRow getMessageRow(int paramIndex)
                {
                IMessageRow result = (IMessageRow)Utils.CheckWrapperForNativeNull(new MessageRow(mNetObj.getMessageRow( 
                                    (int)
                                        paramIndex) , mSession));
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("E203E1D6-0804-4de6-9A55-C44BEBDC3A84")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IGenericTableResponseReader
        {
            
            
            [DispId(0x60040601)]
            int Count
            {
                get;
            }
            
            [DispId(0x60040602)]
            TableType Type
            {
                get;
            }
            
            [DispId(0x60040603)]
            ITableColumnCollection Columns
            {
                get;
            }
            
            [DispId(0x60040604)]
            object getCell(int paramRow, int paramColumn);
            
            [DispId(0x60040605)]
            bool isCellValid(int paramRow, int paramColumn);
            
            [DispId(0x60040606)]
            
            [return: MarshalAs(UnmanagedType.IDispatch)]
            object getGenericRow(int paramRow);
        }

        
        [ComVisible(true)]
        [Guid("DEAD3D84-C263-4eaf-95EE-77493E2718C9")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IGenericTableResponseReader))]
        public  partial class GenericTableResponseReader
            : IGenericTableResponseReader, 
              IWrapperBase
        {
            
            private fxcore2.O2GGenericTableResponseReader mNetObj = null;
            
            private Session mSession;
            internal GenericTableResponseReader(fxcore2.O2GGenericTableResponseReader netObj, Session session)
            
            {
                
                        mSession = session;
                    
                    mNetObj = netObj;
                
            }

            object IWrapperBase.NativeObj
            {
                get { return mNetObj; }
            }

            
            internal   fxcore2.O2GGenericTableResponseReader NativeObject
            {
                get { return mNetObj;}
            }
            
            
            
            public int Count
            {
                get
                {
                int result = mNetObj.Count;
                
                return result;
                }
                
            }
            public TableType Type
            {
                get
                {
                TableType result = (TableType)(int)mNetObj.Type;
                
                return result;
                }
                
            }
            public ITableColumnCollection Columns
            {
                get
                {
                ITableColumnCollection result = (ITableColumnCollection)Utils.CheckWrapperForNativeNull(new TableColumnCollection(mNetObj.Columns , mSession));
                
                return result;
                }
                
            }
            public object getCell(int paramRow, int paramColumn)
                {
                object result = mNetObj.getCell( 
                                    (int)
                                        paramRow,  
                                    (int)
                                        paramColumn);
                
                return result;
                }
                
            public bool isCellValid(int paramRow, int paramColumn)
                {
                bool result = mNetObj.isCellValid( 
                                    (int)
                                        paramRow,  
                                    (int)
                                        paramColumn);
                
                return result;
                }
                
            
        }
    
        [ComVisible(true)]
        [Guid("C14256DF-EB56-47cb-BEBC-A755F6FE57F6")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IConstants
        {
            
            string Buy
            {
                get;
            }
            string Sell
            {
                get;
            }
            int INIFINITE_NUMBER_OF_RECONNECTIONS
            {
                get;
            }
            ICommands Commands
            {
                get;
            }
            IOrders Orders
            {
                get;
            }
            IPeg Peg
            {
                get;
            }
            ISystemProperties SystemProperties
            {
                get;
            }
            ITIF TIF
            {
                get;
            }
            IKeyType KeyType
            {
                get;
            }
        }

        
        [ComVisible(true)]
        [Guid("5801F1F1-1B47-4384-A4AA-50461C7C59B6")]
        [ClassInterface(ClassInterfaceType.None)]
        [ComDefaultInterface(typeof(IConstants))]
        public  partial class Constants
            : IConstants, 
              IWrapperBase
        {
            
            private Session mSession;
            internal Constants(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants NativeObject
            {
                get { return null;}
            }
            
            
            
            public string Buy
            {
                get
                {
                string result = 
                        fxcore2.Constants.Buy;
                
                return result;
                }
                
            }
            public string Sell
            {
                get
                {
                string result = 
                        fxcore2.Constants.Sell;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("44C8FA88-7838-491d-AEF3-BBABE97EDB2B")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ICommands
        {
            
            string CreateOCO
            {
                get;
            }
            string CreateOrder
            {
                get;
            }
            string CreateOTO
            {
                get;
            }
            string DeleteOrder
            {
                get;
            }
            string EditOrder
            {
                get;
            }
            string GetLastOrderUpdate
            {
                get;
            }
            string JoinToExistingContingencyGroup
            {
                get;
            }
            string JoinToNewContingencyGroup
            {
                get;
            }
            string RemoveFromContingencyGroup
            {
                get;
            }
            string SetSubscriptionStatus
            {
                get;
            }
            string UpdateMarginRequirements
            {
                get;
            }
            string UpdateCommissions
            {
                get;
            }
        }

        internal  partial class Commands
            : ICommands, 
              IWrapperBase
        {
            
            private Session mSession;
            internal Commands(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants.Commands NativeObject
            {
                get { return null;}
            }
            
            
            
            public string CreateOCO
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.CreateOCO;
                
                return result;
                }
                
            }
            public string CreateOrder
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.CreateOrder;
                
                return result;
                }
                
            }
            public string CreateOTO
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.CreateOTO;
                
                return result;
                }
                
            }
            public string DeleteOrder
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.DeleteOrder;
                
                return result;
                }
                
            }
            public string EditOrder
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.EditOrder;
                
                return result;
                }
                
            }
            public string GetLastOrderUpdate
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.GetLastOrderUpdate;
                
                return result;
                }
                
            }
            public string JoinToExistingContingencyGroup
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.JoinToExistingContingencyGroup;
                
                return result;
                }
                
            }
            public string JoinToNewContingencyGroup
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.JoinToNewContingencyGroup;
                
                return result;
                }
                
            }
            public string RemoveFromContingencyGroup
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.RemoveFromContingencyGroup;
                
                return result;
                }
                
            }
            public string SetSubscriptionStatus
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.SetSubscriptionStatus;
                
                return result;
                }
                
            }
            public string UpdateMarginRequirements
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.UpdateMarginRequirements;
                
                return result;
                }
                
            }
            public string UpdateCommissions
            {
                get
                {
                string result = 
                        fxcore2.Constants.Commands.UpdateCommissions;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("2F249CB9-87FA-4b74-A1C2-E21D23A23531")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IKeyType
        {
            
            string OrderID
            {
                get;
            }
            string RequestID
            {
                get;
            }
            string RequestTXT
            {
                get;
            }
        }

        internal  partial class KeyType
            : IKeyType, 
              IWrapperBase
        {
            
            private Session mSession;
            internal KeyType(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants.KeyType NativeObject
            {
                get { return null;}
            }
            
            
            
            public string OrderID
            {
                get
                {
                string result = 
                        fxcore2.Constants.KeyType.OrderID;
                
                return result;
                }
                
            }
            public string RequestID
            {
                get
                {
                string result = 
                        fxcore2.Constants.KeyType.RequestID;
                
                return result;
                }
                
            }
            public string RequestTXT
            {
                get
                {
                string result = 
                        fxcore2.Constants.KeyType.RequestTXT;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("0AE92085-211A-4023-97C9-B8D82C576122")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IOrders
        {
            
            string MarketCloseRange
            {
                get;
            }
            string Entry
            {
                get;
            }
            string Limit
            {
                get;
            }
            string OpenLimit
            {
                get;
            }
            string CloseLimit
            {
                get;
            }
            string LimitEntry
            {
                get;
            }
            string MarketClose
            {
                get;
            }
            string MarketOpen
            {
                get;
            }
            string MarketOpenRange
            {
                get;
            }
            string Stop
            {
                get;
            }
            string StopEntry
            {
                get;
            }
            string TrueMarketClose
            {
                get;
            }
            string TrueMarketOpen
            {
                get;
            }
        }

        internal  partial class Orders
            : IOrders, 
              IWrapperBase
        {
            
            private Session mSession;
            internal Orders(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants.Orders NativeObject
            {
                get { return null;}
            }
            
            
            
            public string MarketCloseRange
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.MarketCloseRange;
                
                return result;
                }
                
            }
            public string Entry
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.Entry;
                
                return result;
                }
                
            }
            public string Limit
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.Limit;
                
                return result;
                }
                
            }
            public string OpenLimit
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.OpenLimit;
                
                return result;
                }
                
            }
            public string CloseLimit
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.CloseLimit;
                
                return result;
                }
                
            }
            public string LimitEntry
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.LimitEntry;
                
                return result;
                }
                
            }
            public string MarketClose
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.MarketClose;
                
                return result;
                }
                
            }
            public string MarketOpen
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.MarketOpen;
                
                return result;
                }
                
            }
            public string MarketOpenRange
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.MarketOpenRange;
                
                return result;
                }
                
            }
            public string Stop
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.Stop;
                
                return result;
                }
                
            }
            public string StopEntry
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.StopEntry;
                
                return result;
                }
                
            }
            public string TrueMarketClose
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.TrueMarketClose;
                
                return result;
                }
                
            }
            public string TrueMarketOpen
            {
                get
                {
                string result = 
                        fxcore2.Constants.Orders.TrueMarketOpen;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("F24E1E46-C387-443a-A404-5FFD298D0C2E")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface IPeg
        {
            
            string FromClose
            {
                get;
            }
            string FromOpen
            {
                get;
            }
        }

        internal  partial class Peg
            : IPeg, 
              IWrapperBase
        {
            
            private Session mSession;
            internal Peg(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants.Peg NativeObject
            {
                get { return null;}
            }
            
            
            
            public string FromClose
            {
                get
                {
                string result = 
                        fxcore2.Constants.Peg.FromClose;
                
                return result;
                }
                
            }
            public string FromOpen
            {
                get
                {
                string result = 
                        fxcore2.Constants.Peg.FromOpen;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("B6FCFFBD-5BFE-40da-8FFF-15C3C0D0AA77")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ISystemProperties
        {
            
            string BASE_CRNCY
            {
                get;
            }
            string BASE_UNIT_SIZE
            {
                get;
            }
            string BASE_CRNCY_PRECISION
            {
                get;
            }
            string BASE_CRNCY_SYMBOL
            {
                get;
            }
            string BASE_TIME_ZONE
            {
                get;
            }
            string COND_DIST
            {
                get;
            }
            string COND_DIST_ENTRY
            {
                get;
            }
            string CP_170
            {
                get;
            }
            string CP_171
            {
                get;
            }
            string CP_172
            {
                get;
            }
            string CP_86
            {
                get;
            }
            string CP_88
            {
                get;
            }
            string CP_89
            {
                get;
            }
            string CP_94
            {
                get;
            }
            string END_TRADING_DAY
            {
                get;
            }
            string FORCE_PASSWORD_CHANGE
            {
                get;
            }
            string MARKET_OPEN
            {
                get;
            }
            string PEGGED_STOP_LIMIT_DISABLED
            {
                get;
            }
            string QUERYDEPTH_0
            {
                get;
            }
            string QUERYDEPTH_1
            {
                get;
            }
            string QUERYDEPTH_2
            {
                get;
            }
            string QUERYDEPTH_3
            {
                get;
            }
            string QUERYDEPTH_4
            {
                get;
            }
            string QUERYDEPTH_5
            {
                get;
            }
            string QUERYDEPTH_6
            {
                get;
            }
            string QUERYDEPTH_7
            {
                get;
            }
            string QUERYDEPTH_8
            {
                get;
            }
            string QUERYDEPTH_h2
            {
                get;
            }
            string QUERYDEPTH_h3
            {
                get;
            }
            string QUERYDEPTH_h4
            {
                get;
            }
            string QUERYDEPTH_h6
            {
                get;
            }
            string QUERYDEPTH_h8
            {
                get;
            }
            string SERVER_TIME_UTC
            {
                get;
            }
            string SupportTickVolume
            {
                get;
            }
            string TP_170
            {
                get;
            }
            string TP_171
            {
                get;
            }
            string TP_172
            {
                get;
            }
            string TP_86
            {
                get;
            }
            string TP_88
            {
                get;
            }
            string TP_89
            {
                get;
            }
            string TP_94
            {
                get;
            }
            string TRAILING_DYNAMIC
            {
                get;
            }
            string TRAILING_FLUCTUATE
            {
                get;
            }
            string TRAILING_FLUCTUATE_PTS_MAX
            {
                get;
            }
            string TRAILING_FLUCTUATE_PTS_MIN
            {
                get;
            }
            string FIRST_TICK_OPEN_PRICE_ENABLED
            {
                get;
            }
        }

        internal  partial class SystemProperties
            : ISystemProperties, 
              IWrapperBase
        {
            
            private Session mSession;
            internal SystemProperties(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants.SystemProperties NativeObject
            {
                get { return null;}
            }
            
            
            
            public string BASE_CRNCY
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.BASE_CRNCY;
                
                return result;
                }
                
            }
            public string BASE_UNIT_SIZE
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.BASE_UNIT_SIZE;
                
                return result;
                }
                
            }
            public string BASE_CRNCY_PRECISION
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.BASE_CRNCY_PRECISION;
                
                return result;
                }
                
            }
            public string BASE_CRNCY_SYMBOL
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.BASE_CRNCY_SYMBOL;
                
                return result;
                }
                
            }
            public string BASE_TIME_ZONE
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.BASE_TIME_ZONE;
                
                return result;
                }
                
            }
            public string COND_DIST
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.COND_DIST;
                
                return result;
                }
                
            }
            public string COND_DIST_ENTRY
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.COND_DIST_ENTRY;
                
                return result;
                }
                
            }
            public string CP_170
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_170;
                
                return result;
                }
                
            }
            public string CP_171
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_171;
                
                return result;
                }
                
            }
            public string CP_172
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_172;
                
                return result;
                }
                
            }
            public string CP_86
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_86;
                
                return result;
                }
                
            }
            public string CP_88
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_88;
                
                return result;
                }
                
            }
            public string CP_89
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_89;
                
                return result;
                }
                
            }
            public string CP_94
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.CP_94;
                
                return result;
                }
                
            }
            public string END_TRADING_DAY
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.END_TRADING_DAY;
                
                return result;
                }
                
            }
            public string FORCE_PASSWORD_CHANGE
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.FORCE_PASSWORD_CHANGE;
                
                return result;
                }
                
            }
            public string MARKET_OPEN
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.MARKET_OPEN;
                
                return result;
                }
                
            }
            public string PEGGED_STOP_LIMIT_DISABLED
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.PEGGED_STOP_LIMIT_DISABLED;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_0
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_0;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_1
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_1;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_2
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_2;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_3
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_3;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_4
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_4;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_5
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_5;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_6
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_6;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_7
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_7;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_8
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_8;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_h2
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_h2;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_h3
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_h3;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_h4
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_h4;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_h6
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_h6;
                
                return result;
                }
                
            }
            public string QUERYDEPTH_h8
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.QUERYDEPTH_h8;
                
                return result;
                }
                
            }
            public string SERVER_TIME_UTC
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.SERVER_TIME_UTC;
                
                return result;
                }
                
            }
            public string SupportTickVolume
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.SupportTickVolume;
                
                return result;
                }
                
            }
            public string TP_170
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_170;
                
                return result;
                }
                
            }
            public string TP_171
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_171;
                
                return result;
                }
                
            }
            public string TP_172
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_172;
                
                return result;
                }
                
            }
            public string TP_86
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_86;
                
                return result;
                }
                
            }
            public string TP_88
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_88;
                
                return result;
                }
                
            }
            public string TP_89
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_89;
                
                return result;
                }
                
            }
            public string TP_94
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TP_94;
                
                return result;
                }
                
            }
            public string TRAILING_DYNAMIC
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TRAILING_DYNAMIC;
                
                return result;
                }
                
            }
            public string TRAILING_FLUCTUATE
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TRAILING_FLUCTUATE;
                
                return result;
                }
                
            }
            public string TRAILING_FLUCTUATE_PTS_MAX
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TRAILING_FLUCTUATE_PTS_MAX;
                
                return result;
                }
                
            }
            public string TRAILING_FLUCTUATE_PTS_MIN
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.TRAILING_FLUCTUATE_PTS_MIN;
                
                return result;
                }
                
            }
            public string FIRST_TICK_OPEN_PRICE_ENABLED
            {
                get
                {
                string result = 
                        fxcore2.Constants.SystemProperties.FIRST_TICK_OPEN_PRICE_ENABLED;
                
                return result;
                }
                
            }
            
        }
    
        [ComVisible(true)]
        [Guid("D162C667-46DC-4879-AEF8-952E9ABE3C9A")]
        [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
        public partial interface ITIF
        {
            
            string DAY
            {
                get;
            }
            string FOK
            {
                get;
            }
            string GTC
            {
                get;
            }
            string IOC
            {
                get;
            }
            string GTD
            {
                get;
            }
        }

        internal  partial class TIF
            : ITIF, 
              IWrapperBase
        {
            
            private Session mSession;
            internal TIF(Session session)
            
            {
                
                        mSession = session;
                    
            }

            object IWrapperBase.NativeObj
            {
                get { return null; }
            }

            
            internal   fxcore2.Constants.TIF NativeObject
            {
                get { return null;}
            }
            
            
            
            public string DAY
            {
                get
                {
                string result = 
                        fxcore2.Constants.TIF.DAY;
                
                return result;
                }
                
            }
            public string FOK
            {
                get
                {
                string result = 
                        fxcore2.Constants.TIF.FOK;
                
                return result;
                }
                
            }
            public string GTC
            {
                get
                {
                string result = 
                        fxcore2.Constants.TIF.GTC;
                
                return result;
                }
                
            }
            public string IOC
            {
                get
                {
                string result = 
                        fxcore2.Constants.TIF.IOC;
                
                return result;
                }
                
            }
            public string GTD
            {
                get
                {
                string result = 
                        fxcore2.Constants.TIF.GTD;
                
                return result;
                }
                
            }
            
        }
    
}
    