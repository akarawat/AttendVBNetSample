Imports Newtonsoft.Json
Public Class frmDeviceSetting
    Dim NetClass As NetworkingClass

    Private Class GetDeviceSettingModel
        Public Property cmd As String
    End Class
    
    Private Class BrightLedModel
        Public Property mode As String
        Public Property start As String
        Public Property [end] As String
    End Class

    Private Class DataModel
        Public Property MultiCheck As String
        Public Property alarmDelay As String
        Public Property antiPass As String
        Public Property brightLed As BrightLedModel
        Public Property devName As String
        Public Property distance As String
        Public Property inOut As String
        Public Property interval As String
        Public Property language As String
        Public Property liveThreshold As String
        Public Property living As String
        Public Property matchThreshold As String
        Public Property openDoorDelay As String
        Public Property pushEnable As String
        Public Property pushServerHost As String
        Public Property pushServerPort As String
        Public Property reverifyTime As String
        Public Property screensaversTime As String
        Public Property serverHost As String
        Public Property serverPort As String
        Public Property sleepTime As String
        Public Property tamperAlarm As String
        Public Property verifyMode As String
        Public Property volume As String
        Public Property wiegandType As String
    End Class

    Private Class GetDeviceSettingResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
        Public Property result_data As DataModel
    End Class

    Private Class SetDeviceSettingModel
        Public Property cmd As String
        Public Property data As DataModel
    End Class

    Private Class SetDeviceSettingResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
    End Class

    

    Private Sub frmDeviceSetting_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Visible = True
    End Sub

    Private Sub cmdSetDeviceSetting_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetDeviceSetting.Click

        lblStatus.Text = "Working..."
        cmdSetDeviceSetting.Enabled = False

        Dim commandJson As String
        Dim resultStr As String

        Dim multiCheck As String
        Dim alarmDelay As String
        Dim antiPass As String
        Dim brightLedMode As String
        Dim devName As String
        Dim distance As String
        Dim inOut As String
        Dim interval As String
        Dim language As String
        Dim liveThreshold As String
        Dim living As String
        Dim matchThreshold As String
        Dim openDoorDelay As String
        Dim pushEnable As String
        Dim pushServerHost As String
        Dim pushServerPort As String
        Dim reverifyTime As String
        Dim screensaversTime As String
        Dim serverHost As String
        Dim serverPort As String
        Dim sleepTime As String
        Dim tamperAlarm As String
        Dim verifyMode As String
        Dim volume As String
        Dim wiegandType As String

        multiCheck = txtMultiCheck.Text
        alarmDelay = txtAlarmDelay.Text
        antiPass = txtAntiPass.Text
        brightLedMode = cmbBrightLedMode.Text
        devName = txtDeviceName.Text
        distance = txtDistance.Text
        inOut = txtInOut.Text
        interval = txtInterval.Text

        liveThreshold = txtLiveThreshold.Text
        living = cmbLiving.Text
        matchThreshold = txtMatchThreshold.Text
        openDoorDelay = txtOpenDoorDelay.Text
        pushEnable = cmbPushEnable.Text
        pushServerHost = txtPushServerHost.Text
        pushServerPort = txtPushServerPort.Text
        reverifyTime = txtReverifyTime.Text
        screensaversTime = txtScreenSaverTime.Text
        serverHost = txtServerHost.Text
        serverPort = txtServerPort.Text
        sleepTime = txtSleepTime.Text
        tamperAlarm = cmbTamperAlarm.Text

        verifyMode = CStr(GetVerifyValueByComboInx(cmbVerifyMode.SelectedIndex))
        language = CStr(GetLanguageValueByComboInx(cmbLanguage.SelectedIndex))

        volume = txtVolume.Text
        wiegandType = cmbWiegandType.Text

        Dim cmdBrightLed As New BrightLedModel With {
            .mode = cmbBrightLedMode.Text,
            .start = txtBrightLedStart.Text,
            .end = txtBrightLedEnd.Text
        }

        Dim cmdRoot As New SetDeviceSettingModel()
        cmdRoot.cmd = "SetDeviceSetting"

        Dim cmdData As New DataModel()

        cmdData.MultiCheck = multiCheck
        cmdData.alarmDelay = alarmDelay
        cmdData.antiPass = antiPass

        'cmdData.brightLed = cmdBrightLed

        cmdData.devName = devName
        cmdData.distance = distance
        cmdData.inOut = inOut
        cmdData.interval = interval
        cmdData.language = language
        cmdData.liveThreshold = liveThreshold
        cmdData.living = living
        cmdData.matchThreshold = matchThreshold
        cmdData.openDoorDelay = openDoorDelay
        cmdData.pushEnable = pushEnable
        cmdData.pushServerHost = pushServerHost
        cmdData.pushServerPort = pushServerPort
        cmdData.reverifyTime = reverifyTime
        cmdData.screensaversTime = screensaversTime
        cmdData.serverHost = serverHost
        cmdData.serverPort = serverPort
        cmdData.sleepTime = sleepTime
        cmdData.tamperAlarm = tamperAlarm
        cmdData.verifyMode = verifyMode
        cmdData.volume = volume
        cmdData.wiegandType = wiegandType

        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As SetDeviceSettingResponseModel = JsonConvert.DeserializeObject(Of SetDeviceSettingResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            GoTo Err
        End If

        Dim result_code As Integer
        result_code = objResult.result_code
        lblStatus.Text = ReturnResultString(result_code)
        cmdSetDeviceSetting.Enabled = True
        Exit Sub
Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdSetDeviceSetting.Enabled = True
    End Sub

    Private Sub cmdGetDeviceSetting_Click(sender As System.Object, e As System.EventArgs) Handles cmdGetDeviceSetting.Click
        InitializeForm()
        lblStatus.Text = "Working..."
        cmdGetDeviceSetting.Enabled = False

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New GetDeviceSettingModel With {
            .cmd = "GetDeviceSetting"
        }

        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As GetDeviceSettingResponseModel = JsonConvert.DeserializeObject(Of GetDeviceSettingResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            GoTo Err
        End If

        Dim result_code As Integer
        result_code = objResult.result_code

        If result_code = 0 Then
            txtDeviceName.Text = objResult.result_data.devName
            txtMultiCheck.Text = objResult.result_data.MultiCheck
            txtAlarmDelay.Text = objResult.result_data.alarmDelay
            txtAntiPass.Text = objResult.result_data.antiPass

            cmbBrightLedMode.Text = objResult.result_data.brightLed.mode
            txtBrightLedStart.Text = objResult.result_data.brightLed.start
            txtBrightLedEnd.Text = objResult.result_data.brightLed.end


            txtDistance.Text = objResult.result_data.distance
            txtInOut.Text = objResult.result_data.inOut
            txtInterval.Text = objResult.result_data.interval
            txtLiveThreshold.Text = objResult.result_data.liveThreshold
            cmbLiving.Text = objResult.result_data.living
            txtMatchThreshold.Text = objResult.result_data.matchThreshold
            txtOpenDoorDelay.Text = objResult.result_data.openDoorDelay
            cmbPushEnable.Text = objResult.result_data.pushEnable
            txtPushServerHost.Text = objResult.result_data.pushServerHost
            txtPushServerPort.Text = objResult.result_data.pushServerPort
            txtReverifyTime.Text = objResult.result_data.reverifyTime
            txtScreenSaverTime.Text = objResult.result_data.screensaversTime
            txtServerHost.Text = objResult.result_data.serverHost
            txtServerPort.Text = objResult.result_data.serverPort
            txtSleepTime.Text = objResult.result_data.sleepTime
            cmbTamperAlarm.Text = objResult.result_data.tamperAlarm
            txtVolume.Text = objResult.result_data.volume
            cmbWiegandType.Text = objResult.result_data.wiegandType

            Dim verifyMode As Integer
            verifyMode = objResult.result_data.verifyMode
            cmbVerifyMode.SelectedIndex = GetVerifyModeCmbInxByValue(verifyMode)

            Dim language As String
            language = objResult.result_data.language
            cmbLanguage.SelectedIndex = GetLanguageCmbInxByValue(language)
        End If

        lblStatus.Text = ReturnResultString(result_code)
        cmdGetDeviceSetting.Enabled = True
        Exit Sub

Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdGetDeviceSetting.Enabled = True

    End Sub

    Private Sub InitializeForm()
        txtDeviceName.Text = ""
        txtMultiCheck.Text = ""
        txtAlarmDelay.Text = ""
        txtAntiPass.Text = ""

        txtDistance.Text = ""
        txtInOut.Text = ""
        txtInterval.Text = ""

        txtLiveThreshold.Text = ""

        txtMatchThreshold.Text = ""
        txtOpenDoorDelay.Text = ""
        txtPushServerHost.Text = ""
        txtPushServerPort.Text = ""
        txtReverifyTime.Text = ""
        txtScreenSaverTime.Text = ""
        txtServerHost.Text = ""
        txtServerPort.Text = ""
        txtSleepTime.Text = ""

        txtVolume.Text = ""


        cmbWiegandType.Items.Clear()
        cmbWiegandType.Items.Add("26")
        cmbWiegandType.Items.Add("34")
        cmbWiegandType.SelectedIndex = 0

        cmbPushEnable.Items.Clear()
        cmbPushEnable.Items.Add("yes")
        cmbPushEnable.Items.Add("no")
        cmbPushEnable.SelectedIndex = 0

        cmbTamperAlarm.Items.Clear()
        cmbTamperAlarm.Items.Add("yes")
        cmbTamperAlarm.Items.Add("no")
        cmbTamperAlarm.SelectedIndex = 0

        cmbLiving.Items.Clear()
        cmbLiving.Items.Add("yes")
        cmbLiving.Items.Add("no")
        cmbLiving.SelectedIndex = 0

        cmbBrightLedMode.Items.Clear()
        cmbBrightLedMode.Items.Add("on")
        cmbBrightLedMode.Items.Add("off")
        cmbBrightLedMode.Items.Add("auto")
        cmbBrightLedMode.Items.Add("timing")
        cmbBrightLedMode.SelectedIndex = 0

        cmbVerifyMode.Items.Clear()
        cmbVerifyMode.Items.Add("1:1") '1
        cmbVerifyMode.Items.Add("FC/FP/C/P") '2
        cmbVerifyMode.Items.Add("P+(FC/FP)") '3
        cmbVerifyMode.Items.Add("C+(FC/FP)") '4
        cmbVerifyMode.Items.Add("FP+FC") '6
        cmbVerifyMode.SelectedIndex = 1

        cmbLanguage.Items.Clear()
        cmbLanguage.Items.Add("English")
        cmbLanguage.Items.Add("Simplified Chinese")
        cmbLanguage.Items.Add("Traditional Chinese")
        cmbLanguage.Items.Add("Korean")
        cmbLanguage.Items.Add("Thai")
        cmbLanguage.Items.Add("Japanese")
        cmbLanguage.Items.Add("Turkish")
        cmbLanguage.Items.Add("Espanol")
        cmbLanguage.Items.Add("Espanol-Argentine")
        cmbLanguage.Items.Add("Portuguese")
        cmbLanguage.Items.Add("Portuguese-Brazilian")
        cmbLanguage.Items.Add("Indonesian")
        cmbLanguage.Items.Add("German")
        cmbLanguage.Items.Add("Persian")
        cmbLanguage.Items.Add("Arabic")
        cmbLanguage.Items.Add("Vietnamese")
        cmbLanguage.SelectedIndex = 0
    End Sub

    Private Sub frmDeviceSetting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NetClass = NetworkingModule.GetNetworkingClassInstance()

        InitializeForm()
    End Sub
End Class