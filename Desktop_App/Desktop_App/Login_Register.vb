Public Class Login_Register
    Private isLoginMode As Boolean = True
    Private passwordVisible As Boolean = False
    Private confirmPasswordVisible As Boolean = False

    Private Sub Login_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.BackColor = Color.FromArgb(20, 20, 25)
        Me.DoubleBuffered = True

        ' Set panel border colors by removing FixedSingle and using custom painting
        pnlFormContainer.BorderStyle = BorderStyle.None
        pnlFullName.BorderStyle = BorderStyle.None
        pnlEmail.BorderStyle = BorderStyle.None
        pnlBusinessName.BorderStyle = BorderStyle.None
        pnlPassword.BorderStyle = BorderStyle.None
        pnlConfirmPassword.BorderStyle = BorderStyle.None

        ' Ensure textboxes are enabled and can receive focus
        txtEmail.Enabled = True
        txtPassword.Enabled = True
        txtBusinessName.Enabled = True
        txtConfirmPassword.Enabled = True
        txtFullName.Enabled = True

        ' Explicitly ensure all textboxes are not read-only and can receive input
        txtEmail.ReadOnly = False
        txtPassword.ReadOnly = False
        txtBusinessName.ReadOnly = False
        txtConfirmPassword.ReadOnly = False
        txtFullName.ReadOnly = False

        ' Ensure panels don't block mouse events - set TabStop to False so they don't receive focus
        pnlEmail.TabStop = False
        pnlPassword.TabStop = False
        pnlBusinessName.TabStop = False
        pnlConfirmPassword.TabStop = False
        pnlFullName.TabStop = False

        ' Make sure panels don't capture keyboard events
        pnlEmail.CausesValidation = False
        pnlPassword.CausesValidation = False
        pnlBusinessName.CausesValidation = False
        pnlConfirmPassword.CausesValidation = False
        pnlFullName.CausesValidation = False

        ' Make sure textboxes are on top and can receive focus
        ' Set child index to ensure textboxes are on top within their panels
        If pnlEmail.Controls.Contains(txtEmail) Then
            pnlEmail.Controls.SetChildIndex(txtEmail, 0)
        End If
        If pnlPassword.Controls.Contains(txtPassword) Then
            pnlPassword.Controls.SetChildIndex(txtPassword, 0)
        End If
        If pnlBusinessName.Controls.Contains(txtBusinessName) Then
            pnlBusinessName.Controls.SetChildIndex(txtBusinessName, 0)
        End If
        If pnlConfirmPassword.Controls.Contains(txtConfirmPassword) Then
            pnlConfirmPassword.Controls.SetChildIndex(txtConfirmPassword, 0)
        End If
        If pnlFullName.Controls.Contains(txtFullName) Then
            pnlFullName.Controls.SetChildIndex(txtFullName, 0)
        End If

        ' Add custom paint events for borders and icons
        AddHandler pnlFormContainer.Paint, AddressOf PnlFormContainer_Paint
        AddHandler pnlFullName.Paint, AddressOf PnlFullName_Paint
        AddHandler pnlEmail.Paint, AddressOf PnlEmail_Paint
        AddHandler pnlBusinessName.Paint, AddressOf PnlBusinessName_Paint
        AddHandler pnlPassword.Paint, AddressOf PnlPassword_Paint
        AddHandler pnlConfirmPassword.Paint, AddressOf PnlConfirmPassword_Paint

        ' Add mouse event handlers to ensure textboxes receive clicks
        AddHandler pnlFullName.MouseDown, AddressOf Panel_MouseDown
        AddHandler pnlEmail.MouseDown, AddressOf Panel_MouseDown
        AddHandler pnlBusinessName.MouseDown, AddressOf Panel_MouseDown
        AddHandler pnlPassword.MouseDown, AddressOf Panel_MouseDown
        AddHandler pnlConfirmPassword.MouseDown, AddressOf Panel_MouseDown

        ' Also add click handlers as backup
        AddHandler pnlFullName.Click, AddressOf Panel_Click
        AddHandler pnlEmail.Click, AddressOf Panel_Click
        AddHandler pnlBusinessName.Click, AddressOf Panel_Click
        AddHandler pnlPassword.Click, AddressOf Panel_Click
        AddHandler pnlConfirmPassword.Click, AddressOf Panel_Click

        ' Add key handlers to ensure textboxes receive keyboard input
        AddHandler pnlFullName.KeyDown, AddressOf Panel_KeyDown
        AddHandler pnlEmail.KeyDown, AddressOf Panel_KeyDown
        AddHandler pnlBusinessName.KeyDown, AddressOf Panel_KeyDown
        AddHandler pnlPassword.KeyDown, AddressOf Panel_KeyDown
        AddHandler pnlConfirmPassword.KeyDown, AddressOf Panel_KeyDown

        ' Initialize to login mode
        SwitchToLoginMode()

        ' Add custom paint event for grid background
        AddHandler pnlMain.Paint, AddressOf PnlMain_Paint

        ' Add paint event for tab container border
        AddHandler pnlTabContainer.Paint, AddressOf PnlTabContainer_Paint

        ' Add click event for terms link
        AddHandler lblTermsLink.Click, AddressOf LblTermsLink_Click
        lblTermsLink.Cursor = Cursors.Hand

        ' Add click event for forgot password
        AddHandler lblForgotPassword.Click, AddressOf LblForgotPassword_Click
        lblForgotPassword.Cursor = Cursors.Hand
    End Sub

    Private Sub PnlMain_Paint(sender As Object, e As PaintEventArgs)
        ' Draw grid pattern background (subtle green grid)
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
        Dim glowBrush As New Drawing2D.LinearGradientBrush(
            New Point(0, 0),
            New Point(pnlMain.Width, pnlMain.Height),
            Color.FromArgb(20, 0, 200, 100),
            Color.FromArgb(0, 0, 200, 100)
        )
        e.Graphics.FillRectangle(glowBrush, 0, 0, pnlMain.Width, pnlMain.Height)

        gridPen.Dispose()
        glowBrush.Dispose()
    End Sub

    Private Sub PnlTabContainer_Paint(sender As Object, e As PaintEventArgs)
        ' Draw border connecting tab container to form (top and sides, not bottom)
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        ' Top border
        e.Graphics.DrawLine(borderPen, 0, 0, pnlTabContainer.Width, 0)
        ' Left border
        e.Graphics.DrawLine(borderPen, 0, 0, 0, pnlTabContainer.Height)
        ' Right border
        e.Graphics.DrawLine(borderPen, pnlTabContainer.Width - 1, 0, pnlTabContainer.Width - 1, pnlTabContainer.Height)
        borderPen.Dispose()
    End Sub

    Private Sub BtnLoginTab_Click(sender As Object, e As EventArgs) Handles btnLoginTab.Click
        SwitchToLoginMode()
    End Sub

    Private Sub BtnSignUpTab_Click(sender As Object, e As EventArgs) Handles btnSignUpTab.Click
        SwitchToSignUpMode()
    End Sub

    Private Sub SwitchToLoginMode()
        isLoginMode = True

        ' Update tab buttons
        btnLoginTab.BackColor = Color.FromArgb(0, 200, 100)
        btnLoginTab.ForeColor = Color.White
        btnSignUpTab.BackColor = Color.FromArgb(30, 30, 35)
        btnSignUpTab.ForeColor = Color.FromArgb(150, 150, 150)

        ' Show/Hide login fields
        lblFullName.Visible = False
        pnlFullName.Visible = False
        lblBusinessName.Visible = False
        pnlBusinessName.Visible = False
        lblConfirmPassword.Visible = False
        pnlConfirmPassword.Visible = False
        chkAgreeTerms.Visible = False
        lblTermsLink.Visible = False
        btnCreateAccount.Visible = False

        ' Show login fields
        lblEmail.Visible = True
        pnlEmail.Visible = True
        lblPassword.Visible = True
        pnlPassword.Visible = True
        chkRememberMe.Visible = True
        lblForgotPassword.Visible = True
        btnLogin.Visible = True

        ' Adjust form container height and positions
        pnlFormContainer.Height = 380
        lblEmail.Location = New Point(30, 50)
        pnlEmail.Location = New Point(30, 75)
        lblPassword.Location = New Point(30, 130)
        pnlPassword.Location = New Point(30, 155)
        chkRememberMe.Location = New Point(30, 200)
        lblForgotPassword.Location = New Point(250, 200)
        btnLogin.Location = New Point(30, 250)

        ' Ensure textboxes are accessible
        txtEmail.BringToFront()
        txtPassword.BringToFront()

        ' Redraw to remove any leftover lines
        pnlFormContainer.Invalidate()
        Me.Refresh()
    End Sub

    Private Sub SwitchToSignUpMode()
        isLoginMode = False

        ' Update tab buttons
        btnSignUpTab.BackColor = Color.FromArgb(0, 200, 100)
        btnSignUpTab.ForeColor = Color.White
        btnLoginTab.BackColor = Color.FromArgb(30, 30, 35)
        btnLoginTab.ForeColor = Color.FromArgb(150, 150, 150)

        ' Hide login fields
        chkRememberMe.Visible = False
        lblForgotPassword.Visible = False
        btnLogin.Visible = False

        ' Show signup fields (Full Name, Email, Business Name, Password, Confirm Password)
        lblFullName.Visible = True
        pnlFullName.Visible = True
        lblEmail.Visible = True
        pnlEmail.Visible = True
        lblBusinessName.Visible = True
        pnlBusinessName.Visible = True
        lblPassword.Visible = True
        pnlPassword.Visible = True
        lblConfirmPassword.Visible = True
        pnlConfirmPassword.Visible = True
        chkAgreeTerms.Visible = True
        lblTermsLink.Visible = True
        btnCreateAccount.Visible = True

        ' Adjust form container height and positions with proper spacing
        ' Add more space after Create Account button
        ' Button at 470 + 40 button height + 30 space = 540
        pnlFormContainer.Height = 540
        ' Full Name - 50px from top
        lblFullName.Location = New Point(30, 50)
        pnlFullName.Location = New Point(30, 75)
        ' Email - 20px spacing from Full Name panel (75 + 35 + 20 = 130)
        lblEmail.Location = New Point(30, 130)
        pnlEmail.Location = New Point(30, 155)
        ' Business Name - 20px spacing from Email panel (155 + 35 + 20 = 210)
        lblBusinessName.Location = New Point(30, 210)
        pnlBusinessName.Location = New Point(30, 235)
        ' Password - 20px spacing from Business Name panel (235 + 35 + 20 = 290)
        lblPassword.Location = New Point(30, 290)
        pnlPassword.Location = New Point(30, 315)
        ' Confirm Password - 20px spacing from Password panel (315 + 35 + 20 = 370)
        lblConfirmPassword.Location = New Point(30, 370)
        pnlConfirmPassword.Location = New Point(30, 395)
        ' Terms checkbox - 15px spacing from Confirm Password panel (395 + 35 + 15 = 445)
        chkAgreeTerms.Location = New Point(30, 445)
        lblTermsLink.Location = New Point(50, 445)
        ' Create Account button - small spacing from Terms (445 + 20 + 5 = 470)
        btnCreateAccount.Location = New Point(30, 470)

        ' Force redraw of panels to ensure icons are visible
        pnlFullName.Invalidate()
        pnlEmail.Invalidate()
        pnlBusinessName.Invalidate()
        pnlPassword.Invalidate()
        pnlConfirmPassword.Invalidate()

        ' CRITICAL: Ensure all textboxes are on top and can receive input
        ' Force textboxes to be on top by removing and re-adding them to panels
        ' This ensures they're definitely accessible
        If pnlFullName.Controls.Contains(txtFullName) Then
            pnlFullName.Controls.Remove(txtFullName)
            pnlFullName.Controls.Add(txtFullName)
            txtFullName.BringToFront()
        End If

        If pnlEmail.Controls.Contains(txtEmail) Then
            pnlEmail.Controls.Remove(txtEmail)
            pnlEmail.Controls.Add(txtEmail)
            txtEmail.BringToFront()
        End If

        If pnlBusinessName.Controls.Contains(txtBusinessName) Then
            pnlBusinessName.Controls.Remove(txtBusinessName)
            pnlBusinessName.Controls.Add(txtBusinessName)
            txtBusinessName.BringToFront()
        End If

        If pnlPassword.Controls.Contains(txtPassword) Then
            pnlPassword.Controls.Remove(txtPassword)
            pnlPassword.Controls.Add(txtPassword)
            txtPassword.BringToFront()
        End If

        If pnlConfirmPassword.Controls.Contains(txtConfirmPassword) Then
            pnlConfirmPassword.Controls.Remove(txtConfirmPassword)
            pnlConfirmPassword.Controls.Add(txtConfirmPassword)
            txtConfirmPassword.BringToFront()
        End If

        ' Also bring the show password buttons to front (but after textboxes)
        If pnlPassword.Controls.Contains(btnShowPassword) Then
            btnShowPassword.BringToFront()
        End If
        If pnlConfirmPassword.Controls.Contains(btnShowConfirmPassword) Then
            btnShowConfirmPassword.BringToFront()
        End If

        ' Ensure ALL textboxes are enabled, not read-only, and can receive focus
        ' CRITICAL: Explicitly set properties for Full Name, Business Name, and Password
        txtFullName.Enabled = True
        txtFullName.ReadOnly = False
        txtFullName.TabStop = True
        txtFullName.Visible = True
        txtFullName.BringToFront()

        txtEmail.Enabled = True
        txtEmail.ReadOnly = False
        txtEmail.TabStop = True
        txtEmail.Visible = True

        txtBusinessName.Enabled = True
        txtBusinessName.ReadOnly = False
        txtBusinessName.TabStop = True
        txtBusinessName.Visible = True
        txtBusinessName.BringToFront()

        txtPassword.Enabled = True
        txtPassword.ReadOnly = False
        txtPassword.TabStop = True
        txtPassword.Visible = True
        txtPassword.BringToFront()

        txtConfirmPassword.Enabled = True
        txtConfirmPassword.ReadOnly = False
        txtConfirmPassword.TabStop = True
        txtConfirmPassword.Visible = True

        ' Redraw form container to remove any leftover lines
        pnlFormContainer.Invalidate()
        Me.Refresh()
    End Sub

    Private Sub BtnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        passwordVisible = Not passwordVisible
        If passwordVisible Then
            txtPassword.PasswordChar = ControlChars.NullChar
            btnShowPassword.Text = "👁"
        Else
            txtPassword.PasswordChar = ChrW(9679) ' Bullet character
            btnShowPassword.Text = "👁"
        End If
    End Sub

    Private Sub BtnShowConfirmPassword_Click(sender As Object, e As EventArgs) Handles btnShowConfirmPassword.Click
        confirmPasswordVisible = Not confirmPasswordVisible
        If confirmPasswordVisible Then
            txtConfirmPassword.PasswordChar = ControlChars.NullChar
            btnShowConfirmPassword.Text = "👁"
        Else
            txtConfirmPassword.PasswordChar = ChrW(9679) ' Bullet character
            btnShowConfirmPassword.Text = "👁"
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate login fields
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Add actual login logic here
        MessageBox.Show("Login functionality will be implemented here.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        ' Validate signup fields
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtBusinessName.Text) Then
            MessageBox.Show("Please enter your business name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not chkAgreeTerms.Checked Then
            MessageBox.Show("Please agree to the Terms of Service and Privacy Policy.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Add actual registration logic here
        MessageBox.Show("Registration functionality will be implemented here.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LblForgotPassword_Click(sender As Object, e As EventArgs)
        ' TODO: Implement forgot password functionality
        MessageBox.Show("Forgot password functionality will be implemented here.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LblTermsLink_Click(sender As Object, e As EventArgs)
        ' TODO: Open terms and privacy policy pages
        MessageBox.Show("Terms of Service and Privacy Policy links will be implemented here.", "Terms & Privacy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Add icon drawing functionality
    Private Sub DrawIcon(g As Graphics, iconType As String, bounds As Rectangle, color As Color)
        Select Case iconType.ToLower()
            Case "person"
                ' Draw person icon (simplified)
                Dim pen As New Pen(color, 2)
                ' Head
                g.DrawEllipse(pen, New Rectangle(bounds.X + 5, bounds.Y + 2, 12, 12))
                ' Body
                g.DrawLine(pen, New Point(bounds.X + 11, bounds.Y + 14), New Point(bounds.X + 11, bounds.Y + 22))
                ' Arms
                g.DrawLine(pen, New Point(bounds.X + 5, bounds.Y + 18), New Point(bounds.X + 17, bounds.Y + 18))
                pen.Dispose()
            Case "envelope"
                ' Draw envelope icon
                Dim pen As New Pen(color, 2)
                g.DrawRectangle(pen, New Rectangle(bounds.X + 5, bounds.Y + 5, 16, 12))
                g.DrawLine(pen, New Point(bounds.X + 5, bounds.Y + 11), New Point(bounds.X + 13, bounds.Y + 17))
                g.DrawLine(pen, New Point(bounds.X + 21, bounds.Y + 11), New Point(bounds.X + 13, bounds.Y + 17))
                pen.Dispose()
            Case "building"
                ' Draw briefcase/business icon
                Dim pen As New Pen(color, 2)
                ' Briefcase body
                g.DrawRectangle(pen, New Rectangle(bounds.X + 6, bounds.Y + 10, 14, 10))
                ' Briefcase handle (top arc)
                g.DrawArc(pen, New Rectangle(bounds.X + 8, bounds.Y + 8, 10, 4), 0, 180)
                ' Briefcase latch (center line)
                g.DrawLine(pen, New Point(bounds.X + 13, bounds.Y + 10), New Point(bounds.X + 13, bounds.Y + 20))
                pen.Dispose()
            Case "padlock"
                ' Draw padlock icon (lock icon) - clear and visible
                Dim pen As New Pen(color, 2)
                pen.Width = 2
                ' Lock body (rectangle at bottom)
                g.DrawRectangle(pen, New Rectangle(bounds.X + 8, bounds.Y + 15, 10, 8))
                ' Lock shackle (U-shaped arc on top)
                ' Draw the arc
                g.DrawArc(pen, New Rectangle(bounds.X + 8, bounds.Y + 10, 10, 8), 0, 180)
                ' Connect the arc to the rectangle with vertical lines
                g.DrawLine(pen, New Point(bounds.X + 8, bounds.Y + 15), New Point(bounds.X + 8, bounds.Y + 12))
                g.DrawLine(pen, New Point(bounds.X + 18, bounds.Y + 15), New Point(bounds.X + 18, bounds.Y + 12))
                pen.Dispose()
        End Select
    End Sub

    ' Paint events for input panels to add icons and borders
    Private Sub PnlFullName_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        ' Draw green border
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1)
        borderPen.Dispose()
        ' Draw icon (only in the left area, not over textbox)
        DrawIcon(e.Graphics, "person", New Rectangle(10, 5, 30, 25), Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlEmail_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        ' Draw green border
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1)
        borderPen.Dispose()
        ' Draw icon (only in the left area, not over textbox)
        DrawIcon(e.Graphics, "envelope", New Rectangle(10, 5, 30, 25), Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlBusinessName_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        ' Draw green border
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1)
        borderPen.Dispose()
        ' Draw icon (only in the left area, not over textbox)
        DrawIcon(e.Graphics, "building", New Rectangle(10, 5, 30, 25), Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlPassword_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        ' Draw green border
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1)
        borderPen.Dispose()
        ' Draw icon (only in the left area, not over textbox)
        DrawIcon(e.Graphics, "padlock", New Rectangle(10, 5, 30, 25), Color.FromArgb(0, 200, 100))
    End Sub

    Private Sub PnlConfirmPassword_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        ' Draw green border
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1)
        borderPen.Dispose()
        ' Draw icon (only in the left area, not over textbox)
        DrawIcon(e.Graphics, "padlock", New Rectangle(10, 5, 30, 25), Color.FromArgb(0, 200, 100))
    End Sub

    ' Ensure panels don't capture mouse events - they should pass through to child controls
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs)
        ' Forward mouse events to child controls - focus the textbox in the panel
        Dim panel As Panel = DirectCast(sender, Panel)
        ' Always find and focus the textbox in the panel when clicked
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                ' If clicked anywhere on the panel (except the very left icon area), focus the textbox
                ' Always focus the textbox regardless of click position (except icon area)
                If e.X >= 40 Then ' Icon area is roughly 0-40px, textbox starts at 50px
                    txtBox.Focus()
                    txtBox.Select()
                    ' Try to position cursor based on click location
                    If e.X >= txtBox.Left AndAlso e.X < txtBox.Left + txtBox.Width Then
                        ' Calculate approximate character position
                        Dim charPos As Integer = CInt((e.X - txtBox.Left) / (txtBox.Width / Math.Max(1, txtBox.TextLength + 1)))
                        txtBox.SelectionStart = Math.Min(charPos, txtBox.TextLength)
                    Else
                        txtBox.SelectionStart = txtBox.TextLength
                    End If
                    Return
                End If
            End If
        Next
    End Sub

    ' Also handle click events to ensure textboxes get focus
    Private Sub Panel_Click(sender As Object, e As EventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                txtBox.Focus()
                txtBox.Select()
                Return
            End If
        Next
    End Sub

    ' Handle key events to ensure textboxes receive keyboard input
    Private Sub Panel_KeyDown(sender As Object, e As KeyEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                If Not txtBox.Focused Then
                    txtBox.Focus()
                End If
                ' Forward the key event to the textbox
                txtBox.Focus()
                Return
            End If
        Next
    End Sub


    Private Sub PnlFormContainer_Paint(sender As Object, e As PaintEventArgs)
        ' Draw green border around form container (left, right, bottom - top connects to tab container)
        ' Only draw if we're in the correct mode to avoid leftover lines
        Dim borderPen As New Pen(Color.FromArgb(0, 200, 100), 1)
        ' Left border
        e.Graphics.DrawLine(borderPen, 0, 0, 0, pnlFormContainer.Height - 1)
        ' Right border
        e.Graphics.DrawLine(borderPen, pnlFormContainer.Width - 1, 0, pnlFormContainer.Width - 1, pnlFormContainer.Height - 1)
        ' Bottom border
        e.Graphics.DrawLine(borderPen, 0, pnlFormContainer.Height - 1, pnlFormContainer.Width, pnlFormContainer.Height - 1)
        borderPen.Dispose()
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
End Class

