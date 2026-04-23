' ============================================================
'  frmLog_Changes.vb  — ส่วนที่ต้องแก้ใน frmLog.vb เดิม
'
'  สิ่งที่ต้องเพิ่ม/แก้ไขใน frmLog.vb:
'
'  1.  เพิ่ม Singleton reference ของ frmMain (หรือส่งผ่าน Constructor)
'  2.  หลังจาก SP_InsertAttendanceLog สำเร็จ → เรียก NotifyScan()
' ============================================================

' ── ตัวอย่าง Sub ที่แก้ใน frmLog.vb ────────────────────────────────────────
'
'  *** ค้นหา Sub ที่เรียก SP_InsertAttendanceLog แล้วเพิ่มโค้ดต่อท้าย ***

Partial Public Class frmLog

    ' ----------------------------------------------------------------
    '  หา frmMain instance จาก OpenForms (ไม่ต้องแก้ frmMain เดิม)
    ' ----------------------------------------------------------------
    Private ReadOnly Property MainForm As frmMain
        Get
            Return Application.OpenForms.OfType(Of frmMain)().FirstOrDefault()
        End Get
    End Property

    ' ----------------------------------------------------------------
    '  ตัวอย่าง: Sub ที่บันทึก Attendance Log (แก้ให้ตรงกับ Sub เดิมของคุณ)
    '
    '  *** นำโค้ดส่วน "หลัง SP สำเร็จ" ไปใส่ต่อจาก Execute SP เดิม ***
    ' ----------------------------------------------------------------
    Private Sub SaveAttendanceLog_Example(employeeName As String,
                                          employeeId   As String,
                                          scanTime     As DateTime)

        ' ── โค้ดเดิมของคุณ: เรียก SP_InsertAttendanceLog ────────────────
        '
        '   Using conn As New SqlConnection(connectionString)
        '       conn.Open()
        '       Using cmd As New SqlCommand("SP_InsertAttendanceLog", conn)
        '           cmd.CommandType = CommandType.StoredProcedure
        '           cmd.Parameters.AddWithValue("@EmployeeId", employeeId)
        '           cmd.Parameters.AddWithValue("@ScanTime",   scanTime)
        '           cmd.ExecuteNonQuery()
        '       End Using
        '   End Using
        '
        ' ── เพิ่มโค้ดด้านล่างหลัง SP execute สำเร็จ ─────────────────────

        ' แสดง Balloon Tip ใน Tray Icon
        If MainForm IsNot Nothing Then
            MainForm.NotifyScan(
                employeeName := employeeName,
                scanTime     := scanTime.ToString("HH:mm:ss"))
        End If

        ' (Optional) อัปเดต Label/Grid ใน frmLog ด้วย
        ' lblLastScan.Text = $"ล่าสุด: {employeeName} — {scanTime:HH:mm:ss}"

    End Sub

End Class
