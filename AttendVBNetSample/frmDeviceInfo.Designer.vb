<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeviceInfo
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
        Me.cmdGetDeviceInfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDeviceId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirmware = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFpVer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFaceVer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPvVer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFpLimit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserLimit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaxBufferLen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCardLimit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPwdLimit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFaceLimit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtManagerCount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtUserCount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLogLimit = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPwdCount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFaceCount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFpCount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAllLogCount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtLogCount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCardCount = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGetDeviceInfo
        '
        Me.cmdGetDeviceInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDeviceInfo.Location = New System.Drawing.Point(59, 41)
        Me.cmdGetDeviceInfo.Name = "cmdGetDeviceInfo"
        Me.cmdGetDeviceInfo.Size = New System.Drawing.Size(174, 35)
        Me.cmdGetDeviceInfo.TabIndex = 0
        Me.cmdGetDeviceInfo.Text = "GetDeviceInfo"
        Me.cmdGetDeviceInfo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Device Name : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(161, 106)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(420, 26)
        Me.txtName.TabIndex = 2
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDeviceId
        '
        Me.txtDeviceId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeviceId.Location = New System.Drawing.Point(161, 150)
        Me.txtDeviceId.Name = "txtDeviceId"
        Me.txtDeviceId.Size = New System.Drawing.Size(233, 26)
        Me.txtDeviceId.TabIndex = 4
        Me.txtDeviceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DeviceID : "
        '
        'txtFirmware
        '
        Me.txtFirmware.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirmware.Location = New System.Drawing.Point(583, 153)
        Me.txtFirmware.Name = "txtFirmware"
        Me.txtFirmware.Size = New System.Drawing.Size(234, 26)
        Me.txtFirmware.TabIndex = 6
        Me.txtFirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(458, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Firmware Name : "
        '
        'txtFpVer
        '
        Me.txtFpVer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFpVer.Location = New System.Drawing.Point(142, 203)
        Me.txtFpVer.Name = "txtFpVer"
        Me.txtFpVer.Size = New System.Drawing.Size(144, 26)
        Me.txtFpVer.TabIndex = 8
        Me.txtFpVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fp Ver:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFaceVer
        '
        Me.txtFaceVer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaceVer.Location = New System.Drawing.Point(420, 203)
        Me.txtFaceVer.Name = "txtFaceVer"
        Me.txtFaceVer.Size = New System.Drawing.Size(140, 26)
        Me.txtFaceVer.TabIndex = 10
        Me.txtFaceVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Face Ver : "
        '
        'txtPvVer
        '
        Me.txtPvVer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPvVer.Location = New System.Drawing.Point(680, 203)
        Me.txtPvVer.Name = "txtPvVer"
        Me.txtPvVer.Size = New System.Drawing.Size(137, 26)
        Me.txtPvVer.TabIndex = 12
        Me.txtPvVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(579, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PV Ver : "
        '
        'txtFpLimit
        '
        Me.txtFpLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFpLimit.Location = New System.Drawing.Point(680, 263)
        Me.txtFpLimit.Name = "txtFpLimit"
        Me.txtFpLimit.Size = New System.Drawing.Size(137, 26)
        Me.txtFpLimit.TabIndex = 18
        Me.txtFpLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(579, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fp Limit : "
        '
        'txtUserLimit
        '
        Me.txtUserLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLimit.Location = New System.Drawing.Point(420, 263)
        Me.txtUserLimit.Name = "txtUserLimit"
        Me.txtUserLimit.Size = New System.Drawing.Size(140, 26)
        Me.txtUserLimit.TabIndex = 16
        Me.txtUserLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(319, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "User Limit : "
        '
        'txtMaxBufferLen
        '
        Me.txtMaxBufferLen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxBufferLen.Location = New System.Drawing.Point(142, 263)
        Me.txtMaxBufferLen.Name = "txtMaxBufferLen"
        Me.txtMaxBufferLen.Size = New System.Drawing.Size(144, 26)
        Me.txtMaxBufferLen.TabIndex = 14
        Me.txtMaxBufferLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "MaxBufferLen : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCardLimit
        '
        Me.txtCardLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardLimit.Location = New System.Drawing.Point(680, 320)
        Me.txtCardLimit.Name = "txtCardLimit"
        Me.txtCardLimit.Size = New System.Drawing.Size(137, 26)
        Me.txtCardLimit.TabIndex = 24
        Me.txtCardLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(579, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 19)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Card Limit : "
        '
        'txtPwdLimit
        '
        Me.txtPwdLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwdLimit.Location = New System.Drawing.Point(420, 320)
        Me.txtPwdLimit.Name = "txtPwdLimit"
        Me.txtPwdLimit.Size = New System.Drawing.Size(140, 26)
        Me.txtPwdLimit.TabIndex = 22
        Me.txtPwdLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(319, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Pwd Limit : "
        '
        'txtFaceLimit
        '
        Me.txtFaceLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaceLimit.Location = New System.Drawing.Point(142, 320)
        Me.txtFaceLimit.Name = "txtFaceLimit"
        Me.txtFaceLimit.Size = New System.Drawing.Size(144, 26)
        Me.txtFaceLimit.TabIndex = 20
        Me.txtFaceLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 19)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Face Limit : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtManagerCount
        '
        Me.txtManagerCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManagerCount.Location = New System.Drawing.Point(680, 375)
        Me.txtManagerCount.Name = "txtManagerCount"
        Me.txtManagerCount.Size = New System.Drawing.Size(137, 26)
        Me.txtManagerCount.TabIndex = 30
        Me.txtManagerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(566, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 19)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Manager Count : "
        '
        'txtUserCount
        '
        Me.txtUserCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserCount.Location = New System.Drawing.Point(420, 375)
        Me.txtUserCount.Name = "txtUserCount"
        Me.txtUserCount.Size = New System.Drawing.Size(140, 26)
        Me.txtUserCount.TabIndex = 28
        Me.txtUserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(319, 378)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 19)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "User Count : "
        '
        'txtLogLimit
        '
        Me.txtLogLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogLimit.Location = New System.Drawing.Point(142, 375)
        Me.txtLogLimit.Name = "txtLogLimit"
        Me.txtLogLimit.Size = New System.Drawing.Size(144, 26)
        Me.txtLogLimit.TabIndex = 26
        Me.txtLogLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(52, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 19)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Log Limit : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPwdCount
        '
        Me.txtPwdCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwdCount.Location = New System.Drawing.Point(680, 425)
        Me.txtPwdCount.Name = "txtPwdCount"
        Me.txtPwdCount.Size = New System.Drawing.Size(137, 26)
        Me.txtPwdCount.TabIndex = 36
        Me.txtPwdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(579, 428)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Pwd Count : "
        '
        'txtFaceCount
        '
        Me.txtFaceCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaceCount.Location = New System.Drawing.Point(420, 425)
        Me.txtFaceCount.Name = "txtFaceCount"
        Me.txtFaceCount.Size = New System.Drawing.Size(140, 26)
        Me.txtFaceCount.TabIndex = 34
        Me.txtFaceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(319, 428)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 19)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Face Count : "
        '
        'txtFpCount
        '
        Me.txtFpCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFpCount.Location = New System.Drawing.Point(142, 425)
        Me.txtFpCount.Name = "txtFpCount"
        Me.txtFpCount.Size = New System.Drawing.Size(144, 26)
        Me.txtFpCount.TabIndex = 32
        Me.txtFpCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(52, 428)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 19)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Fp Count : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAllLogCount
        '
        Me.txtAllLogCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllLogCount.Location = New System.Drawing.Point(680, 483)
        Me.txtAllLogCount.Name = "txtAllLogCount"
        Me.txtAllLogCount.Size = New System.Drawing.Size(137, 26)
        Me.txtAllLogCount.TabIndex = 42
        Me.txtAllLogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(579, 486)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 19)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "All LogCount : "
        '
        'txtLogCount
        '
        Me.txtLogCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogCount.Location = New System.Drawing.Point(420, 483)
        Me.txtLogCount.Name = "txtLogCount"
        Me.txtLogCount.Size = New System.Drawing.Size(140, 26)
        Me.txtLogCount.TabIndex = 40
        Me.txtLogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(319, 486)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 19)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Log Count : "
        '
        'txtCardCount
        '
        Me.txtCardCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardCount.Location = New System.Drawing.Point(142, 483)
        Me.txtCardCount.Name = "txtCardCount"
        Me.txtCardCount.Size = New System.Drawing.Size(144, 26)
        Me.txtCardCount.TabIndex = 38
        Me.txtCardCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(52, 486)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 19)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Card Count : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(706, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        Me.lblStatus.TabIndex = 77
        '
        'frmDeviceInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 554)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtAllLogCount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtLogCount)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtCardCount)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPwdCount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtFaceCount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFpCount)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtManagerCount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtUserCount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtLogLimit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCardLimit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPwdLimit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFaceLimit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFpLimit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUserLimit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMaxBufferLen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPvVer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFaceVer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFpVer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFirmware)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDeviceId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGetDeviceInfo)
        Me.Name = "frmDeviceInfo"
        Me.Text = "frmDeviceInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGetDeviceInfo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDeviceId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirmware As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFpVer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFaceVer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPvVer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFpLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUserLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMaxBufferLen As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCardLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPwdLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFaceLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtManagerCount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtUserCount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLogLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPwdCount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFaceCount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFpCount As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAllLogCount As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLogCount As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCardCount As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
