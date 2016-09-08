'load constants file
set fso = createObject("Scripting.FileSystemObject")
set oFile = fso.OpenTextFile("fxcore2_com_enums.vbs", 1)
sConstants = oFile.ReadAll
oFile.close
ExecuteGlobal sConstants

username = ""
password = ""
instrument = ""

If WScript.Arguments.Count = 3 Then 'read from command line arguments
    username = WScript.Arguments.Item(0)
    password = WScript.Arguments.Item(1)
    instrument = WScript.Arguments.Item(2)
End If 

If username = "" Or password = "" Or instrument = "" Then
    WScript.Echo "Please provide username, password and instrument"
    WScript.Quit 
End If

LastStatus = ""
LastError = ""
bTablesLoaded = false
mRequestID = ""
mOrderCompleted = false
mOrderExecuted = false


WScript.Echo "Close all orders using Table manager"
Set transport = CreateObject("fxcore2.com.Transport")
Set constants = CreateObject("fxcore2.com.Constants")

'create session
Set session = transport.createSession()
WScript.ConnectObject session, "session_"

WScript.Echo "Log in..."
session.useTableManager TableManagerMode_Yes, Nothing
Call session.login(username, password, "http://www.fxcorporate.com/Hosts.jsp", "Demo")

While LastStatus <> SessionStatusCode_Connected and LastError = ""
    WScript.Sleep 50
Wend

If (LastStatus = SessionStatusCode_Connected) Then
    Dim tableManager    
    Set tableManager = session.getTableManager()
    'Waiting loading of tables
    While not bTablesLoaded and LastError = ""
        WScript.Sleep 50
    Wend
    
    If bTablesLoaded Then        
        Dim accounts, iter, offers, orders, summaries, account, offer, order, summary
        Set accounts = tableManager.getTable(TableType_Accounts)         
        Set offers = tableManager.getTable(TableType_Offers)        
        Set orders = tableManager.getTable(TableType_Orders)        
        Set summaries = tableManager.getTable(TableType_Summary)        
        WScript.ConnectObject orders, "orders_"
        
        'prepare all necessary data to create order
        Dim reqFactory, accountId, offerId
        Set account = accounts.getRow(0) 'the first account for example
        accountId = account.AccountID 
        WScript.Echo "Using account: " & accountId
        
        Set reqFactory = session.getRequestFactory()
        Set iter = offers.createTableIterator()
        
        If offers.getNextRowByColumnValue("Instrument", instrument, iter, offer) Then
            offerId = offer.OfferID
            
            Set iter = summaries.createTableIterator()            
            If summaries.getNextRowByColumnValue("Instrument", instrument, iter, summary) Then                                
                'Close true market order
                Set reqFactory = session.getRequestFactory()
                
                Dim valuemap
                Set valuemap = reqFactory.createValueMap()
                call valuemap.setString(RequestParamsEnum_Command, constants.Commands.CreateOrder)
                call valuemap.setString(RequestParamsEnum_AccountID, accountId)
                call valuemap.setString(RequestParamsEnum_NetQuantity, "Y")
                call valuemap.setString(RequestParamsEnum_OfferID, offerId)
                
                'BuySell must be opposite side for opened positions
                If summary.BuyAmount>0 Then
                    call valuemap.setString(RequestParamsEnum_BuySell, constants.Sell) 
                Else
                    call valuemap.setString(RequestParamsEnum_BuySell, constants.Buy) 
                End If
                call valuemap.setString(RequestParamsEnum_OrderType, constants.Orders.TrueMarketClose)
                Set req = reqFactory.createOrderRequest(valuemap)
                
                WScript.Echo "Request: " & constants.Commands.CreateOrder & ", orderType:" & constants.Orders.TrueMarketClose & ", accountID:"  & accountId & ", BuySell:" & constants.Buy & ", offerId:" & offerId
                
                mRequestId = req.RequestID
                mOrderCompleted =false
                mOrderId = ""
                call  session.SendRequest(req)        
                
                While not mOrderCompleted 
                    WScript.Sleep 250
                Wend
                        
                While not mOrderExecuted
                    WScript.Sleep 250
                Wend
                
            else
                WScript.Echo "There are no opened positions for " & instrument & " instrument!"            
            End if        
            
        else
            WScript.Echo instrument & " instrument is not found!"            
        End if 
        
        
    End If
    'force logout
    WScript.Echo "Log out..."
    session.logout

    Do While (LastStatus <> SessionStatusCode_Disconnected)
        WScript.Sleep 50
    Loop    
