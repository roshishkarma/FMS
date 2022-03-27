<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotpassword))
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.cmbquestion = New System.Windows.Forms.ComboBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.btnfok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.BackColor = System.Drawing.Color.Transparent
        Me.lblanswer.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswer.ForeColor = System.Drawing.Color.Gray
        Me.lblanswer.Location = New System.Drawing.Point(2, 128)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(75, 25)
        Me.lblanswer.TabIndex = 18
        Me.lblanswer.Text = "Answer"
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.BackColor = System.Drawing.Color.Transparent
        Me.lblquestion.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquestion.ForeColor = System.Drawing.Color.Gray
        Me.lblquestion.Location = New System.Drawing.Point(2, 86)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(182, 25)
        Me.lblquestion.TabIndex = 17
        Me.lblquestion.Text = "Select Any Question"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(398, 231)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 16
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(304, 231)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 15
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(190, 133)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(224, 20)
        Me.txtanswer.TabIndex = 14
        '
        'cmbquestion
        '
        Me.cmbquestion.FormattingEnabled = True
        Me.cmbquestion.Items.AddRange(New Object() {"what is your first pets name?", "what is your eldest cousin name?", "what is the name of your bestfriend?", "where is your birthplace?", "what is your favourite food?"})
        Me.cmbquestion.Location = New System.Drawing.Point(190, 90)
        Me.cmbquestion.Name = "cmbquestion"
        Me.cmbquestion.Size = New System.Drawing.Size(224, 21)
        Me.cmbquestion.TabIndex = 13
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(190, 46)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(224, 20)
        Me.txtusername.TabIndex = 12
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Gray
        Me.lblusername.Location = New System.Drawing.Point(2, 41)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(95, 25)
        Me.lblusername.TabIndex = 11
        Me.lblusername.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "New password"
        Me.Label1.Visible = False
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(190, 68)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(224, 20)
        Me.txtnewpass.TabIndex = 12
        Me.txtnewpass.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Confirm password"
        Me.Label2.Visible = False
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Location = New System.Drawing.Point(190, 108)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpass.Size = New System.Drawing.Size(224, 20)
        Me.txtconfirmpass.TabIndex = 12
        Me.txtconfirmpass.Visible = False
        '
        'btnfok
        '
        Me.btnfok.Location = New System.Drawing.Point(304, 231)
        Me.btnfok.Name = "btnfok"
        Me.btnfok.Size = New System.Drawing.Size(75, 23)
        Me.btnfok.TabIndex = 19
        Me.btnfok.Text = "OK"
        Me.btnfok.UseVisualStyleBackColor = True
        Me.btnfok.Visible = False
        '
        'forgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Finance_Management_System.My.Resources.Resources.creative_colorful_eye_creative_colorful_eye_1920x1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(479, 262)
        Me.Controls.Add(Me.btnfok)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.cmbquestion)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "forgotpassword"
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblanswer As System.Windows.Forms.Label
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents cmbquestion As System.Windows.Forms.ComboBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmpass As System.Windows.Forms.TextBox
    Friend WithEvents btnfok As System.Windows.Forms.Button
End Class
