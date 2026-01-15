<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemInfo
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
        Me.cmbDoorStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFeature = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSetDoorStatus = New System.Windows.Forms.Button()
        Me.cmdClearManager = New System.Windows.Forms.Button()
        Me.cmdSetSyncTime = New System.Windows.Forms.Button()
        Me.cmdResetDevice = New System.Windows.Forms.Button()
        Me.cmdRestart = New System.Windows.Forms.Button()
        Me.cmdRemoteEnroll = New System.Windows.Forms.Button()
        Me.txtRemoteEnrollNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbDoorStatus
        '
        Me.cmbDoorStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoorStatus.FormattingEnabled = True
        Me.cmbDoorStatus.Location = New System.Drawing.Point(151, 40)
        Me.cmbDoorStatus.Name = "cmbDoorStatus"
        Me.cmbDoorStatus.Size = New System.Drawing.Size(131, 27)
        Me.cmbDoorStatus.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Door Status : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbFeature
        '
        Me.cmbFeature.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFeature.FormattingEnabled = True
        Me.cmbFeature.Location = New System.Drawing.Point(141, 204)
        Me.cmbFeature.Name = "cmbFeature"
        Me.cmbFeature.Size = New System.Drawing.Size(131, 27)
        Me.cmbFeature.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Feature :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSetDoorStatus
        '
        Me.cmdSetDoorStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDoorStatus.Location = New System.Drawing.Point(305, 36)
        Me.cmdSetDoorStatus.Name = "cmdSetDoorStatus"
        Me.cmdSetDoorStatus.Size = New System.Drawing.Size(141, 34)
        Me.cmdSetDoorStatus.TabIndex = 68
        Me.cmdSetDoorStatus.Text = "Set DoorStatus"
        Me.cmdSetDoorStatus.UseVisualStyleBackColor = True
        '
        'cmdClearManager
        '
        Me.cmdClearManager.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearManager.Location = New System.Drawing.Point(29, 95)
        Me.cmdClearManager.Name = "cmdClearManager"
        Me.cmdClearManager.Size = New System.Drawing.Size(141, 34)
        Me.cmdClearManager.TabIndex = 69
        Me.cmdClearManager.Text = "Clear Manager"
        Me.cmdClearManager.UseVisualStyleBackColor = True
        '
        'cmdSetSyncTime
        '
        Me.cmdSetSyncTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetSyncTime.Location = New System.Drawing.Point(196, 95)
        Me.cmdSetSyncTime.Name = "cmdSetSyncTime"
        Me.cmdSetSyncTime.Size = New System.Drawing.Size(141, 34)
        Me.cmdSetSyncTime.TabIndex = 70
        Me.cmdSetSyncTime.Text = "Sync Time"
        Me.cmdSetSyncTime.UseVisualStyleBackColor = True
        '
        'cmdResetDevice
        '
        Me.cmdResetDevice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetDevice.Location = New System.Drawing.Point(364, 95)
        Me.cmdResetDevice.Name = "cmdResetDevice"
        Me.cmdResetDevice.Size = New System.Drawing.Size(141, 34)
        Me.cmdResetDevice.TabIndex = 71
        Me.cmdResetDevice.Text = "Reset Device"
        Me.cmdResetDevice.UseVisualStyleBackColor = True
        '
        'cmdRestart
        '
        Me.cmdRestart.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestart.Location = New System.Drawing.Point(528, 95)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(141, 34)
        Me.cmdRestart.TabIndex = 72
        Me.cmdRestart.Text = "Restart"
        Me.cmdRestart.UseVisualStyleBackColor = True
        '
        'cmdRemoteEnroll
        '
        Me.cmdRemoteEnroll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoteEnroll.Location = New System.Drawing.Point(287, 201)
        Me.cmdRemoteEnroll.Name = "cmdRemoteEnroll"
        Me.cmdRemoteEnroll.Size = New System.Drawing.Size(141, 34)
        Me.cmdRemoteEnroll.TabIndex = 73
        Me.cmdRemoteEnroll.Text = "Remote Enroll"
        Me.cmdRemoteEnroll.UseVisualStyleBackColor = True
        '
        'txtRemoteEnrollNumber
        '
        Me.txtRemoteEnrollNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemoteEnrollNumber.Location = New System.Drawing.Point(141, 162)
        Me.txtRemoteEnrollNumber.Name = "txtRemoteEnrollNumber"
        Me.txtRemoteEnrollNumber.Size = New System.Drawing.Size(131, 26)
        Me.txtRemoteEnrollNumber.TabIndex = 75
        Me.txtRemoteEnrollNumber.Text = "1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Enroll Number :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(586, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        Me.lblStatus.TabIndex = 76
        '
        'frmSystemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 268)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtRemoteEnrollNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdRemoteEnroll)
        Me.Controls.Add(Me.cmdRestart)
        Me.Controls.Add(Me.cmdResetDevice)
        Me.Controls.Add(Me.cmdSetSyncTime)
        Me.Controls.Add(Me.cmdClearManager)
        Me.Controls.Add(Me.cmdSetDoorStatus)
        Me.Controls.Add(Me.cmbFeature)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDoorStatus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSystemInfo"
        Me.Text = "frmSystemInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDoorStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFeature As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSetDoorStatus As System.Windows.Forms.Button
    Friend WithEvents cmdClearManager As System.Windows.Forms.Button
    Friend WithEvents cmdSetSyncTime As System.Windows.Forms.Button
    Friend WithEvents cmdResetDevice As System.Windows.Forms.Button
    Friend WithEvents cmdRestart As System.Windows.Forms.Button
    Friend WithEvents cmdRemoteEnroll As System.Windows.Forms.Button
    Friend WithEvents txtRemoteEnrollNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