End If

Set session = Nothing

WScript.Echo "Done !"

Sub session_SessionStatusChanged(status)
    WScript.Echo "Status changed: " + GetStatusName(status)
    LastStatus = status
End Sub

Sub session_LoginError(err)    
    WScript.Echo "Error occured: " + err    
    LastError = err
End Sub


Sub session_ManagerStatusChanged(status, tableManager)    
    WScript.Echo "Manager status changed: " + GetManagerStatusName(status)
    bTablesLoaded = (status=TableManagerStatus_TablesLoaded)
    if status = TableManagerStatus_TablesLoadFailed Then
        LastError = "Tables loading failed"
        WScript.Echo LastError
    End if
End Sub


Sub orders_Added(rowID, order)
    If order.RequestID = mRequestID Then
        WScript.Echo "Order added. OrderID:" & order.OrderID & ", OfferID:" & order.OfferID & ", Rate:" & order.Rate & ", Stage:" & order.Stage & ", Status:" & order.Status
        mOrderCompleted = true
    End If
End sub

Sub orders_Changed(rowID, order)
    If order.RequestID = mRequestID Then
        WScript.Echo "Order changed. OrderID:" & order.OrderID & ", OfferID:" & order.OfferID & ", Rate:" & order.Rate & ", Stage:" & order.Stage & ", Status:" & order.Status
    End If
End sub

Sub orders_Deleted(rowID, order)
    If order.RequestID = mRequestID Then
        WScript.Echo "Order deleted. OrderID:" & order.OrderID & ", OfferID:" & order.OfferID & ", Rate:" & order.Rate & ", Stage:" & order.Stage & ", Status:" & order.Status
        mOrderExecuted = true
    End If
End sub

Sub session_RequestFailed(requestId, err)
    if requestId=mRequestId then
        WScript.Echo "Order failed:" & err
        mOrderCompleted = true
    end if
End Sub

Sub session_RequestCompleted(requestId, response)
    if requestId=mRequestId then
        Dim readerFactory, orderResponseReader
        Set readerFactory = session.getResponseReaderFactory()
        Set orderResponseReader = readerFactory.createOrderResponseReader(response)
        mOrderId = orderResponseReader.OrderId
        WScript.Echo "Order request success:" & mOrderId
    end if
End Sub


Function GetManagerStatusName(status)
    Select case status
        case TableManagerStatus_TablesLoading
            GetManagerStatusName = "loading"
        case TableManagerStatus_TablesLoaded
            GetManagerStatusName = "loaded"
        case TableManagerStatus_TablesLoadFailed
            GetManagerStatusName = "load failed"
        case Else            
            GetManagerStatusName = CSTR(status)
    End Select
End Function

Function GetStatusName(status)
    Select case status
        case SessionStatusCode_Connected
            GetStatusName = "connected"
        case SessionStatusCode_Disconnected
            GetStatusName = "disconnected"
        case SessionStatusCode_Connecting
            GetStatusName = "connecting"
        case SessionStatusCode_TradingSessionRequested
            GetStatusName = "trading session requested"
        case SessionStatusCode_Disconnecting
            GetStatusName = "disconnecting"
        case SessionStatusCode_SessionLost
            GetStatusName = "session lost"
        case SessionStatusCode_PriceSessionReconnecting
            GetStatusName = "price session reconnecting"
        case SessionStatusCode_Unknown
            GetStatusName = "unknown"
        case else
            GetStatusName = CSTR(status)
    End Select
End Function
