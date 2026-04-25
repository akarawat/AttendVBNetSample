' ============================================================
'  frmMain_ButtonFlow.vb  — Partial class ของ frmMain
'  จัดการปุ่ม cmdOpenComm (เชื่อม HIP) และ cmdLogData (เปิด frmLog)
'  เพิ่มไฟล์นี้เข้า Project โดยตรง
' ============================================================

Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

Partial Public Class frmMain

    ' ── อ้างอิง frmLog instance เดียวตลอด session ─────────────
    Private _logForm As frmLog = Nothing

    ' ============================================================
    '  cmdOpenComm_Click — เชื่อมต่อ HIP device
    ' ============================================================
    Private Async Sub cmdOpenComm_Click(sender As Object, e As EventArgs) _
        Handles cmdOpenComm.Click

        cmdOpenComm.Enabled = False
        cmdLogData.Enabled = False
        SetStatus("กำลังเชื่อมต่อเครื่อง HIP…", busy:=True)

        Try
            ' ── โค้ดเดิมที่ Open/Connect HIP ─────────────────────
            ' (ย้ายหรือ call Sub เดิมของคุณที่เชื่อม HIP ตรงนี้)
            ' ตัวอย่าง: Await Task.Run(Sub() ConnectHIP())

            ' รอให้เครื่องพร้อม (ปรับเวลาตามความเหมาะสม)
            Await Task.Delay(2000)

            ' ── เปิดใช้ปุ่ม Log Data หลัง connect สำเร็จ ─────────
            cmdLogData.Enabled = True
            SetStatus("เชื่อมต่อสำเร็จ — กด Log Data เพื่อเริ่ม Monitor", busy:=False)

            TrayIcon.ShowBalloonTip(3000, "HIP Face Scan",
                "เชื่อมต่อเครื่องสำเร็จ พร้อมรับข้อมูลแล้ว",
                ToolTipIcon.Info)

        Catch ex As Exception
            cmdOpenComm.Enabled = True
            SetStatus($"เชื่อมต่อไม่สำเร็จ: {ex.Message}", busy:=False)
        End Try
    End Sub

    ' ============================================================
    '  cmdLogData_Click — เปิด frmLog และซ่อน frmMain
    ' ============================================================
    Private Sub cmdLogData_Click(sender As Object, e As EventArgs) _
        Handles cmdLogData.Click

        ' สร้าง instance ใหม่เฉพาะครั้งแรก หรือถ้าถูก dispose ไปแล้ว
        If _logForm Is Nothing OrElse _logForm.IsDisposed Then
            _logForm = New frmLog()
        End If

        ' แสดง frmLog
        _logForm.Show()
        _logForm.WindowState = FormWindowState.Normal
        _logForm.Activate()

        ' ── ซ่อน frmMain ไปอยู่ใน Tray ────────────────────────
        HideToTray()

        ' อัปเดต tray tooltip
        TrayIcon.Text = "HIP Face Scan — กำลัง Monitor…"
    End Sub

    ' ── Helper: แสดงสถานะบน Label (ปรับชื่อ Label ให้ตรง) ─────
    Private Sub SetStatus(msg As String, busy As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() SetStatus(msg, busy))
            Return
        End If
        ' สมมุติ Label ชื่อ lblStatus และ ProgressBar ชื่อ pbBusy
        ' ปรับชื่อตาม UI จริงของคุณ
        Try
            'lblStatus.Text = msg
            'pbBusy.Visible = busy
        Catch
            ' ถ้าไม่มี control พวกนี้ก็ข้ามไป
        End Try
    End Sub

End Class