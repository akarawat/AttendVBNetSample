Imports Newtonsoft.Json
Public Class frmUserTimeGroup
    Dim NetClass As NetworkingClass

    Private Class DeviceResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
    End Class

    Private Class TimeGroupsDataModel
        Public Property sun As String()
        Public Property mon As String()
        Public Property tue As String()
        Public Property wed As String()
        Public Property thu As String()
        Public Property fri As String()
        Public Property sat As String()
    End Class

    Private Class UsersTimeGroupsDataModel
        Public Property usersId As String()
        Public Property timeGroups As TimeGroupsDataModel
    End Class

    Private Class UsersTimeGroupsModel
        Public Property cmd As String
        Public Property data As UsersTimeGroupsDataModel
    End Class

    Private Sub frmUserTimeGroup_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Visible = True
    End Sub

    Private Function GetValueFromGrid(row As Integer, ByRef col As Integer) As String
        Dim strGridValue As String
        Dim strNewValue As String
        strGridValue = MSFlexGridUserGroupTime.Rows(row).Cells(col).Value
        strNewValue = Replace(strGridValue, ":", "")
        strNewValue = Replace(strNewValue, "-", "")
        Return strNewValue
    End Function

    Private Sub cmdSetUsersTimeGroup_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetUsersTimeGroup.Click
        lblStatus.Text = "Working..."
        cmdSetUsersTimeGroup.Enabled = False

        Dim i As Integer

        Dim cmdRoot As New UsersTimeGroupsModel()
        cmdRoot.cmd = "SetUsersTimeGroups"

        Dim cmdData As New UsersTimeGroupsDataModel()

        Dim strUserIDs As String
        strUserIDs = txtUserIDs.Text

        Dim usersID As String()
        usersID = strUserIDs.Split(","c)

        cmdData.usersId = usersID

        Dim cmdTimesGroup As New TimeGroupsDataModel()
        
        'Sunday Period
        Dim sunPeriods(5) As String
        For i = 1 To 6
            sunPeriods.SetValue(GetValueFromGrid(0, i), i - 1)
        Next i
        cmdTimesGroup.sun = sunPeriods

        'Monday Period
        Dim monPeriods(5) As String
        For i = 1 To 6
            monPeriods.SetValue(GetValueFromGrid(1, i), i - 1)
        Next i
        cmdTimesGroup.mon = monPeriods

        'Tuesday Period
        Dim tuePeriods(5) As String
        For i = 1 To 6
            tuePeriods.SetValue(GetValueFromGrid(2, i), i - 1)
        Next i
        cmdTimesGroup.tue = tuePeriods

        'Wednsday Period
        Dim wedPeriods(5) As String
        For i = 1 To 6
            wedPeriods.SetValue(GetValueFromGrid(3, i), i - 1)
        Next i
        cmdTimesGroup.wed = wedPeriods

        'Thursday Period
        Dim thuPeriods(5) As String
        For i = 1 To 6
            thuPeriods.SetValue(GetValueFromGrid(4, i), i - 1)
        Next i
        cmdTimesGroup.thu = thuPeriods

        'Friday Period
        Dim friPeriods(5) As String
        For i = 1 To 6
            friPeriods.SetValue(GetValueFromGrid(5, i), i - 1)
        Next i
        cmdTimesGroup.fri = friPeriods

        'Saturday Period
        Dim satPeriods(5) As String
        For i = 1 To 6
            satPeriods.SetValue(GetValueFromGrid(6, i), i - 1)
        Next i
        cmdTimesGroup.sat = satPeriods

        cmdData.timeGroups = cmdTimesGroup

        cmdRoot.data = cmdData

        Dim commandJson As String
        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
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

        lblStatus.Text = ReturnResultString(result_code)
        cmdSetUsersTimeGroup.Enabled = True
        Exit Sub

Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdSetUsersTimeGroup.Enabled = True
    End Sub

    Private Sub frmUserTimeGroup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NetClass = NetworkingModule.GetNetworkingClassInstance()

        MSFlexGridUserGroupTime.RowCount = 8
        MSFlexGridUserGroupTime.ColumnCount = 7
        MSFlexGridUserGroupTime.Columns(0).Name = "WeekDay"
        MSFlexGridUserGroupTime.Columns(1).Name = "Period1"
        MSFlexGridUserGroupTime.Columns(2).Name = "Period2"
        MSFlexGridUserGroupTime.Columns(3).Name = "Period3"
        MSFlexGridUserGroupTime.Columns(4).Name = "Period4"
        MSFlexGridUserGroupTime.Columns(5).Name = "Period5"
        MSFlexGridUserGroupTime.Columns(6).Name = "Period6"
        
        MSFlexGridUserGroupTime.Rows(0).Cells(0).Value = "Sunday"
        MSFlexGridUserGroupTime.Rows(1).Cells(0).Value = "Monday"
        MSFlexGridUserGroupTime.Rows(2).Cells(0).Value = "Tuesday"
        MSFlexGridUserGroupTime.Rows(3).Cells(0).Value = "Wednsday"
        MSFlexGridUserGroupTime.Rows(4).Cells(0).Value = "Thursday"
        MSFlexGridUserGroupTime.Rows(5).Cells(0).Value = "Friday"
        MSFlexGridUserGroupTime.Rows(6).Cells(0).Value = "Saturday"


        For i = 0 To 6
            MSFlexGridUserGroupTime.Rows(i).Cells(1).Value = "00:00-23:59"
            MSFlexGridUserGroupTime.Rows(i).Cells(2).Value = "00:00-00:00"
            MSFlexGridUserGroupTime.Rows(i).Cells(3).Value = "00:00-00:00"
            MSFlexGridUserGroupTime.Rows(i).Cells(4).Value = "00:00-00:00"
            MSFlexGridUserGroupTime.Rows(i).Cells(5).Value = "00:00-00:00"
            MSFlexGridUserGroupTime.Rows(i).Cells(6).Value = "00:00-00:00"
        Next i
    End Sub


    Private Sub MSFlexGridUserGroupTime_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MSFlexGridUserGroupTime.CellMouseDoubleClick
        If MSFlexGridUserGroupTime.SelectedCells.Count > 0 Then
            ' Handle the DblClick event
            Dim newValue As String
            Dim rowIndex As Integer = MSFlexGridUserGroupTime.SelectedCells(0).RowIndex
            Dim columnIndex As Integer = MSFlexGridUserGroupTime.SelectedCells(0).ColumnIndex

            newValue = InputBox("Enter new value:", "Edit Cell", MSFlexGridUserGroupTime.Rows(rowIndex).Cells(columnIndex).Value)
            If (newValue <> "") Then
                MSFlexGridUserGroupTime.Rows(rowIndex).Cells(columnIndex).Value = newValue
            End If
        End If
    End Sub

    Private Sub MSFlexGridUserGroupTime_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSFlexGridUserGroupTime.CellContentClick

    End Sub
End Class