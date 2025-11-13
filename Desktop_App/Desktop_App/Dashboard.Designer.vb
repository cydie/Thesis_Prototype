<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        pnlMain = New Panel()
        btnHistory = New Button()
        picLogo = New PictureBox()
        btnPause = New Button()
        btnPOSType = New Button()
        pnlAlerts = New Panel()
        lblAlertsContent = New Label()
        lblAlertsTitle = New Label()
        btnStop = New Button()
        pnlSystemStatus = New Panel()
        lblStatusDetails = New Label()
        lblStatusValue = New Label()
        lblStatusTitle = New Label()
        lstSystemLog = New ListBox()
        lblSystemLogTitle = New Label()
        pnlProgressRAM = New Panel()
        lblRAMValue = New Label()
        lblRAMTitle = New Label()
        pnlProgressCPU = New Panel()
        lblCPUValue = New Label()
        lblCPUTitle = New Label()
        pnlProgressPOS = New Panel()
        lblPOSValue = New Label()
        lblPOSLabel = New Label()
        lblKPI = New Label()
        lblTitle = New Label()
        btnEmergencyShutdown = New Button()
        btnClose = New Button()
        btnMaximize = New Button()
        btnMinimize = New Button()
        lblFooter = New Label()
        pnlMain.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlAlerts.SuspendLayout()
        pnlSystemStatus.SuspendLayout()
        pnlProgressRAM.SuspendLayout()
        pnlProgressCPU.SuspendLayout()
        pnlProgressPOS.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMain.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(25))
        pnlMain.Controls.Add(btnHistory)
        pnlMain.Controls.Add(picLogo)
        pnlMain.Controls.Add(btnPause)
        pnlMain.Controls.Add(btnPOSType)
        pnlMain.Controls.Add(pnlAlerts)
        pnlMain.Controls.Add(btnStop)
        pnlMain.Controls.Add(pnlSystemStatus)
        pnlMain.Controls.Add(lstSystemLog)
        pnlMain.Controls.Add(lblSystemLogTitle)
        pnlMain.Controls.Add(pnlProgressRAM)
        pnlMain.Controls.Add(pnlProgressCPU)
        pnlMain.Controls.Add(pnlProgressPOS)
        pnlMain.Controls.Add(lblKPI)
        pnlMain.Controls.Add(lblTitle)
        pnlMain.Controls.Add(btnEmergencyShutdown)
        pnlMain.Location = New Point(12, 16)
        pnlMain.Margin = New Padding(3, 4, 3, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(27, 32, 27, 32)
        pnlMain.Size = New Size(1350, 848)
        pnlMain.TabIndex = 1
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.FromArgb(CByte(30), CByte(60), CByte(35))
        btnHistory.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(200), CByte(120))
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(43, 451)
        btnHistory.Margin = New Padding(3, 4, 3, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(215, 59)
        btnHistory.TabIndex = 3
        btnHistory.Text = "HISTORY"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BackgroundImageLayout = ImageLayout.Zoom
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(10, 13)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(305, 232)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 4
        picLogo.TabStop = False
        ' 
        ' btnPause
        ' 
        btnPause.BackColor = Color.FromArgb(CByte(30), CByte(60), CByte(35))
        btnPause.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(200), CByte(120))
        btnPause.FlatStyle = FlatStyle.Flat
        btnPause.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnPause.ForeColor = Color.White
        btnPause.Location = New Point(55, 270)
        btnPause.Margin = New Padding(3, 4, 3, 4)
        btnPause.Name = "btnPause"
        btnPause.Size = New Size(215, 59)
        btnPause.TabIndex = 0
        btnPause.Text = "PAUSE"
        btnPause.UseVisualStyleBackColor = False
        ' 
        ' btnPOSType
        ' 
        btnPOSType.BackColor = Color.FromArgb(CByte(30), CByte(60), CByte(35))
        btnPOSType.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(200), CByte(120))
        btnPOSType.FlatStyle = FlatStyle.Flat
        btnPOSType.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnPOSType.ForeColor = Color.White
        btnPOSType.Location = New Point(55, 366)
        btnPOSType.Margin = New Padding(3, 4, 3, 4)
        btnPOSType.Name = "btnPOSType"
        btnPOSType.Size = New Size(215, 59)
        btnPOSType.TabIndex = 2
        btnPOSType.Text = "POS TYPE"
        btnPOSType.UseVisualStyleBackColor = False
        ' 
        ' pnlAlerts
        ' 
        pnlAlerts.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlAlerts.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(18))
        pnlAlerts.BorderStyle = BorderStyle.FixedSingle
        pnlAlerts.Controls.Add(lblAlertsContent)
        pnlAlerts.Controls.Add(lblAlertsTitle)
        pnlAlerts.ForeColor = Color.White
        pnlAlerts.Location = New Point(981, 64)
        pnlAlerts.Margin = New Padding(3, 4, 3, 4)
        pnlAlerts.Name = "pnlAlerts"
        pnlAlerts.Size = New Size(341, 357)
        pnlAlerts.TabIndex = 9
        ' 
        ' lblAlertsContent
        ' 
        lblAlertsContent.AutoSize = True
        lblAlertsContent.Font = New Font("Consolas", 10.0F)
        lblAlertsContent.ForeColor = Color.White
        lblAlertsContent.Location = New Point(18, 75)
        lblAlertsContent.Name = "lblAlertsContent"
        lblAlertsContent.Size = New Size(225, 20)
        lblAlertsContent.TabIndex = 1
        lblAlertsContent.Text = "No Anomaly ............."
        ' 
        ' lblAlertsTitle
        ' 
        lblAlertsTitle.AutoSize = True
        lblAlertsTitle.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblAlertsTitle.ForeColor = Color.FromArgb(CByte(255), CByte(80), CByte(80))
        lblAlertsTitle.Location = New Point(18, 27)
        lblAlertsTitle.Name = "lblAlertsTitle"
        lblAlertsTitle.Size = New Size(164, 23)
        lblAlertsTitle.TabIndex = 0
        lblAlertsTitle.Text = "ACTIVE ALERTYS"
        ' 
        ' btnStop
        ' 
        btnStop.BackColor = Color.FromArgb(CByte(30), CByte(60), CByte(35))
        btnStop.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(200), CByte(120))
        btnStop.FlatStyle = FlatStyle.Flat
        btnStop.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnStop.ForeColor = Color.White
        btnStop.Location = New Point(312, 451)
        btnStop.Margin = New Padding(3, 4, 3, 4)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(215, 59)
        btnStop.TabIndex = 1
        btnStop.Text = "STOP"
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' pnlSystemStatus
        ' 
        pnlSystemStatus.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        pnlSystemStatus.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(15))
        pnlSystemStatus.BorderStyle = BorderStyle.FixedSingle
        pnlSystemStatus.Controls.Add(lblStatusDetails)
        pnlSystemStatus.Controls.Add(lblStatusValue)
        pnlSystemStatus.Controls.Add(lblStatusTitle)
        pnlSystemStatus.Location = New Point(1002, 443)
        pnlSystemStatus.Margin = New Padding(3, 4, 3, 4)
        pnlSystemStatus.Name = "pnlSystemStatus"
        pnlSystemStatus.Size = New Size(320, 229)
        pnlSystemStatus.TabIndex = 8
        ' 
        ' lblStatusDetails
        ' 
        lblStatusDetails.AutoSize = True
        lblStatusDetails.Font = New Font("Consolas", 10.0F)
        lblStatusDetails.ForeColor = Color.White
        lblStatusDetails.Location = New Point(18, 101)
        lblStatusDetails.Name = "lblStatusDetails"
        lblStatusDetails.Size = New Size(234, 40)
        lblStatusDetails.TabIndex = 2
        lblStatusDetails.Text = "All critical services are" & vbCrLf & "operational."
        ' 
        ' lblStatusValue
        ' 
        lblStatusValue.AutoSize = True
        lblStatusValue.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblStatusValue.ForeColor = Color.FromArgb(CByte(120), CByte(255), CByte(160))
        lblStatusValue.Location = New Point(18, 64)
        lblStatusValue.Name = "lblStatusValue"
        lblStatusValue.Size = New Size(164, 23)
        lblStatusValue.TabIndex = 1
        lblStatusValue.Text = "Status: NORMAL"
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblStatusTitle.ForeColor = Color.White
        lblStatusTitle.Location = New Point(18, 24)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(153, 23)
        lblStatusTitle.TabIndex = 0
        lblStatusTitle.Text = "System Status"
        ' 
        ' lstSystemLog
        ' 
        lstSystemLog.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lstSystemLog.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(12))
        lstSystemLog.BorderStyle = BorderStyle.None
        lstSystemLog.Font = New Font("Consolas", 10.0F)
        lstSystemLog.ForeColor = Color.FromArgb(CByte(120), CByte(255), CByte(160))
        lstSystemLog.FormattingEnabled = True
        lstSystemLog.Location = New Point(10, 608)
        lstSystemLog.Margin = New Padding(3, 4, 3, 4)
        lstSystemLog.Name = "lstSystemLog"
        lstSystemLog.Size = New Size(975, 200)
        lstSystemLog.TabIndex = 7
        ' 
        ' lblSystemLogTitle
        ' 
        lblSystemLogTitle.AutoSize = True
        lblSystemLogTitle.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblSystemLogTitle.ForeColor = Color.White
        lblSystemLogTitle.Location = New Point(30, 545)
        lblSystemLogTitle.Name = "lblSystemLogTitle"
        lblSystemLogTitle.Size = New Size(263, 23)
        lblSystemLogTitle.TabIndex = 6
        lblSystemLogTitle.Text = "POS System Health Trend"
        ' 
        ' pnlProgressRAM
        ' 
        pnlProgressRAM.BackColor = Color.Transparent
        pnlProgressRAM.Controls.Add(lblRAMValue)
        pnlProgressRAM.Controls.Add(lblRAMTitle)
        pnlProgressRAM.Location = New Point(814, 318)
        pnlProgressRAM.Margin = New Padding(3, 4, 3, 4)
        pnlProgressRAM.Name = "pnlProgressRAM"
        pnlProgressRAM.Size = New Size(142, 213)
        pnlProgressRAM.TabIndex = 5
        ' 
        ' lblRAMValue
        ' 
        lblRAMValue.Anchor = AnchorStyles.Bottom
        lblRAMValue.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblRAMValue.ForeColor = Color.White
        lblRAMValue.Location = New Point(0, 160)
        lblRAMValue.Name = "lblRAMValue"
        lblRAMValue.Size = New Size(142, 32)
        lblRAMValue.TabIndex = 1
        lblRAMValue.Text = "20%"
        lblRAMValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRAMTitle
        ' 
        lblRAMTitle.AutoSize = True
        lblRAMTitle.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblRAMTitle.ForeColor = Color.White
        lblRAMTitle.Location = New Point(55, 91)
        lblRAMTitle.Name = "lblRAMTitle"
        lblRAMTitle.Size = New Size(43, 23)
        lblRAMTitle.TabIndex = 0
        lblRAMTitle.Text = "RAM"
        ' 
        ' pnlProgressCPU
        ' 
        pnlProgressCPU.BackColor = Color.Transparent
        pnlProgressCPU.Controls.Add(lblCPUValue)
        pnlProgressCPU.Controls.Add(lblCPUTitle)
        pnlProgressCPU.Location = New Point(621, 224)
        pnlProgressCPU.Margin = New Padding(3, 4, 3, 4)
        pnlProgressCPU.Name = "pnlProgressCPU"
        pnlProgressCPU.Size = New Size(163, 222)
        pnlProgressCPU.TabIndex = 4
        ' 
        ' lblCPUValue
        ' 
        lblCPUValue.Anchor = AnchorStyles.Bottom
        lblCPUValue.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblCPUValue.ForeColor = Color.White
        lblCPUValue.Location = New Point(10, 169)
        lblCPUValue.Name = "lblCPUValue"
        lblCPUValue.Size = New Size(142, 32)
        lblCPUValue.TabIndex = 1
        lblCPUValue.Text = "10%"
        lblCPUValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCPUTitle
        ' 
        lblCPUTitle.AutoSize = True
        lblCPUTitle.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblCPUTitle.ForeColor = Color.White
        lblCPUTitle.Location = New Point(56, 96)
        lblCPUTitle.Name = "lblCPUTitle"
        lblCPUTitle.Size = New Size(43, 23)
        lblCPUTitle.TabIndex = 0
        lblCPUTitle.Text = "CPU"
        ' 
        ' pnlProgressPOS
        ' 
        pnlProgressPOS.BackColor = Color.Transparent
        pnlProgressPOS.Controls.Add(lblPOSValue)
        pnlProgressPOS.Controls.Add(lblPOSLabel)
        pnlProgressPOS.Location = New Point(335, 109)
        pnlProgressPOS.Margin = New Padding(3, 4, 3, 4)
        pnlProgressPOS.Name = "pnlProgressPOS"
        pnlProgressPOS.Size = New Size(251, 321)
        pnlProgressPOS.TabIndex = 3
        ' 
        ' lblPOSValue
        ' 
        lblPOSValue.Anchor = AnchorStyles.Bottom
        lblPOSValue.Font = New Font("Consolas", 18.0F, FontStyle.Bold)
        lblPOSValue.ForeColor = Color.White
        lblPOSValue.Location = New Point(11, 236)
        lblPOSValue.Name = "lblPOSValue"
        lblPOSValue.Size = New Size(229, 53)
        lblPOSValue.TabIndex = 1
        lblPOSValue.Text = "80%"
        lblPOSValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPOSLabel
        ' 
        lblPOSLabel.AutoSize = True
        lblPOSLabel.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblPOSLabel.ForeColor = Color.White
        lblPOSLabel.Location = New Point(60, 131)
        lblPOSLabel.Name = "lblPOSLabel"
        lblPOSLabel.Size = New Size(131, 46)
        lblPOSLabel.TabIndex = 0
        lblPOSLabel.Text = "    POS " & vbCrLf & "Performance"
        ' 
        ' lblKPI
        ' 
        lblKPI.AutoSize = True
        lblKPI.BackColor = Color.Transparent
        lblKPI.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblKPI.ForeColor = Color.White
        lblKPI.Location = New Point(335, 64)
        lblKPI.Name = "lblKPI"
        lblKPI.Size = New Size(296, 23)
        lblKPI.TabIndex = 2
        lblKPI.Text = "KEY PERFORMANCE INDICATORS"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Consolas", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(335, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(383, 36)
        lblTitle.TabIndex = 1
        lblTitle.Text = "SYSTEM MONITOR & CONTROL"
        ' 
        ' btnEmergencyShutdown
        ' 
        btnEmergencyShutdown.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEmergencyShutdown.BackColor = Color.FromArgb(CByte(40), CByte(120), CByte(60))
        btnEmergencyShutdown.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(200), CByte(120))
        btnEmergencyShutdown.FlatStyle = FlatStyle.Flat
        btnEmergencyShutdown.Font = New Font("Consolas", 10F, FontStyle.Bold)
        btnEmergencyShutdown.ForeColor = Color.White
        btnEmergencyShutdown.Location = New Point(1089, 715)
        btnEmergencyShutdown.Margin = New Padding(3, 4, 3, 4)
        btnEmergencyShutdown.Name = "btnEmergencyShutdown"
        btnEmergencyShutdown.Size = New Size(192, 59)
        btnEmergencyShutdown.TabIndex = 0
        btnEmergencyShutdown.Text = "Emergency shutdown"
        btnEmergencyShutdown.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnClose.Location = New Point(1320, 13)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(46, 40)
        btnClose.TabIndex = 10
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnMaximize
        ' 
        btnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximize.BackColor = Color.Transparent
        btnMaximize.FlatAppearance.BorderSize = 0
        btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnMaximize.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnMaximize.Location = New Point(1269, 13)
        btnMaximize.Margin = New Padding(3, 4, 3, 4)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(46, 40)
        btnMaximize.TabIndex = 11
        btnMaximize.Text = "□"
        btnMaximize.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnMinimize.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnMinimize.Location = New Point(1217, 13)
        btnMinimize.Margin = New Padding(3, 4, 3, 4)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(46, 40)
        btnMinimize.TabIndex = 12
        btnMinimize.Text = "−"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.Anchor = AnchorStyles.Bottom
        lblFooter.AutoSize = True
        lblFooter.Font = New Font("Segoe UI", 10F)
        lblFooter.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        lblFooter.Location = New Point(528, 848)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(303, 23)
        lblFooter.TabIndex = 13
        lblFooter.Text = "RePOS Predictive Maintenance System"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(25))
        ClientSize = New Size(1376, 880)
        Controls.Add(lblFooter)
        Controls.Add(btnClose)
        Controls.Add(btnMaximize)
        Controls.Add(btnMinimize)
        Controls.Add(pnlMain)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RePOS - System Monitor & Control"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlAlerts.ResumeLayout(False)
        pnlAlerts.PerformLayout()
        pnlSystemStatus.ResumeLayout(False)
        pnlSystemStatus.PerformLayout()
        pnlProgressRAM.ResumeLayout(False)
        pnlProgressRAM.PerformLayout()
        pnlProgressCPU.ResumeLayout(False)
        pnlProgressCPU.PerformLayout()
        pnlProgressPOS.ResumeLayout(False)
        pnlProgressPOS.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnEmergencyShutdown As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblKPI As Label
    Friend WithEvents pnlProgressPOS As Panel
    Friend WithEvents lblPOSValue As Label
    Friend WithEvents lblPOSLabel As Label
    Friend WithEvents pnlProgressCPU As Panel
    Friend WithEvents lblCPUValue As Label
    Friend WithEvents lblCPUTitle As Label
    Friend WithEvents pnlProgressRAM As Panel
    Friend WithEvents lblRAMValue As Label
    Friend WithEvents lblRAMTitle As Label
    Friend WithEvents lstSystemLog As ListBox
    Friend WithEvents lblSystemLogTitle As Label
    Friend WithEvents pnlSystemStatus As Panel
    Friend WithEvents lblStatusDetails As Label
    Friend WithEvents lblStatusValue As Label
    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents pnlAlerts As Panel
    Friend WithEvents lblAlertsContent As Label
    Friend WithEvents lblAlertsTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPOSType As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents picLogo As PictureBox
End Class