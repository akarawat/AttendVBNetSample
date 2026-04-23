Imports System.Windows.Forms
Imports System.Drawing

' ============================================================
'  SysTrayHelper.vb
'  Partial class ของ frmMain — เพิ่มไฟล์นี้เข้า project โดยตรง
'  ไม่ต้องแก้ไข frmMain.vb เดิม (ยกเว้นเพิ่ม 2 บรรทัดใน Form_Load)
' ============================================================

Partial Public Class frmMain

    ' ── Tray Controls ─────────────────────────────────────────
    Private WithEvents TrayIcon    As New NotifyIcon()
    Private WithEvents TrayMenu    As New ContextMenuStrip()
    Private WithEvents mnuShow     As New ToolStripMenuItem("เปิดหน้าต่าง")
    Private WithEvents mnuLog      As New ToolStripMenuItem("ดู Log การสแกน")
    Private WithEvents mnuSep      As New ToolStripSeparator()
    Private WithEvents mnuExit     As New ToolStripMenuItem("ออกจากโปรแกรม")

    ' ── Flag: true = user กด X จริง (ผ่าน menu Exit เท่านั้น) ─
    Private _forceExit As Boolean = False

    ' ============================================================
    '  เรียก InitTray() ต่อท้ายใน frmMain_Load()
    '  ตัวอย่าง:
    '      Private Sub frmMain_Load(...) Handles MyBase.Load
    '          ' ... โค้ดเดิม ...
    '          InitTray()       ' <-- เพิ่มบรรทัดนี้
    '      End Sub
    ' ============================================================
    Public Sub InitTray()
        ' --- Icon: ใช้ icon ของ Form (หรือใส่ New Icon("path\hip.ico")) ---
        TrayIcon.Icon = If(Me.Icon IsNot Nothing, Me.Icon,
                           SystemIcons.Application)
        TrayIcon.Text    = "HIP Face Scan — กำลังทำงาน"
        TrayIcon.Visible = True

        ' --- Context menu ---
        mnuShow.Font = New Font(mnuShow.Font, FontStyle.Bold)  ' default action
        TrayMenu.Items.AddRange({mnuShow, mnuLog, mnuSep, mnuExit})
        TrayIcon.ContextMenuStrip = TrayMenu
    End Sub

    ' ============================================================
    '  Minimize → ซ่อน Form, แสดง Tray
    ' ============================================================
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) _
        Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            HideToTray()
        End If
    End Sub

    ' ============================================================
    '  กด X → ซ่อน Form (ไม่ปิดโปรแกรม)
    '  ถ้าต้องการปิดจริง ให้เลือก "ออกจากโปรแกรม" ใน tray menu
    ' ============================================================
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles MyBase.FormClosing

        If _forceExit OrElse e.CloseReason = CloseReason.WindowsShutDown Then
            TrayIcon.Visible = False
            TrayIcon.Dispose()
        Else
            e.Cancel = True
            HideToTray()
        End If
    End Sub

    ' ── ซ่อน + แสดง Balloon ──────────────────────────────────
    Private Sub HideToTray()
        Me.Hide()
        Me.WindowState = FormWindowState.Normal   ' reset ไว้ตอน restore
        TrayIcon.ShowBalloonTip(
            timeout  := 3000,
            tipTitle := "HIP Face Scan",
            tipText  := "โปรแกรมยังทำงานอยู่เบื้องหลัง" & vbCrLf &
                        "ดับเบิ้ลคลิก icon เพื่อเปิดหน้าต่าง",
            tipIcon  := ToolTipIcon.Info)
    End Sub

    ' ── Restore window ───────────────────────────────────────
    Private Sub RestoreWindow()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
        Me.BringToFront()
    End Sub

    ' ============================================================
    '  Tray Icon Events
    ' ============================================================
    Private Sub TrayIcon_DoubleClick(sender As Object, e As EventArgs) _
        Handles TrayIcon.DoubleClick
        RestoreWindow()
    End Sub

    Private Sub mnuShow_Click(sender As Object, e As EventArgs) _
        Handles mnuShow.Click
        RestoreWindow()
    End Sub

    Private Sub mnuLog_Click(sender As Object, e As EventArgs) _
        Handles mnuLog.Click
        RestoreWindow()
        ' เปิด frmLog ถ้ายังไม่เปิด — ปรับชื่อ instance ให้ตรง project ของคุณ
        Dim logFrm As frmLog = Application.OpenForms.OfType(Of frmLog)().FirstOrDefault()
        If logFrm Is Nothing Then
            logFrm = New frmLog()
            logFrm.Show(Me)
        Else
            logFrm.BringToFront()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) _
        Handles mnuExit.Click
        Dim ans = MessageBox.Show(
            "ต้องการออกจากโปรแกรมจริงหรือไม่?" & vbCrLf &
            "การสแกนใบหน้าจะหยุดทำงาน",
            "ยืนยันการออก",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then
            _forceExit = True
            Application.Exit()
        End If
    End Sub

    ' ============================================================
    '  NotifyScan() — เรียกจาก frmLog หลัง SP_InsertAttendanceLog สำเร็จ
    '  ตัวอย่าง: frmMain.Instance.NotifyScan("สมชาย ใจดี", "08:32:15")
    ' ============================================================
    Public Sub NotifyScan(employeeName As String, scanTime As String)
        TrayIcon.ShowBalloonTip(
            timeout  := 4000,
            tipTitle := "สแกนใบหน้าสำเร็จ ✓",
            tipText  := $"{employeeName}" & vbCrLf & $"เวลา {scanTime}",
            tipIcon  := ToolTipIcon.Info)
    End Sub

End Class
