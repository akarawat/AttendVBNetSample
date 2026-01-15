Imports Newtonsoft.Json
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Globalization


Public Class frmUserInfo
    Dim NetClass As NetworkingClass
    Dim AdoConn As New OleDbConnection
    Dim AdoCmd As New OleDbCommand()
    
    Private Class DeviceResponseModel
        Public Property cmd As String
        Public Property result_code As Integer
    End Class

    Private Class DeleteUserDataModel
        Public Property usersCount As Integer
        Public Property usersId As String()
    End Class

    Private Class DeleteUserModel
        Public Property cmd As String
        Public Property data As DeleteUserDataModel
    End Class
    '--------------------------------------------------------------
    Private Class GetUserIdListDataModel
        Public Property packageId As Integer
    End Class

    Private Class GetUserIdListModel
        Public Property cmd As String
        Public Property data As GetUserIdListDataModel
    End Class

    Private Class UserIDNameModel
        Public Property userId As String
        Public Property name As String
    End Class

    Private Class GetUserIdListResponseDataModel
        Public Property packageId As Integer
        Public Property usersCount As Integer
        Public Property users As UserIDNameModel()
    End Class

    Private Class GetUserIdListResponseModel
        Public Property cmd As String
        Public Property result_code As String
        Public Property result_data As GetUserIdListResponseDataModel
    End Class
    '--------------------------------------------------------------


    Private Class GetUserInfoDataModel
        Public Property packageId As Integer
        Public Property usersId As String()
    End Class

    Private Class GetUserInfoModel
        Public Property cmd As String
        Public Property data As GetUserInfoDataModel
    End Class

    Private Class UserInfoModel
        Public Property userId As String
        Public Property name As String
        Public Property privilege As Integer
        Public Property card As String
        Public Property pwd As String
        Public Property fps As String()
        Public Property face As String
        Public Property palm As String
        Public Property photo As String
        Public Property vaildStart As String
        Public Property vaildEnd As String
    End Class

    Private Class GetUserInfoResponseDataModel
        Public Property packageId As Integer
        Public Property usersCount As Integer
        Public Property users As UserInfoModel()
    End Class

    Private Class GetUserInfoResponseModel
        Public Property cmd As String
        Public Property result_code As String
        Public Property result_data As GetUserInfoResponseDataModel
    End Class

    Private Class UserModel
        Public Property userId As String
        Public Property name As String
        Public Property privilege As Integer
        Public Property card As String
        Public Property pwd As String
        Public Property fps As String()
        Public Property face As String
        Public Property palm As String
        Public Property photo As String
        Public Property vaildStart As String
        Public Property vaildEnd As String
        Public Property update As Integer
        Public Property photoEnroll As Integer
    End Class

    Private Class SetUserInfoDataModel
        Public Property users As UserModel()
    End Class

    Private Class SetUserInfoModel
        Public Property cmd As String
        Public Property data As SetUserInfoDataModel
    End Class


    Private Sub frmUserInfo_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Visible = True
        If AdoConn.State = ConnectionState.Open Then
             AdoConn.Close()
        End If
    End Sub

    Private Sub cmdDeleteUserInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeleteUserInfo.Click
        lblStatus.Text = "Working..."
        cmdDeleteUserInfo.Enabled = False

        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New DeleteUserModel()
        cmdRoot.cmd = "DeleteUserInfo"

        Dim cmdData As New DeleteUserDataModel()
        Dim strUserIDs As String
        strUserIDs = txtUserIDs.Text

        Dim usersID As String()
        usersID = strUserIDs.Split(","c)

        Dim nUserCount As Integer
        nUserCount = usersID.Length

        cmdData.usersCount = nUserCount
        cmdData.usersId = usersID
        cmdRoot.data = cmdData

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

        cmdDeleteUserInfo.Enabled = True
    End Sub

    Private Sub frmUserInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NetClass = NetworkingModule.GetNetworkingClassInstance()

        MSFlexGridUsersList.ColumnCount = 11
        MSFlexGridUsersList.Columns(0).Name = USER_ID
        MSFlexGridUsersList.Columns(1).Name = USER_NAME
        MSFlexGridUsersList.Columns(2).Name = USER_PRIVILEGE
        MSFlexGridUsersList.Columns(3).Name = USER_CARD
        MSFlexGridUsersList.Columns(4).Name = USER_PASSWORD
        MSFlexGridUsersList.Columns(5).Name = USER_FPS
        MSFlexGridUsersList.Columns(6).Name = USER_FACE
        MSFlexGridUsersList.Columns(7).Name = USER_PALM
        MSFlexGridUsersList.Columns(8).Name = USER_PHOTO
        MSFlexGridUsersList.Columns(9).Name = USER_VAILDSTART
        MSFlexGridUsersList.Columns(10).Name = USER_VAILDEND

        
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Attend.mdb;"
        AdoConn = New OleDbConnection(connectionString)
        Try
            AdoConn.Open()
            ' Connection is open, perform database operations here
        Catch ex As Exception
            ' Handle exception
        Finally
            'AdoConn.Close()
        End Try
    End Sub

    Private Sub cmdUserIDList_Click(sender As System.Object, e As System.EventArgs) Handles cmdUserIDList.Click
        lblStatus.Text = "Working..."
        cmdUserIDList.Enabled = False

        Image1.Image = Nothing
        MSFlexGridUsersList.Rows.Clear()

        Dim nCmdPackageId As Integer
        nCmdPackageId = 0

