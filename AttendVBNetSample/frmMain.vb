Imports System.Configuration
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Public Class frmMain
    Public gbOpenFlag As Boolean
    Public gnCommHandleIndex As Long
    Dim NetClass As NetworkingClass


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
        ' *** Single Instance Check ***
        If IsProcessAlreadyRunning("BTKiOSFaceScan") Then
            MessageBox.Show("โปรแกรม BTKiOSFaceScan กำลังทำงานอยู่แล้ว!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        Else
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

                ' Auto Connect
                Call cmdOpenComm.PerformClick()
                Call cmdLogData.PerformClick()
            End If
        End If

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

        gnCommHandleIndex = NetClass.ConnectToServer(vpszIPAddress, vpszNetPort, vnTimeOut)

        If gnCommHandleIndex = 0 Then
            gbOpenFlag = True
            OwnerEnableButtons(True)
        Else
            MsgBox("Connect Fail")
            cmdOpenComm.Enabled = True
        End If
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

End Class

