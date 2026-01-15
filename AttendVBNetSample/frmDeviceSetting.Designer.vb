<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeviceSetting
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
        Me.cmdGetDeviceSetting = New System.Windows.Forms.Button()
        Me.cmdSetDeviceSetting = New System.Windows.Forms.Button()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerHost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPushServerPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPushServerHost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOpenDoorDelay = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAntiPass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReverifyTime = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAlarmDelay = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMatchThreshold = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLiveThreshold = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMultiCheck = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBrightLedEnd = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBrightLedStart = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtInOut = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSleepTime = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtScreenSaverTime = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmbWiegandType = New System.Windows.Forms.ComboBox()
        Me.cmbPushEnable = New System.Windows.Forms.ComboBox()
        Me.cmbTamperAlarm = New System.Windows.Forms.ComboBox()
        Me.cmbBrightLedMode = New System.Windows.Forms.ComboBox()
        Me.cmbLiving = New System.Windows.Forms.ComboBox()
        Me.cmbVerifyMode = New System.Windows.Forms.ComboBox()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGetDeviceSetting
        '
        Me.cmdGetDeviceSetting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDeviceSetting.Location = New System.Drawing.Point(34, 35)
        Me.cmdGetDeviceSetting.Name = "cmdGetDeviceSetting"
        Me.cmdGetDeviceSetting.Size = New System.Drawing.Size(173, 40)
        Me.cmdGetDeviceSetting.TabIndex = 0
        Me.cmdGetDeviceSetting.Text = "Get Device Setting"
        Me.cmdGetDeviceSetting.UseVisualStyleBackColor = True
        '
        'cmdSetDeviceSetting
        '
        Me.cmdSetDeviceSetting.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetDeviceSetting.Location = New System.Drawing.Point(236, 35)
        Me.cmdSetDeviceSetting.Name = "cmdSetDeviceSetting"
        Me.cmdSetDeviceSetting.Size = New System.Drawing.Size(173, 40)
        Me.cmdSetDeviceSetting.TabIndex = 1
        Me.cmdSetDeviceSetting.Text = "Set Device Setting"
        Me.cmdSetDeviceSetting.UseVisualStyleBackColor = True
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeviceName.Location = New System.Drawing.Point(157, 115)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(131, 26)
        Me.txtDeviceName.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Device Name : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Wiegand Type : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtServerHost
        '
        Me.txtServerHost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerHost.Location = New System.Drawing.Point(768, 118)
        Me.txtServerHost.Name = "txtServerHost"
        Me.txtServerHost.Size = New System.Drawing.Size(131, 26)
        Me.txtServerHost.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(647, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ServerHost : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPushServerPort
        '
        Me.txtPushServerPort.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushServerPort.Location = New System.Drawing.Point(768, 162)
        Me.txtPushServerPort.Name = "txtPushServerPort"
        Me.txtPushServerPort.Size = New System.Drawing.Size(131, 26)
        Me.txtPushServerPort.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "PushServerPort : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPushServerHost
        '
        Me.txtPushServerHost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushServerHost.Location = New System.Drawing.Point(462, 162)
        Me.txtPushServerHost.Name = "txtPushServerHost"
        Me.txtPushServerHost.Size = New System.Drawing.Size(131, 26)
        Me.txtPushServerHost.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "PushServerHost : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtServerPort
        '
        Me.txtServerPort.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerPort.Location = New System.Drawing.Point(157, 159)
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(131, 26)
        Me.txtServerPort.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ServerPort : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(647, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Language : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInterval
        '
        Me.txtInterval.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterval.Location = New System.Drawing.Point(462, 210)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(131, 26)
        Me.txtInterval.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(342, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Interval : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "PushEnable : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOpenDoorDelay
        '
        Me.txtOpenDoorDelay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenDoorDelay.Location = New System.Drawing.Point(768, 258)
        Me.txtOpenDoorDelay.Name = "txtOpenDoorDelay"
        Me.txtOpenDoorDelay.Size = New System.Drawing.Size(131, 26)
        Me.txtOpenDoorDelay.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(647, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 19)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "OpenDoorDelay : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAntiPass
        '
        Me.txtAntiPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntiPass.Location = New System.Drawing.Point(462, 258)
        Me.txtAntiPass.Name = "txtAntiPass"
        Me.txtAntiPass.Size = New System.Drawing.Size(131, 26)
        Me.txtAntiPass.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(342, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "AntiPass : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolume
        '
        Me.txtVolume.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.Location = New System.Drawing.Point(157, 255)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(131, 26)
        Me.txtVolume.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 19)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Volume : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReverifyTime
        '
        Me.txtReverifyTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReverifyTime.Location = New System.Drawing.Point(768, 304)
        Me.txtReverifyTime.Name = "txtReverifyTime"
        Me.txtReverifyTime.Size = New System.Drawing.Size(131, 26)
        Me.txtReverifyTime.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(647, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 19)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "ReverifyTime : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAlarmDelay
        '
        Me.txtAlarmDelay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarmDelay.Location = New System.Drawing.Point(462, 304)
        Me.txtAlarmDelay.Name = "txtAlarmDelay"
        Me.txtAlarmDelay.Size = New System.Drawing.Size(131, 26)
        Me.txtAlarmDelay.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(342, 307)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 19)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "AlarmDelay : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 19)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "TamperAlarm : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMatchThreshold
        '
        Me.txtMatchThreshold.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatchThreshold.Location = New System.Drawing.Point(768, 492)
        Me.txtMatchThreshold.Name = "txtMatchThreshold"
        Me.txtMatchThreshold.Size = New System.Drawing.Size(131, 26)
        Me.txtMatchThreshold.TabIndex = 62
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(647, 495)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 19)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Match Threshold : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLiveThreshold
        '
        Me.txtLiveThreshold.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiveThreshold.Location = New System.Drawing.Point(462, 492)
        Me.txtLiveThreshold.Name = "txtLiveThreshold"
        Me.txtLiveThreshold.Size = New System.Drawing.Size(131, 26)
        Me.txtLiveThreshold.TabIndex = 60
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(342, 495)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 19)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Live Threshold : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMultiCheck
        '
        Me.txtMultiCheck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMultiCheck.Location = New System.Drawing.Point(157, 489)
        Me.txtMultiCheck.Name = "txtMultiCheck"
        Me.txtMultiCheck.Size = New System.Drawing.Size(131, 26)
        Me.txtMultiCheck.TabIndex = 58
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 492)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 19)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "MultiCheck : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBrightLedEnd
        '
        Me.txtBrightLedEnd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrightLedEnd.Location = New System.Drawing.Point(768, 446)
        Me.txtBrightLedEnd.Name = "txtBrightLedEnd"
        Me.txtBrightLedEnd.Size = New System.Drawing.Size(131, 26)
        Me.txtBrightLedEnd.TabIndex = 56
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(647, 449)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 19)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Bright End : "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBrightLedStart
        '
        Me.txtBrightLedStart.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrightLedStart.Location = New System.Drawing.Point(462, 446)
        Me.txtBrightLedStart.Name = "txtBrightLedStart"
        Me.txtBrightLedStart.Size = New System.Drawing.Size(131, 26)
        Me.txtBrightLedStart.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(342, 449)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 19)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Bright Start : "
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(33, 446)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 19)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Bright Mode : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(647, 401)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 19)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Living : "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInOut
        '
        Me.txtInOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInOut.Location = New System.Drawing.Point(462, 398)
        Me.txtInOut.Name = "txtInOut"
        Me.txtInOut.Size = New System.Drawing.Size(131, 26)
        Me.txtInOut.TabIndex = 48
        '
        'Label23
        '
        Me.Label23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(342, 401)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 19)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "InOut : "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDistance
        '
        Me.txtDistance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistance.Location = New System.Drawing.Point(157, 395)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(131, 26)
        Me.txtDistance.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(33, 398)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 19)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Distance : "
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(647, 353)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(92, 19)
        Me.Label25.TabIndex = 43
        Me.Label25.Text = "VerifyMode : "
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSleepTime
        '
        Me.txtSleepTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSleepTime.Location = New System.Drawing.Point(462, 350)
        Me.txtSleepTime.Name = "txtSleepTime"
        Me.txtSleepTime.Size = New System.Drawing.Size(131, 26)
        Me.txtSleepTime.TabIndex = 42
        '
        'Label26
        '
        Me.Label26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(342, 353)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 19)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "SleepTime : "
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtScreenSaverTime
        '
        Me.txtScreenSaverTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScreenSaverTime.Location = New System.Drawing.Point(157, 347)
        Me.txtScreenSaverTime.Name = "txtScreenSaverTime"
        Me.txtScreenSaverTime.Size = New System.Drawing.Size(131, 26)
        Me.txtScreenSaverTime.TabIndex = 40
        '
        'Label27
        '
        Me.Label27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(33, 350)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(126, 19)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "ScreenSaverTime : "
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbWiegandType
        '
        Me.cmbWiegandType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWiegandType.FormattingEnabled = True
        Me.cmbWiegandType.Location = New System.Drawing.Point(462, 119)
        Me.cmbWiegandType.Name = "cmbWiegandType"
        Me.cmbWiegandType.Size = New System.Drawing.Size(131, 27)
        Me.cmbWiegandType.TabIndex = 63
        '
        'cmbPushEnable
        '
        Me.cmbPushEnable.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPushEnable.FormattingEnabled = True
        Me.cmbPushEnable.Location = New System.Drawing.Point(157, 205)
        Me.cmbPushEnable.Name = "cmbPushEnable"
        Me.cmbPushEnable.Size = New System.Drawing.Size(131, 27)
        Me.cmbPushEnable.TabIndex = 64
        '
        'cmbTamperAlarm
        '
        Me.cmbTamperAlarm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTamperAlarm.FormattingEnabled = True
        Me.cmbTamperAlarm.Location = New System.Drawing.Point(157, 305)
        Me.cmbTamperAlarm.Name = "cmbTamperAlarm"
        Me.cmbTamperAlarm.Size = New System.Drawing.Size(131, 27)
        Me.cmbTamperAlarm.TabIndex = 65
        '
        'cmbBrightLedMode
        '
        Me.cmbBrightLedMode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrightLedMode.FormattingEnabled = True
        Me.cmbBrightLedMode.Location = New System.Drawing.Point(157, 441)
        Me.cmbBrightLedMode.Name = "cmbBrightLedMode"
        Me.cmbBrightLedMode.Size = New System.Drawing.Size(131, 27)
        Me.cmbBrightLedMode.TabIndex = 66
        '
        'cmbLiving
        '
        Me.cmbLiving.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLiving.FormattingEnabled = True
        Me.cmbLiving.Location = New System.Drawing.Point(768, 397)
        Me.cmbLiving.Name = "cmbLiving"
        Me.cmbLiving.Size = New System.Drawing.Size(131, 27)
        Me.cmbLiving.TabIndex = 67
        '
        'cmbVerifyMode
        '
        Me.cmbVerifyMode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVerifyMode.FormattingEnabled = True
        Me.cmbVerifyMode.Location = New System.Drawing.Point(768, 349)
        Me.cmbVerifyMode.Name = "cmbVerifyMode"
        Me.cmbVerifyMode.Size = New System.Drawing.Size(131, 27)
        Me.cmbVerifyMode.TabIndex = 68
        '
        'cmbLanguage
        '
        Me.cmbLanguage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Location = New System.Drawing.Point(768, 209)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(131, 27)
        Me.cmbLanguage.TabIndex = 69
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(790, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 19)
        Me.lblStatus.TabIndex = 77
        '
        'frmDeviceSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 558)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.cmbVerifyMode)
        Me.Controls.Add(Me.cmbLiving)
        Me.Controls.Add(Me.cmbBrightLedMode)
        Me.Controls.Add(Me.cmbTamperAlarm)
        Me.Controls.Add(Me.cmbPushEnable)
        Me.Controls.Add(Me.cmbWiegandType)
        Me.Controls.Add(Me.txtMatchThreshold)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtLiveThreshold)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtMultiCheck)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBrightLedEnd)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBrightLedStart)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtInOut)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtSleepTime)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtScreenSaverTime)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtReverifyTime)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAlarmDelay)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtOpenDoorDelay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAntiPass)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPushServerPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPushServerHost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtServerPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtServerHost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDeviceName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdSetDeviceSetting)
        Me.Controls.Add(Me.cmdGetDeviceSetting)
        Me.Name = "frmDeviceSetting"
        Me.Text = "frmDeviceSetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGetDeviceSetting As System.Windows.Forms.Button
    Friend WithEvents cmdSetDeviceSetting As System.Windows.Forms.Button
    Friend WithEvents txtDeviceName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerHost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPushServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPushServerHost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOpenDoorDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAntiPass As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtReverifyTime As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAlarmDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMatchThreshold As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLiveThreshold As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMultiCheck As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBrightLedEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBrightLedStart As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtInOut As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSleepTime As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtScreenSaverTime As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbWiegandType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPushEnable As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTamperAlarm As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBrightLedMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLiving As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVerifyMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
