<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Type_Of_POS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Type_Of_POS))
        pnlMain = New Panel()
        pnlTopBar = New Panel()
        btnClose = New Button()
        btnMaximize = New Button()
        btnMinimize = New Button()
        pnlLeft = New Panel()
        picLogo = New PictureBox()
        lblBrandTitle = New Label()
        lblPOSTypeHeading = New Label()
        lblQuestion = New Label()
        pnlPOSButtons = New Panel()
        btnLoyverse = New Button()
        btnSquare = New Button()
        btnQuickPOS = New Button()
        btnMosaicPOS = New Button()
        btnIreapPOS = New Button()
        btnUtakPOS = New Button()
        btnPosibleNet = New Button()
        btnNRSPhilippines = New Button()
        btnVend = New Button()
        btnQuickbookPOS = New Button()
        btnShopifyPOS = New Button()
        btnBack = New Button()
        pnlRight = New Panel()
        lblSelectPrompt = New Label()
        btnStart = New Button()
        pnlProgressCPU = New Panel()
        lblCPUValue = New Label()
        lblCPUTitle = New Label()
        pnlProgressRAM = New Panel()
        lblRAMValue = New Label()
        lblRAMTitle = New Label()
        pnlMain.SuspendLayout()
        pnlTopBar.SuspendLayout()
        pnlLeft.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlPOSButtons.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlProgressCPU.SuspendLayout()
        pnlProgressRAM.SuspendLayout()
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
        btnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
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
        btnMaximize.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
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
        btnMinimize.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnMinimize.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnMinimize.Location = New Point(1227, 5)
        btnMinimize.Margin = New Padding(3, 4, 3, 4)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(46, 40)
        btnMinimize.TabIndex = 5
        btnMinimize.Text = "−"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' pnlLeft
        ' 
        pnlLeft.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlLeft.BackColor = Color.Transparent
        pnlLeft.Controls.Add(btnBack)
        pnlLeft.Controls.Add(pnlPOSButtons)
        pnlLeft.Controls.Add(lblQuestion)
        pnlLeft.Controls.Add(lblPOSTypeHeading)
        pnlLeft.Controls.Add(lblBrandTitle)
        pnlLeft.Controls.Add(picLogo)
        pnlLeft.Location = New Point(0, 50)
        pnlLeft.Margin = New Padding(3, 4, 3, 4)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(20, 20, 20, 20)
        pnlLeft.Size = New Size(500, 830)
        pnlLeft.TabIndex = 1
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BackgroundImageLayout = ImageLayout.Zoom
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(20, 20)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(100, 100)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblBrandTitle
        ' 
        lblBrandTitle.AutoSize = True
        lblBrandTitle.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        lblBrandTitle.ForeColor = Color.White
        lblBrandTitle.Location = New Point(20, 130)
        lblBrandTitle.Name = "lblBrandTitle"
        lblBrandTitle.Size = New Size(360, 40)
        lblBrandTitle.TabIndex = 1
        lblBrandTitle.Text = "RePOS" & vbCrLf & "Predictive POS Maintenance"
        ' 
        ' lblPOSTypeHeading
        ' 
        lblPOSTypeHeading.AutoSize = True
        lblPOSTypeHeading.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblPOSTypeHeading.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        lblPOSTypeHeading.Location = New Point(20, 200)
        lblPOSTypeHeading.Name = "lblPOSTypeHeading"
        lblPOSTypeHeading.Size = New Size(180, 23)
        lblPOSTypeHeading.TabIndex = 2
        lblPOSTypeHeading.Text = "POS System type:"
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Font = New Font("Consolas", 11.0F, FontStyle.Bold)
        lblQuestion.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        lblQuestion.Location = New Point(20, 240)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(250, 22)
        lblQuestion.TabIndex = 3
        lblQuestion.Text = "Which POS System do you use?"
        ' 
        ' pnlPOSButtons
        ' 
        pnlPOSButtons.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPOSButtons.BackColor = Color.Transparent
        pnlPOSButtons.Controls.Add(btnShopifyPOS)
        pnlPOSButtons.Controls.Add(btnQuickbookPOS)
        pnlPOSButtons.Controls.Add(btnVend)
        pnlPOSButtons.Controls.Add(btnNRSPhilippines)
        pnlPOSButtons.Controls.Add(btnPosibleNet)
        pnlPOSButtons.Controls.Add(btnUtakPOS)
        pnlPOSButtons.Controls.Add(btnIreapPOS)
        pnlPOSButtons.Controls.Add(btnMosaicPOS)
        pnlPOSButtons.Controls.Add(btnQuickPOS)
        pnlPOSButtons.Controls.Add(btnSquare)
        pnlPOSButtons.Controls.Add(btnLoyverse)
        pnlPOSButtons.Location = New Point(20, 280)
        pnlPOSButtons.Margin = New Padding(3, 4, 3, 4)
        pnlPOSButtons.Name = "pnlPOSButtons"
        pnlPOSButtons.Size = New Size(460, 450)
        pnlPOSButtons.TabIndex = 4
        ' 
        ' btnLoyverse
        ' 
        btnLoyverse.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnLoyverse.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnLoyverse.FlatAppearance.BorderSize = 1
        btnLoyverse.FlatStyle = FlatStyle.Flat
        btnLoyverse.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnLoyverse.ForeColor = Color.White
        btnLoyverse.Location = New Point(0, 0)
        btnLoyverse.Margin = New Padding(3, 4, 3, 4)
        btnLoyverse.Name = "btnLoyverse"
        btnLoyverse.Size = New Size(220, 50)
        btnLoyverse.TabIndex = 0
        btnLoyverse.Text = "LOYVERSE"
        btnLoyverse.UseVisualStyleBackColor = False
        ' 
        ' btnSquare
        ' 
        btnSquare.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnSquare.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnSquare.FlatAppearance.BorderSize = 1
        btnSquare.FlatStyle = FlatStyle.Flat
        btnSquare.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnSquare.ForeColor = Color.White
        btnSquare.Location = New Point(240, 0)
        btnSquare.Margin = New Padding(3, 4, 3, 4)
        btnSquare.Name = "btnSquare"
        btnSquare.Size = New Size(220, 50)
        btnSquare.TabIndex = 1
        btnSquare.Text = "SQUARE"
        btnSquare.UseVisualStyleBackColor = False
        ' 
        ' btnQuickPOS
        ' 
        btnQuickPOS.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnQuickPOS.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnQuickPOS.FlatAppearance.BorderSize = 1
        btnQuickPOS.FlatStyle = FlatStyle.Flat
        btnQuickPOS.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnQuickPOS.ForeColor = Color.White
        btnQuickPOS.Location = New Point(0, 60)
        btnQuickPOS.Margin = New Padding(3, 4, 3, 4)
        btnQuickPOS.Name = "btnQuickPOS"
        btnQuickPOS.Size = New Size(220, 50)
        btnQuickPOS.TabIndex = 2
        btnQuickPOS.Text = "QUICK POS"
        btnQuickPOS.UseVisualStyleBackColor = False
        ' 
        ' btnMosaicPOS
        ' 
        btnMosaicPOS.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnMosaicPOS.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnMosaicPOS.FlatAppearance.BorderSize = 1
        btnMosaicPOS.FlatStyle = FlatStyle.Flat
        btnMosaicPOS.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnMosaicPOS.ForeColor = Color.White
        btnMosaicPOS.Location = New Point(240, 60)
        btnMosaicPOS.Margin = New Padding(3, 4, 3, 4)
        btnMosaicPOS.Name = "btnMosaicPOS"
        btnMosaicPOS.Size = New Size(220, 50)
        btnMosaicPOS.TabIndex = 3
        btnMosaicPOS.Text = "MOSAIC POS"
        btnMosaicPOS.UseVisualStyleBackColor = False
        ' 
        ' btnIreapPOS
        ' 
        btnIreapPOS.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnIreapPOS.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnIreapPOS.FlatAppearance.BorderSize = 1
        btnIreapPOS.FlatStyle = FlatStyle.Flat
        btnIreapPOS.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnIreapPOS.ForeColor = Color.White
        btnIreapPOS.Location = New Point(0, 120)
        btnIreapPOS.Margin = New Padding(3, 4, 3, 4)
        btnIreapPOS.Name = "btnIreapPOS"
        btnIreapPOS.Size = New Size(220, 50)
        btnIreapPOS.TabIndex = 4
        btnIreapPOS.Text = "iREAP POS"
        btnIreapPOS.UseVisualStyleBackColor = False
        ' 
        ' btnUtakPOS
        ' 
        btnUtakPOS.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnUtakPOS.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnUtakPOS.FlatAppearance.BorderSize = 1
        btnUtakPOS.FlatStyle = FlatStyle.Flat
        btnUtakPOS.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnUtakPOS.ForeColor = Color.White
        btnUtakPOS.Location = New Point(240, 120)
        btnUtakPOS.Margin = New Padding(3, 4, 3, 4)
        btnUtakPOS.Name = "btnUtakPOS"
        btnUtakPOS.Size = New Size(220, 50)
        btnUtakPOS.TabIndex = 5
        btnUtakPOS.Text = "UTAK POS"
        btnUtakPOS.UseVisualStyleBackColor = False
        ' 
        ' btnPosibleNet
        ' 
        btnPosibleNet.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnPosibleNet.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnPosibleNet.FlatAppearance.BorderSize = 1
        btnPosibleNet.FlatStyle = FlatStyle.Flat
        btnPosibleNet.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnPosibleNet.ForeColor = Color.White
        btnPosibleNet.Location = New Point(0, 180)
        btnPosibleNet.Margin = New Padding(3, 4, 3, 4)
        btnPosibleNet.Name = "btnPosibleNet"
        btnPosibleNet.Size = New Size(220, 50)
        btnPosibleNet.TabIndex = 6
        btnPosibleNet.Text = "POSIBLE.NET"
        btnPosibleNet.UseVisualStyleBackColor = False
        ' 
        ' btnNRSPhilippines
        ' 
        btnNRSPhilippines.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnNRSPhilippines.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnNRSPhilippines.FlatAppearance.BorderSize = 1
        btnNRSPhilippines.FlatStyle = FlatStyle.Flat
        btnNRSPhilippines.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnNRSPhilippines.ForeColor = Color.White
        btnNRSPhilippines.Location = New Point(240, 180)
        btnNRSPhilippines.Margin = New Padding(3, 4, 3, 4)
        btnNRSPhilippines.Name = "btnNRSPhilippines"
        btnNRSPhilippines.Size = New Size(220, 50)
        btnNRSPhilippines.TabIndex = 7
        btnNRSPhilippines.Text = "NRS PHILLIPINES"
        btnNRSPhilippines.UseVisualStyleBackColor = False
        ' 
        ' btnVend
        ' 
        btnVend.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnVend.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnVend.FlatAppearance.BorderSize = 1
        btnVend.FlatStyle = FlatStyle.Flat
        btnVend.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnVend.ForeColor = Color.White
        btnVend.Location = New Point(0, 240)
        btnVend.Margin = New Padding(3, 4, 3, 4)
        btnVend.Name = "btnVend"
        btnVend.Size = New Size(220, 50)
        btnVend.TabIndex = 8
        btnVend.Text = "VEND"
        btnVend.UseVisualStyleBackColor = False
        ' 
        ' btnQuickbookPOS
        ' 
        btnQuickbookPOS.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnQuickbookPOS.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnQuickbookPOS.FlatAppearance.BorderSize = 1
        btnQuickbookPOS.FlatStyle = FlatStyle.Flat
        btnQuickbookPOS.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnQuickbookPOS.ForeColor = Color.White
        btnQuickbookPOS.Location = New Point(240, 240)
        btnQuickbookPOS.Margin = New Padding(3, 4, 3, 4)
        btnQuickbookPOS.Name = "btnQuickbookPOS"
        btnQuickbookPOS.Size = New Size(220, 50)
        btnQuickbookPOS.TabIndex = 9
        btnQuickbookPOS.Text = "QUICKBOOK POS"
        btnQuickbookPOS.UseVisualStyleBackColor = False
        ' 
        ' btnShopifyPOS
        ' 
        btnShopifyPOS.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnShopifyPOS.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnShopifyPOS.FlatAppearance.BorderSize = 1
        btnShopifyPOS.FlatStyle = FlatStyle.Flat
        btnShopifyPOS.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnShopifyPOS.ForeColor = Color.White
        btnShopifyPOS.Location = New Point(0, 300)
        btnShopifyPOS.Margin = New Padding(3, 4, 3, 4)
        btnShopifyPOS.Name = "btnShopifyPOS"
        btnShopifyPOS.Size = New Size(220, 50)
        btnShopifyPOS.TabIndex = 10
        btnShopifyPOS.Text = "SHOPIFY POS"
        btnShopifyPOS.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBack.BackColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnBack.FlatAppearance.BorderSize = 1
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(20, 750)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(460, 50)
        btnBack.TabIndex = 5
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' pnlRight
        ' 
        pnlRight.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRight.BackColor = Color.Transparent
        pnlRight.Controls.Add(pnlProgressRAM)
        pnlRight.Controls.Add(pnlProgressCPU)
        pnlRight.Controls.Add(btnStart)
        pnlRight.Controls.Add(lblSelectPrompt)
        pnlRight.Location = New Point(500, 50)
        pnlRight.Margin = New Padding(3, 4, 3, 4)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(50, 50, 50, 50)
        pnlRight.Size = New Size(876, 830)
        pnlRight.TabIndex = 2
        ' 
        ' lblSelectPrompt
        ' 
        lblSelectPrompt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblSelectPrompt.Font = New Font("Consolas", 18.0F, FontStyle.Bold)
        lblSelectPrompt.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        lblSelectPrompt.Location = New Point(50, 200)
        lblSelectPrompt.Name = "lblSelectPrompt"
        lblSelectPrompt.Size = New Size(776, 50)
        lblSelectPrompt.TabIndex = 0
        lblSelectPrompt.Text = "Please select a POS system"
        lblSelectPrompt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnStart
        ' 
        btnStart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnStart.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(45))
        btnStart.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        btnStart.FlatAppearance.BorderSize = 1
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Consolas", 14.0F, FontStyle.Bold)
        btnStart.ForeColor = Color.White
        btnStart.Location = New Point(50, 280)
        btnStart.Margin = New Padding(3, 4, 3, 4)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(776, 80)
        btnStart.TabIndex = 1
        btnStart.Text = "START"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' pnlProgressCPU
        ' 
        pnlProgressCPU.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        pnlProgressCPU.BackColor = Color.Transparent
        pnlProgressCPU.Controls.Add(lblCPUValue)
        pnlProgressCPU.Controls.Add(lblCPUTitle)
        pnlProgressCPU.Location = New Point(600, 700)
        pnlProgressCPU.Margin = New Padding(3, 4, 3, 4)
        pnlProgressCPU.Name = "pnlProgressCPU"
        pnlProgressCPU.Size = New Size(120, 120)
        pnlProgressCPU.TabIndex = 2
        ' 
        ' lblCPUTitle
        ' 
        lblCPUTitle.AutoSize = True
        lblCPUTitle.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        lblCPUTitle.ForeColor = Color.White
        lblCPUTitle.Location = New Point(30, 20)
        lblCPUTitle.Name = "lblCPUTitle"
        lblCPUTitle.Size = New Size(43, 20)
        lblCPUTitle.TabIndex = 0
        lblCPUTitle.Text = "CPU"
        ' 
        ' lblCPUValue
        ' 
        lblCPUValue.Anchor = AnchorStyles.Bottom
        lblCPUValue.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblCPUValue.ForeColor = Color.White
        lblCPUValue.Location = New Point(0, 70)
        lblCPUValue.Name = "lblCPUValue"
        lblCPUValue.Size = New Size(120, 30)
        lblCPUValue.TabIndex = 1
        lblCPUValue.Text = "20%"
        lblCPUValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlProgressRAM
        ' 
        pnlProgressRAM.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        pnlProgressRAM.BackColor = Color.Transparent
        pnlProgressRAM.Controls.Add(lblRAMValue)
        pnlProgressRAM.Controls.Add(lblRAMTitle)
        pnlProgressRAM.Location = New Point(730, 700)
        pnlProgressRAM.Margin = New Padding(3, 4, 3, 4)
        pnlProgressRAM.Name = "pnlProgressRAM"
        pnlProgressRAM.Size = New Size(120, 120)
        pnlProgressRAM.TabIndex = 3
        ' 
        ' lblRAMTitle
        ' 
        lblRAMTitle.AutoSize = True
        lblRAMTitle.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        lblRAMTitle.ForeColor = Color.White
        lblRAMTitle.Location = New Point(30, 20)
        lblRAMTitle.Name = "lblRAMTitle"
        lblRAMTitle.Size = New Size(50, 20)
        lblRAMTitle.TabIndex = 0
        lblRAMTitle.Text = "RAM"
        ' 
        ' lblRAMValue
        ' 
        lblRAMValue.Anchor = AnchorStyles.Bottom
        lblRAMValue.Font = New Font("Consolas", 12.0F, FontStyle.Bold)
        lblRAMValue.ForeColor = Color.White
        lblRAMValue.Location = New Point(0, 70)
        lblRAMValue.Name = "lblRAMValue"
        lblRAMValue.Size = New Size(120, 30)
        lblRAMValue.TabIndex = 1
        lblRAMValue.Text = "40%"
        lblRAMValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Type_Of_POS
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(25))
        ClientSize = New Size(1376, 880)
        Controls.Add(pnlMain)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Type_Of_POS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RePOS - Type of POS"
        pnlMain.ResumeLayout(False)
        pnlTopBar.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlPOSButtons.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlProgressCPU.ResumeLayout(False)
        pnlProgressCPU.PerformLayout()
        pnlProgressRAM.ResumeLayout(False)
        pnlProgressRAM.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBrandTitle As Label
    Friend WithEvents lblPOSTypeHeading As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents pnlPOSButtons As Panel
    Friend WithEvents btnLoyverse As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnQuickPOS As Button
    Friend WithEvents btnMosaicPOS As Button
    Friend WithEvents btnIreapPOS As Button
    Friend WithEvents btnUtakPOS As Button
    Friend WithEvents btnPosibleNet As Button
    Friend WithEvents btnNRSPhilippines As Button
    Friend WithEvents btnVend As Button
    Friend WithEvents btnQuickbookPOS As Button
    Friend WithEvents btnShopifyPOS As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblSelectPrompt As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents pnlProgressCPU As Panel
    Friend WithEvents lblCPUTitle As Label
    Friend WithEvents lblCPUValue As Label
    Friend WithEvents pnlProgressRAM As Panel
    Friend WithEvents lblRAMTitle As Label
    Friend WithEvents lblRAMValue As Label
End Class

