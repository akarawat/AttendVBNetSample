Imports System.Configuration
Imports System.Data.SqlClient
Imports Newtonsoft.Json
Public Class frmLog
    Dim NetClass As NetworkingClass
    Private WithEvents pullTimer As New Timer()
    Private Class DeviceCommandModel
        Public Property cmd As String
    End Class

    Private Class DeviceResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
    End Class

    Private Class GetLogDataPageDataModel
        Public Property beginTime As String
        Public Property endTime As String
        Public Property page As Integer
        Public Property pageCount As Integer
    End Class

    Private Class GetLogDataPageModel
        Public Property cmd As String
        Public Property data As GetLogDataPageDataModel
    End Class

    Private Class LogDataModel
        Public Property userId As String
        Public Property time As String
        Public Property verifyMode As String
        Public Property ioMode As Integer
        Public Property inOut As String
        Public Property doorMode As String
        Public Property temperature As Double
        Public Property logPhoto As String
    End Class

    Private Class GetLogDataPageResponseDataModel
        Public Property allLogCount As Integer
        Public Property logs As LogDataModel()
    End Class

    Private Class GetLogDataPageResponseModel
        Public Property cmd As String
        Public Property result_code As String
        Public Property result_data As GetLogDataPageResponseDataModel
    End Class

    Private Class GetLogDataDataModel
        Public Property beginTime As String
        Public Property endTime As String
        Public Property packageId As Integer
        Public Property newLog As Integer
        Public Property clearMark As Integer
    End Class

    Private Class GetLogDataModel
        Public Property cmd As String
        Public Property data As GetLogDataDataModel
    End Class

    Private Class GetLogDataResponseDataModel
        Public Property packageId As Integer
        Public Property allLogCount As Integer
        Public Property logsCount As Integer
        Public Property logs As LogDataModel()
    End Class

    Private Class GetLogDataResponseModel
        Public Property cmd As String
        Public Property result_code As String
        Public Property result_data As GetLogDataResponseDataModel
    End Class

    Private Sub MakeLogGridViewColumn()

        gridLogView.ColumnCount = 9

        gridLogView.Columns(0).Name = "No"
        gridLogView.Columns(1).Name = "userId"
        gridLogView.Columns(2).Name = "time"
        gridLogView.Columns(3).Name = "verifyMode"
        gridLogView.Columns(4).Name = "ioMode"
        gridLogView.Columns(5).Name = "inOut"
        gridLogView.Columns(6).Name = "doorMode"
        gridLogView.Columns(7).Name = "temperature"
        gridLogView.Columns(8).Name = "logPhoto"

    End Sub

    Private Sub frmLog_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Visible = True
        pullTimer.Stop()
    End Sub

    Private Sub cmdClearLogData_Click(sender As System.Object, e As System.EventArgs) Handles cmdClearLogData.Click
        lblStatus.Text = "Working..."
        cmdClearLogData.Enabled = False

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New DeviceCommandModel()
        cmdRoot.cmd = "ClearLogData"

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
        cmdClearLogData.Enabled = True
    End Sub

    Private Sub frmLog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NetClass = NetworkingModule.GetNetworkingClassInstance()
        MakeLogGridViewColumn()
        'txtBeginTime.Text = DateAndTime.Now().ToString("yyyyMMdd 00:00:00")
        'txtEndTime.Text = DateAndTime.Now().ToString("yyyyMMdd 23:59:59")
        'Call cmdGetLogData.PerformClick()
        txtBeginTime.Text = DateAndTime.Now().ToString("yyyyMMdd 00:00:00")
        txtEndTime.Text = DateAndTime.Now().ToString("yyyyMMdd 23:59:59")

        ' ดึงครั้งแรกทันที
        Call cmdGetLogData.PerformClick()

        ' เริ่ม Pull ทุก 3 วินาที
        pullTimer.Interval = 3000    ' 3000 ms = 3 sec
        pullTimer.Start()

        cmdGetLogDataPage.Location = New Point(5000, 5000)
        cmdClearLogData.Location = New Point(5000, 5000)
    End Sub

    Private Sub cmdGetLogDataPage_Click(sender As System.Object, e As System.EventArgs) Handles cmdGetLogDataPage.Click
        lblStatus.Text = "Working..."
        lblAllLogCount.Text = ""
        cmdGetLogDataPage.Enabled = False

        gridLogView.Rows.Clear()

        Dim nRetryCount As Integer

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New GetLogDataPageModel()
        cmdRoot.cmd = "GetLogDataPage"

        Dim cmdData As New GetLogDataPageDataModel()

        Dim nPageCount As Integer
        nPageCount = CInt(txtPageCount.Text)

        cmdData.page = CInt(txtPage.Text)
        cmdData.pageCount = nPageCount
        cmdData.beginTime = txtBeginTime.Text
        cmdData.endTime = txtEndTime.Text

        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

