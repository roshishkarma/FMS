Public Class loanstatement
    Dim sql As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'codes for the movement of the lblevent
        lblevent.Left = lblevent.Left - 6
        If lblevent.Left < -lblevent.Width Then
            lblevent.Left = lblevent.Width
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub loanstatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
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
        loandetails.Close()
        payloan.Close()
        New_User.Close()
        Form1.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
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
    Private Sub StatementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementToolStripMenuItem1.Click
        'opens the accountstatement form
        accountstatement.Show()
    End Sub

    Private Sub AccDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDetailToolStripMenuItem1.Click
        'opens the  account details form
        accountdetails.Show()
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

    Private Sub chkhomeloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhomeloan.CheckedChanged
        If chkhomeloan.Checked = True Then
            chkbusinessloan.Checked = False
            chkeducationloan.Checked = False
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
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkbusinessloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbusinessloan.CheckedChanged
        If chkbusinessloan.Checked = True Then
            chkhomeloan.Checked = False
            chkeducationloan.Checked = False
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
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub chkeducationloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeducationloan.CheckedChanged
        If chkeducationloan.Checked = True Then
            chkhomeloan.Checked = False
            chkbusinessloan.Checked = False
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
            DataGridView4.Visible = True
            DataGridView3.DataSource = ""
            DataGridView2.DataSource = ""
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If chkhomeloan.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtname.Text <> "" Then
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
                    'select all data from home loan with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [home loan] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of home loan  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Home loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of home loan  with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Home loan'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If

        If chkbusinessloan.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtname.Text <> "" Then
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
                    'select all data from business loan with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [business loan] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of business loan  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Business loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of business loan  with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Business loan'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If

        If chkeducationloan.Checked = True Then
            If rdbname.Checked = True Then
                rdbaccid.Checked = False
                If txtname.Text = "" Then
                    MsgBox("Cannot search with empty text in Name", MsgBoxStyle.Critical, "ERROR")
                ElseIf txtname.Text <> "" Then
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
                    'select all data from education loan with account id is the value in txtaccid and fill data to datagridview1
                    sql = "select * from [education loan] where [account id]=" & txtaccid.Text & ""
                    DataGridView1.DataSource = loaddb(sql)
                    'select all data from pay loan of education loan  with account id is the value in txtaccid and fill data to datagridview3
                    sql = "select * from [pay loan] where [account id]=" & txtaccid.Text & " and [account type]='Education loan'"
                    DataGridView3.DataSource = loaddb(sql)
                    'select all data from withdraw loan of education loan  with account id is the value in txtaccid and fill data to datagridview2
                    sql = "select * from [withdraw loan] where [account id]=" & txtaccid.Text & " and [account type]='Education loan'"
                    DataGridView2.DataSource = loaddb(sql)
                    txtboxreset(GroupBox2)
                End If
                txtboxreset(GroupBox2)
                txtboxreset(GroupBox1)
            End If
        End If


        If chkhomeloan.Checked = False And chkbusinessloan.Checked = False And chkeducationloan.Checked = False Then
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf rdbaccid.Checked = False And rdbname.Checked = False Then
            MsgBox("Please select search option for searching", MsgBoxStyle.Exclamation, "SELECTION REQUIRED")
        End If

    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        'closes the current form
        Me.Close()
        'shows the welcome form
        welcome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If chkhomeloan.Checked = False And chkbusinessloan.Checked = False And chkeducationloan.Checked = False Then
            MsgBox("None of the account type are selected", MsgBoxStyle.Exclamation, "ERROR")
        End If

        If chkhomeloan.Checked = True Then
            'codes for viewing all data of home loan account with paid amount and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport3
                Dim dset As New DataSet1
                loaddb("Select * from [home loan]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [pay loan] where [account type]='Home loan'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw loan] where [account type]='Home loan'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
                'codes for viewing data of home loan with paid amount and withdrawal with account id in txtaccid in crystal report
            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                Dim rpt As New CrystalReport3
                Dim dset As New DataSet1
                loaddb("Select * from [home loan] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [pay loan] where [account type]='Home loan' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw loan] where [account type]='Home loan' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            End If

        ElseIf chkbusinessloan.Checked = True Then
            'codes for viewing all data of business loan account with paid amount and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport3
                Dim dset As New DataSet1
                loaddb("Select * from [business loan]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [pay loan] where [account type]='Business loan'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw loan] where [account type]='Business loan'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
                'codes for viewing data of business loan with paid amount and withdrawal with account id in txtaccid in crystal report
            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                Dim rpt As New CrystalReport3
                Dim dset As New DataSet1
                loaddb("Select * from [business loan] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [pay loan] where [account type]='Business loan' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw loan] where [account type]='Business loan' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
            End If

        ElseIf chkeducationloan.Checked = True Then
            'codes for viewing all data of education loan account with paid amount and withdrawal in crystal report
            If txtaccid.Text = "" Then
                Dim rpt As New CrystalReport3
                Dim dset As New DataSet1
                loaddb("Select * from [education loan]")
                rpt.SetDataSource(datatable)
                loaddb("select * from [pay loan] where [account type]='Education loan'")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw loan] where [account type]='Education loan'")
                rpt.Subreports.Item(1).SetDataSource(datatable)
                'source for crystal report
                Form2.CrystalReportViewer1.ReportSource = rpt
                'refresh crystal report
                Form2.CrystalReportViewer1.Refresh()

                Form2.Show()
                'codes for viewing data of education loan with paid amount and withdrawal with account id in txtaccid in crystal report
            ElseIf txtaccid.Text <> "" Then
                If IsNumeric(txtaccid.Text) = False Then
                    MsgBox("Account id should be numeric", MsgBoxStyle.Exclamation, "ERROR")
                    Exit Sub
                End If
                Dim rpt As New CrystalReport3
                Dim dset As New DataSet1
                loaddb("Select * from [education loan] where [account id]=" & txtaccid.Text & "")
                rpt.SetDataSource(datatable)
                loaddb("select * from [pay loan] where [account type]='Education loan' and [account id]=" & txtaccid.Text & "")
                rpt.Subreports.Item(0).SetDataSource(datatable)
                loaddb("select * from [withdraw loan] where [account type]='Education loan' and [account id]=" & txtaccid.Text & "")
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
End Class