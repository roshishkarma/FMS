Public Class accountdetails
    Dim Sql As String

    Private Sub accountdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starts the timer
        Timer1.Start()
    End Sub

    Private Sub chksaving_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksaving.CheckedChanged
        'checks whether chksaving is checked and other checkbox are unchecked
        If chksaving.Checked = True Then
            chkfixed.Checked = False
            chkminor.Checked = False
            chkjoint.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of saving account
            Sql = "select * from savings"
            DataGridView1.DataSource = loaddb(Sql)
            'fills datagridview3 with the details of deposit with saving account
            Sql = "select * from [deposit money] where [account type]='Savings'"
            DataGridView3.DataSource = loaddb(Sql)
            'fills datagridview2 with the details of withdrawal with saving account
            Sql = "select * from [withdraw money] where [account type]='Savings'"
            DataGridView2.DataSource = loaddb(Sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkfixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfixed.CheckedChanged
        'checks whether chkfixed is checked and other checkbox are unchecked
        If chkfixed.Checked = True Then
            chksaving.Checked = False
            chkminor.Checked = False
            chkjoint.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of fixed deposit account
            Sql = "select * from [fixed deposit]"
            DataGridView1.DataSource = loaddb(Sql)
            'fills datagridview3 with the details of deposit with fixed deposit account
            Sql = "select * from [deposit money] where [account type]='Fixed deposit'"
            DataGridView3.DataSource = loaddb(Sql)
            'fills datagridview2 with the details of withdrawal with fixed deposit account
            Sql = "select * from [withdraw money] where [account type]='Fixed deposit'"
            DataGridView2.DataSource = loaddb(Sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkminor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkminor.CheckedChanged
        'checks whether chkminor is checked and other checkbox are unchecked
        If chkminor.Checked = True Then
            chkfixed.Checked = False
            chksaving.Checked = False
            chkjoint.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of minor account
            Sql = "select * from [minor]"
            DataGridView1.DataSource = loaddb(Sql)
            'fills datagridview3 with the details of deposit with minor account
            Sql = "select * from [deposit money] where [account type]='Minor'"
            DataGridView3.DataSource = loaddb(Sql)
            'fills datagridview2 with the details of withdrawal with minor account
            Sql = "select * from [withdraw money] where [account type]='Minor'"
            DataGridView2.DataSource = loaddb(Sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkjoint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkjoint.CheckedChanged
        'checks whether chkjoint is checked and other checkbox are unchecked
        If chkjoint.Checked = True Then
            chkfixed.Checked = False
            chksaving.Checked = False
            chkminor.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of joint account
            Sql = "select * from [jointaccount]"
            DataGridView1.DataSource = loaddb(Sql)
            'fills datagridview3 with the details of deposit with joint account
            Sql = "select * from [deposit money] where [account type]='Joint account'"
            DataGridView3.DataSource = loaddb(Sql)
            'fills datagridview2 with the details of withdrawal with joint account
            Sql = "select * from [withdraw money] where [account type]='Joint account'"
            DataGridView2.DataSource = loaddb(Sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'codes for the movement of the lblevent
        lblevent.Left = lblevent.Left - 6
        If lblevent.Left < -lblevent.Width Then
            lblevent.Left = lblevent.Width
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'codes for the log out
        login.Show()
        welcome.Hide()
        Me.Close()
        loan.Close()
        usernamepasswordchange.Close()
        createnewaccount.Close()
        loanwithdraw.Close()
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

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        'opens the new user form
        New_User.Show()
    End Sub

    Private Sub LoanDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanDetailToolStripMenuItem.Click
        'opens the accountdetails form
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

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If chksaving.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    'displays error message if txtfname,txtmname and txtlname are empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from savings with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    Sql = "select * from [savings] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of savings with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    Sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Savings'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of savings with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Savings'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                'uncheck rdbname if rdbaccid is checked
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    'displays error message if txtaccid is empty
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from savings with account id is the value in txtaccid and fill data to datagridview1
                    Sql = "select * from [savings] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of savings  with account id is the value in txtaccid and fill data to datagridview3
                    Sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Savings'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of savings with account id is the value in txtaccid and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Savings'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkfixed.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    'displays error message if txtfname,txtmname and txtlname are empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from fixed deposit with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    Sql = "select * from [fixed deposit] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of fixed deposit with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    Sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Fixed deposit'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of fixed deposit with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Fixed deposit'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                'uncheck rdbname if rdbaccid is checked
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    'displays error message if txtaccid is empty
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from fixed deposit with account id is the value in txtaccid and fill data to datagridview1
                    Sql = "select * from [fixed deposit] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of fixed deposit with account id is the value in txtaccid and fill data to datagridview3
                    Sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Fixed deposit'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of fixed deposit with account id is the value in txtaccid and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Fixed deposit'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkminor.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    'displays error message if txtfname,txtmname and txtlname are empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from minor with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    Sql = "select * from [minor] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of minor with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    Sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Minor'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of minor with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Minor'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                'uncheck rdbname if rdbaccid is checked
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    'displays error message if txtaccid is empty
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from minor with account id is the value in txtaccid and fill data to datagridview1
                    Sql = "select * from [minor] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of minor with account id is the value in txtaccid and fill data to datagridview3
                    Sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Minor'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of minor with account id is the value in txtaccid and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Minor'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkjoint.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    'displays error message if txtfname,txtmname and txtlname are empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from jointaccount with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    Sql = "select * from [jointaccount] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of jointaccount with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    Sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Joint account'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of jointaccount with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Joint account'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                'uncheck rdbname if rdbaccid is checked
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    'displays error message if txtaccid is empty
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from jointaccount with account id is the value in txtaccid and fill data to datagridview1
                    Sql = "select * from [jointaccount] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(Sql)
                    'select all data from deposit money of jointaccount with account id is the value in txtaccid and fill data to datagridview3
                    Sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Joint account'"
                    DataGridView3.DataSource = loaddb(Sql)
                    'select all data from withdraw money of jointaccount with account id is the value in txtaccid and fill data to datagridview2
                    Sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Joint account'"
                    DataGridView2.DataSource = loaddb(Sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If
        If chksaving.Checked = False And chkfixed.Checked = False And chkminor.Checked = False And chkjoint.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf rdbaccid.Checked = False And rdbname.Checked = False Then
            'displays error message if none of the radiobutton are checked
            MsgBox("Please select search option for searching", MsgBoxStyle.Exclamation, "SELECTION REQUIRED")
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If chksaving.Checked = False And chkfixed.Checked = False And chkminor.Checked = False And chkjoint.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If txtaccid.Text = "" Then
            MsgBox("Account id field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If chksaving.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from savings,deposit money with savings and withdraw money with savings
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                Sql = ("delete * from [savings] where [account id]=" & txtaccid.Text & "")
                delete(Sql)
                Sql = "delete * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Savings'"
                delete(Sql)
                Sql = "delete * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Savings'"
                delete(Sql)
            End If
        End If
        If chkfixed.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from fixed deposit,deposit money with fixed deposit and withdraw money with fixed deposit
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                Sql = ("delete * from [fixed deposit] where [account id]=" & txtaccid.Text & "")
                delete(Sql)
                Sql = "delete * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Fixed deposit'"
                delete(Sql)
                Sql = "delete * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Fixed deposit'"
                delete(Sql)
            End If
        End If
        If chkminor.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from minor,deposit money with minor and withdraw money with minor
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                Sql = ("delete * from [minor] where [account id]=" & txtaccid.Text & "")
                delete(Sql)
                Sql = "delete * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Minor'"
                delete(Sql)
                Sql = "delete * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Minor'"
                delete(Sql)
            End If
        End If
        If chkjoint.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from jointaccount,deposit money with jointaccount and withdraw money with jointaccount
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                Sql = ("delete * from [jointaccount] where [account id]=" & txtaccid.Text & "")
                delete(Sql)
                Sql = "delete * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Joint account'"
                delete(Sql)
                Sql = "delete * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Joint account'"
                delete(Sql)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'updates the record of savings
        If chksaving.Checked = True Then
            Sql = "update [savings] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(2).Value & ","
            Sql = Sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(3).Value & "',"
            Sql = Sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            Sql = Sql & "[first name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            Sql = Sql & "[middle name]= " & "'" & DataGridView1.CurrentRow.Cells(6).Value & "',"
            Sql = Sql & "[last name]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            Sql = Sql & "[gender]= " & "'" & DataGridView1.CurrentRow.Cells(8).Value & "',"
            Sql = Sql & "[marital status]= " & "'" & DataGridView1.CurrentRow.Cells(9).Value & "',"
            Sql = Sql & "[other marital]= " & "'" & DataGridView1.CurrentRow.Cells(10).Value & "',"
            Sql = Sql & "[DOB BS]= " & "#" & DataGridView1.CurrentRow.Cells(11).Value & "#,"
            Sql = Sql & "[DOB AD]= " & "#" & DataGridView1.CurrentRow.Cells(12).Value & "#,"
            Sql = Sql & "[nationality]= " & "'" & DataGridView1.CurrentRow.Cells(13).Value & "',"
            Sql = Sql & "[citizenship/passport no]= " & "" & DataGridView1.CurrentRow.Cells(14).Value & ","
            Sql = Sql & "[place of issue]= " & "'" & DataGridView1.CurrentRow.Cells(15).Value & "',"
            Sql = Sql & "[exp date]= " & "#" & DataGridView1.CurrentRow.Cells(16).Value & "#,"
            Sql = Sql & "[others]= " & "'" & DataGridView1.CurrentRow.Cells(17).Value & "',"
            Sql = Sql & "[plc of issue]= " & "'" & DataGridView1.CurrentRow.Cells(18).Value & "',"
            Sql = Sql & "[ex date]= " & "#" & DataGridView1.CurrentRow.Cells(19).Value & "#,"
            Sql = Sql & "[municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(20).Value & "',"
            Sql = Sql & "[district]= " & "'" & DataGridView1.CurrentRow.Cells(21).Value & "',"
            Sql = Sql & "[country]= " & "'" & DataGridView1.CurrentRow.Cells(22).Value & "',"
            Sql = Sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(23).Value & ","
            Sql = Sql & "[mobile no]= " & "" & DataGridView1.CurrentRow.Cells(24).Value & ","
            Sql = Sql & "[email]= " & "'" & DataGridView1.CurrentRow.Cells(25).Value & "',"
            Sql = Sql & "[R municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(26).Value & "',"
            Sql = Sql & "[R district]= " & "'" & DataGridView1.CurrentRow.Cells(27).Value & "',"
            Sql = Sql & "[R country]= " & "'" & DataGridView1.CurrentRow.Cells(28).Value & "',"
            Sql = Sql & "[R phone no]= " & "" & DataGridView1.CurrentRow.Cells(29).Value & ","
            Sql = Sql & "[R mobile no]= " & "" & DataGridView1.CurrentRow.Cells(30).Value & ","
            Sql = Sql & "[R email]= " & "'" & DataGridView1.CurrentRow.Cells(31).Value & "',"
            Sql = Sql & "[Nrs]= " & "'" & DataGridView1.CurrentRow.Cells(32).Value & "',"
            Sql = Sql & "[foreign others]= " & "'" & DataGridView1.CurrentRow.Cells(33).Value & "',"
            Sql = Sql & "[amount]= " & "" & DataGridView1.CurrentRow.Cells(34).Value & ","
            Sql = Sql & "[fathers/husbands name]= " & "'" & DataGridView1.CurrentRow.Cells(35).Value & "',"
            Sql = Sql & "[grandfathers name]= " & "'" & DataGridView1.CurrentRow.Cells(36).Value & "',"
            Sql = Sql & "[religion]= " & "'" & DataGridView1.CurrentRow.Cells(37).Value & "',"
            Sql = Sql & "[other religion]= " & "'" & DataGridView1.CurrentRow.Cells(38).Value & "',"
            Sql = Sql & "[occupation type]= " & "'" & DataGridView1.CurrentRow.Cells(39).Value & "',"
            Sql = Sql & "[other occupation]= " & "'" & DataGridView1.CurrentRow.Cells(40).Value & "',"
            Sql = Sql & "[if employed]= " & "'" & DataGridView1.CurrentRow.Cells(41).Value & "',"
            Sql = Sql & "[other employment]= " & "'" & DataGridView1.CurrentRow.Cells(42).Value & "',"
            Sql = Sql & "[education]= " & "'" & DataGridView1.CurrentRow.Cells(43).Value & "',"
            Sql = Sql & "[other education]= " & "'" & DataGridView1.CurrentRow.Cells(44).Value & "',"
            Sql = Sql & "[datee]= " & "#" & DataGridView1.CurrentRow.Cells(45).Value & "#,"
            Sql = Sql & "[name of introducer]= " & "'" & DataGridView1.CurrentRow.Cells(46).Value & "',"
            Sql = Sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(47).Value & "',"
            Sql = Sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(48).Value & "',"
            Sql = Sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(49).Value & "',"
            Sql = Sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(50).Value & "'"
            Sql = Sql & " where [account id]=" & DataGridView1.CurrentRow.Cells(1).Value & ""

            updaterecord(Sql)

            'updates the record of fixed deposit
        ElseIf chkfixed.Checked = True Then
            Sql = "update [fixed deposit] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(2).Value & ","
            Sql = Sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(3).Value & "',"
            Sql = Sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            Sql = Sql & "[first name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            Sql = Sql & "[middle name]= " & "'" & DataGridView1.CurrentRow.Cells(6).Value & "',"
            Sql = Sql & "[last name]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            Sql = Sql & "[gender]= " & "'" & DataGridView1.CurrentRow.Cells(8).Value & "',"
            Sql = Sql & "[marital status]= " & "'" & DataGridView1.CurrentRow.Cells(9).Value & "',"
            Sql = Sql & "[other marital]= " & "'" & DataGridView1.CurrentRow.Cells(10).Value & "',"
            Sql = Sql & "[DOB BS]= " & "#" & DataGridView1.CurrentRow.Cells(11).Value & "#,"
            Sql = Sql & "[DOB AD]= " & "#" & DataGridView1.CurrentRow.Cells(12).Value & "#,"
            Sql = Sql & "[nationality]= " & "'" & DataGridView1.CurrentRow.Cells(13).Value & "',"
            Sql = Sql & "[citizenship/passport no]= " & "" & DataGridView1.CurrentRow.Cells(14).Value & ","
            Sql = Sql & "[place of issue]= " & "'" & DataGridView1.CurrentRow.Cells(15).Value & "',"
            Sql = Sql & "[exp date]= " & "#" & DataGridView1.CurrentRow.Cells(16).Value & "#,"
            Sql = Sql & "[others]= " & "'" & DataGridView1.CurrentRow.Cells(17).Value & "',"
            Sql = Sql & "[plac of issue]= " & "'" & DataGridView1.CurrentRow.Cells(18).Value & "',"
            Sql = Sql & "[ex date]= " & "#" & DataGridView1.CurrentRow.Cells(19).Value & "#,"
            Sql = Sql & "[municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(20).Value & "',"
            Sql = Sql & "[district]= " & "'" & DataGridView1.CurrentRow.Cells(21).Value & "',"
            Sql = Sql & "[country]= " & "'" & DataGridView1.CurrentRow.Cells(22).Value & "',"
            Sql = Sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(23).Value & ","
            Sql = Sql & "[mobile no]= " & "" & DataGridView1.CurrentRow.Cells(24).Value & ","
            Sql = Sql & "[email]= " & "'" & DataGridView1.CurrentRow.Cells(25).Value & "',"
            Sql = Sql & "[R municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(26).Value & "',"
            Sql = Sql & "[R district]= " & "'" & DataGridView1.CurrentRow.Cells(27).Value & "',"
            Sql = Sql & "[R country]= " & "'" & DataGridView1.CurrentRow.Cells(28).Value & "',"
            Sql = Sql & "[R phone no]= " & "" & DataGridView1.CurrentRow.Cells(29).Value & ","
            Sql = Sql & "[R mobile no]= " & "" & DataGridView1.CurrentRow.Cells(30).Value & ","
            Sql = Sql & "[R email]= " & "'" & DataGridView1.CurrentRow.Cells(31).Value & "',"
            Sql = Sql & "[Nrs]= " & "'" & DataGridView1.CurrentRow.Cells(32).Value & "',"
            Sql = Sql & "[foreign currency]= " & "'" & DataGridView1.CurrentRow.Cells(33).Value & "',"
            Sql = Sql & "[amount]= " & "" & DataGridView1.CurrentRow.Cells(34).Value & ","
            Sql = Sql & "[amount in words]= " & "'" & DataGridView1.CurrentRow.Cells(35).Value & "',"
            Sql = Sql & "[fathers/husbands name]= " & "'" & DataGridView1.CurrentRow.Cells(36).Value & "',"
            Sql = Sql & "[grandfathers name]= " & "'" & DataGridView1.CurrentRow.Cells(37).Value & "',"
            Sql = Sql & "[religion]= " & "'" & DataGridView1.CurrentRow.Cells(38).Value & "',"
            Sql = Sql & "[other religion]= " & "'" & DataGridView1.CurrentRow.Cells(39).Value & "',"
            Sql = Sql & "[occupation type]= " & "'" & DataGridView1.CurrentRow.Cells(40).Value & "',"
            Sql = Sql & "[other occupation]= " & "'" & DataGridView1.CurrentRow.Cells(41).Value & "',"
            Sql = Sql & "[if employed]= " & "'" & DataGridView1.CurrentRow.Cells(42).Value & "',"
            Sql = Sql & "[other employment]= " & "'" & DataGridView1.CurrentRow.Cells(43).Value & "',"
            Sql = Sql & "[education]= " & "'" & DataGridView1.CurrentRow.Cells(44).Value & "',"
            Sql = Sql & "[other education]= " & "'" & DataGridView1.CurrentRow.Cells(45).Value & "',"
            Sql = Sql & "[datee]= " & "#" & DataGridView1.CurrentRow.Cells(46).Value & "#,"
            Sql = Sql & "[name of introducer]= " & "'" & DataGridView1.CurrentRow.Cells(47).Value & "',"
            Sql = Sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(48).Value & "',"
            Sql = Sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(49).Value & "',"
            Sql = Sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(50).Value & "',"
            Sql = Sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(51).Value & "'"
            Sql = Sql & " where [account id]=" & "" & DataGridView1.CurrentRow.Cells(1).Value & ""

            updaterecord(Sql)

            'updates the record of minor
        ElseIf chkminor.Checked = True Then
            Sql = "update [minor] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(2).Value & ","
            Sql = Sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(3).Value & "',"
            Sql = Sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            Sql = Sql & "[first name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            Sql = Sql & "[middle name]= " & "'" & DataGridView1.CurrentRow.Cells(6).Value & "',"
            Sql = Sql & "[last name]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            Sql = Sql & "[gender]= " & "'" & DataGridView1.CurrentRow.Cells(8).Value & "',"
            Sql = Sql & "[DOB BS]= " & "#" & DataGridView1.CurrentRow.Cells(9).Value & "#,"
            Sql = Sql & "[DOB AD]= " & "#" & DataGridView1.CurrentRow.Cells(10).Value & "#,"
            Sql = Sql & "[nationality]= " & "'" & DataGridView1.CurrentRow.Cells(11).Value & "',"
            Sql = Sql & "[citizenship/passport no]= " & "" & DataGridView1.CurrentRow.Cells(12).Value & ","
            Sql = Sql & "[place of issue]= " & "'" & DataGridView1.CurrentRow.Cells(13).Value & "',"
            Sql = Sql & "[exp date]= " & "#" & DataGridView1.CurrentRow.Cells(14).Value & "#,"
            Sql = Sql & "[others]= " & "'" & DataGridView1.CurrentRow.Cells(15).Value & "',"
            Sql = Sql & "[plc of issue]= " & "'" & DataGridView1.CurrentRow.Cells(16).Value & "',"
            Sql = Sql & "[ex date]= " & "#" & DataGridView1.CurrentRow.Cells(17).Value & "#,"
            Sql = Sql & "[municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(18).Value & "',"
            Sql = Sql & "[district]= " & "'" & DataGridView1.CurrentRow.Cells(19).Value & "',"
            Sql = Sql & "[country]= " & "'" & DataGridView1.CurrentRow.Cells(20).Value & "',"
            Sql = Sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(21).Value & ","
            Sql = Sql & "[mobile no]= " & "" & DataGridView1.CurrentRow.Cells(22).Value & ","
            Sql = Sql & "[email]= " & "'" & DataGridView1.CurrentRow.Cells(23).Value & "',"
            Sql = Sql & "[R municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(24).Value & "',"
            Sql = Sql & "[R district]= " & "'" & DataGridView1.CurrentRow.Cells(25).Value & "',"
            Sql = Sql & "[R country]= " & "'" & DataGridView1.CurrentRow.Cells(26).Value & "',"
            Sql = Sql & "[R phone no]= " & "" & DataGridView1.CurrentRow.Cells(27).Value & ","
            Sql = Sql & "[R mobile no]= " & "" & DataGridView1.CurrentRow.Cells(28).Value & ","
            Sql = Sql & "[R email]= " & "'" & DataGridView1.CurrentRow.Cells(29).Value & "',"
            Sql = Sql & "[guardian's name]= " & "'" & DataGridView1.CurrentRow.Cells(30).Value & "',"
            Sql = Sql & "[guardian's relation]= " & "'" & DataGridView1.CurrentRow.Cells(31).Value & "',"
            Sql = Sql & "[other relation]= " & "'" & DataGridView1.CurrentRow.Cells(32).Value & "',"
            Sql = Sql & "[guardians address]= " & "'" & DataGridView1.CurrentRow.Cells(33).Value & "',"
            Sql = Sql & "[proof of minor]= " & "'" & DataGridView1.CurrentRow.Cells(34).Value & "',"
            Sql = Sql & "[Nrs]= " & "'" & DataGridView1.CurrentRow.Cells(35).Value & "',"
            Sql = Sql & "[foreign currency]= " & "'" & DataGridView1.CurrentRow.Cells(36).Value & "',"
            Sql = Sql & "[amount]= " & "" & DataGridView1.CurrentRow.Cells(37).Value & ","
            Sql = Sql & "[father name]= " & "'" & DataGridView1.CurrentRow.Cells(38).Value & "',"
            Sql = Sql & "[grandfathers name]= " & "'" & DataGridView1.CurrentRow.Cells(39).Value & "',"
            Sql = Sql & "[religion]= " & "'" & DataGridView1.CurrentRow.Cells(40).Value & "',"
            Sql = Sql & "[other religion]= " & "'" & DataGridView1.CurrentRow.Cells(41).Value & "',"
            Sql = Sql & "[occupation type]= " & "'" & DataGridView1.CurrentRow.Cells(42).Value & "',"
            Sql = Sql & "[other occupation]= " & "'" & DataGridView1.CurrentRow.Cells(43).Value & "',"
            Sql = Sql & "[if employed]= " & "'" & DataGridView1.CurrentRow.Cells(44).Value & "',"
            Sql = Sql & "[other employment]= " & "'" & DataGridView1.CurrentRow.Cells(45).Value & "',"
            Sql = Sql & "[education]= " & "'" & DataGridView1.CurrentRow.Cells(46).Value & "',"
            Sql = Sql & "[other education]= " & "'" & DataGridView1.CurrentRow.Cells(47).Value & "',"
            Sql = Sql & "[datee]= " & "#" & DataGridView1.CurrentRow.Cells(48).Value & "#,"
            Sql = Sql & "[name of introducer]= " & "'" & DataGridView1.CurrentRow.Cells(49).Value & "',"
            Sql = Sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(50).Value & "',"
            Sql = Sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(51).Value & "',"
            Sql = Sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(52).Value & "',"
            Sql = Sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(53).Value & "'"
            Sql = Sql & " where [account id]=" & DataGridView1.CurrentRow.Cells(1).Value & ""

            updaterecord(Sql)

            'updates the record of jointaccount
        ElseIf chkjoint.Checked = True Then
            Sql = "update [jointaccount] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(3).Value & ","
            Sql = Sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            Sql = Sql & "[first name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            Sql = Sql & "[middle name]= " & "'" & DataGridView1.CurrentRow.Cells(6).Value & "',"
            Sql = Sql & "[last name]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            Sql = Sql & "[gender]= " & "'" & DataGridView1.CurrentRow.Cells(8).Value & "',"
            Sql = Sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(9).Value & "',"
            Sql = Sql & "[DOB BS]= " & "#" & DataGridView1.CurrentRow.Cells(10).Value & "#,"
            Sql = Sql & "[DOB AD]= " & "#" & DataGridView1.CurrentRow.Cells(11).Value & "#,"
            Sql = Sql & "[2first name]= " & "'" & DataGridView1.CurrentRow.Cells(12).Value & "',"
            Sql = Sql & "[2middle name]= " & "'" & DataGridView1.CurrentRow.Cells(13).Value & "',"
            Sql = Sql & "[2last name]= " & "'" & DataGridView1.CurrentRow.Cells(14).Value & "',"
            Sql = Sql & "[2gender]= " & "'" & DataGridView1.CurrentRow.Cells(15).Value & "',"
            Sql = Sql & "[2photo]= " & "'" & DataGridView1.CurrentRow.Cells(16).Value & "',"
            Sql = Sql & "[2DOB BS]= " & "#" & DataGridView1.CurrentRow.Cells(17).Value & "#,"
            Sql = Sql & "[2DOB AD]= " & "#" & DataGridView1.CurrentRow.Cells(18).Value & "#,"
            Sql = Sql & "[fathers/husbands name]= " & "'" & DataGridView1.CurrentRow.Cells(19).Value & "',"
            Sql = Sql & "[grandfathers name]= " & "'" & DataGridView1.CurrentRow.Cells(20).Value & "',"
            Sql = Sql & "[2fathers/husbands name]= " & "'" & DataGridView1.CurrentRow.Cells(21).Value & "',"
            Sql = Sql & "[2grandfathers name]= " & "'" & DataGridView1.CurrentRow.Cells(22).Value & "',"
            Sql = Sql & "[municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(23).Value & "',"
            Sql = Sql & "[district]= " & "'" & DataGridView1.CurrentRow.Cells(24).Value & "',"
            Sql = Sql & "[country]= " & "'" & DataGridView1.CurrentRow.Cells(25).Value & "',"
            Sql = Sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(26).Value & ","
            Sql = Sql & "[mobile no]= " & "" & DataGridView1.CurrentRow.Cells(27).Value & ","
            Sql = Sql & "[email]= " & "'" & DataGridView1.CurrentRow.Cells(28).Value & "',"
            Sql = Sql & "[R municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(29).Value & "',"
            Sql = Sql & "[R district]= " & "'" & DataGridView1.CurrentRow.Cells(30).Value & "',"
            Sql = Sql & "[R country]= " & "'" & DataGridView1.CurrentRow.Cells(31).Value & "',"
            Sql = Sql & "[R phone no]= " & "" & DataGridView1.CurrentRow.Cells(32).Value & ","
            Sql = Sql & "[R mobile no]= " & "" & DataGridView1.CurrentRow.Cells(33).Value & ","
            Sql = Sql & "[R email]= " & "'" & DataGridView1.CurrentRow.Cells(34).Value & "',"
            Sql = Sql & "[2municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(35).Value & "',"
            Sql = Sql & "[2district]= " & "'" & DataGridView1.CurrentRow.Cells(36).Value & "',"
            Sql = Sql & "[2country]= " & "'" & DataGridView1.CurrentRow.Cells(37).Value & "',"
            Sql = Sql & "[2phone no]= " & "" & DataGridView1.CurrentRow.Cells(38).Value & ","
            Sql = Sql & "[2mobile no]= " & "" & DataGridView1.CurrentRow.Cells(39).Value & ","
            Sql = Sql & "[2email]= " & "'" & DataGridView1.CurrentRow.Cells(40).Value & "',"
            Sql = Sql & "[2R municipality /vdc]= " & "'" & DataGridView1.CurrentRow.Cells(41).Value & "',"
            Sql = Sql & "[2R district]= " & "'" & DataGridView1.CurrentRow.Cells(42).Value & "',"
            Sql = Sql & "[2R country]= " & "'" & DataGridView1.CurrentRow.Cells(43).Value & "',"
            Sql = Sql & "[2R phone no]= " & "" & DataGridView1.CurrentRow.Cells(44).Value & ","
            Sql = Sql & "[2R mobile no]= " & "" & DataGridView1.CurrentRow.Cells(45).Value & ","
            Sql = Sql & "[2R email]= " & "'" & DataGridView1.CurrentRow.Cells(46).Value & "',"
            Sql = Sql & "[nationality]= " & "'" & DataGridView1.CurrentRow.Cells(47).Value & "',"
            Sql = Sql & "[citizenship/passport no]= " & "" & DataGridView1.CurrentRow.Cells(48).Value & ","
            Sql = Sql & "[place of issue]= " & "'" & DataGridView1.CurrentRow.Cells(49).Value & "',"
            Sql = Sql & "[exp date]= " & "#" & DataGridView1.CurrentRow.Cells(50).Value & "#,"
            Sql = Sql & "[others]= " & "'" & DataGridView1.CurrentRow.Cells(51).Value & "',"
            Sql = Sql & "[plc of issue]= " & "'" & DataGridView1.CurrentRow.Cells(52).Value & "',"
            Sql = Sql & "[ex date]= " & "#" & DataGridView1.CurrentRow.Cells(53).Value & "#,"
            Sql = Sql & "[2nationality]= " & "'" & DataGridView1.CurrentRow.Cells(54).Value & "',"
            Sql = Sql & "[2citizenship/passport no]= " & "" & DataGridView1.CurrentRow.Cells(55).Value & ","
            Sql = Sql & "[2place of issue]= " & "'" & DataGridView1.CurrentRow.Cells(56).Value & "',"
            Sql = Sql & "[2exp date]= " & "#" & DataGridView1.CurrentRow.Cells(57).Value & "#,"
            Sql = Sql & "[2others]= " & "'" & DataGridView1.CurrentRow.Cells(58).Value & "',"
            Sql = Sql & "[2plc of issue]= " & "'" & DataGridView1.CurrentRow.Cells(59).Value & "',"
            Sql = Sql & "[2ex date]= " & "#" & DataGridView1.CurrentRow.Cells(60).Value & "#,"
            Sql = Sql & "[Nrs]= " & "'" & DataGridView1.CurrentRow.Cells(61).Value & "',"
            Sql = Sql & "[foreign others]= " & "'" & DataGridView1.CurrentRow.Cells(62).Value & "',"
            Sql = Sql & "[amount]= " & "" & DataGridView1.CurrentRow.Cells(63).Value & ","
            Sql = Sql & "[datee]= " & "#" & DataGridView1.CurrentRow.Cells(64).Value & "#,"
            Sql = Sql & "[name of introducer]= " & "'" & DataGridView1.CurrentRow.Cells(65).Value & "',"
            Sql = Sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(66).Value & "',"
            Sql = Sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(67).Value & "',"
            Sql = Sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(68).Value & "',"
            Sql = Sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(69).Value & "'"
            Sql = Sql & " where [account id]=" & DataGridView1.CurrentRow.Cells(1).Value & ""

            updaterecord(Sql)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If chksaving.Checked = False And chkfixed.Checked = False And chkminor.Checked = False And chkjoint.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        'updates the records of deposit money
        Sql = "update [deposit money] set [account id]=" & "" & DataGridView3.CurrentRow.Cells(1).Value & ","
        Sql = Sql & "[branch office]=" & "'" & DataGridView3.CurrentRow.Cells(2).Value & "',"
        Sql = Sql & "[Date]=" & "#" & DataGridView3.CurrentRow.Cells(3).Value & "#,"
        Sql = Sql & "[first name]=" & "'" & DataGridView3.CurrentRow.Cells(4).Value & "',"
        Sql = Sql & "[middle name]=" & "'" & DataGridView3.CurrentRow.Cells(5).Value & "',"
        Sql = Sql & "[last name]=" & "'" & DataGridView3.CurrentRow.Cells(6).Value & "',"
        Sql = Sql & "[account type]=" & "'" & DataGridView3.CurrentRow.Cells(7).Value & "',"
        Sql = Sql & "[amount]=" & "" & DataGridView3.CurrentRow.Cells(8).Value & ","
        Sql = Sql & "[amount in words]=" & "'" & DataGridView3.CurrentRow.Cells(9).Value & "',"
        Sql = Sql & "[depositor]=" & "'" & DataGridView3.CurrentRow.Cells(10).Value & "',"
        Sql = Sql & "[receiver]=" & "'" & DataGridView3.CurrentRow.Cells(11).Value & "',"
        Sql = Sql & "[authorized by]=" & "'" & DataGridView3.CurrentRow.Cells(12).Value & "'"
        Sql = Sql & " where [receipt no]=" & DataGridView3.CurrentRow.Cells(0).Value & " and [account type]=" & "'" & DataGridView3.CurrentRow.Cells(7).Value & "'"

        updaterecord(Sql)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If chksaving.Checked = False And chkfixed.Checked = False And chkminor.Checked = False And chkjoint.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        'updates the records of withdraw money
        Sql = "update [withdraw money] set [account type]=" & "'" & DataGridView2.CurrentRow.Cells(1).Value & "',"
        Sql = Sql & "[Date]=" & "#" & DataGridView2.CurrentRow.Cells(2).Value & "#,"
        Sql = Sql & "[account id]=" & "" & DataGridView2.CurrentRow.Cells(3).Value & ","
        Sql = Sql & "[branch office]=" & "'" & DataGridView2.CurrentRow.Cells(4).Value & "',"
        Sql = Sql & "[first name]=" & "'" & DataGridView3.CurrentRow.Cells(5).Value & "',"
        Sql = Sql & "[middle name]=" & "'" & DataGridView3.CurrentRow.Cells(6).Value & "',"
        Sql = Sql & "[last name]=" & "'" & DataGridView3.CurrentRow.Cells(7).Value & "',"
        Sql = Sql & "[withdrawal to]=" & "'" & DataGridView2.CurrentRow.Cells(8).Value & "',"
        Sql = Sql & "[name:]=" & "'" & DataGridView2.CurrentRow.Cells(9).Value & "',"
        Sql = Sql & "[amount in words]=" & "'" & DataGridView2.CurrentRow.Cells(10).Value & "',"
        Sql = Sql & "[amount]=" & "" & DataGridView2.CurrentRow.Cells(11).Value & ","
        Sql = Sql & "[account holder]=" & "'" & DataGridView2.CurrentRow.Cells(12).Value & "',"
        Sql = Sql & "[verified by]=" & "'" & DataGridView2.CurrentRow.Cells(13).Value & "'"
        Sql = Sql & " where [receipt no]=" & DataGridView2.CurrentRow.Cells(0).Value & " and [account type]=" & "'" & DataGridView2.CurrentRow.Cells(1).Value & "'"

        updaterecord(Sql)
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        'closes the current form
        Me.Close()
        'shows the welcome form
        welcome.Show()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        welcome.Show()
    End Sub
End Class