<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserTimeGroup
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtUserIDs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSetUsersTimeGroup = New System.Windows.Forms.Button()
        Me.MSFlexGridUserGroupTime = New System.Windows.Forms.DataGridView()
        CType(Me.MSFlexGridUserGroupTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(669, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        Me.lblStatus.TabIndex = 78
        '
        'txtUserIDs
        '
        Me.txtUserIDs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIDs.Location = New System.Drawing.Point(141, 55)
        Me.txtUserIDs.Name = "txtUserIDs"
        Me.txtUserIDs.Size = New System.Drawing.Size(131, 26)
        Me.txtUserIDs.TabIndex = 80
        Me.txtUserIDs.Text = "1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Enroll Number :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSetUsersTimeGroup
        '
        Me.cmdSetUsersTimeGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetUsersTimeGroup.Location = New System.Drawing.Point(296, 50)
        Me.cmdSetUsersTimeGroup.Name = "cmdSetUsersTimeGroup"
        Me.cmdSetUsersTimeGroup.Size = New System.Drawing.Size(187, 34)
        Me.cmdSetUsersTimeGroup.TabIndex = 81
        Me.cmdSetUsersTimeGroup.Text = "Set Users Time Groups"
        Me.cmdSetUsersTimeGroup.UseVisualStyleBackColor = True
        '
        'MSFlexGridUserGroupTime
        '
        Me.MSFlexGridUserGroupTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MSFlexGridUserGroupTime.Location = New System.Drawing.Point(36, 99)
        Me.MSFlexGridUserGroupTime.Name = "MSFlexGridUserGroupTime"
        Me.MSFlexGridUserGroupTime.Size = New System.Drawing.Size(736, 304)
        Me.MSFlexGridUserGroupTime.TabIndex = 82
        '
        'frmUserTimeGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 423)
        Me.Controls.Add(Me.MSFlexGridUserGroupTime)
        Me.Controls.Add(Me.cmdSetUsersTimeGroup)
        Me.Controls.Add(Me.txtUserIDs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "frmUserTimeGroup"
        Me.Text = "frmUserTimeGroup"
        CType(Me.MSFlexGridUserGroupTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtUserIDs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSetUsersTimeGroup As System.Windows.Forms.Button
    Friend WithEvents MSFlexGridUserGroupTime As System.Windows.Forms.DataGridView
End Class
