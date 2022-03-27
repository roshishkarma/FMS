Public Class New_User

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'closes the current form
        Me.Close()
        'opens the welcome form
        welcome.Show()
    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        'closes the current form
        Me.Close()
        'opens the welcome form
        welcome.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "INPUT")
            Exit Sub
        End If
        If cmbquestion.Text = "" Or txtanswer.Text = "" Then
            MsgBox("Enter Question and Answer", MsgBoxStyle.Exclamation, "INPUT")
            Exit Sub
        End If
        'display error message if the username is admin
        If txtusername.Text = "admin" Then
            MsgBox("You cannot create an admin account", MsgBoxStyle.Exclamation, "INVALID")
            'add a new user to the table usernamepasswrodchange.
        ElseIf txtpassword.Text = txtconfrimpass.Text Then
            Dim sql As String
            sql = "Insert into usernamepasswordchange values ('"
            sql = sql & txtusername.Text & "','"
            sql = sql & (encryption(txtconfrimpass.Text)).trim & "','"
            sql = sql & cmbquestion.SelectedItem & "','"
            sql = sql & txtanswer.Text & "')"
            adddata(sql)
            'closes the current form
            Me.Close()
        Else
            'displays error message if passwords are not matching
            MsgBox("Password Not Matching", MsgBoxStyle.Exclamation, "PASSWORD INVALID")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtanswer.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtusername.Text = "" Or txtpassword.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "INPUT")
                Exit Sub
            End If
            If cmbquestion.Text = "" Or txtanswer.Text = "" Then
                MsgBox("Enter Question and Answer", MsgBoxStyle.Exclamation, "INPUT")
                Exit Sub
            End If
            'display error message if the username is admin
            If txtusername.Text = "admin" Then
                MsgBox("You cannot create an admin account", MsgBoxStyle.Exclamation, "INVALID")
                'add a new user to the table usernamepasswrodchange.
            ElseIf txtpassword.Text = txtconfrimpass.Text Then
                Dim sql As String
                sql = "Insert into usernamepasswordchange values ('"
                sql = sql & txtusername.Text & "','"
                sql = sql & (encryption(txtconfrimpass.Text)).trim & "','"
                sql = sql & cmbquestion.SelectedItem & "','"
                sql = sql & txtanswer.Text & "')"
                adddata(sql)
                'closes the current form
                Me.Close()
            Else
                'displays error message if passwords are not matching
                MsgBox("Password Not Matching", MsgBoxStyle.Exclamation, "PASSWORD INVALID")
            End If
        End If
    End Sub

End Class