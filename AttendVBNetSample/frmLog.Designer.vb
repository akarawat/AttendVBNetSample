<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gridLogView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAllLogCount = New System.Windows.Forms.Label()
        Me.chkNewLog = New System.Windows.Forms.CheckBox()
        Me.chkReadMark = New System.Windows.Forms.CheckBox()
        Me.txtBeginTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEndTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPageCount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdGetLogData = New System.Windows.Forms.Button()
        Me.cmdGetLogDataPage = New System.Windows.Forms.Button()
        Me.cmdClearLogData = New System.Windows.Forms.Button()
        CType(Me.gridLogView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(1174, 14)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 27)
        Me.lblStatus.TabIndex = 78
        '
        'gridLogView
        '
        Me.gridLogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLogView.Location = New System.Drawing.Point(36, 105)
        Me.gridLogView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gridLogView.Name = "gridLogView"
        Me.gridLogView.RowHeadersWidth = 62
        Me.gridLogView.Size = New System.Drawing.Size(1248, 645)
        Me.gridLogView.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 27)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Total : "
        '
        'lblAllLogCount
        '
        Me.lblAllLogCount.AutoSize = True
        Me.lblAllLogCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllLogCount.Location = New System.Drawing.Point(123, 66)
        Me.lblAllLogCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAllLogCount.Name = "lblAllLogCount"
        Me.lblAllLogCount.Size = New System.Drawing.Size(24, 27)
        Me.lblAllLogCount.TabIndex = 81
        Me.lblAllLogCount.Text = "0"
        '
        'chkNewLog
        '
        Me.chkNewLog.AutoSize = True
        Me.chkNewLog.Checked = True
        Me.chkNewLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNewLog.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNewLog.Location = New System.Drawing.Point(957, 65)
        Me.chkNewLog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkNewLog.Name = "chkNewLog"
        Me.chkNewLog.Size = New System.Drawing.Size(127, 31)
        Me.chkNewLog.TabIndex = 82
        Me.chkNewLog.Text = "New Log"
        Me.chkNewLog.UseVisualStyleBackColor = True
        '
        'chkReadMark
        '
        Me.chkReadMark.AutoSize = True
        Me.chkReadMark.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReadMark.Location = New System.Drawing.Point(1132, 66)
        Me.chkReadMark.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkReadMark.Name = "chkReadMark"
        Me.chkReadMark.Size = New System.Drawing.Size(140, 31)
        Me.chkReadMark.TabIndex = 83
        Me.chkReadMark.Text = "ReadMark"
        Me.chkReadMark.UseVisualStyleBackColor = True
        '
        'txtBeginTime
        '
        Me.txtBeginTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeginTime.Location = New System.Drawing.Point(168, 789)
        Me.txtBeginTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBeginTime.Name = "txtBeginTime"
        Me.txtBeginTime.Size = New System.Drawing.Size(169, 35)
        Me.txtBeginTime.TabIndex = 85
        Me.txtBeginTime.Text = "20260101"
        Me.txtBeginTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 794)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 27)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Begin Time :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEndTime
        '
        Me.txtEndTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndTime.Location = New System.Drawing.Point(168, 849)
        Me.txtEndTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(169, 35)
        Me.txtEndTime.TabIndex = 87
        Me.txtEndTime.Text = "20260131"
        Me.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 855)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 27)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "End Time :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPageCount
        '
        Me.txtPageCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPageCount.Location = New System.Drawing.Point(507, 855)
        Me.txtPageCount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPageCount.Name = "txtPageCount"
        Me.txtPageCount.Size = New System.Drawing.Size(122, 35)
        Me.txtPageCount.TabIndex = 91
        Me.txtPageCount.Text = "30"
        Me.txtPageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 860)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 27)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Page Count :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPage
        '
        Me.txtPage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPage.Location = New System.Drawing.Point(507, 795)
        Me.txtPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(122, 35)
        Me.txtPage.TabIndex = 89
        Me.txtPage.Text = "0"
        Me.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 802)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 27)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Page :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdGetLogData
        '
        Me.cmdGetLogData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetLogData.Location = New System.Drawing.Point(682, 795)
        Me.cmdGetLogData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdGetLogData.Name = "cmdGetLogData"
        Me.cmdGetLogData.Size = New System.Drawing.Size(178, 94)
        Me.cmdGetLogData.TabIndex = 92
        Me.cmdGetLogData.Text = "Get Log Data"
        Me.cmdGetLogData.UseVisualStyleBackColor = True
        '
        'cmdGetLogDataPage
        '
        Me.cmdGetLogDataPage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetLogDataPage.Location = New System.Drawing.Point(894, 797)
        Me.cmdGetLogDataPage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdGetLogDataPage.Name = "cmdGetLogDataPage"
        Me.cmdGetLogDataPage.Size = New System.Drawing.Size(178, 94)
        Me.cmdGetLogDataPage.TabIndex = 93
        Me.cmdGetLogDataPage.Text = "Get Log Data Page"
        Me.cmdGetLogDataPage.UseVisualStyleBackColor = True
        '
        'cmdClearLogData
        '
        Me.cmdClearLogData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearLogData.Location = New System.Drawing.Point(1106, 795)
        Me.cmdClearLogData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdClearLogData.Name = "cmdClearLogData"
        Me.cmdClearLogData.Size = New System.Drawing.Size(178, 94)
        Me.cmdClearLogData.TabIndex = 94
        Me.cmdClearLogData.Text = "Clear Log Data"
        Me.cmdClearLogData.UseVisualStyleBackColor = True
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 932)
        Me.Controls.Add(Me.cmdClearLogData)
        Me.Controls.Add(Me.cmdGetLogDataPage)
        Me.Controls.Add(Me.cmdGetLogData)
        Me.Controls.Add(Me.txtPageCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEndTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBeginTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkReadMark)
        Me.Controls.Add(Me.chkNewLog)
        Me.Controls.Add(Me.lblAllLogCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridLogView)
        Me.Controls.Add(Me.lblStatus)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLog"
        Me.Text = "frmLog"
        CType(Me.gridLogView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents gridLogView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAllLogCount As System.Windows.Forms.Label
    Friend WithEvents chkNewLog As System.Windows.Forms.CheckBox
    Friend WithEvents chkReadMark As System.Windows.Forms.CheckBox
    Friend WithEvents txtBeginTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEndTime As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPageCount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPage As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdGetLogData As System.Windows.Forms.Button
    Friend WithEvents cmdGetLogDataPage As System.Windows.Forms.Button
    Friend WithEvents cmdClearLogData As System.Windows.Forms.Button
End Class
