Imports System.Configuration
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation
Imports System.IO
Public Class frmMain
    Public gbOpenFlag As Boolean
    Public gnCommHandleIndex As Long
    Dim NetClass As NetworkingClass

    ' ฟังก์ชันสำหรับการเช็คและเชื่อมต่อ (เรียกใช้ได้ทั้ง Timer และปุ่มกด)
    Private Sub TryConnectToDevice()
        Dim vpszIPAddress As String = Trim(txtIPAddress.Text)
        Dim vpszNetPort As Integer = CLng(txtPortNo.Text)
        Dim vnTimeOut As Integer = CLng(txtTimeOut.Text)

        ' ถ้าเชื่อมต่ออยู่แล้ว ไม่ต้องทำอะไร
        If gbOpenFlag Then Return

        Dim pingSender As New Ping()
        Dim reply As PingReply

        Try
            ' Ping ไปยัง IP ของเครื่องสแกน
            reply = pingSender.Send(vpszIPAddress, 1000)

            If reply.Status = IPStatus.Success Then
                ' หาก Ping สำเร็จ จึงค่อยสั่งเชื่อมต่อ
                gnCommHandleIndex = NetClass.ConnectToServer(vpszIPAddress, vpszNetPort, vnTimeOut)

                If gnCommHandleIndex = 0 Then
                    gbOpenFlag = True
                    OwnerEnableButtons(True)

                    ' แจ้งเตือน หรือ Log เมื่อเชื่อมต่อสำเร็จ
                    Console.WriteLine("Connected to " & vpszIPAddress)

                    ' หากเชื่อมต่อสำเร็จแล้ว ให้หยุด Timer
                    tmrCheckConnection.Stop()
                Else
                    Console.WriteLine("Connect Fail")
                End If
            Else
                Console.WriteLine("Device not reachable: " & vpszIPAddress)
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    ' --- Event ของ Timer ---
    Private Sub tmrCheckConnection_Tick(sender As Object, e As EventArgs) Handles tmrCheckConnection.Tick
        ' วนลูปเช็คถ้ายังไม่เชื่อมต่อ
        If Not gbOpenFlag Then
            TryConnectToDevice()
        End If
    End Sub

    ' --- Event ของปุ่มกด (สำหรับสั่งเริ่ม) ---
    Private Sub cmdOpenComm_ClickBak(sender As System.Object, e As System.EventArgs)
        '' เมื่อกดปุ่ม ให้เริ่มทำงานของ Timer
        'tmrCheckConnection.Start()
        '' และลองเชื่อมต่อทันทีครั้งแรก
        'TryConnectToDevice()
    End Sub

    Private Sub OwnerEnableButtons(abEnableFlag As Boolean)
        cmdOpenComm.Enabled = Not abEnableFlag
        cmdCloseComm.Enabled = abEnableFlag
        cmdSystemInfo.Enabled = abEnableFlag
        cmdUserInfo.Enabled = abEnableFlag
        cmdUserTimeGroup.Enabled = abEnableFlag

        cmdLogData.Enabled = abEnableFlag
        cmdDeviceInfo.Enabled = abEnableFlag
        cmdDeviceSetting.Enabled = abEnableFlag
    End Sub

    'Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    NetClass = NetworkingModule.GetNetworkingClassInstance()
    '    gbOpenFlag = False
    '    txtMachineNumber.Text = "1"
    '    OwnerEnableButtons(False)
    'End Sub
    Private Function IsProcessAlreadyRunning(processName As String) As Boolean
        Dim current As Process = Process.GetCurrentProcess()
        Dim running() As Process = Process.GetProcessesByName(processName)

        For Each p In running
            If p.Id <> current.Id Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Set icon
        Dim iconPath As String = "bnnuserscan.ico"
        If File.Exists(iconPath) Then
            Me.Icon = New Icon(iconPath)
            NotifyIcon1.Icon = New Icon(iconPath)
        End If

        ' *** Single Instance Check *** 
        ' Toto ปิด เพื่อให้สามารถเปิดได้หลาย IP
        ''If IsProcessAlreadyRunning("BTKiOSFaceScan") Then
        ''    MessageBox.Show("โปรแกรม BTKiOSFaceScan กำลังทำงานอยู่แล้ว!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ''    Me.Close()
        ''    Return
        ''Else
        ''    NetClass = NetworkingModule.GetNetworkingClassInstance()
        ''    gbOpenFlag = False

        ''    ' Load config values
        ''    txtMachineNumber.Text = ConfigurationManager.AppSettings("MachineNumber")
        ''    txtLicense.Text = ConfigurationManager.AppSettings("License")
        ''    txtIPAddress.Text = ConfigurationManager.AppSettings("ServerIP")
        ''    txtPortNo.Text = ConfigurationManager.AppSettings("ServerPort")
        ''    txtPassword.Text = ConfigurationManager.AppSettings("Password")
        ''    txtTimeOut.Text = ConfigurationManager.AppSettings("Timeout")
        ''    OwnerEnableButtons(False)
        ''    Dim autoConnect As Boolean = ConfigurationManager.AppSettings("autoRunFlag")
        ''    Dim scrXPos As Integer = ConfigurationManager.AppSettings("scrXPos")
        ''    Dim scrYPos As Integer = ConfigurationManager.AppSettings("scrYPos")
        ''    If autoConnect = True Then
        ''        ' Move Main Form out of screen
        ''        Location = New Point(scrXPos, scrYPos)

        ''        ' Auto Connect
        ''        Call cmdOpenComm.PerformClick()
        ''        Call cmdLogData.PerformClick()
        ''    End If
        ''End If


        NetClass = NetworkingModule.GetNetworkingClassInstance()
        gbOpenFlag = False

        ' Load config values
        txtMachineNumber.Text = ConfigurationManager.AppSettings("MachineNumber")
        txtLicense.Text = ConfigurationManager.AppSettings("License")
        txtIPAddress.Text = ConfigurationManager.AppSettings("ServerIP")
        txtPortNo.Text = ConfigurationManager.AppSettings("ServerPort")
        txtPassword.Text = ConfigurationManager.AppSettings("Password")
        txtTimeOut.Text = ConfigurationManager.AppSettings("Timeout")
        OwnerEnableButtons(False)
        Dim autoConnect As Boolean = ConfigurationManager.AppSettings("autoRunFlag")
        Dim scrXPos As Integer = ConfigurationManager.AppSettings("scrXPos")
        Dim scrYPos As Integer = ConfigurationManager.AppSettings("scrYPos")
        If autoConnect = True Then
            ' Move Main Form out of screen
            Location = New Point(scrXPos, scrYPos)
            ' เมื่อกดปุ่ม ให้เริ่มทำงานของ Timer
            ' tmrCheckConnection.Start()
            ' และลองเชื่อมต่อทันทีครั้งแรก
            If Not gbOpenFlag Then
                TryConnectToDevice()
                ' Auto Connect
                Call cmdOpenComm.PerformClick()
                Call cmdLogData.PerformClick()
            End If
        End If

        ' ตั้งค่า NotifyIcon เบื้องต้น
        Me.Text = txtIPAddress.Text
        NotifyIcon1.Text = "HIP " & txtIPAddress.Text
        NotifyIcon1.Visible = True

        ' Timer1: รอ 5 วินาที หลัง Load แล้วกดปุ่ม Open อัตโนมัติ
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub cmdDeviceInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeviceInfo.Click
        Me.Visible = False
        frmDeviceInfo.Visible = True
    End Sub

    Private Sub cmdDeviceSetting_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeviceSetting.Click
        Me.Visible = False
        frmDeviceSetting.Visible = True
    End Sub

    Private Sub cmdSystemInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdSystemInfo.Click
        Me.Visible = False
        frmSystemInfo.Visible = True
    End Sub

    Private Sub cmdLogData_Click(sender As System.Object, e As System.EventArgs) Handles cmdLogData.Click
        Me.Visible = False
        frmLog.Visible = True
    End Sub

    Private Sub cmdUserTimeGroup_Click(sender As System.Object, e As System.EventArgs) Handles cmdUserTimeGroup.Click
        Me.Visible = False
        frmUserTimeGroup.Visible = True
    End Sub

    Private Sub cmdUserInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdUserInfo.Click
        Me.Visible = False
        frmUserInfo.Visible = True
    End Sub

    'Private Sub cmdOpenComm_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenComm.Click
    '    Dim vnMachineNumber As Integer
    '    Dim vnLicense As Integer
    '    Dim vpszIPAddress As String
    '    Dim vpszNetPort As Integer
    '    Dim vpszNetPassword As Integer
    '    Dim vnTimeOut As Integer

    '    vnMachineNumber = Val(txtMachineNumber.Text)
    '    vnLicense = Val(txtLicense.Text)

    '    vpszIPAddress = Trim(txtIPAddress.Text)
    '    vpszNetPort = CLng(txtPortNo.Text)
    '    vpszNetPassword = CLng(txtPassword.Text)
    '    vnTimeOut = CLng(txtTimeOut.Text)

    '    gnCommHandleIndex = NetClass.ConnectToServer(vpszIPAddress, vpszNetPort, vnTimeOut)

    '    If gnCommHandleIndex = 0 Then
    '        gbOpenFlag = True
    '        OwnerEnableButtons(True)
    '    Else
    '        MsgBox("Connect Fail")
    '        cmdOpenComm.Enabled = True
    '    End If
    'End Sub
    Private Sub cmdOpenComm_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenComm.Click
        Dim vnMachineNumber As Integer
        Dim vnLicense As Integer
        Dim vpszIPAddress As String
        Dim vpszNetPort As Integer
        Dim vpszNetPassword As Integer
        Dim vnTimeOut As Integer

        vnMachineNumber = Val(txtMachineNumber.Text)
        vnLicense = Val(txtLicense.Text)

        vpszIPAddress = Trim(txtIPAddress.Text)
        vpszNetPort = CLng(txtPortNo.Text)
        vpszNetPassword = CLng(txtPassword.Text)
        vnTimeOut = CLng(txtTimeOut.Text)

        ' === เพิ่มโค้ด Ping ที่นี่ ===
        Dim pingSender As New Ping()
        Dim reply As PingReply

        Dim logPath As String = Application.StartupPath & "\ConnectionLog.txt"
        Dim logMessage As String = ""

        Try
            ' ส่ง Ping ไปยัง IP ของเครื่องสแกน (กำหนด Timeout เช่น 1000ms หรือ 1 วินาที)
            reply = pingSender.Send(vpszIPAddress, 1000)

            If reply.Status = IPStatus.Success Then
                ' หาก Ping สำเร็จ จึงค่อยสั่งเชื่อมต่อ
                gnCommHandleIndex = NetClass.ConnectToServer(vpszIPAddress, vpszNetPort, vnTimeOut)

                If gnCommHandleIndex = 0 Then
                    gbOpenFlag = True
                    OwnerEnableButtons(True)
                    ' MsgBox("Connected Successfully")
                    ' === ส่วนบันทึก Log เมื่อสำเร็จ ===
                    logMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - Connected Successfully to " & vpszIPAddress & Environment.NewLine
                    File.AppendAllText(logPath, logMessage)
                    ' =================================
                Else
                    'MsgBox("Connect Fail")
                    logMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - Connect Fail to " & vpszIPAddress & Environment.NewLine
                    File.AppendAllText(logPath, logMessage)
                    cmdOpenComm.Enabled = True
                End If
            Else
                ' หาก Ping ไม่สำเร็จ ให้แจ้งเตือนและไม่ต้อง Connect
                'MsgBox("Device not reachable. Please check network connection.")
                logMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - Device not reachable: " & vpszIPAddress & Environment.NewLine
                File.AppendAllText(logPath, logMessage)
                cmdOpenComm.Enabled = True
            End If
        Catch ex As Exception
            'MsgBox("Error Ping: " & ex.Message)
            logMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - Error: " & ex.Message & Environment.NewLine
            File.AppendAllText(logPath, logMessage)
            cmdOpenComm.Enabled = True
        End Try
        ' ===========================

    End Sub

    Private Sub cmdCloseComm_Click(sender As System.Object, e As System.EventArgs) Handles cmdCloseComm.Click
        If gbOpenFlag = True Then
            NetClass.CloseConnect()
            gbOpenFlag = False
            OwnerEnableButtons(False)
        End If
    End Sub
    Private Sub frmLog_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim pass As String = InputBox("โปรดระบุรหัสผ่านเพื่อปิดโปรแกรม", "ยืนยันการปิดโปรแกรม")
        'If pass <> "admin1234" Then
        '    MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    e.Cancel = True ' ยกเลิกการปิดฟอร์ม
        'Else
        '    NetClass.CloseConnect()
        '    gbOpenFlag = False
        '    e.Cancel = False ' อนุญาตให้ปิด
        'End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    'Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    If Me.WindowState = FormWindowState.Minimized Then
    '        Me.Hide() ' ซ่อนหน้าต่างหลัก
    '        NotifyIcon1.Visible = True ' แสดงไอคอนที่ Tray
    '        NotifyIcon1.ShowBalloonTip(1000, "HIP Service", "โปรแกรมทำงานใน Background", ToolTipIcon.Info)
    '    End If
    'End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' เปิดโปรแกรม
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' ปิดโปรแกรม
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub
    ' ── Timer1: กดปุ่ม Open หลัง Load เสร็จ 5 วินาที ─────────────
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()           ' ยิงครั้งเดียวพอ
        cmdOpenComm.PerformClick()

        ' Timer2: รอเช็คว่า connect สำเร็จทุก 2 วินาที แล้วกดปุ่ม Log Data
        Timer2.Interval = 2000
        Timer2.Start()
    End Sub

    ' ── Timer2: รอ Connect สำเร็จ แล้วกดปุ่ม Log Data ───────────
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If gbOpenFlag Then      ' connect สำเร็จแล้ว
            Timer2.Stop()
            cmdLogData.PerformClick()
        End If
        ' ถ้ายังไม่ได้ก็รอ Tick ต่อไป
    End Sub

    ' ── ซ่อนหน้าต่างไปอยู่ใน Tray ──────────────────────────────
    Private Sub HideToTray(Optional msg As String = "โปรแกรมทำงานอยู่ใน Background")
        Me.Hide()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.ShowBalloonTip(2000, "HIP Face Scan", msg, ToolTipIcon.Info)
    End Sub

End Class