SubRecev:
        Dim nRetryCount As Integer
Retry:
        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New GetUserIdListModel()
        cmdRoot.cmd = "GetUserIdList"

        'Make Command Data
        Dim cmdData As New GetUserIdListDataModel()

        cmdData.packageId = nCmdPackageId
        cmdRoot.data = cmdData

        'Convert JSON String
        commandJson = JsonConvert.SerializeObject(cmdRoot)

        ' Send JSON command to the server
        Dim nRet As Integer
        nRet = NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        'Get Result
        Dim objResult As GetUserIdListResponseModel = JsonConvert.DeserializeObject(Of GetUserIdListResponseModel)(resultStr)

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
            Dim usersCount As Integer
            usersCount = objResult.result_data.usersCount
            txtUsersCount.Text = usersCount

            MSFlexGridUsersList.RowCount = usersCount

            For i = 0 To usersCount - 1
                MSFlexGridUsersList.Rows(i).Cells(0).Value = objResult.result_data.users(i).userId
                MSFlexGridUsersList.Rows(i).Cells(1).Value = objResult.result_data.users(i).name
            Next i

            Dim packageId As Integer
            packageId = objResult.result_data.packageId
            If packageId <> 0 Then
                nCmdPackageId = nCmdPackageId + 1
                GoTo SubRecev
            End If
        End If
        lblStatus.Text = ReturnResultString(result_code)
        cmdUserIDList.Enabled = True
        Exit Sub
Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdUserIDList.Enabled = True
    End Sub


    Private Sub FuncSaveToDB(strUserID As String, strUserName As String, nPrivilege As Integer, strCard As String, strPwd As String, _
                        strFace As String, strPalm As String, strPhoto As String, strVaildStart As String, strVaildEnd As String, _
                        strFp1 As String, strFp2 As String, strFp3 As String, strFp4 As String, strFp5 As String, _
                        strFp6 As String, strFp7 As String, strFp8 As String, strFp9 As String, strFp10 As String)

        Dim strSelectSQL As String
        strSelectSQL = "SELECT * FROM tblUser Where userId = '" & strUserID & "'"

        AdoCmd = New OleDbCommand(strSelectSQL, AdoConn)
        Dim AdoUser As OleDbDataReader = AdoCmd.ExecuteReader()

        If AdoUser.HasRows = True Then
            Try
                Dim updateQuery As String = "UPDATE tblUser SET " &
                    USER_NAME & " = '" & strUserName & "', " &
                    USER_PRIVILEGE & " = " & nPrivilege & ", " &
                    USER_CARD & " = '" & strCard & "', " &
                    USER_PASSWORD & " = '" & strPwd & "', " &
                    USER_FACE & " = '" & strFace & "', " &
                    USER_PALM & " = '" & strPalm & "', " &
                    USER_PHOTO & " = '" & strPhoto & "', " &
                    USER_VAILDSTART & " = '" & strVaildStart & "', " &
                    USER_VAILDEND & " = '" & strVaildEnd & "', " &
                    USER_FP1 & " = '" & strFp1 & "', " &
                    USER_FP2 & " = '" & strFp2 & "', " &
                    USER_FP3 & " = '" & strFp3 & "', " &
                    USER_FP4 & " = '" & strFp4 & "', " &
                    USER_FP5 & " = '" & strFp5 & "', " &
                    USER_FP6 & " = '" & strFp6 & "', " &
                    USER_FP7 & " = '" & strFp7 & "', " &
                    USER_FP8 & " = '" & strFp8 & "', " &
                    USER_FP9 & " = '" & strFp9 & "', " &
                    USER_FP10 & " = '" & strFp10 & "', " &
                    " Where " & USER_ID & " = '" & strUserID & "'"

                AdoCmd = New OleDbCommand(updateQuery, AdoConn)
                AdoCmd.ExecuteNonQuery()

                Console.WriteLine("User updated successfully.")
            Catch ex As Exception
                Console.WriteLine("Error updating user: " & ex.Message)
            Finally
                'CloseConnection()
            End Try
        Else
            Try
                Dim insertQuery As String = "INSERT INTO tblUser (" &
                    USER_ID & ", " & USER_NAME & ", " & USER_PRIVILEGE & ", " & USER_CARD & ", " & USER_PASSWORD & ", " & USER_FACE & ", " & USER_PALM & ", " & USER_PHOTO & ", " & USER_VAILDSTART & ", " & USER_VAILDEND & ", " &
                    USER_FP1 & ", " & USER_FP2 & ", " & USER_FP3 & ", " & USER_FP4 & ", " & USER_FP5 & ", " & USER_FP6 & ", " & USER_FP7 & ", " & USER_FP8 & ", " & USER_FP9 & ", " & USER_FP10 &
                    ") VALUES ( " &
                    "'" & strUserID & "', '" & strUserName & "'," & nPrivilege & ", '" & strCard & "','" & strPwd &
                    "', '" & strFace & "','" & strPalm & "', '" & strPhoto & "','" & strVaildStart & "', '" & strVaildEnd &
                    "', '" & strFp1 & "','" & strFp2 & "', '" & strFp3 & "','" & strFp4 & "', '" & strFp5 &
                    "', '" & strFp6 & "', '" & strFp7 & "','" & strFp8 & "', '" & strFp9 & "', '" & strFp10 & "')"

                AdoCmd = New OleDbCommand(insertQuery, AdoConn)
                AdoCmd.ExecuteNonQuery()

                Console.WriteLine("User added successfully.")
            Catch ex As Exception
                Console.WriteLine("Error adding user: " & ex.Message)
            Finally
                'CloseConnection()
            End Try
        End If
    End Sub

    Private Sub ShowUserListToGridView(nIndex As Integer, strUserID As String, strUserName As String, nPrivilege As Integer, strCard As String, strPwd As String, _
                            fpsCount As Integer, faceCount As Integer, palmCount As Integer, photoCount As Integer, strVaildStart As String, strVaildEnd As String)

        MSFlexGridUsersList.Rows(nIndex).Cells(0).Value = strUserID
        MSFlexGridUsersList.Rows(nIndex).Cells(1).Value = strUserName
        MSFlexGridUsersList.Rows(nIndex).Cells(2).Value = nPrivilege
        MSFlexGridUsersList.Rows(nIndex).Cells(3).Value = strCard
        MSFlexGridUsersList.Rows(nIndex).Cells(4).Value = strPwd
        MSFlexGridUsersList.Rows(nIndex).Cells(5).Value = fpsCount
        MSFlexGridUsersList.Rows(nIndex).Cells(6).Value = faceCount
        MSFlexGridUsersList.Rows(nIndex).Cells(7).Value = palmCount
        MSFlexGridUsersList.Rows(nIndex).Cells(8).Value = photoCount

        strVaildStart = strVaildStart.Substring(0, 4) & "-" & Mid(strVaildStart, 4, 2) & "-" & strVaildStart.Substring(6, 2)
        strVaildEnd = strVaildEnd.Substring(0, 4) & "-" & Mid(strVaildEnd, 4, 2) & "-" & strVaildEnd.Substring(6, 2)

        MSFlexGridUsersList.Rows(nIndex).Cells(9).Value = strVaildStart
        MSFlexGridUsersList.Rows(nIndex).Cells(10).Value = strVaildEnd

    End Sub

    Private Sub cmdGetUserInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdGetUserInfo.Click

        Image1.Image = Nothing
        MSFlexGridUsersList.Rows.Clear()

        lblStatus.Text = "Working..."
        cmdGetUserInfo.Enabled = False

        Dim nCmdPackageId As Integer
        Dim nAllUserInx As Integer
        nCmdPackageId = 0

        Dim strUserIDs As String
        strUserIDs = txtUserIDs.Text

        Dim usersID As String()
        usersID = strUserIDs.Split(","c)

        Dim nUserCount As Integer
        nUserCount = usersID.Length

        If nUserCount <= 0 Then
            GoTo Err
        End If

        MSFlexGridUsersList.RowCount = nUserCount

