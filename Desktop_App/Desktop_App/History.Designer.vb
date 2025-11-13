<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        pnlMain = New Panel()
        pnlRight = New Panel()
        txtEventLog = New TextBox()
        lblHistoryTitle = New Label()
        pnlHeader = New Panel()
        btnAnalysisReport = New Button()
        btnHistory = New Button()
        pnlLeft = New Panel()
        btnBack = New Button()
        pnlSystemStatus = New Panel()
        lblStatusDetails = New Label()
        lblStatusValue = New Label()
        lblStatusTitle = New Label()
        pnlCalendar = New Panel()
        pnlCalendarGrid = New Panel()
        lblDaysOfWeek = New Label()
        lblMonthYear = New Label()
        picLogo = New PictureBox()
        pnlTopBar = New Panel()
        btnClose = New Button()
        btnMaximize = New Button()
        btnMinimize = New Button()
        pnlMain.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        pnlSystemStatus.SuspendLayout()
        pnlCalendar.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.Transparent
        pnlMain.Controls.Add(pnlRight)
        pnlMain.Controls.Add(pnlLeft)
        pnlMain.Controls.Add(pnlTopBar)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Margin = New Padding(3, 4, 3, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1376, 880)
        pnlMain.TabIndex = 0
        ' 
        ' pnlRight
        ' 
        pnlRight.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRight.BackColor = Color.Transparent
        pnlRight.Controls.Add(txtEventLog)
        pnlRight.Controls.Add(lblHistoryTitle)
        pnlRight.Controls.Add(pnlHeader)
        pnlRight.Location = New Point(400, 50)
        pnlRight.Margin = New Padding(3, 4, 3, 4)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(30)
        pnlRight.Size = New Size(976, 817)
        pnlRight.TabIndex = 2
        ' 
        ' txtEventLog
        ' 
        txtEventLog.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEventLog.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(12))
        txtEventLog.BorderStyle = BorderStyle.None
        txtEventLog.Font = New Font("Consolas", 10F)
        txtEventLog.ForeColor = Color.White
        txtEventLog.Location = New Point(9, 146)
        txtEventLog.Margin = New Padding(3, 4, 3, 4)
        txtEventLog.Multiline = True
        txtEventLog.Name = "txtEventLog"
        txtEventLog.ReadOnly = True
        txtEventLog.ScrollBars = ScrollBars.Vertical
        txtEventLog.Size = New Size(955, 637)
        txtEventLog.TabIndex = 2
        ' 
        ' lblHistoryTitle
        ' 
        lblHistoryTitle.AutoSize = True
        lblHistoryTitle.Font = New Font("Consolas", 16F, FontStyle.Bold)
        lblHistoryTitle.ForeColor = Color.White
        lblHistoryTitle.Location = New Point(30, 110)
        lblHistoryTitle.Name = "lblHistoryTitle"
        lblHistoryTitle.Size = New Size(119, 32)
        lblHistoryTitle.TabIndex = 1
        lblHistoryTitle.Text = "HISTORY"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(btnAnalysisReport)
        pnlHeader.Controls.Add(btnHistory)
        pnlHeader.Location = New Point(30, 30)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(916, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' btnAnalysisReport
        ' 
        btnAnalysisReport.BackColor = Color.FromArgb(CByte(30), CByte(60), CByte(35))
        btnAnalysisReport.FlatAppearance.BorderSize = 0
        btnAnalysisReport.FlatStyle = FlatStyle.Flat
        btnAnalysisReport.Font = New Font("Consolas", 14F, FontStyle.Bold)
        btnAnalysisReport.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        btnAnalysisReport.Location = New Point(200, 0)
        btnAnalysisReport.Margin = New Padding(3, 4, 3, 4)
        btnAnalysisReport.Name = "btnAnalysisReport"
        btnAnalysisReport.Size = New Size(300, 60)
        btnAnalysisReport.TabIndex = 1
        btnAnalysisReport.Text = "ANALYSIS REPORT"
        btnAnalysisReport.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Consolas", 14F, FontStyle.Bold)
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(0, 0)
        btnHistory.Margin = New Padding(3, 4, 3, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(200, 60)
        btnHistory.TabIndex = 0
        btnHistory.Text = "HISTORY"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' pnlLeft
        ' 
        pnlLeft.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlLeft.BackColor = Color.Transparent
        pnlLeft.Controls.Add(btnBack)
        pnlLeft.Controls.Add(pnlSystemStatus)
        pnlLeft.Controls.Add(pnlCalendar)
        pnlLeft.Controls.Add(picLogo)
        pnlLeft.Location = New Point(0, 50)
        pnlLeft.Margin = New Padding(3, 4, 3, 4)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(20)
        pnlLeft.Size = New Size(400, 830)
        pnlLeft.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBack.BackColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Consolas", 12F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(23, 746)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(360, 60)
        btnBack.TabIndex = 4
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' pnlSystemStatus
        ' 
        pnlSystemStatus.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(15))
        pnlSystemStatus.BorderStyle = BorderStyle.FixedSingle
        pnlSystemStatus.Controls.Add(lblStatusDetails)
        pnlSystemStatus.Controls.Add(lblStatusValue)
        pnlSystemStatus.Controls.Add(lblStatusTitle)
        pnlSystemStatus.Location = New Point(20, 570)
        pnlSystemStatus.Margin = New Padding(3, 4, 3, 4)
        pnlSystemStatus.Name = "pnlSystemStatus"
        pnlSystemStatus.Size = New Size(360, 150)
        pnlSystemStatus.TabIndex = 3
        ' 
        ' lblStatusDetails
        ' 
        lblStatusDetails.AutoSize = True
        lblStatusDetails.Font = New Font("Consolas", 10F)
        lblStatusDetails.ForeColor = Color.White
        lblStatusDetails.Location = New Point(15, 85)
        lblStatusDetails.Name = "lblStatusDetails"
        lblStatusDetails.Size = New Size(234, 40)
        lblStatusDetails.TabIndex = 2
        lblStatusDetails.Text = "All critical services are" & vbCrLf & "operational."
        ' 
        ' lblStatusValue
        ' 
        lblStatusValue.AutoSize = True
        lblStatusValue.Font = New Font("Consolas", 12F, FontStyle.Bold)
        lblStatusValue.ForeColor = Color.FromArgb(CByte(120), CByte(255), CByte(160))
        lblStatusValue.Location = New Point(15, 50)
        lblStatusValue.Name = "lblStatusValue"
        lblStatusValue.Size = New Size(164, 23)
        lblStatusValue.TabIndex = 1
        lblStatusValue.Text = "Status: NORMAL"
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Consolas", 12F, FontStyle.Bold)
        lblStatusTitle.ForeColor = Color.White
        lblStatusTitle.Location = New Point(15, 15)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(153, 23)
        lblStatusTitle.TabIndex = 0
        lblStatusTitle.Text = "System Status"
        ' 
        ' pnlCalendar
        ' 
        pnlCalendar.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(25))
        pnlCalendar.BorderStyle = BorderStyle.FixedSingle
        pnlCalendar.Controls.Add(pnlCalendarGrid)
        pnlCalendar.Controls.Add(lblDaysOfWeek)
        pnlCalendar.Controls.Add(lblMonthYear)
        pnlCalendar.Location = New Point(20, 200)
        pnlCalendar.Margin = New Padding(3, 4, 3, 4)
        pnlCalendar.Name = "pnlCalendar"
        pnlCalendar.Size = New Size(360, 350)
        pnlCalendar.TabIndex = 2
        ' 
        ' pnlCalendarGrid
        ' 
        pnlCalendarGrid.Location = New Point(10, 80)
        pnlCalendarGrid.Margin = New Padding(3, 4, 3, 4)
        pnlCalendarGrid.Name = "pnlCalendarGrid"
        pnlCalendarGrid.Size = New Size(340, 260)
        pnlCalendarGrid.TabIndex = 2
        ' 
        ' lblDaysOfWeek
        ' 
        lblDaysOfWeek.AutoSize = True
        lblDaysOfWeek.Font = New Font("Consolas", 9F)
        lblDaysOfWeek.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        lblDaysOfWeek.Location = New Point(10, 50)
        lblDaysOfWeek.Name = "lblDaysOfWeek"
        lblDaysOfWeek.Size = New Size(272, 18)
        lblDaysOfWeek.TabIndex = 1
        lblDaysOfWeek.Text = "SUN  MON  TUE  WED  THU  FRI  SAT"
        ' 
        ' lblMonthYear
        ' 
        lblMonthYear.AutoSize = True
        lblMonthYear.Font = New Font("Consolas", 12F, FontStyle.Bold)
        lblMonthYear.ForeColor = Color.White
        lblMonthYear.Location = New Point(10, 15)
        lblMonthYear.Name = "lblMonthYear"
        lblMonthYear.Size = New Size(109, 23)
        lblMonthYear.TabIndex = 0
        lblMonthYear.Text = "JULY 2024"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), Image)
        picLogo.BackgroundImageLayout = ImageLayout.Zoom
        picLogo.Location = New Point(20, 20)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(204, 158)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.Transparent
        pnlTopBar.Controls.Add(btnClose)
        pnlTopBar.Controls.Add(btnMaximize)
        pnlTopBar.Controls.Add(btnMinimize)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Margin = New Padding(3, 4, 3, 4)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(1376, 50)
        pnlTopBar.TabIndex = 3
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
        btnClose.Location = New Point(1330, 5)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(46, 40)
        btnClose.TabIndex = 3
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
        btnMaximize.Location = New Point(1279, 5)
        btnMaximize.Margin = New Padding(3, 4, 3, 4)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(46, 40)
        btnMaximize.TabIndex = 4
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
        btnMinimize.Location = New Point(1227, 5)
        btnMinimize.Margin = New Padding(3, 4, 3, 4)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(46, 40)
        btnMinimize.TabIndex = 5
        btnMinimize.Text = "−"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(25))
        ClientSize = New Size(1376, 880)
        Controls.Add(pnlMain)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "History"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RePOS - History | Analysis Report"
        pnlMain.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlSystemStatus.ResumeLayout(False)
        pnlSystemStatus.PerformLayout()
        pnlCalendar.ResumeLayout(False)
        pnlCalendar.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlTopBar.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlCalendar As Panel
    Friend WithEvents lblMonthYear As Label
    Friend WithEvents lblDaysOfWeek As Label
    Friend WithEvents pnlCalendarGrid As Panel
    Friend WithEvents pnlSystemStatus As Panel
    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents lblStatusValue As Label
    Friend WithEvents lblStatusDetails As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnAnalysisReport As Button
    Friend WithEvents lblHistoryTitle As Label
    Friend WithEvents txtEventLog As TextBox
End Class

