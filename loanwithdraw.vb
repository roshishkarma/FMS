Public Class loanwithdraw

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        'closes the current form and go back to welcome form
        welcome.Show()
        Me.Close()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'closes the current form
        Me.Close()
    End Sub

    Private Sub lblname_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblname.MouseEnter
        'displays the hint 
        lblhint.Visible = True
    End Sub

    Private Sub lblname_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblname.MouseLeave
        'hides the hint
        lblhint.Visible = False
    End Sub

    Private Sub cmbto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbwithdraw.SelectedIndexChanged
        'displays lblname and txtname if cmbwithdraw value is "others"
        If cmbwithdraw.SelectedItem = "Others" Then
            lblname.Visible = True
            txtname.Visible = True
        Else
            lblname.Visible = False
            txtname.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'moves the text"Finance Management System" of buttom of form right to left can be used as decoration
        lblevent.Left = lblevent.Left - 6
        If lblevent.Left < -lblevent.Width Then
            lblevent.Left = lblevent.Width
        End If
    End Sub

    Private Sub withdrawmoney_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starts the timer1
        Timer1.Start()
        Dim sql As String
        'generates the receipt no automatically
        sql = "select [receipt no] from [withdraw loan]"
        lblrcp.Text = id(sql)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'codes for the log out
        login.Show()
        welcome.Hide()
        Me.Close()
        loan.Close()
        usernamepasswordchange.Close()
        createnewaccount.Close()
        accountdetails.Close()
        accountstatement.Close()
        deposit.Close()
        withdrawmoney.Close()
        loandetails.Close()
        loanstatement.Close()
        payloan.Close()
        New_User.Close()
        Form1.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the current form
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
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

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        'opens the new user form
        New_User.Show()
    End Sub

    Private Sub AccDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDetailToolStripMenuItem.Click
        'opens the accountdetails form
        accountdetails.Show()
    End Sub

    Private Sub LoanDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanDetailToolStripMenuItem.Click
        'opens the loandetails form
        loandetails.Show()
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToolStripMenuItem.Click
        'opens the usernamepassword form
        usernamepasswordchange.Show()
    End Sub
    Private Sub StatementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'opens the accountstatement form
        accountstatement.Show()
    End Sub

    Private Sub AccDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'opens the accountdetails form
        accountdetails.Show()
    End Sub

    Private Sub StatementToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'opens the loanstatement form
        loanstatement.Show()
    End Sub

    Private Sub DetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'opens the loandetails form
        loandetails.Show()
    End Sub

    Private Sub SavingDepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'opens the deposit form
        deposit.Show()
    End Sub

    Private Sub WithdrawMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawMoneyToolStripMenuItem.Click
        'opens the withdrawmoney form
        withdrawmoney.Show()
    End Sub

    Private Sub PayLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayLoanToolStripMenuItem.Click
        'opens the payloan form
        payloan.Show()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtaccid.Text = "" Then
            'displays error message if account id field is empty
            MsgBox("Account id field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If IsNumeric(txtaccid.Text) = False Then
            MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        'stores txtname "--" if cmbwithdraw value is not "Others"
        If cmbwithdraw.Text <> "Others" Then
            txtname.Text = "--"
        End If
        If cmbacctype.Text <> "" And txtaccid.Text <> "" And txtacch.Text <> "" And txtchkb.Text <> "" Then
            'codes to store withdrawal details
            Dim sql As String
            sql = "insert into [withdraw loan] values ('" & lblrcp.Text & "','"
            sql = sql & cmbacctype.Text & "','"
            sql = sql & DateTimePicker1.Value & "','"
            sql = sql & txtaccid.Text & "','"
            sql = sql & txtbrncho.Text & "','"
            sql = sql & txtfname.Text & "','"
            sql = sql & cmbwithdraw.Text & "','"
            sql = sql & txtname.Text & "','"
            sql = sql & txtawords.Text & "','"
            sql = sql & nudamount.Value & "','"
            sql = sql & txtacch.Text & "','"
            sql = sql & txtchkb.Text & "')"

            'add the loanwithdraw details
            adddata(sql)
            If cmbacctype.Text = "Home loan" Then
                'get the data of sanctioned loan from home loan with value of account id in txtaccid.text
                sql = "select [sanctioned loan] from [home loan] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                'checks if the number of rows is not zero
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'substract the value of nudamount from add
                    add = amount - nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the sactioned loan
                    sql = "update [home loan] set [sanctioned loan]=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""
                    updaterecord(sql)
                Else
                    'dispalys error message if the account id does not exists
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If
            ElseIf cmbacctype.Text = "Business loan" Then
                'get the data of sanctioned loan from business loan with value of account id in txtaccid.text
                sql = "select [sanctioned loan] from [business loan] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                'checks if the number of rows is not zero
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'substract the value of nudamount from add
                    add = amount - nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the sactioned loan
                    sql = "update [business loan] set [sanctioned loan]=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""

                    updaterecord(sql)
                Else
                    'dispalys error message if the account id does not exists
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If
            ElseIf cmbacctype.Text = "Education loan" Then
                'get the data of sanctioned loan from education loan with value of account id in txtaccid.text
                sql = "select [sanctioned loan] from [education loan] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                'checks if the number of rows is not zero
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'substract the value of nudamount from add
                    add = amount - nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the sactioned loan
                    sql = "update [education loan] set [sanctioned loan]=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""

                    updaterecord(sql)
                Else
                    'dispalys error message if the account id does not exists
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If
            End If
            'closes the current form
            Me.Close()
        ElseIf txtchkb.Text = "" Then
            'displays error message if verifier field is empty
            MsgBox("Verifier field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf cmbacctype.Text = "" Then
            'displays error message if Account type field is empty
            MsgBox("Account type cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub
End Class