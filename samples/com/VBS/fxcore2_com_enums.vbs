'RequestParamsEnum enum
const RequestParamsEnum_Command = 1
const RequestParamsEnum_AccountID = 2
const RequestParamsEnum_OfferID = 3
const RequestParamsEnum_TradeID = 4
const RequestParamsEnum_BuySell = 5
const RequestParamsEnum_Amount = 6
const RequestParamsEnum_Rate = 7
const RequestParamsEnum_RateStop = 8
const RequestParamsEnum_RateLimit = 9
const RequestParamsEnum_TrailStepStop = 10
const RequestParamsEnum_TrailStep = 11
const RequestParamsEnum_TimeInForce = 12
const RequestParamsEnum_CustomID = 13
const RequestParamsEnum_OrderID = 14
const RequestParamsEnum_PegOffsetStop = 15
const RequestParamsEnum_PegOffsetLimit = 16
const RequestParamsEnum_PegTypeStop = 17
const RequestParamsEnum_PegTypeLimit = 18
const RequestParamsEnum_PegOffset = 19
const RequestParamsEnum_PegType = 20
const RequestParamsEnum_NetQuantity = 21
const RequestParamsEnum_OrderType = 22
const RequestParamsEnum_RateMin = 23
const RequestParamsEnum_RateMax = 24
const RequestParamsEnum_ContingencyID = 25
const RequestParamsEnum_SubscriptionStatus = 26
const RequestParamsEnum_ClientRate = 27
const RequestParamsEnum_ContingencyGroupType = 28
const RequestParamsEnum_PrimaryQID = 29
const RequestParamsEnum_AccountName = 30
const RequestParamsEnum_Key = 31
const RequestParamsEnum_Id = 32
const RequestParamsEnum_Symbol = 38
const RequestParamsEnum_ExpireDateTime = 82
const RequestParamsEnum_UnknownParam = -1

'TimeframeUnit enum
const TimeframeUnit_Tick = 0
const TimeframeUnit_Min = 1
const TimeframeUnit_Hour = 2
const TimeframeUnit_Day = 3
const TimeframeUnit_Week = 4
const TimeframeUnit_Month = 5
const TimeframeUnit_Year = 6

'TimeConverterTimeZone enum
const TimeConverterTimeZone_UTC = 0
const TimeConverterTimeZone_Local = 1
const TimeConverterTimeZone_EST = 2
const TimeConverterTimeZone_Server = 3

'PermissionStatus enum
const PermissionStatus_PermissionDisabled = 0
const PermissionStatus_PermissionEnabled = 1
const PermissionStatus_PermissionHidden = -2

'MarketStatus enum
const MarketStatus_MarketStatusOpen = 0
const MarketStatus_MarketStatusClosed = 1

'PriceUpdateMode enum
const PriceUpdateMode_Default = 0
const PriceUpdateMode_NoPrice = 1

'TableManagerMode enum
const TableManagerMode_No = 0
const TableManagerMode_Yes = 1

'TableManagerStatus enum
const TableManagerStatus_TablesLoading = 0
const TableManagerStatus_TablesLoaded = 1
const TableManagerStatus_TablesLoadFailed = 2

'ResponseType enum
const ResponseType_MarketDataSnapshot = 1
const ResponseType_GetAccounts = 2
const ResponseType_GetOffers = 3
const ResponseType_GetOrders = 4
const ResponseType_GetTrades = 5
const ResponseType_GetClosedTrades = 6
const ResponseType_GetMessages = 7
const ResponseType_CreateOrderResponse = 8
const ResponseType_GetSystemProperties = 9
const ResponseType_CommandResponse = 10
const ResponseType_MarginRequirementsResponse = 11
const ResponseType_GetLastOrderUpdate = 12
const ResponseType_ResponseUnknown = -1

'TableColumnType enum
const TableColumnType_Integer = 0
const TableColumnType_Double = 1
const TableColumnType_String = 2
const TableColumnType_Date = 3
const TableColumnType_Boolean = 4

'TableType enum
const TableType_Offers = 0
const TableType_Accounts = 1
const TableType_Orders = 2
const TableType_Trades = 3
const TableType_ClosedTrades = 4
const TableType_Messages = 5
const TableType_Summary = 6
const TableType_TableUnknown = -1

'TableUpdateType enum
const TableUpdateType_Insert = 0
const TableUpdateType_Update = 1
const TableUpdateType_Delete = 2
const TableUpdateType_UpdateUnknown = -1

'SessionStatusCode enum
const SessionStatusCode_Disconnected = 0
const SessionStatusCode_Connecting = 1
const SessionStatusCode_TradingSessionRequested = 2
const SessionStatusCode_Connected = 3
const SessionStatusCode_Reconnecting = 4
const SessionStatusCode_Disconnecting = 5
const SessionStatusCode_SessionLost = 6
const SessionStatusCode_PriceSessionReconnecting = 7
const SessionStatusCode_Unknown = 8

'ChartSessionStatusCode enum
const ChartSessionStatusCode_Disconnected = 0
const ChartSessionStatusCode_Connecting = 1
const ChartSessionStatusCode_Connected = 3
const ChartSessionStatusCode_Reconnecting = 4
const ChartSessionStatusCode_Disconnecting = 5
const ChartSessionStatusCode_SessionLost = 6
const ChartSessionStatusCode_Unknown = 7

'TableStatus enum
const TableStatus_Initial = 0
const TableStatus_Refreshing = 1
const TableStatus_Refreshed = 2
const TableStatus_Failed = 3

'RelationalOperators enum
const RelationalOperators_EqualTo = 0
const RelationalOperators_NotEqualTo = 1
const RelationalOperators_GreaterThan = 2
const RelationalOperators_LessThan = 3
const RelationalOperators_GreaterThanOrEqualTo = 4
const RelationalOperators_LessThanOrEqualTo = 5
const RelationalOperators_Between = -1

'LogicOperators enum
const LogicOperators_And = 0
const LogicOperators_Or = 1

'UpdatesProcessStatus enum
const UpdatesProcessStatus_BeginTablesUpdate = 0
const UpdatesProcessStatus_EndTablesUpdate = 1
const UpdatesProcessStatus_UnknownProcessStatus = -1

'CandleOpenPriceMode enum
const CandleOpenPriceMode_PreviousClose = 0
const CandleOpenPriceMode_FirstTick = 1

'O2GTableEventsFilter enum
const O2GTableEventsFilter_AllEvents = 0
const O2GTableEventsFilter_ServerOnly = 1

'ChartSessionMode enum
const ChartSessionMode_NoChartSession = 0
const ChartSessionMode_Attached = 1
const ChartSessionMode_Detached = 2

'CommissionStage enum
const CommissionStage_OpenCommission = 0
const CommissionStage_CloseCommission = 1
const CommissionStage_AnyDealCommission = 2
const CommissionStage_CommissionStageUnknown = -1

'CommissionUnitType enum
const CommissionUnitType_CommissionPerLot = 0
const CommissionUnitType_CommissionPerLotConv = 1
const CommissionUnitType_CommissionPerTrade = 2
const CommissionUnitType_CommissionPerOrder = 3
const CommissionUnitType_CommissionPerOrderConv = 4
const CommissionUnitType_CommissionPerBasisPoints = 5
const CommissionUnitType_CommissionTypeUnknown = -1

'O2GCommissionStatus enum
const O2GCommissionStatus_CommissionStatusDisabled = 0
const O2GCommissionStatus_CommissionStatusLoading = 1
const O2GCommissionStatus_CommissionStatusReady = 2
const O2GCommissionStatus_CommissionStatusFailToLoad = 3

