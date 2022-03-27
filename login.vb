
Public Class login
    Dim datatable As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenter.Click
        Dim t As String
        'encrypts password and save to t
        t = encryption(txtpassword.Text)
        Dim sql As String
        'selects all from usernamepasswordchange where username is the value in txtusername
        sql = "select * from usernamepasswordchange where username='" & txtusername.Text & "'"
        datatable = loaddb(sql)
        If datatable.Rows.Count <= 0 Then
            MsgBox("Username or password incorrect", MsgBoxStyle.Exclamation, "INVALID")
            Exit Sub
        End If
        'checks if username and password are entered correctly
        If txtusername.Text.Trim = datatable.Rows(0)(0) And t.Trim = datatable.Rows(0)(1).trim Then
            If datatable.Rows(0)(0) = "admin" Then
                'stores admin in the value of usernamepasswordchange.txtnewusername and disables it
                usernamepasswordchange.txtnewusername.Text = "admin"
                usernamepasswordchange.txtnewusername.Enabled = False
                welcome.btncreateuser.Enabled = True
            Else
                'disables btncreateuser in welcome form
                welcome.btncreateuser.Enabled = False
            End If
            'shows up the welcome form and clear txtusername and txtpassword
            welcome.Show()
            txtusername.Clear()
            txtpassword.Clear()
            'closes the current form
            Me.Close()
        Else
            'displays error message if username and password are not valid and clears txtusername and txtpassword
            MsgBox("Username or Password is incorrect", MsgBoxStyle.Critical, "username or password wrong")
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Select()
        End If
    End Sub

    Private Sub login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If welcome.Visible = True Then
            'hides about form if welcome form is visible
            about.Hide()
        Else
            'closes about form
            about.Close()
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'disables the datetimepicker1 and selects txtusername
        DateTimePicker1.Enabled = False
        txtusername.Select()

    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim t As String
            'encrypts password and save to t
            t = encryption(txtpassword.Text)
            Dim sql As String
            'selects all from usernamepasswordchange where username is the value in txtusername
            sql = "select * from usernamepasswordchange where username='" & txtusername.Text & "'"
            datatable = loaddb(sql)
            If datatable.Rows.Count <= 0 Then
                MsgBox("Username or password incorrect", MsgBoxStyle.Exclamation, "INVALID")
                Exit Sub
            End If
            'checks if username and password are entered correctly
            If txtusername.Text.Trim = datatable.Rows(0)(0) And t.Trim = datatable.Rows(0)(1).trim Then
                If datatable.Rows(0)(0) = "admin" Then
                    'stores admin in the value of usernamepasswordchange.txtnewusername and disables it
                    usernamepasswordchange.txtnewusername.Text = "admin"
                    usernamepasswordchange.txtnewusername.Enabled = False
                    welcome.btncreateuser.Enabled = True
                Else
                    'disables btncreateuser in welcome form
                    welcome.btncreateuser.Enabled = False
                End If
                'shows up the welcome form and clear txtusername and txtpassword
                welcome.Show()
                txtusername.Clear()
                txtpassword.Clear()
                'closes the current form
                Me.Close()
            Else
                'displays error message if username and password are not valid and clears txtusername and txtpassword
                MsgBox("Username or Password is incorrect", MsgBoxStyle.Critical, "username or password wrong")
                txtusername.Clear()
                txtpassword.Clear()
                txtusername.Select()
            End If
        End If
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'closes the current form
        Me.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'closes the current form
        Me.Close()
    End Sub

    Private Sub help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles help.Click
        'shows the forgot password form
        forgotpassword.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'closes the current form
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'shows form1
        Form1.Show()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub
End Class