SubRecev:

        Dim nRetryCount As Integer
        Dim commandJson As String
        Dim resultStr As String

        Dim cmdRoot As New GetUserInfoModel()
        cmdRoot.cmd = "GetUserInfo"

        Dim cmdData As New GetUserInfoDataModel()

        cmdData.packageId = nCmdPackageId

        cmdData.usersId = usersID
        cmdRoot.data = cmdData

        commandJson = JsonConvert.SerializeObject(cmdRoot)

Retry:
        ' Send JSON command to the server
        NetClass.SendCommand(commandJson)
        resultStr = NetClass.ReceiveData()

        Dim objResult As GetUserInfoResponseModel
        Try
            objResult = JsonConvert.DeserializeObject(Of GetUserInfoResponseModel)(resultStr)

            If resultStr = "" Or objResult Is Nothing Then
                nRetryCount = nRetryCount + 1
                If nRetryCount = RETRY_COUNT Then
                    GoTo Err
                Else
                    NetClass.ReConnect()
                    GoTo Retry
                End If
            End If
        Catch ex As Exception
            nRetryCount = nRetryCount + 1
            If nRetryCount = RETRY_COUNT Then
                GoTo Err
            Else
                NetClass.ReConnect()
                GoTo Retry
            End If
        End Try


        Dim result_code As Integer
        result_code = objResult.result_code

        If result_code = 0 Then
            Dim usersCount As Integer
            usersCount = objResult.result_data.usersCount

            Dim userIndex As Integer
            For userIndex = 0 To usersCount - 1
                Dim strUserID As String
                Dim strUserName As String
                Dim nPrivilege As Integer
                Dim strCard As String
                Dim strPwd As String
                Dim strVaildStart As String
                Dim strVaildEnd As String

                Dim strFp1 As String
                Dim strFp2 As String
                Dim strFp3 As String
                Dim strFp4 As String
                Dim strFp5 As String
                Dim strFp6 As String
                Dim strFp7 As String
                Dim strFp8 As String
                Dim strFp9 As String
                Dim strFp10 As String

                Dim timesGroup As Object
                Dim strFace As String
                Dim strPalm As String
                Dim strPhoto As String

                Dim fpsCount As Integer
                Dim faceCount As Integer
                Dim palmCount As Integer
                Dim photoCount As Integer

                strUserID = objResult.result_data.users(userIndex).userId
                strUserName = objResult.result_data.users(userIndex).name
                nPrivilege = objResult.result_data.users(userIndex).privilege
                strCard = objResult.result_data.users(userIndex).card
                strPwd = objResult.result_data.users(userIndex).pwd
                strVaildStart = objResult.result_data.users(userIndex).vaildStart
                strVaildEnd = objResult.result_data.users(userIndex).vaildEnd

                strFace = objResult.result_data.users(userIndex).face
                If strFace = "0" Then
                    strFace = ""
                End If
                If strFace = "" Then
                    faceCount = 0
                Else
                    faceCount = 1
                End If

                strPalm = objResult.result_data.users(userIndex).palm
                If strPalm = "" Then
                    palmCount = 0
                Else
                    palmCount = 1
                End If

                strPhoto = objResult.result_data.users(userIndex).photo
                If strPhoto = "" Then
                    photoCount = 0
                Else
                    photoCount = 1
                End If

                If (objResult.result_data.users(userIndex).fps Is Nothing) Then
                    fpsCount = 0
                Else
                    fpsCount = objResult.result_data.users(userIndex).fps.Length
                End If


                For j = 0 To fpsCount - 1
                    Select Case j
                        Case 1
                            strFp1 = objResult.result_data.users(userIndex).fps(j)
                        Case 2
                            strFp2 = objResult.result_data.users(userIndex).fps(j)
                        Case 3
                            strFp3 = objResult.result_data.users(userIndex).fps(j)
                        Case 4
                            strFp4 = objResult.result_data.users(userIndex).fps(j)
                        Case 5
                            strFp5 = objResult.result_data.users(userIndex).fps(j)
                        Case 6
                            strFp6 = objResult.result_data.users(userIndex).fps(j)
                        Case 7
                            strFp7 = objResult.result_data.users(userIndex).fps(j)
                        Case 8
                            strFp8 = objResult.result_data.users(userIndex).fps(j)
                        Case 9
                            strFp9 = objResult.result_data.users(userIndex).fps(j)
                        Case 10
                            strFp10 = objResult.result_data.users(userIndex).fps(j)
                    End Select
                Next j

                'timesGroup = objResult.result_data.users(userIndex).Item(USER_TIMEGROUPS)

                ShowUserListToGridView(nAllUserInx, strUserID, strUserName, nPrivilege, strCard, strPwd, fpsCount, faceCount, palmCount, photoCount, strVaildStart, strVaildEnd)
                FuncSaveToDB(strUserID, strUserName, nPrivilege, strCard, strPwd, strFace, strPalm, strPhoto, strVaildStart, strVaildEnd, strFp1, strFp2, strFp3, strFp4, strFp5, strFp6, strFp7, strFp8, strFp9, strFp10) ', objFps
                nAllUserInx = nAllUserInx + 1
            Next userIndex

            Dim packageId As Integer
            packageId = objResult.result_data.packageId
            If packageId <> 0 Then
                nCmdPackageId = nCmdPackageId + 1
                GoTo SubRecev
            End If
        End If

        lblStatus.Text = ReturnResultString(result_code)
        cmdGetUserInfo.Enabled = True
        Exit Sub

