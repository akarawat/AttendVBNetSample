<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUserIDs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsersCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdUserIDList = New System.Windows.Forms.Button()
        Me.chkPhotoEnroll = New System.Windows.Forms.CheckBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.MSFlexGridUsersList = New System.Windows.Forms.DataGridView()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.cmdGetUserInfo = New System.Windows.Forms.Button()
        Me.cmdDeleteUserInfo = New System.Windows.Forms.Button()
        Me.cmdSetUserInfo = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.MSFlexGridUsersList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserIDs
        '
        Me.txtUserIDs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIDs.Location = New System.Drawing.Point(138, 500)
        Me.txtUserIDs.Name = "txtUserIDs"
        Me.txtUserIDs.Size = New System.Drawing.Size(131, 26)
        Me.txtUserIDs.TabIndex = 82
        Me.txtUserIDs.Text = "1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Enroll Number :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsersCount
        '
        Me.txtUsersCount.AutoSize = True
        Me.txtUsersCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsersCount.Location = New System.Drawing.Point(124, 36)
        Me.txtUsersCount.Name = "txtUsersCount"
        Me.txtUsersCount.Size = New System.Drawing.Size(17, 19)
        Me.txtUsersCount.TabIndex = 84
        Me.txtUsersCount.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "User Count : "
        '
        'cmdUserIDList
        '
        Me.cmdUserIDList.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUserIDList.Location = New System.Drawing.Point(167, 27)
        Me.cmdUserIDList.Name = "cmdUserIDList"
        Me.cmdUserIDList.Size = New System.Drawing.Size(131, 32)
        Me.cmdUserIDList.TabIndex = 93
        Me.cmdUserIDList.Text = "GetUserIDList"
        Me.cmdUserIDList.UseVisualStyleBackColor = True
        '
        'chkPhotoEnroll
        '
        Me.chkPhotoEnroll.AutoSize = True
        Me.chkPhotoEnroll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPhotoEnroll.Location = New System.Drawing.Point(764, 40)
        Me.chkPhotoEnroll.Name = "chkPhotoEnroll"
        Me.chkPhotoEnroll.Size = New System.Drawing.Size(99, 23)
        Me.chkPhotoEnroll.TabIndex = 96
        Me.chkPhotoEnroll.Text = "PhotoEnroll"
        Me.chkPhotoEnroll.UseVisualStyleBackColor = True
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Checked = True
        Me.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdate.Location = New System.Drawing.Point(668, 39)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(73, 23)
        Me.chkUpdate.TabIndex = 95
        Me.chkUpdate.Text = "Update"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'MSFlexGridUsersList
        '
        Me.MSFlexGridUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MSFlexGridUsersList.Location = New System.Drawing.Point(33, 65)
        Me.MSFlexGridUsersList.Name = "MSFlexGridUsersList"
        Me.MSFlexGridUsersList.Size = New System.Drawing.Size(832, 419)
        Me.MSFlexGridUsersList.TabIndex = 94
        '
        'Image1
        '
        Me.Image1.Location = New System.Drawing.Point(881, 65)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(153, 187)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 97
        Me.Image1.TabStop = False
        '
        'cmdGetUserInfo
        '
        Me.cmdGetUserInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetUserInfo.Location = New System.Drawing.Point(407, 492)
        Me.cmdGetUserInfo.Name = "cmdGetUserInfo"
        Me.cmdGetUserInfo.Size = New System.Drawing.Size(141, 39)
        Me.cmdGetUserInfo.TabIndex = 98
        Me.cmdGetUserInfo.Text = "GetUserInfo"
        Me.cmdGetUserInfo.UseVisualStyleBackColor = True
        '
        'cmdDeleteUserInfo
        '
        Me.cmdDeleteUserInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteUserInfo.Location = New System.Drawing.Point(724, 492)
        Me.cmdDeleteUserInfo.Name = "cmdDeleteUserInfo"
        Me.cmdDeleteUserInfo.Size = New System.Drawing.Size(141, 39)
        Me.cmdDeleteUserInfo.TabIndex = 99
        Me.cmdDeleteUserInfo.Text = "DeleteUserInfo"
        Me.cmdDeleteUserInfo.UseVisualStyleBackColor = True
        '
        'cmdSetUserInfo
        '
        Me.cmdSetUserInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetUserInfo.Location = New System.Drawing.Point(566, 492)
        Me.cmdSetUserInfo.Name = "cmdSetUserInfo"
        Me.cmdSetUserInfo.Size = New System.Drawing.Size(141, 39)
        Me.cmdSetUserInfo.TabIndex = 100
        Me.cmdSetUserInfo.Text = "SetUserInfo"
        Me.cmdSetUserInfo.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(785, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        Me.lblStatus.TabIndex = 101
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmUserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 543)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmdSetUserInfo)
        Me.Controls.Add(Me.cmdDeleteUserInfo)
        Me.Controls.Add(Me.cmdGetUserInfo)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.chkPhotoEnroll)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.MSFlexGridUsersList)
        Me.Controls.Add(Me.cmdUserIDList)
        Me.Controls.Add(Me.txtUsersCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserIDs)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmUserInfo"
        Me.Text = "frmUserInfo"
        CType(Me.MSFlexGridUsersList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserIDs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsersCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdUserIDList As System.Windows.Forms.Button
    Friend WithEvents chkPhotoEnroll As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents MSFlexGridUsersList As System.Windows.Forms.DataGridView
    Friend WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdGetUserInfo As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteUserInfo As System.Windows.Forms.Button
    Friend WithEvents cmdSetUserInfo As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
