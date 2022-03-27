Public Class usernamepasswordchange
    Dim datatable As DataTable
    Private Sub save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim datatable As DataTable = loaddb("select username from usernamepasswordchange")
        Dim count As Integer = datatable.Rows.Count
        Dim x, i As Integer
        Dim sql, array(count) As String
        For j = 0 To count - 1
            x = x + 1
            'fills the array
            array(x) = datatable.Rows(j)(0)
        Next
        If txtusername.Text = "" Or txtoldpassword.Text = "" Or txtnewusername.Text = "" Or txtnewpass.Text = "" Then
            MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "INPUT")
            Exit Sub
        End If
        If cmbquestion.Text = "" Or txtanswer.Text = "" Then
            MsgBox("Enter Question and Answer", MsgBoxStyle.Exclamation, "INPUT")
            Exit Sub
        End If
        'selects username, old password, question and answer
        sql = "select * from usernamepasswordchange where username='" & txtusername.Text & "' and password='" & encryption(txtoldpassword.Text).trim & "';"
        datatable = loaddb(sql)
        'checks the existance of user
        If datatable.Rows.Count <= 0 Then
            MsgBox("Existing Username or old-password Invalid", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        i = 0
        For i = 1 To x
            If array(i) = txtnewusername.Text And txtnewusername.Text <> txtusername.Text Then
                MsgBox("Username Invalid", MsgBoxStyle.Information, "INVALID")
                Exit Sub
                Exit For
            End If
        Next
        If txtconfirmpass.Text = txtnewpass.Text Then
            'updates the usernamepasswordchange table
            sql = "Update usernamepasswordchange SET [password] =" & "'" & (encryption(txtnewpass.Text)).trim & "'"
            sql = sql & ", [username]='" & txtnewusername.Text & "'"
            sql = sql & " where [username]='" & (txtusername.Text) & "'"
            sql = sql & " and [password]='" & (encryption(txtoldpassword.Text)) & "'"
            sql = sql & " and [question]='" & cmbquestion.SelectedItem & "'"
            sql = sql & " and [answer]='" & txtanswer.Text & "'"

            updaterecord(sql)
            MsgBox("Password changed", MsgBoxStyle.Information, "SUCCESSFUL")
            login.Show()
            welcome.Hide()
            Me.Close()
            deposit.Close()
            loanstatement.Close()
            accountstatement.Close()
            loanwithdraw.Close()
            accountdetails.Close()
            createnewaccount.Close()
            withdrawmoney.Close()
            loan.Close()
            loandetails.Close()
            payloan.Close()
            New_User.Close()
            Form1.Close()
        Else
            MsgBox("Password Mismatch", MsgBoxStyle.Information, "Mismatch")
        End If
    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        welcome.Show()
        Me.Hide()
    End Sub

    Private Sub cancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel1.Click
        Me.Close()
        welcome.Show()
    End Sub

    Private Sub usernamepasswordchange_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        welcome.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtanswer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtanswer.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim datatable As DataTable = loaddb("select username from usernamepasswordchange")
            Dim count As Integer = datatable.Rows.Count
            Dim x, i As Integer
            Dim sql, array(count) As String
            For j = 0 To count - 1
                x = x + 1
                'fills the array
                array(x) = datatable.Rows(j)(0)
            Next
            If txtusername.Text = "" Or txtoldpassword.Text = "" Or txtnewusername.Text = "" Or txtnewpass.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "INPUT")
                Exit Sub
            End If
            'selects username, old password, question and answer
            sql = "select * from usernamepasswordchange where username='" & txtusername.Text & "' and password='" & encryption(txtoldpassword.Text).trim & "';"
            datatable = loaddb(sql)
            'checks the existance of user
            If datatable.Rows.Count <= 0 Then
                MsgBox("Existing Username and old-password Invalid", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If
            i = 0
            For i = 1 To x
                If array(i) = txtnewusername.Text And txtnewusername.Text <> txtusername.Text Then
                    MsgBox("Username Invalid", MsgBoxStyle.Information, "INVALID")
                    Exit Sub
                    Exit For
                End If
            Next
            'updates the usernamepasswordchange table
            If txtconfirmpass.Text = txtnewpass.Text Then
                sql = "Update usernamepasswordchange SET [password] =" & "'" & (encryption(txtnewpass.Text)).trim & "'"
                sql = sql & ", [username]='" & txtnewusername.Text & "'"
                sql = sql & " where [username]='" & (txtusername.Text) & "'"
                sql = sql & " and [password]='" & (encryption(txtoldpassword.Text)) & "'"
                sql = sql & " and [question]='" & cmbquestion.SelectedItem & "'"
                sql = sql & " and [answer]='" & txtanswer.Text & "'"

                updaterecord(sql)
                MsgBox("Password changed", MsgBoxStyle.Information, "SUCCESSFUL")
                login.Show()
                welcome.Hide()
                Me.Close()
                deposit.Close()
                loanstatement.Close()
                accountstatement.Close()
                loanwithdraw.Close()
                accountdetails.Close()
                createnewaccount.Close()
                withdrawmoney.Close()
                loan.Close()
                loandetails.Close()
                payloan.Close()
                New_User.Close()
                Form1.Close()
            Else
                MsgBox("Password Mismatch", MsgBoxStyle.Information, "Mismatch")
            End If
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'codes for the log out
        login.Show()
        welcome.Hide()
        Me.Close()
        deposit.Close()
        loanstatement.Close()
        accountstatement.Close()
        loanwithdraw.Close()
        accountdetails.Close()
        createnewaccount.Close()
        withdrawmoney.Close()
        loan.Close()
        loandetails.Close()
        payloan.Close()
        New_User.Close()
        Form1.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'closes the current form
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'opens the about form
        Form1.Show()
    End Sub

    Private Sub SavingAccToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavingAccToolStripMenuItem.Click
        'Opens the createaccount form
        createnewaccount.Show()
    End Sub

    Private Sub LoanAccToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanAccToolStripMenuItem.Click
        'opens the loan form
        loan.Show()
    End Sub

    Private Sub AccDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDetailToolStripMenuItem.Click
        'opens the accountdetails form
        accountdetails.Show()
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        'opens the new user form
        New_User.Show()
    End Sub

    Private Sub LoanDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanDetailToolStripMenuItem.Click
        'opens the loandetails form
        loandetails.Show()
    End Sub

    Private Sub StatementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementToolStripMenuItem1.Click
        'opens the accountstatement form
        accountstatement.Show()
    End Sub

    Private Sub AccDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDetailToolStripMenuItem1.Click
        'opens the accountdetails form
        accountdetails.Show()
    End Sub

    Private Sub StatementToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementToolStripMenuItem2.Click
        'opens the loanstatement form
        loanstatement.Show()
    End Sub

    Private Sub DetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailToolStripMenuItem.Click
        'opens the loandetails form
        loandetails.Show()
    End Sub

    Private Sub SavingDepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavingDepositToolStripMenuItem.Click
        'opens the deposit form
        deposit.Show()
    End Sub

    Private Sub WithdrawLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawLoanToolStripMenuItem.Click
        'opens the loanwithdraw form
        loanwithdraw.Show()
    End Sub

    Private Sub WithdrawMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawMoneyToolStripMenuItem.Click
        'opens the withdrawmoney form
        withdrawmoney.Show()
    End Sub

    Private Sub PayLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayLoanToolStripMenuItem.Click
        'opens the payloan form
        payloan.Show()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If txtusername.Text & (e.KeyChar) = "admin" Then
            txtnewusername.Enabled = False
            txtnewusername.Text = "admin"
        Else
            txtnewusername.Text = ""
            txtnewusername.Enabled = True
        End If
    End Sub

    Private Sub txtnewusername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnewusername.GotFocus
        If txtusername.Text = "admin" Then
            txtnewusername.Enabled = False
            txtnewusername.Text = "admin"
        Else
            txtnewusername.Text = ""
            txtnewusername.Enabled = True
        End If
    End Sub

    Private Sub usernamepasswordchange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.Select()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub
End Class