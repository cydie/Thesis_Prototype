Public Class Type_Of_POS
    Private selectedPOS As String = ""
    Private cpuProgress As Integer = 20
    Private ramProgress As Integer = 40
    Private posButtons As List(Of Button) = New List(Of Button)()

    Private Sub Type_Of_POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties - same theme as Dashboard
        Me.BackColor = Color.FromArgb(20, 20, 25)
        Me.DoubleBuffered = True

        ' Add custom paint events
        AddHandler pnlMain.Paint, AddressOf PnlMain_Paint
        AddHandler pnlProgressCPU.Paint, AddressOf PnlProgressCPU_Paint
        AddHandler pnlProgressRAM.Paint, AddressOf PnlProgressRAM_Paint

        ' Initialize POS buttons list
        posButtons.AddRange({btnLoyverse, btnSquare, btnQuickPOS, btnMosaicPOS, btnIreapPOS, 
                            btnUtakPOS, btnPosibleNet, btnNRSPhilippines, btnVend, 
                            btnQuickbookPOS, btnShopifyPOS})

        ' Add click handlers to all POS buttons
        For Each btn As Button In posButtons
            AddHandler btn.Click, AddressOf POSButton_Click
        Next

        ' Initialize START button as disabled
        btnStart.BackColor = Color.FromArgb(40, 40, 45)
        btnStart.ForeColor = Color.FromArgb(150, 150, 150)
        btnStart.Enabled = False

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

    Private Sub PnlProgressCPU_Paint(sender As Object, e As PaintEventArgs)
        DrawCircularProgress(e.Graphics, pnlProgressCPU, cpuProgress, 100, 100, Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlProgressRAM_Paint(sender As Object, e As PaintEventArgs)
        DrawCircularProgress(e.Graphics, pnlProgressRAM, ramProgress, 100, 100, Color.FromArgb(0, 200, 100))
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

        ' Draw progress arc (bright green)
        Dim progressPen As New Pen(color, 10)
        progressPen.StartCap = System.Drawing.Drawing2D.LineCap.Round
        progressPen.EndCap = System.Drawing.Drawing2D.LineCap.Round
        Dim sweepAngle As Single = (percentage / 100.0F) * 360.0F
        ' Start from top (-90 degrees) and draw clockwise
        g.DrawArc(progressPen, rect, -90, sweepAngle)
        progressPen.Dispose()
    End Sub

    Private Sub POSButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = DirectCast(sender, Button)
        
        ' Reset all buttons to default state
        For Each btn As Button In posButtons
            btn.BackColor = Color.FromArgb(40, 40, 45)
            btn.ForeColor = Color.White
        Next
        
        ' Highlight selected button
        clickedButton.BackColor = Color.FromArgb(0, 200, 100)
        clickedButton.ForeColor = Color.White
        
        ' Store selected POS
        selectedPOS = clickedButton.Text
        
        ' Update prompt
        lblSelectPrompt.Text = "Selected: " & selectedPOS
        lblSelectPrompt.ForeColor = Color.FromArgb(0, 200, 100)
        
        ' Enable START button
        btnStart.BackColor = Color.FromArgb(0, 200, 100)
        btnStart.ForeColor = Color.White
        btnStart.Enabled = True
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If String.IsNullOrEmpty(selectedPOS) Then
            MessageBox.Show("Please select a POS system first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        
        ' Navigate to Dashboard
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
        
        ' Show Dashboard and close Type of POS
        dashboardForm.Show()
        Me.Close()
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
        
        ' Show Dashboard and close Type of POS
        dashboardForm.Show()
        Me.Close()
    End Sub
End Class

