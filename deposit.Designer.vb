<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deposit))
        Me.txtaccid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtbrnoffice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtawords = New System.Windows.Forms.TextBox()
        Me.nudamount = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.authorisation = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtauthorized = New System.Windows.Forms.TextBox()
        Me.txtdepositor = New System.Windows.Forms.TextBox()
        Me.txtreceiver = New System.Windows.Forms.TextBox()
        Me.chkterms = New System.Windows.Forms.CheckBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.grpterms = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbacctype = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.labeltimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblevent = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.lblrcp = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudamount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.authorisation.SuspendLayout()
        Me.grpterms.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtaccid
        '
        Me.txtaccid.Location = New System.Drawing.Point(103, 38)
        Me.txtaccid.Name = "txtaccid"
        Me.txtaccid.Size = New System.Drawing.Size(184, 20)
        Me.txtaccid.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Account No:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker1.Location = New System.Drawing.Point(376, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'txtbrnoffice
        '
        Me.txtbrnoffice.Location = New System.Drawing.Point(103, 64)
        Me.txtbrnoffice.Name = "txtbrnoffice"
        Me.txtbrnoffice.Size = New System.Drawing.Size(184, 20)
        Me.txtbrnoffice.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Branch Office:"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(123, 34)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(110, 20)
        Me.txtmname.TabIndex = 4
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(7, 34)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(110, 20)
        Me.txtfname.TabIndex = 3
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(239, 34)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(110, 20)
        Me.txtlname.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(256, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Last Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(135, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Middle Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "First Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtmname)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 66)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Holder's Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtawords)
        Me.GroupBox2.Controls.Add(Me.nudamount)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 85)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Money"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Amount in words"
        '
        'txtawords
        '
        Me.txtawords.Location = New System.Drawing.Point(111, 43)
        Me.txtawords.Multiline = True
        Me.txtawords.Name = "txtawords"
        Me.txtawords.Size = New System.Drawing.Size(454, 36)
        Me.txtawords.TabIndex = 9
        '
        'nudamount
        '
        Me.nudamount.Location = New System.Drawing.Point(77, 17)
        Me.nudamount.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudamount.Name = "nudamount"
        Me.nudamount.Size = New System.Drawing.Size(127, 20)
        Me.nudamount.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Amount"
        '
        'btnback
        '
        Me.btnback.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.icontexto_webdev_reload_048x048
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.Location = New System.Drawing.Point(0, 396)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(43, 29)
        Me.btnback.TabIndex = 15
        Me.btnback.UseVisualStyleBackColor = True
        '
        'authorisation
        '
        Me.authorisation.BackColor = System.Drawing.Color.Transparent
        Me.authorisation.Controls.Add(Me.Label8)
        Me.authorisation.Controls.Add(Me.Label6)
        Me.authorisation.Controls.Add(Me.Label5)
        Me.authorisation.Controls.Add(Me.txtauthorized)
        Me.authorisation.Controls.Add(Me.txtdepositor)
        Me.authorisation.Controls.Add(Me.txtreceiver)
        Me.authorisation.Location = New System.Drawing.Point(1, 254)
        Me.authorisation.Name = "authorisation"
        Me.authorisation.Size = New System.Drawing.Size(574, 55)
        Me.authorisation.TabIndex = 39
        Me.authorisation.TabStop = False
        Me.authorisation.Text = "Authorisation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(432, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Authorized By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(243, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Receiver's Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(49, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Depositor's Name"
        '
        'txtauthorized
        '
        Me.txtauthorized.Location = New System.Drawing.Point(385, 17)
        Me.txtauthorized.Name = "txtauthorized"
        Me.txtauthorized.Size = New System.Drawing.Size(184, 20)
        Me.txtauthorized.TabIndex = 12
        '
        'txtdepositor
        '
        Me.txtdepositor.Location = New System.Drawing.Point(5, 17)
        Me.txtdepositor.Name = "txtdepositor"
        Me.txtdepositor.Size = New System.Drawing.Size(184, 20)
        Me.txtdepositor.TabIndex = 10
        '
        'txtreceiver
        '
        Me.txtreceiver.Location = New System.Drawing.Point(195, 17)
        Me.txtreceiver.Name = "txtreceiver"
        Me.txtreceiver.Size = New System.Drawing.Size(184, 20)
        Me.txtreceiver.TabIndex = 11
        '
        'chkterms
        '
        Me.chkterms.AutoSize = True
        Me.chkterms.BackColor = System.Drawing.Color.Transparent
        Me.chkterms.Location = New System.Drawing.Point(399, 326)
        Me.chkterms.Name = "chkterms"
        Me.chkterms.Size = New System.Drawing.Size(181, 17)
        Me.chkterms.TabIndex = 13
        Me.chkterms.Text = "I accept the terms and condition."
        Me.chkterms.UseVisualStyleBackColor = False
        '
        'btnsubmit
        '
        Me.btnsubmit.Enabled = False
        Me.btnsubmit.Location = New System.Drawing.Point(399, 349)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(106, 34)
        Me.btnsubmit.TabIndex = 14
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(495, 399)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 16
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'grpterms
        '
        Me.grpterms.BackColor = System.Drawing.Color.Transparent
        Me.grpterms.Controls.Add(Me.Panel1)
        Me.grpterms.Controls.Add(Me.Label9)
        Me.grpterms.Location = New System.Drawing.Point(1, 315)
        Me.grpterms.Name = "grpterms"
        Me.grpterms.Size = New System.Drawing.Size(379, 80)
        Me.grpterms.TabIndex = 44
        Me.grpterms.TabStop = False
        Me.grpterms.Text = "Terms and Condition"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(48, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 29)
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(310, 52)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmbacctype)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 66)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Type(Select anyone)"
        '
        'cmbacctype
        '
        Me.cmbacctype.FormattingEnabled = True
        Me.cmbacctype.Items.AddRange(New Object() {"Savings", "Fixed deposit", "Minor", "Joint account"})
        Me.cmbacctype.Location = New System.Drawing.Point(18, 26)
        Me.cmbacctype.Name = "cmbacctype"
        Me.cmbacctype.Size = New System.Drawing.Size(164, 21)
        Me.cmbacctype.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(363, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(399, 61)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker2.TabIndex = 2
        Me.DateTimePicker2.Value = New Date(2012, 2, 8, 0, 0, 0, 0)
        '
        'labeltimer
        '
        '
        'lblevent
        '
        Me.lblevent.AutoSize = True
        Me.lblevent.BackColor = System.Drawing.Color.Transparent
        Me.lblevent.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblevent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblevent.Location = New System.Drawing.Point(115, 2)
        Me.lblevent.Name = "lblevent"
        Me.lblevent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblevent.Size = New System.Drawing.Size(232, 25)
        Me.lblevent.TabIndex = 63
        Me.lblevent.Text = "Finance Management System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblevent)
        Me.Panel2.Location = New System.Drawing.Point(49, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 29)
        Me.Panel2.TabIndex = 64
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.ws_Ultimate_Vista_1600x1200
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 66
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
        'lblrcp
        '
        Me.lblrcp.AutoSize = True
        Me.lblrcp.Location = New System.Drawing.Point(11, 25)
        Me.lblrcp.Name = "lblrcp"
        Me.lblrcp.Size = New System.Drawing.Size(66, 13)
        Me.lblrcp.TabIndex = 69
        Me.lblrcp.Text = "Receipt/No:"
        '
        'deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.of_me_and_you_of_me_and_you_blue_abstract_1920x1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(576, 425)
        Me.Controls.Add(Me.lblrcp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpterms)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.chkterms)
        Me.Controls.Add(Me.authorisation)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbrnoffice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtaccid)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "deposit"
        Me.Text = "Deposit Money"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudamount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.authorisation.ResumeLayout(False)
        Me.authorisation.PerformLayout()
        Me.grpterms.ResumeLayout(False)
        Me.grpterms.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtaccid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbrnoffice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtawords As System.Windows.Forms.TextBox
    Friend WithEvents nudamount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents authorisation As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtauthorized As System.Windows.Forms.TextBox
    Friend WithEvents txtdepositor As System.Windows.Forms.TextBox
    Friend WithEvents txtreceiver As System.Windows.Forms.TextBox
    Friend WithEvents chkterms As System.Windows.Forms.CheckBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents grpterms As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbacctype As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents labeltimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblevent As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
    Friend WithEvents lblrcp As System.Windows.Forms.Label
End Class
