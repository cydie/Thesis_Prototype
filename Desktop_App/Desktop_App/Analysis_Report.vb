Public Class Analysis_Report
    Private selectedDate As DateTime = DateTime.Now
    Private calendarButtons As List(Of Button) = New List(Of Button)()

    Private Sub Analysis_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties - same theme as Dashboard
        Me.BackColor = Color.FromArgb(20, 20, 25)
        Me.DoubleBuffered = True

        ' Add custom paint events
        AddHandler pnlMain.Paint, AddressOf PnlMain_Paint
        AddHandler pnlCalendar.Paint, AddressOf PnlCalendar_Paint

        ' Initialize calendar
        InitializeCalendar()

        ' Initialize report content
        InitializeReportContent()

        ' Set button states
        btnAnalysisReport.BackColor = Color.FromArgb(0, 200, 100)
        btnAnalysisReport.ForeColor = Color.White
        btnHistory.BackColor = Color.FromArgb(30, 60, 35)
        btnHistory.ForeColor = Color.FromArgb(150, 150, 150)
        
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
        
        ' Refresh report content for selected date
        RefreshReportContent()
    End Sub

    Private Sub InitializeReportContent()
        ' Initialize with sample report content from the image
        Dim content As String = "• MTTR (Mean Time to Repair): 1.5 hrs" & vbCrLf & vbCrLf &
                                "  Definition: The average time it takes to repair a failed system or component." & vbCrLf & vbCrLf &
                                "  Trend: Improved by 0.3 hours from Q3 (1.8 hrs), achieving the target." & vbCrLf & vbCrLf &
                                "  Impact: Faster resolution times minimize operational disruption and costs."

        txtMetricsContent.Text = content
        txtMetricsContent.SelectionStart = 0
        txtMetricsContent.SelectionLength = 0
    End Sub

    Private Sub RefreshReportContent()
        ' Refresh report content based on selected date
        ' In a real application, this would filter report data by date
        InitializeReportContent()
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
        
        ' Show Dashboard and close Analysis Report
        dashboardForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ' Navigate to History form
        Dim historyForm As History = Nothing
        
        ' Try to find existing History form
        For Each form As Form In Application.OpenForms
            If TypeOf form Is History Then
                historyForm = DirectCast(form, History)
                Exit For
            End If
        Next
        
        ' If History not found, create a new one
        If historyForm Is Nothing Then
            historyForm = New History()
            historyForm.Show()
        Else
            ' If form exists, bring it to front
            historyForm.BringToFront()
            historyForm.WindowState = FormWindowState.Normal
            historyForm.Show()
        End If
        
        ' Hide current form instead of closing
        Me.Hide()
    End Sub

    Private Sub BtnAnalysisReport_Click(sender As Object, e As EventArgs) Handles btnAnalysisReport.Click
        ' Analysis Report button clicked - we're already on Analysis Report form, just ensure it's highlighted
        btnAnalysisReport.BackColor = Color.FromArgb(0, 200, 100)
        btnAnalysisReport.ForeColor = Color.White
        btnHistory.BackColor = Color.FromArgb(30, 60, 35)
        btnHistory.ForeColor = Color.FromArgb(150, 150, 150)
        
        ' No navigation needed - already on Analysis Report form
    End Sub

    Private Sub BtnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        ' Navigate to previous month
        selectedDate = selectedDate.AddMonths(-1)
        UpdateCalendar()
    End Sub

    Private Sub BtnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        ' Navigate to next month
        selectedDate = selectedDate.AddMonths(1)
        UpdateCalendar()
    End Sub

    Private Sub UpdateCalendar()
        ' Update month/year label
        lblMonthYear.Text = selectedDate.ToString("MMMM yyyy").ToUpper()
        
        ' Reinitialize calendar
        InitializeCalendar()
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

