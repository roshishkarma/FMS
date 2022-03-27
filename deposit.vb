Public Class deposit

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        'closes the deposit form and go back to the welcome form
        Me.Close()
        welcome.Show()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'closes the form
        Me.Close()

    End Sub

    Private Sub labeltimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labeltimer.Tick
        'moves the text"Finance Management System" of buttom of form right to left can be used as decoration
        lblevent.Left = lblevent.Left - 6
        If lblevent.Left < -lblevent.Width Then
            lblevent.Left = lblevent.Width
        End If
    End Sub

    Private Sub deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starts the timer
        labeltimer.Start()
        Dim sql As String
        'generates the receipt no automatically
        sql = "select [receipt no] from [deposit money]"
        lblrcp.Text = id(sql)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'codes for the log out
        login.Show()
        welcome.Hide()
        Me.Close()
        loan.Close()
        usernamepasswordchange.Close()
        accountstatement.Close()
        loanwithdraw.Close()
        accountdetails.Close()
        createnewaccount.Close()
        withdrawmoney.Close()
        loandetails.Close()
        loanstatement.Close()
        payloan.Close()
        New_User.Close()
        Form1.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the deposit form
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

    Private Sub chkterms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkterms.CheckedChanged
        'cheks whether the terms and condition are accepted or not and enables submit button if terms are accepted
        If chkterms.Checked = True Then
            btnsubmit.Enabled = True
        Else
            btnsubmit.Enabled = False
        End If
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
        'stores the deposit details if depositor field,receiver field and authorizer field are filled properly
        If txtdepositor.Text <> "" And txtreceiver.Text <> "" And txtauthorized.Text <> "" And txtaccid.Text <> "" And cmbacctype.Text <> "" Then
            'codes to store deposit details
            Dim sql As String
            sql = "insert into [deposit money] values ('" & lblrcp.Text & "','"
            sql = sql & txtaccid.Text & "','"
            sql = sql & txtbrnoffice.Text & "','"
            sql = sql & DateTimePicker2.Value & "','"
            sql = sql & txtfname.Text & "','"
            sql = sql & txtmname.Text & "','"
            sql = sql & txtlname.Text & "','"
            sql = sql & cmbacctype.Text & "','"
            sql = sql & nudamount.Value & "','"
            sql = sql & txtawords.Text & "','"
            sql = sql & txtdepositor.Text & "','"
            sql = sql & txtreceiver.Text & "','"
            sql = sql & txtauthorized.Text & "')"

            'add the deposit details
            adddata(sql)
            If cmbacctype.Text = "Savings" Then
                'get the data of amount from savings with value of account id in txtaccid.text
                sql = "select [amount] from [savings] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                'checks if the number of rows is not zero
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'add the value of nudamount with add
                    add = amount + nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the amount 
                    sql = "update [savings] set amount=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""

                    updaterecord(sql)
                Else
                    'dispalys error message if the account id does not exists
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If
            ElseIf cmbacctype.Text = "Fixed deposit" Then
                'get the data of amount from fixed deposit with value of account id in txtaccid.text
                sql = "select [amount] from [fixed deposit] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'add the value of nudamount with add
                    add = amount + nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the amount 
                    sql = "update [fixed deposit] set amount=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""

                    updaterecord(sql)
                Else
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If
            ElseIf cmbacctype.Text = "Minor" Then
                'get the data of amount from minor with value of account id in txtaccid.text
                sql = "select [amount] from [minor] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'add the value of nudamount with add
                    add = amount + nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the amount 
                    sql = "update [minor] set amount=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""

                    updaterecord(sql)
                Else
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If

            ElseIf cmbacctype.Text = "Joint account" Then
                'get the data of amount from jointaccount with value of account id in txtaccid.text
                sql = "select [amount] from [jointaccount] where [account id]=" & txtaccid.Text
                loaddb(sql)
                Dim amount As Double
                Dim add As Double
                If datatable.Rows.Count > 0 Then
                    amount = datatable.Rows(0)(0)
                    'add the value of nudamount with add
                    add = amount + nudamount.Value
                    MsgBox("The new balance is " & add, MsgBoxStyle.Information, "BALANCE")
                    'update the amount 
                    sql = "update [jointaccount] set amount=" & "" & add & ""
                    sql = sql & " where [account id]=" & txtaccid.Text & ""

                    updaterecord(sql)
                Else
                    MsgBox("No account id detected", MsgBoxStyle.Exclamation, "ERROR")
                    Me.Close()
                    Exit Sub
                End If
            End If
            'closes the current form
                Me.Close()
        ElseIf txtdepositor.Text = "" Then
            'displays error message if Depositor field is empty
            MsgBox("Depositor field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf txtreceiver.Text = "" Then
            'displays error message if Receiver field is empty
            MsgBox("Receiver field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf txtauthorized.Text = "" Then
            'displays error message if Authorizer field is empty
            MsgBox("Authorizer field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
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