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

Dim core
Dim session

WScript.Echo "Get history prices" 
Set core = CreateObject("fxcore2.com.Transport")

Set session = core.createSession()
call WScript.ConnectObject(session,"session_")

LastStatus = ""
LastError = ""

WScript.Echo "Log in..."
Call session.login(username, password, "http://www.fxcorporate.com/Hosts.jsp", "Demo")
While LastStatus <> SessionStatusCode_Connected and LastError = ""
    WScript.Sleep 50
Wend

If (LastStatus = SessionStatusCode_Connected) Then

    WScript.Echo "Create market snapshort for EUR/USD m1, last 10 bars"
    Dim fact 
    Set fact = session.getRequestFactory()

    Dim mds, tfs, tf
    Set tfs = fact.Timeframes 
    Set tf = tfs.getByID("m1")

    Set mds = fact.createMarketDataSnapshotRequestInstrument("EUR/USD", tf, 10)
    WScript.Echo "Sending request..."
    Call session.SendRequest(mds)

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

Sub session_RequestCompleted(requestID, response)
    Dim readerFactory, snapshotReader, offerRow
    Set readerFactory = session.getResponseReaderFactory()
    Set snapshotReader = readerFactory.createMarketDataSnapshotReader(response)
    Dim sSnapshot
    sSnapshot = ""
    For i = 0 to snapshotReader.Count - 1            
        sSnapshot = sSnapshot & snapshotReader.getDate(i) & " ask:" & snapshotReader.getAsk(i) & " bid:" & snapshotReader.getBid(i) & CHR(10) & CHR(13)
    Next
    WScript.Echo sSnapshot
End Sub

Sub session_RequestFailed(requestID, err)
    LastError = err
    WScript.Echo "Request failed: " & LastError
End Sub

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


