<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Register))
        pnlMain = New Panel()
        btnClose = New Button()
        btnMaximize = New Button()
        btnMinimize = New Button()
        lblFooter = New Label()
        pnlFormContainer = New Panel()
        btnCreateAccount = New Button()
        chkAgreeTerms = New CheckBox()
        lblTermsLink = New Label()
        lblConfirmPassword = New Label()
        pnlConfirmPassword = New Panel()
        btnShowConfirmPassword = New Button()
        txtConfirmPassword = New TextBox()
        lblPassword = New Label()
        pnlPassword = New Panel()
        btnShowPassword = New Button()
        txtPassword = New TextBox()
        lblBusinessName = New Label()
        pnlBusinessName = New Panel()
        txtBusinessName = New TextBox()
        lblEmail = New Label()
        pnlEmail = New Panel()
        txtEmail = New TextBox()
        lblFullName = New Label()
        pnlFullName = New Panel()
        txtFullName = New TextBox()
        btnLogin = New Button()
        lblForgotPassword = New Label()
        chkRememberMe = New CheckBox()
        pnlTabContainer = New Panel()
        btnSignUpTab = New Button()
        btnLoginTab = New Button()
        picLogo = New PictureBox()
        pnlMain.SuspendLayout()
        pnlFormContainer.SuspendLayout()
        pnlConfirmPassword.SuspendLayout()
        pnlPassword.SuspendLayout()
        pnlBusinessName.SuspendLayout()
        pnlEmail.SuspendLayout()
        pnlFullName.SuspendLayout()
        pnlTabContainer.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(25))
        pnlMain.Controls.Add(btnClose)
        pnlMain.Controls.Add(btnMaximize)
        pnlMain.Controls.Add(btnMinimize)
        pnlMain.Controls.Add(lblFooter)
        pnlMain.Controls.Add(pnlFormContainer)
        pnlMain.Controls.Add(pnlTabContainer)
        pnlMain.Controls.Add(picLogo)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Margin = New Padding(3, 4, 3, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1371, 1067)
        pnlMain.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnClose.Location = New Point(1314, 13)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(46, 40)
        btnClose.TabIndex = 4
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnMaximize
        ' 
        btnMaximize.BackColor = Color.Transparent
        btnMaximize.FlatAppearance.BorderSize = 0
        btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnMaximize.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnMaximize.Location = New Point(1263, 13)
        btnMaximize.Margin = New Padding(3, 4, 3, 4)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(46, 40)
        btnMaximize.TabIndex = 5
        btnMaximize.Text = "□"
        btnMaximize.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnMinimize.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnMinimize.Location = New Point(1211, 13)
        btnMinimize.Margin = New Padding(3, 4, 3, 4)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(46, 40)
        btnMinimize.TabIndex = 6
        btnMinimize.Text = "−"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.AutoSize = True
        lblFooter.Font = New Font("Segoe UI", 10.0F)
        lblFooter.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        lblFooter.Location = New Point(528, 1035)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(303, 23)
        lblFooter.TabIndex = 3
        lblFooter.Text = "RePOS Predictive Maintenance System"
        ' 
        ' pnlFormContainer
        ' 
        pnlFormContainer.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(35))
        pnlFormContainer.BorderStyle = BorderStyle.FixedSingle
        pnlFormContainer.Controls.Add(btnCreateAccount)
        pnlFormContainer.Controls.Add(chkAgreeTerms)
        pnlFormContainer.Controls.Add(lblTermsLink)
        pnlFormContainer.Controls.Add(lblConfirmPassword)
        pnlFormContainer.Controls.Add(pnlConfirmPassword)
        pnlFormContainer.Controls.Add(lblPassword)
        pnlFormContainer.Controls.Add(pnlPassword)
        pnlFormContainer.Controls.Add(lblBusinessName)
        pnlFormContainer.Controls.Add(pnlBusinessName)
        pnlFormContainer.Controls.Add(lblEmail)
        pnlFormContainer.Controls.Add(pnlEmail)
        pnlFormContainer.Controls.Add(lblFullName)
        pnlFormContainer.Controls.Add(pnlFullName)
        pnlFormContainer.Controls.Add(btnLogin)
        pnlFormContainer.Controls.Add(lblForgotPassword)
        pnlFormContainer.Controls.Add(chkRememberMe)
        pnlFormContainer.Location = New Point(457, 333)
        pnlFormContainer.Margin = New Padding(3, 4, 3, 4)
        pnlFormContainer.Name = "pnlFormContainer"
        pnlFormContainer.Size = New Size(457, 698)
        pnlFormContainer.TabIndex = 2
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnCreateAccount.FlatAppearance.BorderSize = 0
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCreateAccount.ForeColor = Color.White
        btnCreateAccount.Location = New Point(33, 609)
        btnCreateAccount.Margin = New Padding(3, 4, 3, 4)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(389, 53)
        btnCreateAccount.TabIndex = 20
        btnCreateAccount.Text = "CREATE ACCOUNT"
        btnCreateAccount.UseVisualStyleBackColor = False
        btnCreateAccount.Visible = False
        ' 
        ' chkAgreeTerms
        ' 
        chkAgreeTerms.AutoSize = True
        chkAgreeTerms.Font = New Font("Segoe UI", 9.0F)
        chkAgreeTerms.ForeColor = Color.White
        chkAgreeTerms.Location = New Point(46, 571)
        chkAgreeTerms.Margin = New Padding(3, 4, 3, 4)
        chkAgreeTerms.Name = "chkAgreeTerms"
        chkAgreeTerms.Size = New Size(18, 17)
        chkAgreeTerms.TabIndex = 19
        chkAgreeTerms.UseVisualStyleBackColor = True
        chkAgreeTerms.Visible = False
        ' 
        ' lblTermsLink
        ' 
        lblTermsLink.AutoSize = True
        lblTermsLink.Font = New Font("Segoe UI", 9.0F)
        lblTermsLink.ForeColor = Color.White
        lblTermsLink.Location = New Point(70, 571)
        lblTermsLink.Name = "lblTermsLink"
        lblTermsLink.Size = New Size(331, 20)
        lblTermsLink.TabIndex = 18
        lblTermsLink.Text = "I agree to the Terms of Service and Privacy Policy"
        lblTermsLink.Visible = False
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 10.0F)
        lblConfirmPassword.ForeColor = Color.White
        lblConfirmPassword.Location = New Point(34, 427)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(146, 23)
        lblConfirmPassword.TabIndex = 16
        lblConfirmPassword.Text = "Confirm Password"
        lblConfirmPassword.Visible = False
        ' 
        ' pnlConfirmPassword
        ' 
        pnlConfirmPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        pnlConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        pnlConfirmPassword.Controls.Add(btnShowConfirmPassword)
        pnlConfirmPassword.Controls.Add(txtConfirmPassword)
        pnlConfirmPassword.Location = New Point(34, 460)
        pnlConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        pnlConfirmPassword.Name = "pnlConfirmPassword"
        pnlConfirmPassword.Size = New Size(388, 46)
        pnlConfirmPassword.TabIndex = 15
        pnlConfirmPassword.Visible = False
        ' 
        ' btnShowConfirmPassword
        ' 
        btnShowConfirmPassword.BackColor = Color.Transparent
        btnShowConfirmPassword.FlatAppearance.BorderSize = 0
        btnShowConfirmPassword.FlatStyle = FlatStyle.Flat
        btnShowConfirmPassword.Font = New Font("Segoe UI Symbol", 10.0F)
        btnShowConfirmPassword.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnShowConfirmPassword.Location = New Point(343, 0)
        btnShowConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        btnShowConfirmPassword.Name = "btnShowConfirmPassword"
        btnShowConfirmPassword.Size = New Size(46, 47)
        btnShowConfirmPassword.TabIndex = 1
        btnShowConfirmPassword.Text = "👁"
        btnShowConfirmPassword.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        txtConfirmPassword.BorderStyle = BorderStyle.None
        txtConfirmPassword.Font = New Font("Segoe UI", 10.0F)
        txtConfirmPassword.ForeColor = Color.White
        txtConfirmPassword.Location = New Point(57, 11)
        txtConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "●"c
        txtConfirmPassword.PlaceholderText = "Confirm your password"
        txtConfirmPassword.Size = New Size(320, 23)
        txtConfirmPassword.TabIndex = 17
        txtConfirmPassword.Visible = False
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10.0F)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(34, 267)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(80, 23)
        lblPassword.TabIndex = 13
        lblPassword.Text = "Password"
        ' 
        ' pnlPassword
        ' 
        pnlPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        pnlPassword.BorderStyle = BorderStyle.FixedSingle
        pnlPassword.Controls.Add(btnShowPassword)
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.Location = New Point(34, 300)
        pnlPassword.Margin = New Padding(3, 4, 3, 4)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(388, 46)
        pnlPassword.TabIndex = 12
        ' 
        ' btnShowPassword
        ' 
        btnShowPassword.BackColor = Color.Transparent
        btnShowPassword.FlatAppearance.BorderSize = 0
        btnShowPassword.FlatStyle = FlatStyle.Flat
        btnShowPassword.Font = New Font("Segoe UI Symbol", 10.0F)
        btnShowPassword.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnShowPassword.Location = New Point(343, 0)
        btnShowPassword.Margin = New Padding(3, 4, 3, 4)
        btnShowPassword.Name = "btnShowPassword"
        btnShowPassword.Size = New Size(46, 47)
        btnShowPassword.TabIndex = 1
        btnShowPassword.Text = "👁"
        btnShowPassword.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(57, 11)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.Size = New Size(320, 23)
        txtPassword.TabIndex = 14
        ' 
        ' lblBusinessName
        ' 
        lblBusinessName.AutoSize = True
        lblBusinessName.Font = New Font("Segoe UI", 10.0F)
        lblBusinessName.ForeColor = Color.White
        lblBusinessName.Location = New Point(34, 200)
        lblBusinessName.Name = "lblBusinessName"
        lblBusinessName.Size = New Size(125, 23)
        lblBusinessName.TabIndex = 10
        lblBusinessName.Text = "Business Name"
        lblBusinessName.Visible = False
        ' 
        ' pnlBusinessName
        ' 
        pnlBusinessName.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        pnlBusinessName.BorderStyle = BorderStyle.FixedSingle
        pnlBusinessName.Controls.Add(txtBusinessName)
        pnlBusinessName.Location = New Point(34, 233)
        pnlBusinessName.Margin = New Padding(3, 4, 3, 4)
        pnlBusinessName.Name = "pnlBusinessName"
        pnlBusinessName.Size = New Size(388, 46)
        pnlBusinessName.TabIndex = 9
        pnlBusinessName.Visible = False
        ' 
        ' txtBusinessName
        ' 
        txtBusinessName.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        txtBusinessName.BorderStyle = BorderStyle.None
        txtBusinessName.Font = New Font("Segoe UI", 10.0F)
        txtBusinessName.ForeColor = Color.White
        txtBusinessName.Location = New Point(57, 11)
        txtBusinessName.Margin = New Padding(3, 4, 3, 4)
        txtBusinessName.Name = "txtBusinessName"
        txtBusinessName.PlaceholderText = "Enter your business name"
        txtBusinessName.Size = New Size(331, 23)
        txtBusinessName.TabIndex = 11
        txtBusinessName.Visible = False
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.0F)
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(34, 67)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(116, 23)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email Address"
        ' 
        ' pnlEmail
        ' 
        pnlEmail.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        pnlEmail.BorderStyle = BorderStyle.FixedSingle
        pnlEmail.Controls.Add(txtEmail)
        pnlEmail.Location = New Point(34, 100)
        pnlEmail.Margin = New Padding(3, 4, 3, 4)
        pnlEmail.Name = "pnlEmail"
        pnlEmail.Size = New Size(388, 46)
        pnlEmail.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(57, 11)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter your email"
        txtEmail.Size = New Size(331, 23)
        txtEmail.TabIndex = 8
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 10.0F)
        lblFullName.ForeColor = Color.White
        lblFullName.Location = New Point(34, 67)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(87, 23)
        lblFullName.TabIndex = 4
        lblFullName.Text = "Full Name"
        lblFullName.Visible = False
        ' 
        ' pnlFullName
        ' 
        pnlFullName.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        pnlFullName.BorderStyle = BorderStyle.FixedSingle
        pnlFullName.Controls.Add(txtFullName)
        pnlFullName.Location = New Point(34, 100)
        pnlFullName.Margin = New Padding(3, 4, 3, 4)
        pnlFullName.Name = "pnlFullName"
        pnlFullName.Size = New Size(388, 46)
        pnlFullName.TabIndex = 3
        pnlFullName.Visible = False
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        txtFullName.BorderStyle = BorderStyle.None
        txtFullName.Font = New Font("Segoe UI", 10.0F)
        txtFullName.ForeColor = Color.White
        txtFullName.Location = New Point(57, 11)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "Enter your full name"
        txtFullName.Size = New Size(331, 23)
        txtFullName.TabIndex = 5
        txtFullName.Visible = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(34, 427)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(389, 53)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblForgotPassword
        ' 
        lblForgotPassword.AutoSize = True
        lblForgotPassword.Cursor = Cursors.Hand
        lblForgotPassword.Font = New Font("Segoe UI", 9.0F)
        lblForgotPassword.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        lblForgotPassword.Location = New Point(286, 373)
        lblForgotPassword.Name = "lblForgotPassword"
        lblForgotPassword.Size = New Size(127, 20)
        lblForgotPassword.TabIndex = 1
        lblForgotPassword.Text = "Forgot password?"
        ' 
        ' chkRememberMe
        ' 
        chkRememberMe.AutoSize = True
        chkRememberMe.Font = New Font("Segoe UI", 9.0F)
        chkRememberMe.ForeColor = Color.White
        chkRememberMe.Location = New Point(34, 373)
        chkRememberMe.Margin = New Padding(3, 4, 3, 4)
        chkRememberMe.Name = "chkRememberMe"
        chkRememberMe.Size = New Size(129, 24)
        chkRememberMe.TabIndex = 0
        chkRememberMe.Text = "Remember me"
        chkRememberMe.UseVisualStyleBackColor = True
        ' 
        ' pnlTabContainer
        ' 
        pnlTabContainer.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(35))
        pnlTabContainer.Controls.Add(btnSignUpTab)
        pnlTabContainer.Controls.Add(btnLoginTab)
        pnlTabContainer.Location = New Point(457, 267)
        pnlTabContainer.Margin = New Padding(3, 4, 3, 4)
        pnlTabContainer.Name = "pnlTabContainer"
        pnlTabContainer.Size = New Size(457, 67)
        pnlTabContainer.TabIndex = 1
        ' 
        ' btnSignUpTab
        ' 
        btnSignUpTab.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(35))
        btnSignUpTab.FlatAppearance.BorderSize = 0
        btnSignUpTab.FlatStyle = FlatStyle.Flat
        btnSignUpTab.Font = New Font("Segoe UI", 11.0F)
        btnSignUpTab.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        btnSignUpTab.Location = New Point(229, 0)
        btnSignUpTab.Margin = New Padding(3, 4, 3, 4)
        btnSignUpTab.Name = "btnSignUpTab"
        btnSignUpTab.Size = New Size(229, 67)
        btnSignUpTab.TabIndex = 1
        btnSignUpTab.Text = "Sign Up"
        btnSignUpTab.UseVisualStyleBackColor = False
        ' 
        ' btnLoginTab
        ' 
        btnLoginTab.BackColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnLoginTab.FlatAppearance.BorderSize = 0
        btnLoginTab.FlatStyle = FlatStyle.Flat
        btnLoginTab.Font = New Font("Segoe UI", 11.0F)
        btnLoginTab.ForeColor = Color.White
        btnLoginTab.Location = New Point(0, 0)
        btnLoginTab.Margin = New Padding(3, 4, 3, 4)
        btnLoginTab.Name = "btnLoginTab"
        btnLoginTab.Size = New Size(229, 67)
        btnLoginTab.TabIndex = 0
        btnLoginTab.Text = "Login"
        btnLoginTab.UseVisualStyleBackColor = False
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BackgroundImageLayout = ImageLayout.Zoom
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(480, 58)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(402, 201)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' Login_Register
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 1067)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login_Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RePOS - Login/Register"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlFormContainer.ResumeLayout(False)
        pnlFormContainer.PerformLayout()
        pnlConfirmPassword.ResumeLayout(False)
        pnlConfirmPassword.PerformLayout()
        pnlPassword.ResumeLayout(False)
        pnlPassword.PerformLayout()
        pnlBusinessName.ResumeLayout(False)
        pnlBusinessName.PerformLayout()
        pnlEmail.ResumeLayout(False)
        pnlEmail.PerformLayout()
        pnlFullName.ResumeLayout(False)
        pnlFullName.PerformLayout()
        pnlTabContainer.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlTabContainer As Panel
    Friend WithEvents btnLoginTab As Button
    Friend WithEvents btnSignUpTab As Button
    Friend WithEvents pnlFormContainer As Panel
    Friend WithEvents chkRememberMe As CheckBox
    Friend WithEvents lblForgotPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents pnlPassword As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents pnlFullName As Panel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents pnlBusinessName As Panel
    Friend WithEvents txtBusinessName As TextBox
    Friend WithEvents lblBusinessName As Label
    Friend WithEvents pnlConfirmPassword As Panel
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnShowConfirmPassword As Button
    Friend WithEvents lblTermsLink As Label
    Friend WithEvents chkAgreeTerms As CheckBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
End Class

