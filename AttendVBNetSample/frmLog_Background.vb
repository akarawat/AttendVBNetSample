' ============================================================
'  frmLog_Background.vb  — Partial class ของ frmLog
'  ทำให้ frmLog ทำงานเป็น background เมื่อ minimize หรือกด X
'  เพิ่มไฟล์นี้เข้า Project โดยตรง
' ============================================================

Partial Public Class frmLog

    ' ── Flag สำหรับปิดจริง (เรียกจาก frmMain เท่านั้น) ─────
    Friend _forceClose As Boolean = False

    ' ============================================================
    '  Minimize → ซ่อนไปทำงาน background
    '  ไม่แสดงใน Taskbar ระหว่างซ่อน
    ' ============================================================
    Private Sub frmLog_Resize(sender As Object, e As EventArgs) _
        Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            HideLogToBackground()
        End If
    End Sub

    ' ============================================================
    '  กด X → ไม่ปิด แค่ซ่อน (Monitor ยังทำงานต่อ)
    ' ============================================================
    Private Sub frmLog_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles MyBase.FormClosing

        If _forceClose OrElse e.CloseReason = CloseReason.WindowsShutDown Then
            Return   ' ปิดจริง
        End If

        e.Cancel = True
        HideLogToBackground()
    End Sub

    ' ── ซ่อน frmLog + แจ้ง tray ──────────────────────────────
    Private Sub HideLogToBackground()
        Me.Hide()
        Me.WindowState = FormWindowState.Normal   ' reset ไว้ตอน restore

        ' แจ้ง tray icon ของ frmMain ว่ากำลัง monitor อยู่
        Dim main = Application.OpenForms.OfType(Of frmMain)().FirstOrDefault()
        If main IsNot Nothing Then
            main.TrayIcon.ShowBalloonTip(
                3000,
                "HIP Face Scan — Monitor ทำงานอยู่",
                "กำลังรับข้อมูลการสแกนใบหน้าอยู่เบื้องหลัง" & vbCrLf &
                "คลิกขวา Tray Icon → ""ดู Log การสแกน"" เพื่อเปิดหน้าต่าง",
                ToolTipIcon.Info)
            main.TrayIcon.Text = "HIP Face Scan — Monitor ทำงานอยู่ 🟢"
        End If
    End Sub

    ' ============================================================
    '  RestoreLog() — เรียกจาก tray menu "ดู Log การสแกน"
    '  ใน SysTrayHelper.vb ปรับ mnuLog_Click เป็นแบบนี้:
    '
    '      Private Sub mnuLog_Click(...) Handles mnuLog.Click
    '          RestoreFromTray()
    '      End Sub
    ' ============================================================
    Friend Sub RestoreLog()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Activate()
        Me.BringToFront()
    End Sub

End Class