Retry:
        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        'Get Result
        Dim objResult As GetLogDataPageResponseModel = JsonConvert.DeserializeObject(Of GetLogDataPageResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            nRetryCount = nRetryCount + 1
            If nRetryCount = RETRY_COUNT Then
                GoTo Err
            Else
                NetClass.ReConnect()
                GoTo Retry
            End If
        End If
        Dim result_code As Integer
        result_code = objResult.result_code

        If result_code = 0 Then
            Dim allLogCount As Integer
            allLogCount = objResult.result_data.allLogCount
            lblAllLogCount.Text = allLogCount

            'Dim strLogs As String
            Dim nGetLogCount As Integer
            If Not objResult.result_data.logs Is Nothing Then
                nGetLogCount = objResult.result_data.logs.Count
            End If

            If nGetLogCount > 0 Then
                gridLogView.RowCount = nGetLogCount
            End If

            Dim logIndex As Integer
            For logIndex = 0 To nGetLogCount - 1
                gridLogView.Rows(logIndex).Cells(0).Value = logIndex + 1
                gridLogView.Rows(logIndex).Cells(1).Value = objResult.result_data.logs(logIndex).userId
                gridLogView.Rows(logIndex).Cells(2).Value = objResult.result_data.logs(logIndex).time
                gridLogView.Rows(logIndex).Cells(3).Value = objResult.result_data.logs(logIndex).verifyMode
                gridLogView.Rows(logIndex).Cells(4).Value = objResult.result_data.logs(logIndex).ioMode
                gridLogView.Rows(logIndex).Cells(5).Value = objResult.result_data.logs(logIndex).inOut
                gridLogView.Rows(logIndex).Cells(6).Value = objResult.result_data.logs(logIndex).doorMode
                gridLogView.Rows(logIndex).Cells(7).Value = objResult.result_data.logs(logIndex).temperature
                gridLogView.Rows(logIndex).Cells(8).Value = objResult.result_data.logs(logIndex).logPhoto
            Next logIndex
        End If

        lblStatus.Text = ReturnResultString(result_code)
        cmdGetLogDataPage.Enabled = True
        Exit Sub

Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdGetLogDataPage.Enabled = True
    End Sub

    Private Sub cmdGetLogData_Click(sender As System.Object, e As System.EventArgs) Handles cmdGetLogData.Click
        lblStatus.Text = "Working..."
        lblAllLogCount.Text = ""
        cmdGetLogData.Enabled = False

        gridLogView.Rows.Clear()

        Dim nCmdPackageId As Integer
        nCmdPackageId = 0

        Dim nAllLogInx As Integer

SubRecev:
        Dim nRetryCount As Integer
        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New GetLogDataModel()
        cmdRoot.cmd = "GetLogData"

        Dim cmdData As New GetLogDataDataModel()


        Dim vnReadMark As Integer
        If chkReadMark.Checked = True Then
            vnReadMark = 1
        Else
            vnReadMark = 0
        End If

        Dim vnNewLog As Integer
        If chkNewLog.Checked = True Then
            vnNewLog = 1
        Else
            vnNewLog = 0
        End If

        cmdData.packageId = nCmdPackageId
        cmdData.newLog = vnNewLog
        cmdData.beginTime = txtBeginTime.Text
        cmdData.endTime = txtEndTime.Text
        cmdData.clearMark = vnReadMark

        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

Retry:
        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As GetLogDataResponseModel = JsonConvert.DeserializeObject(Of GetLogDataResponseModel)(resultStr)

        If resultStr = "" Or objResult Is Nothing Then
            nRetryCount = nRetryCount + 1
            If nRetryCount = RETRY_COUNT Then
                GoTo Err
            Else
                NetClass.ReConnect()
                GoTo Retry
            End If
        End If

        Dim result_code As Integer
        result_code = objResult.result_code

        If result_code = 0 Then
            Dim allLogCount As Integer
            allLogCount = objResult.result_data.allLogCount
            lblAllLogCount.Text = allLogCount

            Dim nGetLogCount As Integer
            If Not objResult.result_data.logs Is Nothing Then
                nGetLogCount = objResult.result_data.logs.Count
            End If

            If nGetLogCount > 0 Then
                gridLogView.RowCount = nGetLogCount
            End If

            Dim db As New DBClass()

            ' Buffer กัน Duplicate
            Dim logBuffer As New Dictionary(Of String, Boolean)

            Dim logIndex As Integer
            For logIndex = 0 To nGetLogCount - 1

                Dim UserId As String = objResult.result_data.logs(logIndex).userId
                Dim HIPId As String = ConfigurationManager.AppSettings("MachineNumber") 'objResult.result_data.logs(logIndex).hipId
                Dim logTimeStr As String = objResult.result_data.logs(logIndex).time
                Dim logTime As DateTime = DateTime.ParseExact(logTimeStr, "yyyyMMddHHmmss", Globalization.CultureInfo.InvariantCulture)
                'Dim logTimeTxt As String = DateTime.ParseExact(logTimeStr, "yyyyMMddHHmmss", Globalization.CultureInfo.InvariantCulture)

                Dim VerifyMode As String = objResult.result_data.logs(logIndex).verifyMode
                Dim IOMode As Integer = objResult.result_data.logs(logIndex).ioMode
                Dim InOut As String = objResult.result_data.logs(logIndex).inOut
                Dim DoorMode As String = objResult.result_data.logs(logIndex).doorMode
                Dim Temperature As Double = objResult.result_data.logs(logIndex).temperature

                ' ---- Buffer Key ----
                Dim logKey As String = $"{UserId}|{HIPId}|{logTime:yyyy-MM-dd HH:mm}"

                If logBuffer.ContainsKey(logKey) Then
                    ' ซ้ำภายในรอบนี้ → ไม่ Insert
                    Continue For
                Else
                    logBuffer.Add(logKey, True)
                End If

                ' Insert to grid view UI
                gridLogView.Rows(logIndex).Cells(0).Value = logIndex + 1
                gridLogView.Rows(logIndex).Cells(1).Value = UserId
                gridLogView.Rows(logIndex).Cells(2).Value = LogTime
                gridLogView.Rows(logIndex).Cells(3).Value = VerifyMode
                gridLogView.Rows(logIndex).Cells(4).Value = IOMode
                gridLogView.Rows(logIndex).Cells(5).Value = InOut
                gridLogView.Rows(logIndex).Cells(6).Value = DoorMode
                gridLogView.Rows(logIndex).Cells(7).Value = Temperature
                gridLogView.Rows(logIndex).Cells(8).Value = objResult.result_data.logs(logIndex).logPhoto

                ' ---- Insert to Database ----
                'DBClass.InsertAttendanceLog(UserId, HIPId, LogTime, VerifyMode, IOMode, InOut, DoorMode, Temperature)
                '=== Insert to DB ===
                Dim p As New List(Of SqlParameter) From {
                    New SqlParameter("@UserId", objResult.result_data.logs(logIndex).userId),
                    New SqlParameter("@HIPId", ConfigurationManager.AppSettings("MachineNumber")), ' TODO: ปรับเองตามสถานการณ์
                    New SqlParameter("@LogTime", logTime),
                    New SqlParameter("@VerifyMode", objResult.result_data.logs(logIndex).verifyMode),
                    New SqlParameter("@IOMode", objResult.result_data.logs(logIndex).ioMode),
                    New SqlParameter("@InOut", objResult.result_data.logs(logIndex).inOut),
                    New SqlParameter("@DoorMode", objResult.result_data.logs(logIndex).doorMode),
                    New SqlParameter("@Temperature", objResult.result_data.logs(logIndex).temperature)
                }
                db.ExecSP("SP_InsertAttendanceLog", p)

            Next logIndex

        End If


        lblStatus.Text = ReturnResultString(result_code)
            cmdGetLogData.Enabled = True
            Exit Sub
Err:
            lblStatus.Text = ReturnResultString(RUNERR_ERROR)
            cmdGetLogData.Enabled = True
    End Sub
    Private Sub pullTimer_Tick(sender As Object, e As EventArgs) Handles pullTimer.Tick
        If cmdGetLogData.Enabled = True Then
            cmdGetLogData.PerformClick()
        End If
    End Sub
End Class