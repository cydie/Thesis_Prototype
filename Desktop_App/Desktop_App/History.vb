Public Class History
    Private selectedDate As DateTime = DateTime.Now
    Private calendarButtons As List(Of Button) = New List(Of Button)()

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties - same theme as Dashboard
        Me.BackColor = Color.FromArgb(20, 20, 25)
        Me.DoubleBuffered = True

        ' Add custom paint events
        AddHandler pnlMain.Paint, AddressOf PnlMain_Paint
        AddHandler pnlCalendar.Paint, AddressOf PnlCalendar_Paint

        ' Initialize calendar
        InitializeCalendar()

        ' Initialize event log with sample data
        InitializeEventLog()

        ' Set button states
        btnHistory.BackColor = Color.FromArgb(0, 200, 100)
        btnHistory.ForeColor = Color.White
        btnAnalysisReport.BackColor = Color.FromArgb(30, 60, 35)
        btnAnalysisReport.ForeColor = Color.FromArgb(150, 150, 150)
        
        ' Ensure top bar is on top
        pnlTopBar.BringToFront()
    End Sub

    Private Sub PnlMain_Paint(sender As Object, e As PaintEventArgs)
        ' Draw grid pattern background - same as Dashboard
        Dim gridColor As Color = Color.FromArgb(30, 0, 200, 100) ' Subtle green
        Dim gridPen As New Pen(gridColor, 1)

        Dim spacing As Integer = 30
        Dim startX As Integer = 0
        Dim startY As Integer = 0

        ' Draw vertical lines
        For x As Integer = startX To pnlMain.Width Step spacing
            e.Graphics.DrawLine(gridPen, x, 0, x, pnlMain.Height)
        Next

        ' Draw horizontal lines
        For y As Integer = startY To pnlMain.Height Step spacing
            e.Graphics.DrawLine(gridPen, 0, y, pnlMain.Width, y)
        Next

        ' Draw gradient glow effect from top-left (subtle)
        Dim glowBrush As New System.Drawing.Drawing2D.LinearGradientBrush(
            New Point(0, 0),
            New Point(pnlMain.Width, pnlMain.Height),
            Color.FromArgb(20, 0, 200, 100),
            Color.FromArgb(0, 0, 200, 100)
        )
        e.Graphics.FillRectangle(glowBrush, 0, 0, pnlMain.Width, pnlMain.Height)

        gridPen.Dispose()
        glowBrush.Dispose()
    End Sub

    Private Sub PnlCalendar_Paint(sender As Object, e As PaintEventArgs)
        ' Draw border around calendar
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        e.Graphics.DrawRectangle(borderPen, 0, 0, pnlCalendar.Width - 1, pnlCalendar.Height - 1)
        borderPen.Dispose()
    End Sub

    Private Sub InitializeCalendar()
        ' Set current month to July 2024
        selectedDate = New DateTime(2024, 7, 1)
        lblMonthYear.Text = "JULY 2024"

        ' Clear existing calendar buttons
        For Each btn As Button In calendarButtons
            pnlCalendarGrid.Controls.Remove(btn)
            btn.Dispose()
        Next
        calendarButtons.Clear()

        ' Get first day of month and number of days
        Dim firstDay As DateTime = New DateTime(selectedDate.Year, selectedDate.Month, 1)
        Dim daysInMonth As Integer = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month)
        Dim startDayOfWeek As Integer = CInt(firstDay.DayOfWeek)

        ' Get previous month's last days
        Dim prevMonth As DateTime = selectedDate.AddMonths(-1)
        Dim daysInPrevMonth As Integer = DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month)

        ' Create calendar grid (6 rows x 7 columns)
        Dim cellWidth As Integer = pnlCalendarGrid.Width \ 7
        Dim cellHeight As Integer = pnlCalendarGrid.Height \ 6
        Dim buttonSize As Integer = Math.Min(cellWidth - 4, cellHeight - 4)

        ' Dates to highlight (from image: 4, 12, 14, 21, 25, 28)
        Dim highlightDates As New List(Of Integer) From {4, 12, 14, 21, 25, 28}

        ' Create buttons for each day
        Dim dayCounter As Integer = 1
        Dim prevMonthDayCounter As Integer = daysInPrevMonth - startDayOfWeek + 1

        For row As Integer = 0 To 5
            For col As Integer = 0 To 6
                Dim btn As New Button()
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.Font = New Font("Consolas", 9.0F)
                btn.Size = New Size(buttonSize, buttonSize)
                btn.Location = New Point(col * cellWidth + (cellWidth - buttonSize) \ 2, row * cellHeight + (cellHeight - buttonSize) \ 2)
                btn.TextAlign = ContentAlignment.MiddleCenter

                If row = 0 AndAlso col < startDayOfWeek Then
                    ' Previous month days
                    btn.Text = prevMonthDayCounter.ToString()
                    btn.ForeColor = Color.FromArgb(100, 100, 100)
                    btn.BackColor = Color.Transparent
                    prevMonthDayCounter += 1
                ElseIf dayCounter <= daysInMonth Then
                    ' Current month days
                    btn.Text = dayCounter.ToString()
                    btn.ForeColor = Color.White
                    btn.BackColor = Color.Transparent

                    ' Highlight specific dates with circular green background
                    Dim isHighlighted As Boolean = highlightDates.Contains(dayCounter)
                    If isHighlighted Then
                        btn.BackColor = Color.FromArgb(0, 200, 100)
                        btn.ForeColor = Color.White
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 220, 110)
                        ' Make button circular using Region
                        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
                        path.AddEllipse(0, 0, btn.Width, btn.Height)
                        btn.Region = New Region(path)
                    End If

                    ' Store the date for click handling
                    Dim currentDay As Integer = dayCounter
                    AddHandler btn.Click, Sub() CalendarDay_Click(currentDay)

                    dayCounter += 1
                Else
                    ' Next month days
                    Dim nextMonthDay As Integer = dayCounter - daysInMonth
                    btn.Text = nextMonthDay.ToString()
                    btn.ForeColor = Color.FromArgb(100, 100, 100)
                    btn.BackColor = Color.Transparent
                    dayCounter += 1
                End If

                calendarButtons.Add(btn)
                pnlCalendarGrid.Controls.Add(btn)
            Next
        Next
    End Sub

    Private Sub CalendarDay_Click(day As Integer)
        ' Update selected date
        selectedDate = New DateTime(selectedDate.Year, selectedDate.Month, day)
        
        ' Refresh event log for selected date
        RefreshEventLog()
    End Sub

    Private Sub InitializeEventLog()
        ' Initialize with sample event log entries from the image
        Dim events As New List(Of String) From {
            "[2023-10-27 10:45:12] ALERT RESOLVED: POS-007 Offline (Location: Main Counter). Action: Power cycle performed by User: Cydric.",
            "[2023-10-27 10:38:55] WARNING ACKNOWLEDGED: Server CPU Utilization > 90%. Action: Acknowledged by User: Espencer.",
            "[2023-10-27 10:30:00] USER ACTION: User: Espencer initiated ""Run Diagnostics"" on Server Farm A.",
            "[2023-10-27 10:20:00] INFO LOG: Low Stock Alert - Item #INV456 (Threshold: 10 units, Current: 8 units). Action: Reorder process initiated.",
            "[2023-10-27 10:15:05] MAINTENANCE: Performed routine system backup. Status: Successful.",
            "[2023-10-27 10:10:30] ALERT RESOLVED: Network Switch 1 Port 8 - Link Down. Action: Cable reseated by User: Cydric.",
            "[2023-10-27 09:55:40] CONFIGURATION CHANGE: Updated Firewall Rule Set (Version 3.1) by User: Admin.",
            "[2023-10-27 09:30:10] SYSTEM LOG: Scheduled database optimization completed. Duration: 15 min.",
            "[2023-10-27 09:00:00] ALERT LOG: Database Backup Failed - Last 24 Hours. Action: Manual backup initiated by User: Admin."
        }

        txtEventLog.Text = String.Join(vbCrLf, events)
        txtEventLog.SelectionStart = 0
        txtEventLog.SelectionLength = 0
    End Sub

    Private Sub RefreshEventLog()
        ' Refresh event log based on selected date
        ' In a real application, this would filter events by date
        InitializeEventLog()
    End Sub


    ' Window control button handlers
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            btnMaximize.Text = "□"
        Else
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.Text = "❐"
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Navigate back to Dashboard
        Dim dashboardForm As Dashboard = Nothing
        
        ' Try to find existing Dashboard form
        For Each form As Form In Application.OpenForms
            If TypeOf form Is Dashboard Then
                dashboardForm = DirectCast(form, Dashboard)
                Exit For
            End If
        Next
        
        ' If Dashboard not found, create a new one
        If dashboardForm Is Nothing Then
            dashboardForm = New Dashboard()
        End If
        
        ' Show Dashboard and close History
        dashboardForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ' History button clicked - we're already on History form, just ensure it's highlighted
        btnHistory.BackColor = Color.FromArgb(0, 200, 100)
        btnHistory.ForeColor = Color.White
        btnAnalysisReport.BackColor = Color.FromArgb(30, 60, 35)
        btnAnalysisReport.ForeColor = Color.FromArgb(150, 150, 150)

        ' No navigation needed - already on History form
    End Sub

    Private Sub BtnAnalysisReport_Click(sender As Object, e As EventArgs) Handles btnAnalysisReport.Click
        ' Navigate to Analysis Report form
        Dim analysisReportForm As Analysis_Report = Nothing

        ' Try to find existing Analysis Report form
        For Each form As Form In Application.OpenForms
            If TypeOf form Is Analysis_Report Then
                analysisReportForm = DirectCast(form, Analysis_Report)
                Exit For
            End If
        Next

        ' If Analysis Report not found, create a new one
        If analysisReportForm Is Nothing Then
            analysisReportForm = New Analysis_Report()
            analysisReportForm.Show()
        Else
            ' If form exists, bring it to front
            analysisReportForm.BringToFront()
            analysisReportForm.WindowState = FormWindowState.Normal
            analysisReportForm.Show()
        End If

        ' Hide current form instead of closing
        Me.Hide()
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        ' Clean up calendar buttons
        For Each btn As Button In calendarButtons
            btn.Dispose()
        Next
        calendarButtons.Clear()
        MyBase.OnFormClosing(e)
    End Sub
End Class

