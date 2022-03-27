Public Class loandetails
    Dim sql As String
    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        'shows the welcome form
        welcome.Show()
        'closes the current form
        Me.Close()
    End Sub

    Private Sub loandetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'hides lblgoback
        lblgoback.Hide()
        'stars timer1
        Timer1.Start()

    End Sub

    Private Sub back_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles back.MouseEnter
        'shows lblgoback
        lblgoback.Show()
    End Sub

    Private Sub back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles back.MouseLeave
        'hides lblgoback
        lblgoback.Hide()
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
        deposit.Close()
        usernamepasswordchange.Close()
        accountstatement.Close()
        loanwithdraw.Close()
        accountdetails.Close()
        createnewaccount.Close()
        withdrawmoney.Close()
        loan.Close()
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

    Private Sub AccDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDetailToolStripMenuItem.Click
        'opens the accountdetails form
        accountdetails.Show()
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
        'opens the  account details form
        accountdetails.Show()
    End Sub

    Private Sub StatementToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementToolStripMenuItem2.Click
        'opens the loanstatement form
        loanstatement.Show()
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

    Private Sub chkhomeloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhomeloan.CheckedChanged
        'checks whether homeloan is checked and other checkbox are unchecked
        If chkhomeloan.Checked = True Then
            chkbusinessloan.Checked = False
            chkeducationloan.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of home loan
            sql = "select * from [home loan]"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of pay loan with home loan
            sql = "select * from [pay loan] where [account type]='Home loan'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with home loan
            sql = "select * from [withdraw loan] where [account type]='Home loan'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkbusinessloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbusinessloan.CheckedChanged
        'checks whether homeloan is checked and other checkbox are unchecked
        If chkbusinessloan.Checked = True Then
            chkhomeloan.Checked = False
            chkeducationloan.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of business loan
            sql = "select * from [business loan]"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of pay loan with Business loan
            sql = "select * from [pay loan] where [account type]='Business loan'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with Business loan
            sql = "select * from [withdraw loan] where [account type]='Business loan'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkeducationloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeducationloan.CheckedChanged
        'checks whether homeloan is checked and other checkbox are unchecked
        If chkeducationloan.Checked = True Then
            chkhomeloan.Checked = False
            chkbusinessloan.Checked = False
            'hides the datagridview4
            DataGridView4.Visible = False
            'fills datagridview1 with the details of education loan
            sql = "select * from [education loan]"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of pay loan with Education loan
            sql = "select * from [pay loan] where [account type]='Education loan'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with Education loan
            sql = "select * from [withdraw loan] where [account type]='Education loan'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            'makes datagridview4 visible and clear out datagridview3 and datagridview2
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If chkhomeloan.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtname.Text = "" Then
                    'displays error message if txtname is empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from home loan with name of txtname and fill data to datagridview1
                    sql = "select * from [home loan] where [applicants name]='" & txtname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of home loan with name of txtname and fill data to datagridview3
                    sql = "select * from [pay loan] where [receiver]='" & txtname.Text & "' and [account type]='Home loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of home loan with name of txtname and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account holder]='" & txtname.Text & "' and [account type]='Home loan'"
                    DataGridView2.DataSource = loaddb(sql)
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
                    'select all data from home loan with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [home loan] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of home loan  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Home loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of home loan  with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Home loan'"
                    DataGridView2.DataSource = loaddb(sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If

        If chkbusinessloan.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtname.Text = "" Then
                    'displays error message if txtname is empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from business loan with name of txtname and fill data to datagridview1
                    sql = "select * from [business loan] where [applicants name]='" & txtname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of  business loan with name of txtname and fill data to datagridview3
                    sql = "select * from [pay loan] where [receiver]='" & txtname.Text & "' and [account type]='Business loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of business loan with name of txtname and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account holder]='" & txtname.Text & "' and [account type]='Business loan'"
                    DataGridView2.DataSource = loaddb(sql)
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
                    'select all data from business loan with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [business loan] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of business loan  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Business loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of business loan  with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Business loan'"
                    DataGridView2.DataSource = loaddb(sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If

        If chkeducationloan.Checked = True Then
            If rdbname.Checked = True Then
                'uncheck rdbaccid if rdbname is checked
                rdbaccid.Checked = False
                If txtname.Text = "" Then
                    'displays error message if txtname is empty
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtname.Text <> "" Then
                    'hides datagridview4
                    DataGridView4.Visible = False
                    'select all data from education loan with name of txtname and fill data to datagridview1
                    sql = "select * from [education loan] where [applicants name]='" & txtname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of education loan with name of txtname and fill data to datagridview3
                    sql = "select * from [pay loan] where [receiver]='" & txtname.Text & "' and [account type]='Education loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of education loan with name of txtname and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account holder]='" & txtname.Text & "' and [account type]='Education loan'"
                    DataGridView2.DataSource = loaddb(sql)
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
                    'select all data from education loan with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [education loan] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of education loan  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Education loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of education loan  with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Education loan'"
                    DataGridView2.DataSource = loaddb(sql)
                    'reset groupbox2 and groupbox1
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkhomeloan.Checked = False And chkbusinessloan.Checked = False And chkeducationloan.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf rdbaccid.Checked = False And rdbname.Checked = False Then
            'displays error message if none of the radiobutton are checked
            MsgBox("Please select search option for searching", MsgBoxStyle.Exclamation, "SELECTION REQUIRED")
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If chkhomeloan.Checked = False And chkbusinessloan.Checked = False And chkeducationloan.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If txtaccid.Text = "" Then
            MsgBox("Account id field cannot be empty", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        If chkhomeloan.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from home loan,pay loan with home loan and withdraw loan with home loan
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                sql = "delete * from [home loan] where [account id]=" & txtaccid.Text & ""
                delete(sql)
                sql = "delete * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Home loan'"
                delete(sql)
                sql = "delete * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Home loan'"
                delete(sql)
            End If
        End If

        If chkbusinessloan.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from business loan,pay loan with business loan and withdraw loan with business loan
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                sql = ("delete * from [business loan] where [account id]=" & txtaccid.Text & "")
                delete(sql)
                sql = "delete * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Business loan'"
                delete(sql)
                sql = "delete * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Business loan'"
                delete(sql)
            End If
        End If

        If chkeducationloan.Checked = True Then
            If IsNumeric(txtaccid.Text) = False Then
                MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            End If
            'ask for confrimation of deletion and delete record of the account id in txtaccid from education loan,pay loan with education loan and withdraw loan with education loan
            If MsgBox("Do you want to delete record with account id" & txtaccid.Text, MsgBoxStyle.YesNo, "VERIRY") = MsgBoxResult.Yes Then
                sql = ("delete * from [education loan] where [account id]=" & txtaccid.Text & "")
                delete(sql)
                sql = "delete * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Education loan'"
                delete(sql)
                sql = "delete * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Education loan'"
                delete(sql)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If chkhomeloan.Checked = True Then
            'updates the records in home loan
            sql = "update [home loan] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(2).Value & ","
            sql = sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(3).Value & "',"
            sql = sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            sql = sql & "[applicants name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            sql = sql & "[service completed]= " & "" & DataGridView1.CurrentRow.Cells(6).Value & ","
            sql = sql & "[fathers/husbands name]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            sql = sql & "[designation]= " & "'" & DataGridView1.CurrentRow.Cells(8).Value & "',"
            sql = sql & "[citizenship]= " & "" & DataGridView1.CurrentRow.Cells(9).Value & ","
            sql = sql & "[organization]= " & "'" & DataGridView1.CurrentRow.Cells(10).Value & "',"
            sql = sql & "[address]= " & "'" & DataGridView1.CurrentRow.Cells(11).Value & "',"
            sql = sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(12).Value & ","
            sql = sql & "[fax]= " & "" & DataGridView1.CurrentRow.Cells(13).Value & ","
            sql = sql & "[residence]= " & "'" & DataGridView1.CurrentRow.Cells(14).Value & "',"
            sql = sql & "[Rphone no]= " & "" & DataGridView1.CurrentRow.Cells(15).Value & ","
            sql = sql & "[Rfax]= " & "" & DataGridView1.CurrentRow.Cells(16).Value & ","
            sql = sql & "[dependents]= " & "" & DataGridView1.CurrentRow.Cells(17).Value & ","
            sql = sql & "[childrens]= " & "" & DataGridView1.CurrentRow.Cells(18).Value & ","
            sql = sql & "[others]= " & "" & DataGridView1.CurrentRow.Cells(19).Value & ","
            sql = sql & "[loan amount]= " & "" & DataGridView1.CurrentRow.Cells(20).Value & ","
            sql = sql & "[margin]= " & "" & DataGridView1.CurrentRow.Cells(21).Value & ","
            sql = sql & "[rate of interest]= " & "" & DataGridView1.CurrentRow.Cells(22).Value & ","
            sql = sql & "[repayment]= " & "" & DataGridView1.CurrentRow.Cells(23).Value & ","
            sql = sql & "[moratorium period]= " & "" & DataGridView1.CurrentRow.Cells(24).Value & ","
            sql = sql & "[security]= " & "" & DataGridView1.CurrentRow.Cells(25).Value & ","
            sql = sql & "[recommended loan]= " & "" & DataGridView1.CurrentRow.Cells(26).Value & ","
            sql = sql & "[sanctioned loan]= " & "" & DataGridView1.CurrentRow.Cells(27).Value & ","
            sql = sql & "[officer]= " & "'" & DataGridView1.CurrentRow.Cells(28).Value & "',"
            sql = sql & "[date:]= " & "#" & DataGridView1.CurrentRow.Cells(29).Value & "#,"
            sql = sql & "[branch manager]= " & "'" & DataGridView1.CurrentRow.Cells(30).Value & "',"
            sql = sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(31).Value & "',"
            sql = sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(32).Value & "',"
            sql = sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(33).Value & "',"
            sql = sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(34).Value & "'"
            sql = sql & " where [account id]=" & DataGridView1.CurrentRow.Cells(1).Value & ""


            updaterecord(sql)

        ElseIf chkbusinessloan.Checked = True Then
            'updates the records in business loan
            sql = "update [business loan] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(2).Value & ","
            sql = sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(3).Value & "',"
            sql = sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            sql = sql & "[applicants name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            sql = sql & "[dateofcommence]= " & "#" & DataGridView1.CurrentRow.Cells(6).Value & "#,"
            sql = sql & "[business]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            sql = sql & "[address]= " & "'" & DataGridView1.CurrentRow.Cells(8).Value & "',"
            sql = sql & "[office]= " & "'" & DataGridView1.CurrentRow.Cells(9).Value & "',"
            sql = sql & "[registrationno]= " & "" & DataGridView1.CurrentRow.Cells(10).Value & ","
            sql = sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(11).Value & ","
            sql = sql & "[fax]= " & "" & DataGridView1.CurrentRow.Cells(12).Value & ","
            sql = sql & "[gname1]= " & "'" & DataGridView1.CurrentRow.Cells(13).Value & "',"
            sql = sql & "[gname2]= " & "'" & DataGridView1.CurrentRow.Cells(14).Value & "',"
            sql = sql & "[loan amount]= " & "" & DataGridView1.CurrentRow.Cells(15).Value & ","
            sql = sql & "[margin]= " & "" & DataGridView1.CurrentRow.Cells(16).Value & ","
            sql = sql & "[rate of interest]= " & "" & DataGridView1.CurrentRow.Cells(17).Value & ","
            sql = sql & "[repayment]= " & "" & DataGridView1.CurrentRow.Cells(18).Value & ","
            sql = sql & "[moratorium period]= " & "" & DataGridView1.CurrentRow.Cells(19).Value & ","
            sql = sql & "[security]= " & "" & DataGridView1.CurrentRow.Cells(20).Value & ","
            sql = sql & "[recommended loan]= " & "" & DataGridView1.CurrentRow.Cells(21).Value & ","
            sql = sql & "[sanctioned loan]= " & "" & DataGridView1.CurrentRow.Cells(22).Value & ","
            sql = sql & "[officer]= " & "'" & DataGridView1.CurrentRow.Cells(23).Value & "',"
            sql = sql & "[date:]= " & "#" & DataGridView1.CurrentRow.Cells(24).Value & "#,"
            sql = sql & "[branch manager]= " & "'" & DataGridView1.CurrentRow.Cells(25).Value & "',"
            sql = sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(26).Value & "',"
            sql = sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(27).Value & "',"
            sql = sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(28).Value & "',"
            sql = sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(29).Value & "'"
            sql = sql & " where [account id]=" & DataGridView1.CurrentRow.Cells(1).Value & ""

            updaterecord(sql)


        ElseIf chkeducationloan.Checked = True Then
            'updates the records in education loan
            sql = "update [education loan] set [branch code no]= " & "" & DataGridView1.CurrentRow.Cells(2).Value & ","
            sql = sql & "[branch office]= " & "'" & DataGridView1.CurrentRow.Cells(3).Value & "',"
            sql = sql & "[photo]= " & "'" & DataGridView1.CurrentRow.Cells(4).Value & "',"
            sql = sql & "[applicants name]= " & "'" & DataGridView1.CurrentRow.Cells(5).Value & "',"
            sql = sql & "[fathers/husbands name]= " & "'" & DataGridView1.CurrentRow.Cells(6).Value & "',"
            sql = sql & "[address]= " & "'" & DataGridView1.CurrentRow.Cells(7).Value & "',"
            sql = sql & "[phone no]= " & "" & DataGridView1.CurrentRow.Cells(8).Value & ","
            sql = sql & "[citizenship]= " & "" & DataGridView1.CurrentRow.Cells(9).Value & ","
            sql = sql & "[email]= " & "'" & DataGridView1.CurrentRow.Cells(10).Value & "',"
            sql = sql & "[education]= " & "'" & DataGridView1.CurrentRow.Cells(11).Value & "',"
            sql = sql & "[other education]= " & "'" & DataGridView1.CurrentRow.Cells(12).Value & "',"
            sql = sql & "[loan amount]= " & "" & DataGridView1.CurrentRow.Cells(13).Value & ","
            sql = sql & "[margin]= " & "" & DataGridView1.CurrentRow.Cells(14).Value & ","
            sql = sql & "[rate of interest]= " & "" & DataGridView1.CurrentRow.Cells(15).Value & ","
            sql = sql & "[repayment]= " & "" & DataGridView1.CurrentRow.Cells(16).Value & ","
            sql = sql & "[moratorium period]= " & "" & DataGridView1.CurrentRow.Cells(17).Value & ","
            sql = sql & "[security]= " & "" & DataGridView1.CurrentRow.Cells(18).Value & ","
            sql = sql & "[recommended loan]= " & "" & DataGridView1.CurrentRow.Cells(19).Value & ","
            sql = sql & "[sanctioned loan]= " & "" & DataGridView1.CurrentRow.Cells(20).Value & ","
            sql = sql & "[officer]= " & "'" & DataGridView1.CurrentRow.Cells(21).Value & "',"
            sql = sql & "[date:]= " & "#" & DataGridView1.CurrentRow.Cells(22).Value & "#,"
            sql = sql & "[branch manager]= " & "'" & DataGridView1.CurrentRow.Cells(23).Value & "',"
            sql = sql & "[acc reject details]= " & "'" & DataGridView1.CurrentRow.Cells(24).Value & "',"
            sql = sql & "[prepared by]= " & "'" & DataGridView1.CurrentRow.Cells(25).Value & "',"
            sql = sql & "[verified by]= " & "'" & DataGridView1.CurrentRow.Cells(26).Value & "',"
            sql = sql & "[authorized by]= " & "'" & DataGridView1.CurrentRow.Cells(27).Value & "'"
            sql = sql & " where [account id]=" & DataGridView1.CurrentRow.Cells(1).Value & ""


            updaterecord(sql)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If chkhomeloan.Checked = False And chkbusinessloan.Checked = False And chkeducationloan.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        'updates the records in pay loan
        sql = "update [pay loan] set [account id]=" & "" & DataGridView3.CurrentRow.Cells(1).Value & ","
        sql = sql & "[branch office]=" & "'" & DataGridView3.CurrentRow.Cells(2).Value & "',"
        sql = sql & "[Date]=" & "#" & DataGridView3.CurrentRow.Cells(3).Value & "#,"
        sql = sql & "[name]=" & "'" & DataGridView3.CurrentRow.Cells(4).Value & "',"
        sql = sql & "[account type]=" & "'" & DataGridView3.CurrentRow.Cells(5).Value & "',"
        sql = sql & "[amount]=" & "" & DataGridView3.CurrentRow.Cells(6).Value & ","
        sql = sql & "[amount in words]=" & "'" & DataGridView3.CurrentRow.Cells(7).Value & "',"
        sql = sql & "[depositor]=" & "'" & DataGridView3.CurrentRow.Cells(8).Value & "',"
        sql = sql & "[receiver]=" & "'" & DataGridView3.CurrentRow.Cells(9).Value & "',"
        sql = sql & "[authorized by]=" & "'" & DataGridView3.CurrentRow.Cells(10).Value & "'"
        sql = sql & " where [receipt no]=" & DataGridView3.CurrentRow.Cells(0).Value & " and [account type]=" & "'" & DataGridView3.CurrentRow.Cells(5).Value & "'"

        updaterecord(sql)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If chkhomeloan.Checked = False And chkbusinessloan.Checked = False And chkeducationloan.Checked = False Then
            'displays error message if none of the accounttype checkbox are checked
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
        'updates the records in withdraw loan
        sql = "update [withdraw loan] set [account type]=" & "'" & DataGridView2.CurrentRow.Cells(1).Value & "',"
        sql = sql & "[Date]=" & "#" & DataGridView2.CurrentRow.Cells(2).Value & "#,"
        sql = sql & "[account id]=" & "" & DataGridView2.CurrentRow.Cells(3).Value & ","
        sql = sql & "[branch office]=" & "'" & DataGridView2.CurrentRow.Cells(4).Value & "',"
        sql = sql & "[name]=" & "'" & DataGridView2.CurrentRow.Cells(5).Value & "',"
        sql = sql & "[withdrawal to]=" & "'" & DataGridView2.CurrentRow.Cells(6).Value & "',"
        sql = sql & "[name:]=" & "'" & DataGridView2.CurrentRow.Cells(7).Value & "',"
        sql = sql & "[amount in words]=" & "'" & DataGridView2.CurrentRow.Cells(8).Value & "',"
        sql = sql & "[amount]=" & "" & DataGridView2.CurrentRow.Cells(9).Value & ","
        sql = sql & "[account holder]=" & "'" & DataGridView2.CurrentRow.Cells(10).Value & "',"
        sql = sql & "[verified by]=" & "'" & DataGridView2.CurrentRow.Cells(11).Value & "'"
        sql = sql & " where [receipt no]=" & DataGridView2.CurrentRow.Cells(0).Value & " and [account type]=" & "'" & DataGridView2.CurrentRow.Cells(1).Value & "'"

        updaterecord(sql)
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