' Dashboard.Designer.vb
' Full designer for the Dashboard form (RePOS UI)
' This file only handles UI initialization — logic lives in Dashboard.vb

Partial Class Dashboard
    Inherits Form

    ' Form Controls
    Private sidebar As Panel
    Private mainPanel As Panel
    Private btnPause As Button
    Private btnStop As Button
    Private btnPOSType As Button
    Private btnHistory As Button
    Private lblTitle As Label
    Private lblPOSPerformance As Label
    Private lblCPU As Label
    Private lblRAM As Label
    Private progressCPU As ProgressBar
    Private progressRAM As ProgressBar
    Private lblPOSPercent As Label
    Private progressPOS As ProgressBar
    Private rtbSystemHealth As RichTextBox
    Private lblStatus As Label
    Private btnEmergency As Button
    Private updateTimer As System.Windows.Forms.Timer

    ' === DESIGNER INITIALIZATION ===
    Private Sub InitializeComponent()
        Me.sidebar = New Panel()
        Me.mainPanel = New Panel()
        Me.btnPause = New Button()
        Me.btnStop = New Button()
        Me.btnPOSType = New Button()
        Me.btnHistory = New Button()
        Me.lblTitle = New Label()
        Me.lblPOSPerformance = New Label()
        Me.lblCPU = New Label()
        Me.lblRAM = New Label()
        Me.progressCPU = New ProgressBar()
        Me.progressRAM = New ProgressBar()
        Me.lblPOSPercent = New Label()
        Me.progressPOS = New ProgressBar()
        Me.rtbSystemHealth = New RichTextBox()
        Me.lblStatus = New Label()
        Me.btnEmergency = New Button()
        Me.updateTimer = New System.Windows.Forms.Timer()

        ' ======== FORM ========
        Me.SuspendLayout()
        Me.Text = "RePOS - System Monitor & Control"
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(1050, 640)
        Me.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)

        ' ======== SIDEBAR ========
        Me.sidebar.BackColor = Color.FromArgb(15, 15, 15)
        Me.sidebar.Location = New Point(10, 10)
        Me.sidebar.Size = New Size(160, 620)
        Me.sidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left

        ' Buttons
        Dim buttons = {Me.btnPause, Me.btnStop, Me.btnPOSType, Me.btnHistory}
        Dim buttonTexts = {"PAUSE", "STOP", "POS type", "HISTORY"}
        For i = 0 To buttons.Length - 1
            Dim b = buttons(i)
            b.Text = buttonTexts(i)
            b.Size = New Size(130, 36)
            b.Location = New Point(15, 60 + i * 60)
            b.FlatStyle = FlatStyle.Flat
            b.ForeColor = Color.White
            b.BackColor = Color.FromArgb(40, 40, 40)
            b.FlatAppearance.BorderSize = 1
            b.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            sidebar.Controls.Add(b)
        Next

        ' ======== MAIN PANEL ========
        Me.mainPanel.BackColor = Color.FromArgb(20, 20, 20)
        Me.mainPanel.Location = New Point(180, 10)
        Me.mainPanel.Size = New Size(850, 620)
        Me.mainPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        ' Title
        Me.lblTitle.Text = "SYSTEM MONITOR & CONTROL"
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Font = New Font("Consolas", 14, FontStyle.Bold)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New Point(10, 10)

        ' POS Performance
        Me.lblPOSPerformance.Text = "POS Performance"
        Me.lblPOSPerformance.ForeColor = Color.LightGreen
        Me.lblPOSPerformance.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblPOSPerformance.AutoSize = True
        Me.lblPOSPerformance.Location = New Point(20, 60)

        Me.progressPOS.Size = New Size(240, 40)
        Me.progressPOS.Location = New Point(20, 85)
        Me.progressPOS.Minimum = 0
        Me.progressPOS.Maximum = 100
        Me.progressPOS.Value = 0

        Me.lblPOSPercent.Text = "0%"
        Me.lblPOSPercent.ForeColor = Color.White
        Me.lblPOSPercent.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblPOSPercent.AutoSize = True
        Me.lblPOSPercent.Location = New Point(270, 88)

        ' CPU
        Me.lblCPU.Text = "CPU"
        Me.lblCPU.ForeColor = Color.White
        Me.lblCPU.Location = New Point(20, 150)
        Me.progressCPU.Size = New Size(220, 20)
        Me.progressCPU.Location = New Point(20, 170)
        Me.progressCPU.Minimum = 0
        Me.progressCPU.Maximum = 100

        ' RAM
        Me.lblRAM.Text = "RAM"
        Me.lblRAM.ForeColor = Color.White
        Me.lblRAM.Location = New Point(20, 200)
        Me.progressRAM.Size = New Size(220, 20)
        Me.progressRAM.Location = New Point(20, 220)
        Me.progressRAM.Minimum = 0
        Me.progressRAM.Maximum = 100

        ' POS System Health Trend
        Dim lblTrend As New Label()
        lblTrend.Text = "POS System Health Trend"
        lblTrend.ForeColor = Color.White
        lblTrend.Location = New Point(300, 60)
        lblTrend.AutoSize = True

        Me.rtbSystemHealth.Size = New Size(500, 240)
        Me.rtbSystemHealth.Location = New Point(300, 85)
        Me.rtbSystemHealth.ReadOnly = True
        Me.rtbSystemHealth.BackColor = Color.FromArgb(10, 10, 10)
        Me.rtbSystemHealth.ForeColor = Color.LightGreen
        Me.rtbSystemHealth.Font = New Font("Consolas", 9)

        ' System Status Panel
        Dim statusBox As New Panel()
        statusBox.Size = New Size(260, 140)
        statusBox.Location = New Point(300, 340)
        statusBox.BackColor = Color.FromArgb(25, 25, 25)
        statusBox.BorderStyle = BorderStyle.FixedSingle

        Me.lblStatus.Text = "Status: UNKNOWN"
        Me.lblStatus.ForeColor = Color.YellowGreen
        Me.lblStatus.Location = New Point(8, 8)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        statusBox.Controls.Add(Me.lblStatus)

        ' Emergency Button
        Me.btnEmergency.Text = "Emergency shutdown"
        Me.btnEmergency.Size = New Size(180, 28)
        Me.btnEmergency.Location = New Point(300, 500)
        Me.btnEmergency.FlatStyle = FlatStyle.Flat
        Me.btnEmergency.ForeColor = Color.White
        Me.btnEmergency.BackColor = Color.FromArgb(40, 40, 40)
        Me.btnEmergency.FlatAppearance.BorderSize = 1

        ' Timer
        Me.updateTimer.Interval = 1500

        ' Add Controls
        Me.Controls.Add(Me.sidebar)
        Me.Controls.Add(Me.mainPanel)

        Me.mainPanel.Controls.AddRange(New Control() {
            Me.lblTitle, Me.lblPOSPerformance, Me.progressPOS, Me.lblPOSPercent,
            Me.lblCPU, Me.progressCPU, Me.lblRAM, Me.progressRAM,
            lblTrend, Me.rtbSystemHealth, statusBox, Me.btnEmergency
        })

        Me.ResumeLayout(False)
    End Sub

End Class
