<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.txtPortNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdOpenComm = New System.Windows.Forms.Button()
        Me.cmdCloseComm = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdDeviceInfo = New System.Windows.Forms.Button()
        Me.cmdDeviceSetting = New System.Windows.Forms.Button()
        Me.cmdSystemInfo = New System.Windows.Forms.Button()
        Me.cmdUserInfo = New System.Windows.Forms.Button()
        Me.cmdUserTimeGroup = New System.Windows.Forms.Button()
        Me.cmdLogData = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMachineNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address : "
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPAddress.Location = New System.Drawing.Point(178, 46)
        Me.txtIPAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(168, 35)
        Me.txtIPAddress.TabIndex = 1
        Me.txtIPAddress.Text = "192.168.3.100"
        '
        'txtPortNo
        '
        Me.txtPortNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPortNo.Location = New System.Drawing.Point(549, 46)
        Me.txtPortNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPortNo.Name = "txtPortNo"
        Me.txtPortNo.Size = New System.Drawing.Size(148, 35)
        Me.txtPortNo.TabIndex = 3
        Me.txtPortNo.Text = "5005"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port Number : "
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(178, 122)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(168, 35)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password : "
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOut.Location = New System.Drawing.Point(549, 122)
        Me.txtTimeOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(148, 35)
        Me.txtTimeOut.TabIndex = 7
        Me.txtTimeOut.Text = "3000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TimeOut : "
        '
        'cmdOpenComm
        '
        Me.cmdOpenComm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenComm.Location = New System.Drawing.Point(182, 225)
        Me.cmdOpenComm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdOpenComm.Name = "cmdOpenComm"
        Me.cmdOpenComm.Size = New System.Drawing.Size(166, 49)
        Me.cmdOpenComm.TabIndex = 8
        Me.cmdOpenComm.Text = "Open"
        Me.cmdOpenComm.UseVisualStyleBackColor = True
        '
        'cmdCloseComm
        '
        Me.cmdCloseComm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseComm.Location = New System.Drawing.Point(400, 225)
        Me.cmdCloseComm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCloseComm.Name = "cmdCloseComm"
        Me.cmdCloseComm.Size = New System.Drawing.Size(166, 49)
        Me.cmdCloseComm.TabIndex = 9
        Me.cmdCloseComm.Text = "Close"
        Me.cmdCloseComm.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(230, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(408, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Attend VB.Net Sample v1.00"
        '
        'cmdDeviceInfo
        '
        Me.cmdDeviceInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeviceInfo.Location = New System.Drawing.Point(87, 551)
        Me.cmdDeviceInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDeviceInfo.Name = "cmdDeviceInfo"
        Me.cmdDeviceInfo.Size = New System.Drawing.Size(304, 63)
        Me.cmdDeviceInfo.TabIndex = 11
        Me.cmdDeviceInfo.Text = "DeviceInfo"
        Me.cmdDeviceInfo.UseVisualStyleBackColor = True
        '
        'cmdDeviceSetting
        '
        Me.cmdDeviceSetting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeviceSetting.Location = New System.Drawing.Point(87, 658)
        Me.cmdDeviceSetting.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDeviceSetting.Name = "cmdDeviceSetting"
        Me.cmdDeviceSetting.Size = New System.Drawing.Size(304, 63)
        Me.cmdDeviceSetting.TabIndex = 12
        Me.cmdDeviceSetting.Text = "Device Setting"
        Me.cmdDeviceSetting.UseVisualStyleBackColor = True
        '
        'cmdSystemInfo
        '
        Me.cmdSystemInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystemInfo.Location = New System.Drawing.Point(87, 763)
        Me.cmdSystemInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSystemInfo.Name = "cmdSystemInfo"
        Me.cmdSystemInfo.Size = New System.Drawing.Size(304, 63)
        Me.cmdSystemInfo.TabIndex = 13
        Me.cmdSystemInfo.Text = "System Info"
        Me.cmdSystemInfo.UseVisualStyleBackColor = True
        '
        'cmdUserInfo
        '
        Me.cmdUserInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUserInfo.Location = New System.Drawing.Point(472, 763)
        Me.cmdUserInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdUserInfo.Name = "cmdUserInfo"
        Me.cmdUserInfo.Size = New System.Drawing.Size(304, 63)
        Me.cmdUserInfo.TabIndex = 16
        Me.cmdUserInfo.Text = "UserInfo"
        Me.cmdUserInfo.UseVisualStyleBackColor = True
        '
        'cmdUserTimeGroup
        '
        Me.cmdUserTimeGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUserTimeGroup.Location = New System.Drawing.Point(472, 658)
        Me.cmdUserTimeGroup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdUserTimeGroup.Name = "cmdUserTimeGroup"
        Me.cmdUserTimeGroup.Size = New System.Drawing.Size(304, 63)
        Me.cmdUserTimeGroup.TabIndex = 15
        Me.cmdUserTimeGroup.Text = "User Time Group"
        Me.cmdUserTimeGroup.UseVisualStyleBackColor = True
        '
        'cmdLogData
        '
        Me.cmdLogData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogData.Location = New System.Drawing.Point(472, 551)
        Me.cmdLogData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdLogData.Name = "cmdLogData"
        Me.cmdLogData.Size = New System.Drawing.Size(304, 63)
        Me.cmdLogData.TabIndex = 14
        Me.cmdLogData.Text = "Log Data"
        Me.cmdLogData.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmdCloseComm)
        Me.GroupBox1.Controls.Add(Me.cmdOpenComm)
        Me.GroupBox1.Controls.Add(Me.txtTimeOut)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPortNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIPAddress)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 198)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(772, 306)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(704, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 26)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "(ms)"
        '
        'txtLicense
        '
        Me.txtLicense.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicense.Location = New System.Drawing.Point(606, 132)
        Me.txtLicense.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(148, 35)
        Me.txtLicense.TabIndex = 21
        Me.txtLicense.Text = "404232217"
        Me.txtLicense.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(490, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 27)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "License : "
        Me.Label6.Visible = False
        '
        'txtMachineNumber
        '
        Me.txtMachineNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineNumber.Location = New System.Drawing.Point(236, 132)
        Me.txtMachineNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMachineNumber.Name = "txtMachineNumber"
        Me.txtMachineNumber.Size = New System.Drawing.Size(168, 35)
        Me.txtMachineNumber.TabIndex = 19
        Me.txtMachineNumber.Text = "1"
        Me.txtMachineNumber.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 27)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Machine Number : "
        Me.Label7.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 894)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMachineNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdUserInfo)
        Me.Controls.Add(Me.cmdUserTimeGroup)
        Me.Controls.Add(Me.cmdLogData)
        Me.Controls.Add(Me.cmdSystemInfo)
        Me.Controls.Add(Me.cmdDeviceSetting)
        Me.Controls.Add(Me.cmdDeviceInfo)
        Me.Controls.Add(Me.Label5)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "HIP Attendance ID103"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPortNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdOpenComm As System.Windows.Forms.Button
    Friend WithEvents cmdCloseComm As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdDeviceInfo As System.Windows.Forms.Button
    Friend WithEvents cmdDeviceSetting As System.Windows.Forms.Button
    Friend WithEvents cmdSystemInfo As System.Windows.Forms.Button
    Friend WithEvents cmdUserInfo As System.Windows.Forms.Button
    Friend WithEvents cmdUserTimeGroup As System.Windows.Forms.Button
    Friend WithEvents cmdLogData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMachineNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
