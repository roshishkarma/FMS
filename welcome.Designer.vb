<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome))
        Me.btnpayloan = New System.Windows.Forms.Button()
        Me.btnloanwithdraw = New System.Windows.Forms.Button()
        Me.btnwithdraw = New System.Windows.Forms.Button()
        Me.btndeposit = New System.Windows.Forms.Button()
        Me.btnloanstatements = New System.Windows.Forms.Button()
        Me.btnaccstatements = New System.Windows.Forms.Button()
        Me.btnloandetails = New System.Windows.Forms.Button()
        Me.btnloan = New System.Windows.Forms.Button()
        Me.btnaccdetails = New System.Windows.Forms.Button()
        Me.btncreateaccount = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithdrawMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnchangeuser = New System.Windows.Forms.Button()
        Me.btncreateuser = New System.Windows.Forms.Button()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.backup = New System.Windows.Forms.SaveFileDialog()
        Me.restore = New System.Windows.Forms.OpenFileDialog()
        Me.btnrestore = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnpayloan
        '
        Me.btnpayloan.Location = New System.Drawing.Point(424, 247)
        Me.btnpayloan.Name = "btnpayloan"
        Me.btnpayloan.Size = New System.Drawing.Size(75, 37)
        Me.btnpayloan.TabIndex = 25
        Me.btnpayloan.Text = "Pay Loan"
        Me.btnpayloan.UseVisualStyleBackColor = True
        '
        'btnloanwithdraw
        '
        Me.btnloanwithdraw.Location = New System.Drawing.Point(424, 297)
        Me.btnloanwithdraw.Name = "btnloanwithdraw"
        Me.btnloanwithdraw.Size = New System.Drawing.Size(75, 37)
        Me.btnloanwithdraw.TabIndex = 24
        Me.btnloanwithdraw.Text = "Loan Withdraw"
        Me.btnloanwithdraw.UseVisualStyleBackColor = True
        '
        'btnwithdraw
        '
        Me.btnwithdraw.Location = New System.Drawing.Point(21, 297)
        Me.btnwithdraw.Name = "btnwithdraw"
        Me.btnwithdraw.Size = New System.Drawing.Size(75, 37)
        Me.btnwithdraw.TabIndex = 23
        Me.btnwithdraw.Text = "Withdraw Money"
        Me.btnwithdraw.UseVisualStyleBackColor = True
        '
        'btndeposit
        '
        Me.btndeposit.Location = New System.Drawing.Point(21, 247)
        Me.btndeposit.Name = "btndeposit"
        Me.btndeposit.Size = New System.Drawing.Size(75, 37)
        Me.btndeposit.TabIndex = 22
        Me.btndeposit.Text = "Deposit Money"
        Me.btndeposit.UseVisualStyleBackColor = True
        '
        'btnloanstatements
        '
        Me.btnloanstatements.Location = New System.Drawing.Point(424, 197)
        Me.btnloanstatements.Name = "btnloanstatements"
        Me.btnloanstatements.Size = New System.Drawing.Size(75, 37)
        Me.btnloanstatements.TabIndex = 20
        Me.btnloanstatements.Text = "Loan Statements"
        Me.btnloanstatements.UseVisualStyleBackColor = True
        '
        'btnaccstatements
        '
        Me.btnaccstatements.Location = New System.Drawing.Point(21, 197)
        Me.btnaccstatements.Name = "btnaccstatements"
        Me.btnaccstatements.Size = New System.Drawing.Size(75, 37)
        Me.btnaccstatements.TabIndex = 19
        Me.btnaccstatements.Text = "Account Statements"
        Me.btnaccstatements.UseVisualStyleBackColor = True
        '
        'btnloandetails
        '
        Me.btnloandetails.Location = New System.Drawing.Point(424, 147)
        Me.btnloandetails.Name = "btnloandetails"
        Me.btnloandetails.Size = New System.Drawing.Size(75, 37)
        Me.btnloandetails.TabIndex = 18
        Me.btnloandetails.Text = "Loan Details"
        Me.btnloandetails.UseVisualStyleBackColor = True
        '
        'btnloan
        '
        Me.btnloan.Location = New System.Drawing.Point(424, 98)
        Me.btnloan.Name = "btnloan"
        Me.btnloan.Size = New System.Drawing.Size(75, 37)
        Me.btnloan.TabIndex = 17
        Me.btnloan.Text = "Loan"
        Me.btnloan.UseVisualStyleBackColor = True
        '
        'btnaccdetails
        '
        Me.btnaccdetails.Location = New System.Drawing.Point(21, 147)
        Me.btnaccdetails.Name = "btnaccdetails"
        Me.btnaccdetails.Size = New System.Drawing.Size(75, 37)
        Me.btnaccdetails.TabIndex = 16
        Me.btnaccdetails.Text = "Account Details"
        Me.btnaccdetails.UseVisualStyleBackColor = True
        '
        'btncreateaccount
        '
        Me.btncreateaccount.Location = New System.Drawing.Point(21, 98)
        Me.btncreateaccount.Name = "btncreateaccount"
        Me.btncreateaccount.Size = New System.Drawing.Size(75, 37)
        Me.btncreateaccount.TabIndex = 15
        Me.btncreateaccount.Text = "Create Account"
        Me.btncreateaccount.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(248, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(220, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "WELCOME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(129, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = """FINANCE MANAGEMENT SYSTEM""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.ws_Ultimate_Vista_1600x1200
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 29
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
        Me.DepositToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavingDepositToolStripMenuItem, Me.PayToolStripMenuItem})
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
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PayToolStripMenuItem.Text = "Pay loan"
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
        'btnchangeuser
        '
        Me.btnchangeuser.Location = New System.Drawing.Point(102, 297)
        Me.btnchangeuser.Name = "btnchangeuser"
        Me.btnchangeuser.Size = New System.Drawing.Size(108, 37)
        Me.btnchangeuser.TabIndex = 30
        Me.btnchangeuser.Text = "Change Username Password"
        Me.btnchangeuser.UseVisualStyleBackColor = True
        '
        'btncreateuser
        '
        Me.btncreateuser.Location = New System.Drawing.Point(316, 297)
        Me.btncreateuser.Name = "btncreateuser"
        Me.btncreateuser.Size = New System.Drawing.Size(102, 37)
        Me.btncreateuser.TabIndex = 31
        Me.btncreateuser.Text = "Create New User"
        Me.btncreateuser.UseVisualStyleBackColor = True
        '
        'btnbackup
        '
        Me.btnbackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbackup.Location = New System.Drawing.Point(225, 292)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(75, 21)
        Me.btnbackup.TabIndex = 32
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'backup
        '
        Me.backup.DefaultExt = "rsb"
        '
        'restore
        '
        Me.restore.DefaultExt = "mdb"
        '
        'btnrestore
        '
        Me.btnrestore.Location = New System.Drawing.Point(225, 319)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(75, 21)
        Me.btnrestore.TabIndex = 33
        Me.btnrestore.Text = "Restore"
        Me.btnrestore.UseVisualStyleBackColor = True
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.Mac_Art_by_mj_coffeeholick
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 343)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.btncreateuser)
        Me.Controls.Add(Me.btnchangeuser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpayloan)
        Me.Controls.Add(Me.btnloanwithdraw)
        Me.Controls.Add(Me.btnwithdraw)
        Me.Controls.Add(Me.btndeposit)
        Me.Controls.Add(Me.btnloanstatements)
        Me.Controls.Add(Me.btnaccstatements)
        Me.Controls.Add(Me.btnloandetails)
        Me.Controls.Add(Me.btnloan)
        Me.Controls.Add(Me.btnaccdetails)
        Me.Controls.Add(Me.btncreateaccount)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "welcome"
        Me.Text = "Welcome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpayloan As System.Windows.Forms.Button
    Friend WithEvents btnloanwithdraw As System.Windows.Forms.Button
    Friend WithEvents btnwithdraw As System.Windows.Forms.Button
    Friend WithEvents btndeposit As System.Windows.Forms.Button
    Friend WithEvents btnloanstatements As System.Windows.Forms.Button
    Friend WithEvents btnaccstatements As System.Windows.Forms.Button
    Friend WithEvents btnloandetails As System.Windows.Forms.Button
    Friend WithEvents btnloan As System.Windows.Forms.Button
    Friend WithEvents btnaccdetails As System.Windows.Forms.Button
    Friend WithEvents btncreateaccount As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnchangeuser As System.Windows.Forms.Button
    Friend WithEvents btncreateuser As System.Windows.Forms.Button
    Friend WithEvents SavingAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents PayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithdrawMoneyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents backup As System.Windows.Forms.SaveFileDialog
    Friend WithEvents restore As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnrestore As System.Windows.Forms.Button
End Class
