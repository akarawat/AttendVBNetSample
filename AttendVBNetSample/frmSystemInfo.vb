Imports Newtonsoft.Json
Public Class frmSystemInfo

    Dim NetClass As NetworkingClass

    Private Class DeviceCommandModel
        Public Property cmd As String
    End Class

    Private Class DeviceResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
    End Class

    Private Class SetTimeDataModel
        Public Property syncTime As String
    End Class

    Private Class SetTimeModel
        Public Property cmd As String
        Public Property data As SetTimeDataModel
    End Class

    Private Class EnterEnrollDataModel
        Public Property userId As String
        Public Property feature As String
    End Class

    Private Class EnterEnrollModel
        Public Property cmd As String
        Public Property data As EnterEnrollDataModel
    End Class

    Private Class SetDoorStatusDataModel
        Public Property doorStatus As String
    End Class

    Private Class SetDoorStatusModel
        Public Property cmd As String
        Public Property data As SetDoorStatusDataModel
    End Class

    Private Sub InitializeForm()
        cmbDoorStatus.Items.Clear()
        cmbDoorStatus.Items.Add("close")
        cmbDoorStatus.Items.Add("open")
        cmbDoorStatus.Items.Add("open_close")
        cmbDoorStatus.SelectedIndex = 0

        cmbFeature.Items.Clear()
        cmbFeature.Items.Add("face")
        cmbFeature.Items.Add("fp")
        cmbFeature.Items.Add("card")
        cmbFeature.Items.Add("pwd")
        cmbFeature.SelectedIndex = 0
    End Sub

    Private Sub frmSystemInfo_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Visible = True
    End Sub

    Private Sub frmSystemInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NetClass = NetworkingModule.GetNetworkingClassInstance()

        InitializeForm()
    End Sub

    Private Sub cmdSetSyncTime_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetSyncTime.Click
        lblStatus.Text = "Working..."
        cmdSetSyncTime.Enabled = False

        Dim vdwDate As Date
        Dim formattedTime As String

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New SetTimeModel()
        cmdRoot.cmd = "SetTime"

        Dim cmdData As New SetTimeDataModel()

        vdwDate = Now
        formattedTime = Format(vdwDate, "yyyyMMddhhmmss")
        cmdData.syncTime = formattedTime

        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        Else
            Dim result_code As Integer
            result_code = objResult.result_code

            lblStatus.Text = ReturnResultString(result_code)
        End If
        cmdSetSyncTime.Enabled = True
    End Sub

    Private Sub cmdResetDevice_Click(sender As System.Object, e As System.EventArgs) Handles cmdResetDevice.Click
        lblStatus.Text = "Working..."
        cmdResetDevice.Enabled = False

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New DeviceCommandModel()
        cmdRoot.cmd = "ResetDevice"

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        Else
            Dim result_code As Integer
            result_code = objResult.result_code

            lblStatus.Text = ReturnResultString(result_code)
        End If
        cmdResetDevice.Enabled = True
    End Sub

    Private Sub cmdClearManager_Click(sender As System.Object, e As System.EventArgs) Handles cmdClearManager.Click
        lblStatus.Text = "Working..."
        cmdClearManager.Enabled = False

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New DeviceCommandModel()
        cmdRoot.cmd = "ClearManager"

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        Else
            Dim result_code As Integer
            result_code = objResult.result_code

            lblStatus.Text = ReturnResultString(result_code)
        End If
        cmdClearManager.Enabled = True
    End Sub

    Private Sub cmdRestart_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestart.Click
        lblStatus.Text = "Working..."
        cmdRestart.Enabled = False

        Dim commandJson As String

        Dim cmdRoot As New DeviceCommandModel()
        cmdRoot.cmd = "Restart"

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        
        cmdRestart.Enabled = True
    End Sub

    Private Sub cmdRemoteEnroll_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemoteEnroll.Click
        cmdRemoteEnroll.Enabled = False
        lblStatus.Text = "Working..."

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New EnterEnrollModel()
        cmdRoot.cmd = "EnterEnroll"

        Dim cmdData As New EnterEnrollDataModel()
        Dim selectedItem As String
        Dim userID As String

        userID = txtRemoteEnrollNumber.Text
        selectedItem = cmbFeature.Text

        cmdData.userId = userID
        cmdData.feature = selectedItem

        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        Else
            Dim result_code As Integer
            result_code = objResult.result_code

            lblStatus.Text = ReturnResultString(result_code)
        End If

        cmdRemoteEnroll.Enabled = True
    End Sub

    Private Sub cmdSetDoorStatus_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetDoorStatus.Click
        lblStatus.Text = "Working..."
        cmdSetDoorStatus.Enabled = False
        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New SetDoorStatusModel()
        cmdRoot.cmd = "SetDoorStatus"

        Dim cmdData As New SetDoorStatusDataModel()
        Dim selectedItem As String
        selectedItem = cmbDoorStatus.Text

        cmdData.doorStatus = selectedItem

        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        Else
            Dim result_code As Integer
            result_code = objResult.result_code

            lblStatus.Text = ReturnResultString(result_code)
        End If
        cmdSetDoorStatus.Enabled = True
    End Sub
End Class