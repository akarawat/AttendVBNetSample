' ============================================================
'  SysTrayHelper_Update.vb — แก้เฉพาะ mnuLog_Click
'  ใน SysTrayHelper.vb เดิม ให้แทนที่ Sub mnuLog_Click ด้วยนี้
' ============================================================

'   *** แทนที่ Sub mnuLog_Click เดิมใน SysTrayHelper.vb ***
'
'    Private Sub mnuLog_Click(sender As Object, e As EventArgs) _
'        Handles mnuLog.Click
'
'        RestoreWindow()   ' เปิด frmMain กลับมาด้วยถ้าต้องการ (optional)
'
'        ' หา frmLog instance ที่รันอยู่ (ถูกซ่อนอยู่ใน background)
'        Dim logFrm As frmLog = Application.OpenForms.OfType(Of frmLog)().FirstOrDefault()
'
'        If logFrm IsNot Nothing Then
'            logFrm.RestoreLog()          ' ใช้ method ใน frmLog_Background.vb
'        Else
'            ' frmLog ยังไม่เคยเปิด → บอกให้กลับไปกด Log Data ก่อน
'            MessageBox.Show(
'                "กรุณาเปิดโปรแกรมและกดปุ่ม Log Data ก่อนนะคะ",
'                "HIP Face Scan",
'                MessageBoxButtons.OK,
'                MessageBoxIcon.Information)
'            RestoreWindow()
'        End If
'    End Sub
