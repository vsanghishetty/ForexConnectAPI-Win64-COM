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
bReaded = false

WScript.Echo "Manage offers without table manager"
Set core = CreateObject("fxcore2.com.Transport")

'create session
Set session = core.createSession()
WScript.ConnectObject session, "session_"

'force login
WScript.Echo "Log in..."
Call session.login(username, password, "http://www.fxcorporate.com/Hosts.jsp", "Demo")

While LastStatus <> SessionStatusCode_Connected and LastError = ""
    WScript.Sleep 50
Wend

If (LastStatus = SessionStatusCode_Connected) Then
    Dim loginRules, offersResponse, readerFactory, offersReader
    Set loginRules = session.getLoginRules()
    Set offersResponse = loginRules.getTableRefreshResponse(TableType_Offers)
    Set readerFactory = session.getResponseReaderFactory()
    Set offersReader = readerFactory.createOffersTableReader(offersResponse)
    
    Dim sOffers
    sOffers = "Instruments and offers: " & CHR(10) & CHR(13)
    For i = 0 To offersReader.Count - 1
        Set offer = offersReader.getRow(i)
        If offer.SubscriptionStatus <> "D" then
            sOffers = sOffers & offer.Instrument & " Bid:" & CSTR(offer.Bid) & ", Ask:" & CSTR(offer.Ask) & CHR(10) & CHR(13)
        End If
    Next
    WScript.Echo sOffers

    bReaded = true

    WScript.Echo "Waiting offers updates..."
    
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


Sub session_TablesUpdates(data)    
    if bReaded then
        Dim readerFactory, tableUpdatesReader, offerRow        
        Set readerFactory = session.getResponseReaderFactory()
        Set tableUpdatesReader = readerFactory.createTablesUpdatesReader(data)
        Dim sUpdates
        sUpdates = ""
        For i = 0 to tableUpdatesReader.Count -1
            If tableUpdatesReader.getUpdateTable(i) = TableType_Offers Then
                Set offerRow = tableUpdatesReader.getOfferRow(i)
                sUpdates = sUpdates & "Offer " & GetUpdateTypeName(tableUpdatesReader.getUpdateType(i)) & " " & offerRow.Instrument & " Bid:" + CStr(offerRow.Bid) & ", Ask:" + CStr(offerRow.Ask) & CHR(10) & CHR(13)
            End if
        Next
        If sUpdates <> "" Then
            WScript.Echo sUpdates
        End if
    end if
End Sub

Function GetUpdateTypeName(updateType)
    Select Case updateType
        Case TableUpdateType_Insert
            GetUpdateTypeName = "Insert"
        Case TableUpdateType_Update
            GetUpdateTypeName = "Update"
        Case TableUpdateType_Delete
            GetUpdateTypeName = "Delete"
        Case TableUpdateType_UpdateUnknown
            GetUpdateTypeName = "Unknown"
        Case Else
            GetUpdateTypeName = CSTR(updateType)
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
