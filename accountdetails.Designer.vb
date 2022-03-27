<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accountdetails))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtaccid = New System.Windows.Forms.TextBox()
        Me.lblaccid = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblmname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.SavingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.chkjoint = New System.Windows.Forms.CheckBox()
        Me.chkminor = New System.Windows.Forms.CheckBox()
        Me.chksaving = New System.Windows.Forms.CheckBox()
        Me.chkfixed = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblevent = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.rdbaccid = New System.Windows.Forms.RadioButton()
        Me.rdbname = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtaccid)
        Me.GroupBox1.Controls.Add(Me.lblaccid)
        Me.GroupBox1.Location = New System.Drawing.Point(396, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 66)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        '
        'txtaccid
        '
        Me.txtaccid.Location = New System.Drawing.Point(99, 27)
        Me.txtaccid.Name = "txtaccid"
        Me.txtaccid.Size = New System.Drawing.Size(100, 20)
        Me.txtaccid.TabIndex = 8
        '
        'lblaccid
        '
        Me.lblaccid.AutoSize = True
        Me.lblaccid.Location = New System.Drawing.Point(8, 30)
        Me.lblaccid.Name = "lblaccid"
        Me.lblaccid.Size = New System.Drawing.Size(67, 13)
        Me.lblaccid.TabIndex = 7
        Me.lblaccid.Text = "Account No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtmname)
        Me.GroupBox2.Controls.Add(Me.txtfname)
        Me.GroupBox2.Controls.Add(Me.txtlname)
        Me.GroupBox2.Controls.Add(Me.lbllname)
        Me.GroupBox2.Controls.Add(Me.lblmname)
        Me.GroupBox2.Controls.Add(Me.lblfname)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 66)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Info"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(123, 33)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(110, 20)
        Me.txtmname.TabIndex = 5
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(7, 33)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(110, 20)
        Me.txtfname.TabIndex = 4
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(239, 33)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(110, 20)
        Me.txtlname.TabIndex = 6
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(256, 16)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(58, 13)
        Me.lbllname.TabIndex = 25
        Me.lbllname.Text = "Last Name"
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.Location = New System.Drawing.Point(135, 16)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(69, 13)
        Me.lblmname.TabIndex = 23
        Me.lblmname.Text = "Middle Name"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(12, 16)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(57, 13)
        Me.lblfname.TabIndex = 17
        Me.lblfname.Text = "First Name"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.DataSource = Me.SavingsBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(0, 145)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(1039, 206)
        Me.DataGridView4.TabIndex = 51
        '
        'SavingsBindingSource
        '
        Me.SavingsBindingSource.DataMember = "savings"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(960, 619)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.icontexto_webdev_reload_048x048
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.Location = New System.Drawing.Point(2, 613)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(43, 29)
        Me.btnback.TabIndex = 11
        Me.btnback.UseVisualStyleBackColor = True
        '
        'chkjoint
        '
        Me.chkjoint.AutoSize = True
        Me.chkjoint.BackColor = System.Drawing.Color.Transparent
        Me.chkjoint.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chkjoint.Location = New System.Drawing.Point(555, 52)
        Me.chkjoint.Name = "chkjoint"
        Me.chkjoint.Size = New System.Drawing.Size(90, 17)
        Me.chkjoint.TabIndex = 3
        Me.chkjoint.Text = "Joint account"
        Me.chkjoint.UseVisualStyleBackColor = False
        '
        'chkminor
        '
        Me.chkminor.AutoSize = True
        Me.chkminor.BackColor = System.Drawing.Color.Transparent
        Me.chkminor.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chkminor.Location = New System.Drawing.Point(389, 52)
        Me.chkminor.Name = "chkminor"
        Me.chkminor.Size = New System.Drawing.Size(52, 17)
        Me.chkminor.TabIndex = 2
        Me.chkminor.Text = "Minor"
        Me.chkminor.UseVisualStyleBackColor = False
        '
        'chksaving
        '
        Me.chksaving.AutoSize = True
        Me.chksaving.BackColor = System.Drawing.Color.Transparent
        Me.chksaving.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chksaving.Location = New System.Drawing.Point(10, 52)
        Me.chksaving.Name = "chksaving"
        Me.chksaving.Size = New System.Drawing.Size(59, 17)
        Me.chksaving.TabIndex = 0
        Me.chksaving.Text = "Saving"
        Me.chksaving.UseVisualStyleBackColor = False
        '
        'chkfixed
        '
        Me.chkfixed.AutoSize = True
        Me.chkfixed.BackColor = System.Drawing.Color.Transparent
        Me.chkfixed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chkfixed.Location = New System.Drawing.Point(182, 52)
        Me.chkfixed.Name = "chkfixed"
        Me.chkfixed.Size = New System.Drawing.Size(88, 17)
        Me.chkfixed.TabIndex = 1
        Me.chkfixed.Text = "Fixed deposit"
        Me.chkfixed.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.ws_Ultimate_Vista_1600x1200
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 24)
        Me.MenuStrip1.TabIndex = 64
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccDetailToolStripMenuItem, Me.LoanDetailToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.HelpToolStripMenuItem.Text = "&Edit"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(529, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Withdrawal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Deposit"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(518, 380)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(521, 198)
        Me.DataGridView2.TabIndex = 66
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 380)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(512, 198)
        Me.DataGridView3.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(935, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(437, 584)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Save edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(964, 584)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Save edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(838, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 70
        '
        'lblevent
        '
        Me.lblevent.AutoSize = True
        Me.lblevent.BackColor = System.Drawing.Color.Transparent
        Me.lblevent.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblevent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblevent.Location = New System.Drawing.Point(576, 3)
        Me.lblevent.Name = "lblevent"
        Me.lblevent.Size = New System.Drawing.Size(232, 25)
        Me.lblevent.TabIndex = 62
        Me.lblevent.Text = "Finance Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblevent)
        Me.Panel1.Location = New System.Drawing.Point(92, 613)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 29)
        Me.Panel1.TabIndex = 63
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnsearch)
        Me.GroupBox3.Controls.Add(Me.rdbaccid)
        Me.GroupBox3.Controls.Add(Me.rdbname)
        Me.GroupBox3.Location = New System.Drawing.Point(653, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 66)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search By"
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1039, 206)
        Me.DataGridView1.TabIndex = 51
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btndelete)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(856, 75)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 66)
        Me.GroupBox4.TabIndex = 84
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(54, 40)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 79
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Type Acc No: in Account Details"
        '
        'accountdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.w22
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1039, 645)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkjoint)
        Me.Controls.Add(Me.chkminor)
        Me.Controls.Add(Me.chksaving)
        Me.Controls.Add(Me.chkfixed)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "accountdetails"
        Me.Text = "Account Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtaccid As System.Windows.Forms.TextBox
    Friend WithEvents lblaccid As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblmname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents chkjoint As System.Windows.Forms.CheckBox
    Friend WithEvents chkminor As System.Windows.Forms.CheckBox
    Friend WithEvents chksaving As System.Windows.Forms.CheckBox
    Friend WithEvents chkfixed As System.Windows.Forms.CheckBox
    Friend WithEvents SavingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchCodeNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchOfficeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OtherMaritalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CitizenshippassportNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceOfIssueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OthersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlcOfIssueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MunicipalityvdcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistrictDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RMunicipalityvdcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RDistrictDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RCountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RPhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RMobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForeignOthersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FathershusbandsNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrandfathersNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OccupationTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherOccupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IfEmployedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherEmploymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EducationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherEducationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameOfIntroducerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccRejectDetailsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreparedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerifiedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorizedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavingAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblevent As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents rdbaccid As System.Windows.Forms.RadioButton
    Friend WithEvents rdbname As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
