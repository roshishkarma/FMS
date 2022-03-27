<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgetpassword
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
        Me.fusername = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.ok = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.question = New System.Windows.Forms.Label()
        Me.answer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'fusername
        '
        Me.fusername.AutoSize = True
        Me.fusername.BackColor = System.Drawing.Color.Transparent
        Me.fusername.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fusername.ForeColor = System.Drawing.Color.Gray
        Me.fusername.Location = New System.Drawing.Point(2, 24)
        Me.fusername.Name = "fusername"
        Me.fusername.Size = New System.Drawing.Size(95, 25)
        Me.fusername.TabIndex = 0
        Me.fusername.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(190, 29)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(224, 20)
        Me.txtusername.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"what is your first pet's name?", "what is your eldest cousin name?", "what is the name of your bestfriend?", "where is your birthplace?", "what is your favourite food?"})
        Me.ComboBox1.Location = New System.Drawing.Point(190, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(190, 116)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(224, 20)
        Me.txtanswer.TabIndex = 5
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(304, 231)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 6
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(398, 231)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 7
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'question
        '
        Me.question.AutoSize = True
        Me.question.BackColor = System.Drawing.Color.Transparent
        Me.question.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question.ForeColor = System.Drawing.Color.Gray
        Me.question.Location = New System.Drawing.Point(2, 69)
        Me.question.Name = "question"
        Me.question.Size = New System.Drawing.Size(182, 25)
        Me.question.TabIndex = 9
        Me.question.Text = "Select Any Question"
        '
        'answer
        '
        Me.answer.AutoSize = True
        Me.answer.BackColor = System.Drawing.Color.Transparent
        Me.answer.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer.ForeColor = System.Drawing.Color.Gray
        Me.answer.Location = New System.Drawing.Point(2, 111)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(75, 25)
        Me.answer.TabIndex = 10
        Me.answer.Text = "Answer"
        '
        'Forgetpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bank_acc_management_sys.My.Resources.Resources.creative_colorful_eye_creative_colorful_eye_1920x10801
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(479, 262)
        Me.Controls.Add(Me.answer)
        Me.Controls.Add(Me.question)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.fusername)
        Me.Name = "Forgetpassword"
        Me.Text = "Forgetpassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fusername As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents question As System.Windows.Forms.Label
    Friend WithEvents answer As System.Windows.Forms.Label
End Class
