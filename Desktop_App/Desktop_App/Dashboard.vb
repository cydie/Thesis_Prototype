Public Class Dashboard
    Private isPaused As Boolean = False
    Private progressTimer As System.Windows.Forms.Timer
    Private posProgress As Integer = 80
    Private cpuProgress As Integer = 10
    Private ramProgress As Integer = 20
    Private random As New Random()

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties - same theme as Login_Register
        Me.BackColor = Color.FromArgb(20, 20, 25)
        Me.DoubleBuffered = True

        ' Add custom paint events for progress bars and background
        AddHandler pnlMain.Paint, AddressOf PnlMain_Paint
        AddHandler pnlProgressPOS.Paint, AddressOf PnlProgressPOS_Paint
        AddHandler pnlProgressCPU.Paint, AddressOf PnlProgressCPU_Paint
        AddHandler pnlProgressRAM.Paint, AddressOf PnlProgressRAM_Paint
        AddHandler pnlAlerts.Paint, AddressOf PnlAlerts_Paint

        ' Initialize system log with sample entries
        InitializeSystemLog()

        ' Start progress timer for animated progress bars
        progressTimer = New System.Windows.Forms.Timer()
        progressTimer.Interval = 1000 ' Update every second
        AddHandler progressTimer.Tick, AddressOf ProgressTimer_Tick
        progressTimer.Start()
    End Sub

    Private Sub PnlMain_Paint(sender As Object, e As PaintEventArgs)
        ' Draw grid pattern background - same as Login_Register
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

        ' Draw gradient glow effect from top-left (subtle) - same as Login_Register
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

    Private Sub PnlProgressPOS_Paint(sender As Object, e As PaintEventArgs)
        DrawCircularProgress(e.Graphics, pnlProgressPOS, posProgress, 200, 200, Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlProgressCPU_Paint(sender As Object, e As PaintEventArgs)
        DrawCircularProgress(e.Graphics, pnlProgressCPU, cpuProgress, 150, 150, Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlProgressRAM_Paint(sender As Object, e As PaintEventArgs)
        DrawCircularProgress(e.Graphics, pnlProgressRAM, ramProgress, 150, 150, Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlAlerts_Paint(sender As Object, e As PaintEventArgs)
        ' Draw red border around alerts panel
        Dim borderPen As New Pen(Color.Red, 2)
        e.Graphics.DrawRectangle(borderPen, 0, 0, pnlAlerts.Width - 1, pnlAlerts.Height - 1)
        borderPen.Dispose()
    End Sub

    Private Sub DrawCircularProgress(g As Graphics, panel As Panel, percentage As Integer, width As Integer, height As Integer, color As Color)
        ' Draw circular progress bar (gauge style)
        Dim centerX As Integer = panel.Width \ 2
        Dim centerY As Integer = panel.Height \ 2
        Dim radius As Integer = Math.Min(width, height) \ 2 - 15
        Dim rect As New Rectangle(centerX - radius, centerY - radius, radius * 2, radius * 2)

        ' Draw background circle (dark gray)
        Dim bgPen As New Pen(Color.FromArgb(50, 50, 55), 10)
        bgPen.StartCap = System.Drawing.Drawing2D.LineCap.Round
        bgPen.EndCap = System.Drawing.Drawing2D.LineCap.Round
        g.DrawEllipse(bgPen, rect)
        bgPen.Dispose()

        ' Draw progress arc (bright green) - same color as Login_Register
        Dim progressPen As New Pen(color, 10)
        progressPen.StartCap = System.Drawing.Drawing2D.LineCap.Round
        progressPen.EndCap = System.Drawing.Drawing2D.LineCap.Round
        Dim sweepAngle As Single = (percentage / 100.0F) * 360.0F
        ' Start from top (-90 degrees) and draw clockwise
        g.DrawArc(progressPen, rect, -90, sweepAngle)
        progressPen.Dispose()
    End Sub

    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs)
        If Not isPaused Then
            ' Simulate progress changes with realistic variations
            posProgress = Math.Max(70, Math.Min(90, posProgress + random.Next(-2, 3)))
            cpuProgress = Math.Max(5, Math.Min(15, cpuProgress + random.Next(-1, 2)))
            ramProgress = Math.Max(15, Math.Min(25, ramProgress + random.Next(-1, 2)))

            ' Update labels
            lblPOSValue.Text = posProgress.ToString() & "%"
            lblCPUValue.Text = cpuProgress.ToString() & "%"
            lblRAMValue.Text = ramProgress.ToString() & "%"

            ' Redraw progress bars
            pnlProgressPOS.Invalidate()
            pnlProgressCPU.Invalidate()
            pnlProgressRAM.Invalidate()

            ' Add log entry periodically
            If random.Next(0, 10) = 0 Then
                AddLogEntry()
            End If
        End If
    End Sub

    Private Sub InitializeSystemLog()
        lstSystemLog.Items.Clear()
        lstSystemLog.Items.Add("[2023-10-27 10:35:01] System Load: 45% (Normal)")
        lstSystemLog.Items.Add("[2023-10-27 10:30:15] Network Latency: 12ms (Optimal)")
        lstSystemLog.Items.Add("[2023-10-27 10:25:40] Disk I/O: 120MB/s (Stable)")
        lstSystemLog.Items.Add("[2023-10-27 10:20:05] CPU Temp: 58°C (Normal)")
        lstSystemLog.Items.Add("[2023-10-27 10:15:30] Memory Usage: 6.2GB/16GB (Normal)")
        lstSystemLog.Items.Add("[2023-10-27 10:10:00] All Sub-Systems Reporting Nominal.")
        lstSystemLog.Items.Add("[2023-10-27 10:05:10] Database Connection: Stable.")
        lstSystemLog.Items.Add("[2023-10-27 10:00:00] Daily System Check Initiated.")
        lstSystemLog.TopIndex = 0
    End Sub

    Private Sub AddLogEntry()
        Dim timestamp As String = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]")
        Dim messages As String() = {
            "System Load: " & random.Next(40, 50) & "% (Normal)",
            "Network Latency: " & random.Next(10, 15) & "ms (Optimal)",
            "Disk I/O: " & random.Next(100, 130) & "MB/s (Stable)",
            "CPU Temp: " & random.Next(55, 60) & "°C (Normal)",
            "Memory Usage: " & String.Format("{0:F1}", random.Next(60, 70) / 10.0) & "GB/16GB (Normal)",
            "All Sub-Systems Reporting Nominal.",
            "Database Connection: Stable.",
            "POS Transaction Processed Successfully."
        }
        Dim message As String = timestamp & " " & messages(random.Next(messages.Length))
        lstSystemLog.Items.Insert(0, message)
        If lstSystemLog.Items.Count > 50 Then
            lstSystemLog.Items.RemoveAt(lstSystemLog.Items.Count - 1)
        End If
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        isPaused = Not isPaused
        If isPaused Then
            btnPause.Text = "START"
        Else
            btnPause.Text = "PAUSE"
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If MessageBox.Show("Are you sure you want to stop the system?", "Stop System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            progressTimer.Stop()
            MessageBox.Show("System stopped.", "Stop System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnPOSType_Click(sender As Object, e As EventArgs) Handles btnPOSType.Click
        MessageBox.Show("POS Type configuration will be implemented here.", "POS Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        MessageBox.Show("History view will be implemented here.", "History", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnEmergencyShutdown_Click(sender As Object, e As EventArgs) Handles btnEmergencyShutdown.Click
        If MessageBox.Show("WARNING: This will perform an emergency shutdown of the system. Are you sure?", "Emergency Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If MessageBox.Show("Final confirmation: Emergency shutdown will stop all services immediately. Continue?", "Emergency Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then
                progressTimer.Stop()
                MessageBox.Show("Emergency shutdown initiated.", "Emergency Shutdown", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ' Application.Exit() ' Uncomment to actually close the application
            End If
        End If
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If progressTimer IsNot Nothing Then
            progressTimer.Stop()
            progressTimer.Dispose()
        End If
        MyBase.OnFormClosing(e)
    End Sub
End Class
