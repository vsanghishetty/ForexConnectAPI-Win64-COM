Option Explicit

Dim fso, file
Dim constants
Dim core, session
Dim username, password, url, connection, sessionId, pin
Dim lastError, lastStatus

'load constants file

set fso = createObject("Scripting.FileSystemObject")
set file = fso.OpenTextFile("fxcore2_com_enums.vbs", 1)
constants = file.ReadAll
file.close
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
If lastStatus <> SessionStatusCode_Connected then
    WScript.Echo "Error occured: " & lastError
    WScript.Quit
End if
WScript.Echo "Logged in"
WScript.Echo "Press Ok to logout"

'logout

WScript.Echo "Log out..."
lastStatus = session.logoutSync(lastError)
If lastStatus <> SessionStatusCode_Disconnected then
    WScript.Echo "Error occured: " & lastError
    WScript.Quit
End if
WScript.Echo "Logged out"

Sub session_SessionStatusChanged(status)
    WScript.Echo "Status changed: " & GetStatusName(status)
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
    End Select
End Function