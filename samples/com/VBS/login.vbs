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

WScript.Echo "Login and logout"

Set core = CreateObject("fxcore2.com.Transport")

Set session = core.createSession()
WScript.ConnectObject session, "session_"

WScript.Echo "Log in..."
call session.login(username, password, "http://www.fxcorporate.com/Hosts.jsp", "Demo")

While LastStatus <> SessionStatusCode_Connected and LastError = ""
    WScript.Sleep(50)
Wend

WScript.Echo "Log out..."
session.logout
While LastStatus <> SessionStatusCode_Disconnected
    WScript.Sleep(50)
Wend

WScript.Echo "Session status:" & GetStatusName(LastStatus)

Set session = Nothing

WScript.Echo "Done !"

Sub session_SessionStatusChanged(status)
    WScript.Echo "Status changed: " + GetStatusName(status)
    LastStatus = status
End Sub

Sub session_SessionStatusLoginError(err)
    WScript.Echo "Error occured: " + err
    LastError = err
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