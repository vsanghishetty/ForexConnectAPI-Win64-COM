'load constants file
set fso = createObject("Scripting.FileSystemObject")
set oFile = fso.OpenTextFile("fxcore2_com_enums.vbs", 1)
sConstants = oFile.ReadAll
oFile.close
ExecuteGlobal sConstants

username = ""
password = ""
If WScript.Arguments.Count = 2 Then 'read from command line arguments
    username = WScript.Arguments.Item(0)
    password = WScript.Arguments.Item(1)
End If 


If username = "" Or password = "" Then
    WScript.Echo "Please provide username and password to the appropriate variables"
    WScript.Quit 
End If

LastStatus = ""
LastError = ""
bTablesLoaded = false
bWaitUpdates = false


WScript.Echo "Manage offers using table manager"
Set core = CreateObject("fxcore2.com.Transport")

'create session
Set session = core.createSession()
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
        Dim offers, iter, offer
        Set offers = tableManager.getTable(TableType_Offers)         
        WScript.ConnectObject offers, "offers_"
        Dim sOffers
        sOffers = "Instruments and offers: " & CHR(10) & CHR(13)        
        Set iter = offers.createTableIterator()
        Do While offers.getNextRow(iter, offer)
            If offer.SubscriptionStatus <> "D" then
                sOffers = sOffers & offer.Instrument & " Bid:" & CSTR(offer.Bid) & ", Ask:" & CSTR(offer.Ask) & CHR(10) & CHR(13)
            End If
        Loop
        WScript.Echo sOffers

        bReaded = true

        WScript.Echo "Waiting offers updates..."
        bWaitUpdates = true
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

Sub offers_Changed(rowID, offer)
    If bWaitUpdates Then
        WScript.Echo offer.Instrument & " Bid:" & CSTR(offer.Bid) & ", Ask:" & CSTR(offer.Ask) & CHR(10) & CHR(13)
    End If
End sub

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
