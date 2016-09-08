Option Explicit

Dim fso, file
Dim constants
Dim core, session
Dim username, password, url, connection, sessionId, pin
Dim lastError, lastStatus

'load constants file

Set fso = CreateObject("Scripting.FileSystemObject")
Set file = fso.OpenTextFile("fxcore2_com_enums.vbs", 1)
constants = file.ReadAll
file.Close
ExecuteGlobal constants

'create session

Set core = CreateObject("fxcore2.com.Transport")
Set session = core.createSession()
Call WScript.ConnectObject(session, "session_")

'get command line arguments

username = ""
password = ""
url = ""
connection = ""
sessionId = ""
pin = ""
If WScript.Arguments.Count < 4 Then
    WScript.Echo "Not Enough Parameters!"
    WScript.Echo "USAGE: [user ID] [password] [URL] [connection] [session ID (if needed)] [pin (if needed)]"
    WScript.Quit
End If
username = WScript.Arguments.Item(0)
password = WScript.Arguments.Item(1)
url = WScript.Arguments.Item(2)
connection = WScript.Arguments.Item(3)
If WScript.Arguments.Count > 4 Then
    sessionId = WScript.Arguments.Item(4)
End If
If WScript.Arguments.Count > 5 Then
    pin = WScript.Arguments.Item(5)
End If

'login

WScript.Echo "Log in..."
lastStatus = -1
lastError = ""
lastStatus = session.loginSync(username, password, url, connection, sessionId, pin, lastError)
If lastStatus <> SessionStatusCode_Connected Then
    WScript.Echo "Error occured: " & lastError
    WScript.Quit
End If
WScript.Echo "Logged in"

'create and send request

WScript.Echo "Create market snapshot for EUR/USD m1, last 10 bars"

Dim factory, timeframe, snapshotRequest, response
Set factory = session.getRequestFactory()
Set timeframe = factory.Timeframes.getByID("m1")
Set snapshotRequest = factory.createMarketDataSnapshotRequestInstrument("EUR/USD", timeframe, 10)
WScript.Echo "Send request..."
Set response = session.sendRequestSync(snapshotRequest, lastError)
If Not response Is Nothing Then
    Call PrintHistoryData(response)
Else
    If lastError <> "" Then
        WScript.Echo "Request failed: " & lastError
    End If
End If

WScript.Echo "Press Ok to logout"

'logout

WScript.Echo "Log out..."
lastStatus = session.logoutSync(lastError)
If lastStatus <> SessionStatusCode_Disconnected Then
    WScript.Echo "Error occured: " & lastError
    WScript.Quit
End If
WScript.Echo "Logged out"

Sub session_SessionStatusChanged(status)
    WScript.Echo "Status changed: " & GetStatusName(status)
End Sub

Function GetStatusName(status)
    Select Case status
        Case SessionStatusCode_Connected
            GetStatusName = "connected"
        Case SessionStatusCode_Disconnected
            GetStatusName = "disconnected"
        Case SessionStatusCode_Connecting
            GetStatusName = "connecting"
        Case SessionStatusCode_TradingSessionRequested
            GetStatusName = "trading session requested"
        Case SessionStatusCode_Disconnecting
            GetStatusName = "disconnecting"
        Case SessionStatusCode_SessionLost
            GetStatusName = "session lost"
        Case SessionStatusCode_PriceSessionReconnecting
            GetStatusName = "price session reconnecting"
        Case SessionStatusCode_Unknown
            GetStatusName = "unknown"
    End Select
End Function

Sub PrintHistoryData(responseObj)
    Dim readerFactory, snapshotReader
    Dim snapshot
    Set readerFactory = session.getResponseReaderFactory()
    Set snapshotReader = readerFactory.createMarketDataSnapshotReader(responseObj)
    snapshot = ""
    Dim i
    For i = 0 To snapshotReader.Count - 1
        snapshot = snapshot & snapshotReader.getDate(i) & " ask:" & snapshotReader.getAsk(i) & " bid:" & snapshotReader.getBid(i) & CHR(10) & CHR(13)
    Next
    WScript.Echo snapshot
End Sub
