<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loanstatement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loanstatement))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblevent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkeducationloan = New System.Windows.Forms.CheckBox()
        Me.chkbusinessloan = New System.Windows.Forms.CheckBox()
        Me.chkhomeloan = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtaccid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccDetailToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatementToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingDepositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.rdbname = New System.Windows.Forms.RadioButton()
        Me.rdbaccid = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1039, 198)
        Me.DataGridView1.TabIndex = 2
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(964, 583)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 29
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(883, 584)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 30
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 66)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Info"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(51, 26)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(299, 20)
        Me.txtname.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Name:"
        '
        'btnback
        '
        Me.btnback.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.icontexto_webdev_reload_048x048
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.Location = New System.Drawing.Point(2, 580)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(43, 29)
        Me.btnback.TabIndex = 25
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblevent)
        Me.Panel1.Location = New System.Drawing.Point(51, 580)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 29)
        Me.Panel1.TabIndex = 64
        '
        'lblevent
        '
        Me.lblevent.AutoSize = True
        Me.lblevent.BackColor = System.Drawing.Color.Transparent
        Me.lblevent.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblevent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblevent.Location = New System.Drawing.Point(129, 3)
        Me.lblevent.Name = "lblevent"
        Me.lblevent.Size = New System.Drawing.Size(232, 25)
        Me.lblevent.TabIndex = 62
        Me.lblevent.Text = "Finance Management System"
        '
        'Timer1
        '
        '
        'chkeducationloan
        '
        Me.chkeducationloan.AutoSize = True
        Me.chkeducationloan.BackColor = System.Drawing.Color.Transparent
        Me.chkeducationloan.ForeColor = System.Drawing.Color.Silver
        Me.chkeducationloan.Location = New System.Drawing.Point(304, 57)
        Me.chkeducationloan.Name = "chkeducationloan"
        Me.chkeducationloan.Size = New System.Drawing.Size(97, 17)
        Me.chkeducationloan.TabIndex = 70
        Me.chkeducationloan.Text = "Education loan"
        Me.chkeducationloan.UseVisualStyleBackColor = False
        '
        'chkbusinessloan
        '
        Me.chkbusinessloan.AutoSize = True
        Me.chkbusinessloan.BackColor = System.Drawing.Color.Transparent
        Me.chkbusinessloan.ForeColor = System.Drawing.Color.Silver
        Me.chkbusinessloan.Location = New System.Drawing.Point(149, 57)
        Me.chkbusinessloan.Name = "chkbusinessloan"
        Me.chkbusinessloan.Size = New System.Drawing.Size(91, 17)
        Me.chkbusinessloan.TabIndex = 69
        Me.chkbusinessloan.Text = "Business loan"
        Me.chkbusinessloan.UseVisualStyleBackColor = False
        '
        'chkhomeloan
        '
        Me.chkhomeloan.AutoSize = True
        Me.chkhomeloan.BackColor = System.Drawing.Color.Transparent
        Me.chkhomeloan.ForeColor = System.Drawing.Color.Silver
        Me.chkhomeloan.Location = New System.Drawing.Point(7, 57)
        Me.chkhomeloan.Name = "chkhomeloan"
        Me.chkhomeloan.Size = New System.Drawing.Size(77, 17)
        Me.chkhomeloan.TabIndex = 68
        Me.chkhomeloan.Text = "Home loan"
        Me.chkhomeloan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtaccid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(419, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 66)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        '
        'txtaccid
        '
        Me.txtaccid.Location = New System.Drawing.Point(99, 27)
        Me.txtaccid.Name = "txtaccid"
        Me.txtaccid.Size = New System.Drawing.Size(100, 20)
        Me.txtaccid.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Account No:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.ws_Ultimate_Vista_1600x1200
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1039, 24)
        Me.MenuStrip2.TabIndex = 72
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.NewToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavingAccToolStripMenuItem, Me.LoanAccToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SavingAccToolStripMenuItem
        '
        Me.SavingAccToolStripMenuItem.Name = "SavingAccToolStripMenuItem"
        Me.SavingAccToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SavingAccToolStripMenuItem.Text = "Saving Acc"
        '
        'LoanAccToolStripMenuItem
        '
        Me.LoanAccToolStripMenuItem.Name = "LoanAccToolStripMenuItem"
        Me.LoanAccToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LoanAccToolStripMenuItem.Text = "Loan Acc"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccDetailToolStripMenuItem, Me.LoanDetailToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(39, 20)
        Me.ToolStripMenuItem4.Text = "&Edit"
        '
        'AccDetailToolStripMenuItem
        '
        Me.AccDetailToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AccDetailToolStripMenuItem.Name = "AccDetailToolStripMenuItem"
        Me.AccDetailToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AccDetailToolStripMenuItem.Text = "Acc Detail"
        '
        'LoanDetailToolStripMenuItem
        '
        Me.LoanDetailToolStripMenuItem.Name = "LoanDetailToolStripMenuItem"
        Me.LoanDetailToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.LoanDetailToolStripMenuItem.Text = "Loan Detail"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ChangeToolStripMenuItem.Text = "Change username / password"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatementToolStripMenuItem, Me.LoanToolStripMenuItem, Me.DepositToolStripMenuItem, Me.WithdrawToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'StatementToolStripMenuItem
        '
        Me.StatementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatementToolStripMenuItem1, Me.AccDetailToolStripMenuItem1})
        Me.StatementToolStripMenuItem.Name = "StatementToolStripMenuItem"
        Me.StatementToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.StatementToolStripMenuItem.Text = "Saving"
        '
        'StatementToolStripMenuItem1
        '
        Me.StatementToolStripMenuItem1.Name = "StatementToolStripMenuItem1"
        Me.StatementToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.StatementToolStripMenuItem1.Text = "Statement"
        '
        'AccDetailToolStripMenuItem1
        '
        Me.AccDetailToolStripMenuItem1.Name = "AccDetailToolStripMenuItem1"
        Me.AccDetailToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.AccDetailToolStripMenuItem1.Text = "Acc Detail"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatementToolStripMenuItem2, Me.DetailToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'StatementToolStripMenuItem2
        '
        Me.StatementToolStripMenuItem2.Name = "StatementToolStripMenuItem2"
        Me.StatementToolStripMenuItem2.Size = New System.Drawing.Size(128, 22)
        Me.StatementToolStripMenuItem2.Text = "Statement"
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DetailToolStripMenuItem.Text = "Detail"
        '
        'DepositToolStripMenuItem
        '
        Me.DepositToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavingDepositToolStripMenuItem, Me.PayLoanToolStripMenuItem})
        Me.DepositToolStripMenuItem.Name = "DepositToolStripMenuItem"
        Me.DepositToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.DepositToolStripMenuItem.Text = "Deposit"
        '
        'SavingDepositToolStripMenuItem
        '
        Me.SavingDepositToolStripMenuItem.Name = "SavingDepositToolStripMenuItem"
        Me.SavingDepositToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SavingDepositToolStripMenuItem.Text = "Saving Deposit"
        '
        'PayLoanToolStripMenuItem
        '
        Me.PayLoanToolStripMenuItem.Name = "PayLoanToolStripMenuItem"
        Me.PayLoanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PayLoanToolStripMenuItem.Text = "Pay loan"
        '
        'WithdrawToolStripMenuItem
        '
        Me.WithdrawToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WithdrawLoanToolStripMenuItem, Me.WithdrawMoneyToolStripMenuItem})
        Me.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem"
        Me.WithdrawToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.WithdrawToolStripMenuItem.Text = "Withdraw"
        '
        'WithdrawLoanToolStripMenuItem
        '
        Me.WithdrawLoanToolStripMenuItem.Name = "WithdrawLoanToolStripMenuItem"
        Me.WithdrawLoanToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.WithdrawLoanToolStripMenuItem.Text = "Withdraw loan"
        '
        'WithdrawMoneyToolStripMenuItem
        '
        Me.WithdrawMoneyToolStripMenuItem.Name = "WithdrawMoneyToolStripMenuItem"
        Me.WithdrawMoneyToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.WithdrawMoneyToolStripMenuItem.Text = "Withdraw money"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ContentsToolStripMenuItem})
        Me.HelpToolStripMenuItem1.ForeColor = System.Drawing.Color.Silver
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ContentsToolStripMenuItem.Text = "Contents"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(838, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(529, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Withdrawal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Deposit"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(518, 376)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(521, 198)
        Me.DataGridView2.TabIndex = 74
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 376)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(512, 198)
        Me.DataGridView3.TabIndex = 75
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(0, 152)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(1039, 198)
        Me.DataGridView4.TabIndex = 2
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(86, 40)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 79
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'rdbname
        '
        Me.rdbname.AutoSize = True
        Me.rdbname.BackColor = System.Drawing.Color.Transparent
        Me.rdbname.Location = New System.Drawing.Point(10, 19)
        Me.rdbname.Name = "rdbname"
        Me.rdbname.Size = New System.Drawing.Size(53, 17)
        Me.rdbname.TabIndex = 80
        Me.rdbname.TabStop = True
        Me.rdbname.Text = "Name"
        Me.rdbname.UseVisualStyleBackColor = False
        '
        'rdbaccid
        '
        Me.rdbaccid.AutoSize = True
        Me.rdbaccid.BackColor = System.Drawing.Color.Transparent
        Me.rdbaccid.Location = New System.Drawing.Point(82, 19)
        Me.rdbaccid.Name = "rdbaccid"
        Me.rdbaccid.Size = New System.Drawing.Size(79, 17)
        Me.rdbaccid.TabIndex = 80
        Me.rdbaccid.TabStop = True
        Me.rdbaccid.Text = "Account ID"
        Me.rdbaccid.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnsearch)
        Me.GroupBox3.Controls.Add(Me.rdbaccid)
        Me.GroupBox3.Controls.Add(Me.rdbname)
        Me.GroupBox3.Location = New System.Drawing.Point(702, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 66)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search By"
        '
        'loanstatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.Graphic_Design_Light_graphic_design_light_1680x1050
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1039, 610)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkeducationloan)
        Me.Controls.Add(Me.chkbusinessloan)
        Me.Controls.Add(Me.chkhomeloan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "loanstatement"
        Me.Text = "Loan Statements"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblevent As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkeducationloan As System.Windows.Forms.CheckBox
    Friend WithEvents chkbusinessloan As System.Windows.Forms.CheckBox
    Friend WithEvents chkhomeloan As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtaccid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavingAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccDetailToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatementToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepositToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavingDepositToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawMoneyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents rdbname As System.Windows.Forms.RadioButton
    Friend WithEvents rdbaccid As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