Err:
        lblStatus.Text = ReturnResultString(RUNERR_ERROR)
        cmdGetUserInfo.Enabled = True
        Exit Sub
    End Sub

    Private Sub cmdSetUserInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetUserInfo.Click
        lblStatus.Text = "Working..."
        cmdSetUserInfo.Enabled = False

        Dim commandJson As String

        Dim cmdRoot As New SetUserInfoModel()
        cmdRoot.cmd = "SetUserInfo"

        Dim cmdData As New SetUserInfoDataModel()

        Dim users As New ArrayList()
        Dim userData As New UserModel()

        Dim vnUpdate As Integer
        If chkUpdate.Checked = True Then
            vnUpdate = 1
        Else
            vnUpdate = 0
        End If

        Dim vnPhotoEnroll As Integer
        If chkPhotoEnroll.Checked = True Then
            vnPhotoEnroll = 1
        Else
            vnPhotoEnroll = 0
        End If

        Dim strUserID As String
        strUserID = txtUserIDs.Text

        Dim strSelectSQL As String

        strSelectSQL = "SELECT * FROM tblUser Where userId = '" & strUserID & "'"
        AdoCmd = New OleDbCommand(strSelectSQL, AdoConn)
        Dim AdoUser As OleDbDataReader = AdoCmd.ExecuteReader()

        If AdoUser.HasRows = True Then
            AdoUser.Read()
            userData.userId = strUserID
            userData.name = AdoUser.Item(USER_NAME).ToString()
            userData.privilege = AdoUser.Item(USER_PRIVILEGE).ToString()
            userData.card = AdoUser.Item(USER_CARD).ToString()
            userData.pwd = AdoUser.Item(USER_PASSWORD).ToString()

            Dim strFace As String
            strFace = AdoUser.Item(USER_FACE).ToString()
            If Not String.IsNullOrEmpty(strFace) AndAlso strFace IsNot Nothing Then
                userData.face = strFace
            End If

            Dim strPalm As String
            strPalm = AdoUser.Item(USER_PALM).ToString()
            If Not String.IsNullOrEmpty(strPalm) AndAlso strPalm IsNot Nothing Then
                userData.palm = strPalm
            End If

            Dim strPhoto As String
            strPhoto = AdoUser.Item(USER_PHOTO).ToString()
            If Not String.IsNullOrEmpty(strPhoto) AndAlso strPhoto IsNot Nothing Then
                userData.photo = strPhoto
            End If

            Dim fpsList As New ArrayList()
            Dim nFpCount As Integer
            For i = 1 To 10
                Dim strFp As String = AdoUser.Item("fp" & i).ToString()

                If Not String.IsNullOrEmpty(strFp) AndAlso strFp IsNot Nothing Then
                    fpsList.Add(strFp)
                    nFpCount = nFpCount + 1
                End If
            Next i

            ' Convert the ArrayList to an array if needed
            Dim fpsArray As String() = DirectCast(fpsList.ToArray(GetType(String)), String())

            If nFpCount > 0 Then
                userData.fps = fpsArray
            End If
            '--------------------------------------------------------------------------

            userData.vaildStart = AdoUser.Item(USER_VAILDSTART).ToString()
            userData.vaildEnd = AdoUser.Item(USER_VAILDEND).ToString()

            'userData.Add "timeGroups", Null

            userData.update = vnUpdate
            userData.photoEnroll = vnPhotoEnroll

            users.Add(userData)

            Dim userArray As UserModel() = DirectCast(users.ToArray(GetType(UserModel)), UserModel())

            cmdData.users = userArray
            cmdRoot.data = cmdData

            commandJson = JsonConvert.SerializeObject(cmdRoot)

            ' Send JSON command to the server
            Dim resultStr As String
            NetClass.SendCommand(commandJson)
            resultStr = NetClass.ReceiveData()

            Dim objResult As DeviceResponseModel = JsonConvert.DeserializeObject(Of DeviceResponseModel)(resultStr)

            If resultStr = "" Or objResult Is Nothing Then
                lblStatus.Text = ReturnResultString(RUNERR_ERROR)
            Else
                Dim result_code As Integer
                result_code = objResult.result_code

                lblStatus.Text = ReturnResultString(result_code)
            End If
        End If

        AdoUser.Close()
        cmdSetUserInfo.Enabled = True
    End Sub

    Private Function DecodeBase64(base64String As String) As Byte()
        ' Decode Base64 string to binary data
        Dim decodedBytes As Byte() = Convert.FromBase64String(base64String)
        Return decodedBytes
    End Function


    Private Sub ViewCellPhoto()

        Dim rowIndex As Integer = MSFlexGridUsersList.SelectedCells(0).RowIndex
        Dim columnIndex As Integer = MSFlexGridUsersList.SelectedCells(0).ColumnIndex

        If columnIndex = USER_PHOTO_INX Then
            Dim strSelectSQL As String
            Dim strUserID As String

            strUserID = MSFlexGridUsersList.Rows(rowIndex).Cells(0).Value()

            strSelectSQL = "SELECT * FROM tblUser Where userId = '" & strUserID & "'"

            AdoCmd = New OleDbCommand(strSelectSQL, AdoConn)
            Dim AdoUser As OleDbDataReader = AdoCmd.ExecuteReader()

            If AdoUser.HasRows = True Then
                AdoUser.Read()
                Dim strPhoto As String
                strPhoto = AdoUser(USER_PHOTO).ToString()
                If strPhoto <> "" Then
                    Dim binData() As Byte
                    binData = DecodeBase64(strPhoto)

                    LoadPictureFromBinary(binData)
                End If
            End If
            AdoUser.Close()
        End If
    End Sub

    Private Sub MSFlexGridUsersList_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSFlexGridUsersList.CellClick
        ViewCellPhoto()
    End Sub

    Private Sub LoadImage(filePath As String)
        ' Load the image into PictureBox
        Image1.Image = Image.FromFile(filePath)
    End Sub

    Private Function EncodeBase64(data() As Byte) As String
        ' Encode binary data to Base64
        Return Convert.ToBase64String(data)
    End Function

    Private Function ConvertToBase64(filePath As String) As String
        ' Read the binary data of the image file
        Dim binData() As Byte = File.ReadAllBytes(filePath)

        ' Convert binary data to Base64
        Return EncodeBase64(binData)
    End Function

    Private Sub LoadPictureFromBinary(binData() As Byte)
        ' Convert Base64 string to binary data
        Dim imageData() As Byte = Convert.FromBase64String(EncodeBase64(binData))

        ' Load the binary data into PictureBox
        Using stream As New MemoryStream(imageData)
            Image1.Image = Image.FromStream(stream)
        End Using
    End Sub

    Private Function LoadUserPicture() As String
        With OpenFileDialog1
            .Title = "Select JPG File"
            .Filter = "JPEG Files|*.jpg|All Files|*.*"
            .ShowDialog()

            ' Check if the user selected a file
            If .FileName <> "" Then
                ' Load the image into PictureBox
                LoadImage(.FileName)

                ' Convert image to base64
                Dim base64String As String
                base64String = ConvertToBase64(.FileName)

                Return base64String
            End If
        End With

        Return String.Empty
    End Function

    Private Sub MSFlexGridUsersList_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSFlexGridUsersList.CellDoubleClick
        Dim rowIndex As Integer = MSFlexGridUsersList.SelectedCells(0).RowIndex
        Dim colIndex As Integer = MSFlexGridUsersList.SelectedCells(0).ColumnIndex

        Dim strUserID As String
        strUserID = MSFlexGridUsersList.Rows(rowIndex).Cells(0).Value()

        Dim strUpdateSQL As String
        If colIndex = USER_NAME_INX Or colIndex = USER_PRIVILEGE_INX Or colIndex = USER_CARD_INX Or colIndex = USER_PWD_INX Or colIndex = USER_VAILDSTART_INX Or colIndex = USER_VAILDEND_INX Then
            ' Handle the DblClick event
            Dim newValue As String
            newValue = InputBox("Enter new value:", "Edit Cell", MSFlexGridUsersList.Rows(rowIndex).Cells(colIndex).Value())

            If newValue <> "" Then
                ' Update the value in the grid
                MSFlexGridUsersList.Rows(rowIndex).Cells(colIndex).Value = newValue
                strUpdateSQL = ""
                ' Update the value in the mdb
                Select Case colIndex
                    Case USER_PRIVILEGE_INX
                        strUpdateSQL = "UPDATE tblUser SET " & USER_PRIVILEGE & " = '" & newValue & "' WHERE userId = '" & strUserID & "'"
                    Case USER_NAME_INX
                        strUpdateSQL = "UPDATE tblUser SET " & USER_NAME & " = '" & newValue & "' WHERE userId = '" & strUserID & "'"
                    Case USER_CARD_INX
                        strUpdateSQL = "UPDATE tblUser SET " & USER_CARD & " = '" & newValue & "' WHERE userId = '" & strUserID & "'"
                    Case USER_PWD_INX
                        strUpdateSQL = "UPDATE tblUser SET " & USER_PASSWORD & " = '" & newValue & "' WHERE userId = '" & strUserID & "'"
                    Case USER_VAILDSTART_INX
                        newValue = Replace(newValue, "-", "")
                        strUpdateSQL = "UPDATE tblUser SET " & USER_VAILDSTART & " = '" & newValue & "' WHERE userId = '" & strUserID & "'"
                    Case USER_VAILDEND_INX
                        newValue = Replace(newValue, "-", "")
                        strUpdateSQL = "UPDATE tblUser SET " & USER_VAILDEND & " = '" & newValue & "' WHERE userId = '" & strUserID & "'"
                End Select

                AdoCmd = New OleDbCommand(strUpdateSQL, AdoConn)
                AdoCmd.ExecuteNonQuery()
            End If
        ElseIf colIndex = USER_PHOTO_INX Then
            Dim strNewPhoto As String
            strNewPhoto = LoadUserPicture
            strNewPhoto = Replace(strNewPhoto, Chr(10), "")
            strUpdateSQL = "UPDATE tblUser SET " & USER_PHOTO & " = '" & strNewPhoto & "' WHERE userId = '" & strUserID & "'"

            AdoCmd = New OleDbCommand(strUpdateSQL, AdoConn)
            AdoCmd.ExecuteNonQuery()
        End If
    End Sub
End Class