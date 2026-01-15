Imports Newtonsoft.Json

Public Class frmDeviceInfo
    Dim NetClass As NetworkingClass

    Private Class GetDeviceInfoModel
        Public Property cmd As String
    End Class

    Private Class DataModel
        Public Property name As String
        Public Property deviceId As String
        Public Property firmware As String
        Public Property fpVer As String
        Public Property faceVer As String
        Public Property pvVer As String
        Public Property maxBufferLen As Integer
        Public Property userLimit As Integer
        Public Property fpLimit As Integer
        Public Property faceLimit As Integer
        Public Property pwdLimit As Integer
        Public Property cardLimit As Integer
        Public Property logLimit As Integer
        Public Property userCount As Integer
        Public Property managerCount As Integer
        Public Property fpCount As Integer
        Public Property faceCount As Integer
        Public Property pwdCount As Integer
        Public Property cardCount As Integer
        Public Property logCount As Integer
        Public Property allLogCount As Integer
    End Class

    Private Class DeviceResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
        Public Property result_data As DataModel
    End Class

    Private Sub frmDeviceInfo_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Visible = True
    End Sub

    Private Sub cmdGetDeviceInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdGetDeviceInfo.Click
        InitializeForm()
        lblStatus.Text = "Working..."
        cmdGetDeviceInfo.Enabled = False

        Dim commandJson As String
        Dim cmdRoot As New GetDeviceInfoModel With {
            .cmd = "GetDeviceInfo"
        }

        ' Serializing the object to JSON
        commandJson = JsonConvert.SerializeObject(cmdRoot)


        Dim resultStr As String
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            GoTo Err
        End If

        Dim result_code As Integer
        result_code = objResult.result_code

        If result_code = 0 Then
            txtName.Text = objResult.result_data.name
            txtDeviceId.Text = objResult.result_data.deviceId
            txtFirmware.Text = objResult.result_data.firmware
            txtFpVer.Text = objResult.result_data.fpVer
            txtFaceVer.Text = objResult.result_data.faceVer
            txtPvVer.Text = objResult.result_data.pvVer
            txtMaxBufferLen.Text = objResult.result_data.maxBufferLen
            txtUserLimit.Text = objResult.result_data.userLimit
            txtFpLimit.Text = objResult.result_data.fpLimit
            txtFaceLimit.Text = objResult.result_data.faceLimit
            txtPwdLimit.Text = objResult.result_data.pwdLimit
            txtCardLimit.Text = objResult.result_data.cardLimit
            txtLogLimit.Text = objResult.result_data.logLimit
            txtUserCount.Text = objResult.result_data.userCount
            txtManagerCount.Text = objResult.result_data.managerCount
            txtFpCount.Text = objResult.result_data.fpCount
            txtFaceCount.Text = objResult.result_data.faceCount
            txtPwdCount.Text = objResult.result_data.pwdCount
            txtCardCount.Text = objResult.result_data.cardCount
            txtLogCount.Text = objResult.result_data.logCount
            txtAllLogCount.Text = objResult.result_data.allLogCount
        End If
        lblStatus.Text = ReturnResultString(result_code)
        cmdGetDeviceInfo.Enabled = True
        Exit Sub
Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdGetDeviceInfo.Enabled = True
    End Sub

    Private Sub InitializeForm()
        lblStatus.Text = ""
        txtName.Text = ""
        txtDeviceId.Text = ""
        txtFirmware.Text = ""
        txtFpVer.Text = ""
        txtFaceVer.Text = ""
        txtPvVer.Text = ""
        txtMaxBufferLen.Text = ""
        txtUserLimit.Text = ""
        txtFpLimit.Text = ""
        txtFaceLimit.Text = ""
        txtPwdLimit.Text = ""
        txtCardLimit.Text = ""
        txtLogLimit.Text = ""
        txtUserCount.Text = ""
        txtManagerCount.Text = ""
        txtFpCount.Text = ""
        txtFaceCount.Text = ""
        txtPwdCount.Text = ""
        txtCardCount.Text = ""
        txtLogCount.Text = ""
        txtAllLogCount.Text = ""
    End Sub

    Private Sub frmDeviceInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NetClass = NetworkingModule.GetNetworkingClassInstance()
        InitializeForm()
    End Sub
End Class