Public Class accountstatement
    Dim sql As String
    Private Sub accountstatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
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
        accountdetails.Close()
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

    Private Sub chksaving_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksaving.CheckedChanged

        If chksaving.Checked = True Then
            chkfixed.Checked = False
            chkminor.Checked = False
            chkjoint.Checked = False
            DataGridView4.Visible = False
            'fills datagridview1 with the details of saving account
            sql = "select * from savings"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of deposit with saving account
            sql = "select * from [deposit money] where [account type]='Savings'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with saving account
            sql = "select * from [withdraw money] where [account type]='Savings'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If

    End Sub

    Private Sub chkfixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfixed.CheckedChanged
        If chkfixed.Checked = True Then
            chksaving.Checked = False
            chkminor.Checked = False
            chkjoint.Checked = False
            DataGridView4.Visible = False
            'fills datagridview1 with the details of fixed deposit account
            sql = "select * from [fixed deposit]"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of deposit with fixed deposit account
            sql = "select * from [deposit money] where [account type]='Fixed deposit'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with fixed deposit account
            sql = "select * from [withdraw money] where [account type]='Fixed deposit'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkminor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkminor.CheckedChanged
        If chkminor.Checked = True Then
            chkfixed.Checked = False
            chksaving.Checked = False
            chkjoint.Checked = False
            DataGridView4.Visible = False
            'fills datagridview1 with the details of minor account
            sql = "select * from [minor]"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of deposit with minor account
            sql = "select * from [deposit money] where [account type]='Minor'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with minor account
            sql = "select * from [withdraw money] where [account type]='Minor'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkjoint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkjoint.CheckedChanged
        If chkjoint.Checked = True Then
            chkfixed.Checked = False
            chksaving.Checked = False
            chkminor.Checked = False
            DataGridView4.Visible = False
            'fills datagridview1 with the details of joint account
            sql = "select * from [jointaccount]"
            DataGridView1.DataSource = loaddb(sql)
            'fills datagridview3 with the details of deposit with joint account
            sql = "select * from [deposit money] where [account type]='Joint account'"
            DataGridView3.DataSource = loaddb(sql)
            'fills datagridview2 with the details of withdrawal with joint account
            sql = "select * from [withdraw money] where [account type]='Joint account'"
            DataGridView2.DataSource = loaddb(sql)
        Else
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If chksaving.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from savings with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    sql = "select * from [savings] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of savings with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Savings'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of savings with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Savings'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from savings with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [savings] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of savings  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Savings'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of savings with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Savings'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkfixed.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from fixed deposit with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    sql = "select * from [fixed deposit] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of fixed deposit with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Fixed deposit'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of fixed deposit with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Fixed deposit'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from fixed deposit with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [fixed deposit] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of fixed deposit with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Fixed deposit'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of fixed deposit with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Fixed deposit'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkminor.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from minor with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    sql = "select * from [minor] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of minor with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Minor'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of minor with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Minor'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from minor with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [minor] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of minor with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Minor'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of minor with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Minor'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkjoint.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtfname.Text = "" And txtmname.Text = "" And txtlname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtfname.Text <> "" And txtmname.Text <> "" And txtlname.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from jointaccount with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview1
                    sql = "select * from [jointaccount] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "'"
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of jointaccount with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview3
                    sql = "select * from [deposit money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Joint account'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of jointaccount with firstname of txtfname,middlename of txtmname and lastname of txtlname and fill data to datagridview2
                    sql = "select * from [withdraw money] where [first name]='" & txtfname.Text & "' and [middle name]='" & txtmname.Text & "' and [last name]='" & txtlname.Text & "' and [account type]='Joint account'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox1)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)

            ElseIf rdbaccid.Checked = True Then
                rdbname.Checked = False
                If txtaccid.Text = "" Then
                    MsgBox("Cannot search with empty value in Account ID", MsgBoxStyle.Critical, "ERROR")
                ElseIf IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                ElseIf txtaccid.Text <> "" Then
                    DataGridView4.Visible = False
                    'select all data from jointaccount with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [jointaccount] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from deposit money of jointaccount with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [deposit money] where [account id]=" & txtaccid.Text & " and [account type]='Joint account'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw money of jointaccount with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw money] where [account id]=" & txtaccid.Text & " and [account type]='Joint account'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If
        If chksaving.Checked = False And chkfixed.Checked = False And chkminor.Checked = False And chkjoint.Checked = False Then
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf rdbaccid.Checked = False And rdbname.Checked = False Then
            MsgBox("Please select search option for searching", MsgBoxStyle.Exclamation, "SELECTION REQUIRED")
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        'closes the current form
        Me.Close()
        'shows the welcome form
        welcome.Show()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If chksaving.Checked = False And chkfixed.Checked = False And chkminor.Checked = False And chkjoint.Checked = False Then
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
        End If
        If chksaving.Checked = True Then
            'codes for viewing all data of saving account with deposit and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport2
                Dim dset As New DataSet1
                loaddb("Select * from [savings]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Savings'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Savings'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()

            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                'codes for viewing data of saving account with deposit and withdrawal with account id in txtaccidin crystal report
                Dim rpt As New CrystalReport2
                Dim dset As New DataSet1
                loaddb("Select * from [savings] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Savings' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Savings' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            End If

        ElseIf chkfixed.Checked = True Then
            'codes for viewing all data of fixed deposit account with deposit and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport2
                Dim dset As New DataSet1
                loaddb("Select * from [fixed deposit]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Fixed deposit'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Fixed deposit'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                'codes for viewing data of fixed deposit account with deposit and withdrawal with account id in txtaccid in crystal report
                Dim rpt As New CrystalReport2
                Dim dset As New DataSet1
                loaddb("Select * from [fixed deposit] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Fixed deposit' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Fixed deposit' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            End If

        ElseIf chkminor.Checked = True Then
            'codes for viewing all data of minor account with deposit and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport2
                Dim dset As New DataSet1
                loaddb("Select * from [minor]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Minor'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Minor'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                'codes for viewing data of minor account with deposit and withdrawal with account id in txtaccid in crystal report
                Dim rpt As New CrystalReport2
                Dim dset As New DataSet1
                loaddb("Select * from [minor] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Minor' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Minor' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            End If

        ElseIf chkjoint.Checked = True Then
            'codes for viewing all data of joint account with deposit and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport4
                Dim dset As New DataSet1
                loaddb("Select * from [jointaccount]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Joint account'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Joint account'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                'codes for viewing data of joint account with deposit and withdrawal with account id in txtaccid in crystal report
                Dim rpt As New CrystalReport4
                Dim dset As New DataSet1
                loaddb("Select * from [jointaccount] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [deposit money] where [account type]='Joint account' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw money] where [account type]='Joint account' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            End If
        End If

    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        welcome.Show()
    End Sub

    Private Sub lblevent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblevent.Click

    End Sub
End Class