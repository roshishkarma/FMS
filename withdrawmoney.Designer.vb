<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class withdrawmoney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(withdrawmoney))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblacch = New System.Windows.Forms.Label()
        Me.lblchkb = New System.Windows.Forms.Label()
        Me.txtchkb = New System.Windows.Forms.TextBox()
        Me.txtacchn = New System.Windows.Forms.TextBox()
        Me.nudamount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblhint = New System.Windows.Forms.Label()
        Me.lblwithdraw = New System.Windows.Forms.Label()
        Me.cmbwithdraw = New System.Windows.Forms.ComboBox()
        Me.txtawords = New System.Windows.Forms.TextBox()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbrncho = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtaccid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblevent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbacctype = New System.Windows.Forms.ComboBox()
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.lblrcp = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudamount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(515, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2012, 2, 8, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(476, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblacch)
        Me.GroupBox1.Controls.Add(Me.lblchkb)
        Me.GroupBox1.Controls.Add(Me.txtchkb)
        Me.GroupBox1.Controls.Add(Me.txtacchn)
        Me.GroupBox1.Controls.Add(Me.nudamount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblhint)
        Me.GroupBox1.Controls.Add(Me.lblwithdraw)
        Me.GroupBox1.Controls.Add(Me.cmbwithdraw)
        Me.GroupBox1.Controls.Add(Me.txtawords)
        Me.GroupBox1.Controls.Add(Me.lblamount)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.lblname)
        Me.GroupBox1.Location = New System.Drawing.Point(234, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 202)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Withdrawal Details"
        '
        'lblacch
        '
        Me.lblacch.AutoSize = True
        Me.lblacch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacch.Location = New System.Drawing.Point(68, 183)
        Me.lblacch.Name = "lblacch"
        Me.lblacch.Size = New System.Drawing.Size(103, 12)
        Me.lblacch.TabIndex = 62
        Me.lblacch.Text = "Account Holder's Name"
        '
        'lblchkb
        '
        Me.lblchkb.AutoSize = True
        Me.lblchkb.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchkb.Location = New System.Drawing.Point(458, 182)
        Me.lblchkb.Name = "lblchkb"
        Me.lblchkb.Size = New System.Drawing.Size(89, 12)
        Me.lblchkb.TabIndex = 61
        Me.lblchkb.Text = "Checked/Verified by"
        '
        'txtchkb
        '
        Me.txtchkb.Location = New System.Drawing.Point(403, 159)
        Me.txtchkb.Name = "txtchkb"
        Me.txtchkb.Size = New System.Drawing.Size(204, 20)
        Me.txtchkb.TabIndex = 12
        '
        'txtacchn
        '
        Me.txtacchn.Location = New System.Drawing.Point(16, 160)
        Me.txtacchn.Name = "txtacchn"
        Me.txtacchn.Size = New System.Drawing.Size(204, 20)
        Me.txtacchn.TabIndex = 11
        '
        'nudamount
        '
        Me.nudamount.Location = New System.Drawing.Point(117, 108)
        Me.nudamount.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudamount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudamount.Name = "nudamount"
        Me.nudamount.Size = New System.Drawing.Size(120, 20)
        Me.nudamount.TabIndex = 10
        Me.nudamount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Amount:(In Figures)"
        '
        'lblhint
        '
        Me.lblhint.AutoSize = True
        Me.lblhint.Location = New System.Drawing.Point(45, 66)
        Me.lblhint.Name = "lblhint"
        Me.lblhint.Size = New System.Drawing.Size(132, 13)
        Me.lblhint.TabIndex = 13
        Me.lblhint.Text = "Name of the person to pay"
        Me.lblhint.Visible = False
        '
        'lblwithdraw
        '
        Me.lblwithdraw.AutoSize = True
        Me.lblwithdraw.Location = New System.Drawing.Point(15, 22)
        Me.lblwithdraw.Name = "lblwithdraw"
        Me.lblwithdraw.Size = New System.Drawing.Size(85, 13)
        Me.lblwithdraw.TabIndex = 12
        Me.lblwithdraw.Text = "Withdarawal To:"
        '
        'cmbwithdraw
        '
        Me.cmbwithdraw.FormattingEnabled = True
        Me.cmbwithdraw.Items.AddRange(New Object() {"Myself", "Others"})
        Me.cmbwithdraw.Location = New System.Drawing.Point(117, 19)
        Me.cmbwithdraw.Name = "cmbwithdraw"
        Me.cmbwithdraw.Size = New System.Drawing.Size(121, 21)
        Me.cmbwithdraw.TabIndex = 7
        '
        'txtawords
        '
        Me.txtawords.Location = New System.Drawing.Point(111, 82)
        Me.txtawords.Name = "txtawords"
        Me.txtawords.Size = New System.Drawing.Size(487, 20)
        Me.txtawords.TabIndex = 9
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Location = New System.Drawing.Point(13, 85)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(92, 13)
        Me.lblamount.TabIndex = 9
        Me.lblamount.Text = "Amount(In Words)"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(58, 46)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(408, 20)
        Me.txtname.TabIndex = 8
        Me.txtname.Visible = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(13, 49)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(38, 13)
        Me.lblname.TabIndex = 7
        Me.lblname.Text = "Name:"
        Me.lblname.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtbrncho)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtaccid)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtmname)
        Me.GroupBox2.Controls.Add(Me.txtfname)
        Me.GroupBox2.Controls.Add(Me.txtlname)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 202)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Details"
        '
        'txtbrncho
        '
        Me.txtbrncho.Location = New System.Drawing.Point(89, 62)
        Me.txtbrncho.Name = "txtbrncho"
        Me.txtbrncho.Size = New System.Drawing.Size(110, 20)
        Me.txtbrncho.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(10, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Branch Office:"
        '
        'txtaccid
        '
        Me.txtaccid.Location = New System.Drawing.Point(89, 31)
        Me.txtaccid.Name = "txtaccid"
        Me.txtaccid.Size = New System.Drawing.Size(110, 20)
        Me.txtaccid.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Account No:"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(89, 127)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(110, 20)
        Me.txtmname.TabIndex = 5
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(89, 94)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(110, 20)
        Me.txtfname.TabIndex = 4
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(89, 161)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(110, 20)
        Me.txtlname.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Last Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Middle Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "First Name"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(783, 279)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 15
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.icontexto_webdev_reload_048x048
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Location = New System.Drawing.Point(0, 276)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(43, 29)
        Me.back.TabIndex = 14
        Me.back.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(660, 27)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblevent)
        Me.Panel1.Location = New System.Drawing.Point(49, 276)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 29)
        Me.Panel1.TabIndex = 64
        '
        'lblevent
        '
        Me.lblevent.AutoSize = True
        Me.lblevent.BackColor = System.Drawing.Color.Transparent
        Me.lblevent.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblevent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblevent.Location = New System.Drawing.Point(393, 3)
        Me.lblevent.Name = "lblevent"
        Me.lblevent.Size = New System.Drawing.Size(232, 25)
        Me.lblevent.TabIndex = 62
        Me.lblevent.Text = "Finance Management System"
        '
        'Timer1
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmbacctype)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 42)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Type(Select anyone)"
        '
        'cmbacctype
        '
        Me.cmbacctype.FormattingEnabled = True
        Me.cmbacctype.Items.AddRange(New Object() {"Savings", "Fixed deposit", "Minor", "Joint account"})
        Me.cmbacctype.Location = New System.Drawing.Point(6, 15)
        Me.cmbacctype.Name = "cmbacctype"
        Me.cmbacctype.Size = New System.Drawing.Size(164, 21)
        Me.cmbacctype.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.ws_Ultimate_Vista_1600x1200
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(860, 24)
        Me.MenuStrip1.TabIndex = 67
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
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(694, 279)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 13
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'lblrcp
        '
        Me.lblrcp.AutoSize = True
        Me.lblrcp.Location = New System.Drawing.Point(775, 51)
        Me.lblrcp.Name = "lblrcp"
        Me.lblrcp.Size = New System.Drawing.Size(66, 13)
        Me.lblrcp.TabIndex = 68
        Me.lblrcp.Text = "Receipt/No:"
        '
        'withdrawmoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.picture_935a40dba2_1680x1050
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(860, 306)
        Me.Controls.Add(Me.lblrcp)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "withdrawmoney"
        Me.Text = "Withdraw Money"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudamount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nudamount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblhint As System.Windows.Forms.Label
    Friend WithEvents lblwithdraw As System.Windows.Forms.Label
    Friend WithEvents cmbwithdraw As System.Windows.Forms.ComboBox
    Friend WithEvents txtawords As System.Windows.Forms.TextBox
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtchkb As System.Windows.Forms.TextBox
    Friend WithEvents txtacchn As System.Windows.Forms.TextBox
    Friend WithEvents txtaccid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblacch As System.Windows.Forms.Label
    Friend WithEvents lblchkb As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblevent As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbacctype As System.Windows.Forms.ComboBox
    Friend WithEvents txtbrncho As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents lblrcp As System.Windows.Forms.Label
End Class
