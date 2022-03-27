Public Class forgotpassword
    Dim sql As String

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'close the current form
        Me.Close()
        'shows the login form
        login.Show()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        'selects question and aswer from usernamepasswordchange
        sql = "select [question],[answer] from [usernamepasswordchange] where [username]=" & "'" & txtusername.Text & "'"
        loaddb(sql)
        'checks the existance of the user
        If datatable.Rows.Count <= 0 Then
            MsgBox("Invalid username", MsgBoxStyle.Exclamation, "INVALID")
            Exit Sub
        End If
        Dim question, answer As String
        'sets question with the value of question in usernamepasswordchange
        question = datatable.Rows(0)(0)
        'sets answer with the value of answer in usernamepasswordchange
        answer = datatable.Rows(0)(1)
        'if cmbquestion and txtanswer are valid then shows label1,label2,txtnewpas,txtconfirmpass and btnfok hiding all others
        If cmbquestion.Text = question And txtanswer.Text = answer Then
            lblanswer.Visible = False
            lblquestion.Visible = False
            lblusername.Visible = False
            txtanswer.Visible = False
            txtusername.Visible = False
            cmbquestion.Visible = False
            btnok.Visible = False
            Label1.Visible = True
            Label2.Visible = True
            txtnewpass.Visible = True
            txtconfirmpass.Visible = True
            btnfok.Visible = True
        Else
            'display error msg if question or answer is invalid
            MsgBox("Question or Answer is not correct", MsgBoxStyle.Exclamation, "INVALID")
        End If
    End Sub

    Private Sub txtanswer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtanswer.KeyPress
        If e.KeyChar = Chr(13) Then
            'selects question and aswer from usernamepasswordchange
            sql = "select [question],[answer] from [usernamepasswordchange] where [username]=" & "'" & txtusername.Text & "'"
            loaddb(sql)
            'checks the existance of the user
            If datatable.Rows.Count <= 0 Then
                MsgBox("Invalid username", MsgBoxStyle.Exclamation, "INVALID")
                Exit Sub
            End If
            Dim question, answer As String
            'sets question with the value of question in usernamepasswordchange
            question = datatable.Rows(0)(0)
            'sets answer with the value of answer in usernamepasswordchange
            answer = datatable.Rows(0)(1)
            'if cmbquestion and txtanswer are valid then shows label1,label2,txtnewpas,txtconfirmpass and btnfok hiding all others
            If cmbquestion.Text = question And txtanswer.Text = answer Then
                lblanswer.Visible = False
                lblquestion.Visible = False
                lblusername.Visible = False
                txtanswer.Visible = False
                txtusername.Visible = False
                cmbquestion.Visible = False
                btnok.Visible = False
                Label1.Visible = True
                Label2.Visible = True
                txtnewpass.Visible = True
                txtconfirmpass.Visible = True
                btnfok.Visible = True
            Else
                'display error msg if question or answer is invalid
                MsgBox("Question or Answer is not correct", MsgBoxStyle.Exclamation, "INVALID")
            End If
        End If
    End Sub

    Private Sub forgotpassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'shows the login form
        login.Show()
    End Sub

    Private Sub btnfok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfok.Click
        If txtnewpass.Text = txtconfirmpass.Text Then
            'updates password
            sql = "update [usernamepasswordchange] set [password]=" & "'" & encryption(txtconfirmpass.Text).trim & "'"
            sql = sql & " where [username]=" & "'" & txtusername.Text.Trim & "'"
            updaterecord(sql)
            MsgBox("Password changed", MsgBoxStyle.Information, "SUCCESSFUL")
            'closes the current form
            Me.Close()
        Else
            MsgBox("Passwords mismatched", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub txtconfirmpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconfirmpass.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtnewpass.Text = txtconfirmpass.Text Then
                'updates password
                sql = "update [usernamepasswordchange] set [password]=" & "'" & encryption(txtconfirmpass.Text).trim & "'"
                sql = sql & " where [username]=" & "'" & txtusername.Text.Trim & "'"
                updaterecord(sql)
                MsgBox("Password changed", MsgBoxStyle.Information, "SUCCESSFUL")
                'closes the current form
                Me.Close()
            Else
                MsgBox("Passwords mismatched", MsgBoxStyle.Exclamation, "ERROR")
            End If
        End If
    End Sub

End Class