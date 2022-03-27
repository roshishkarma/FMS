Public Class welcome
    Dim sql As String
    Dim datedifferent As Integer
    Dim dtrow As DataRow
    Dim id As Integer
    Private Sub welcome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("The program is terminating now", MsgBoxStyle.OkCancel, "closing") = MsgBoxResult.Ok Then
            'close whole program if messagebox result is "ok"
            about.Close()
        ElseIf MsgBoxResult.Cancel Then
            'does nothing if messagebox results "cancel" and stay as it is
            e.Cancel = True
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateaccount.Click
        'shows createnewaccount form
        createnewaccount.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccstatements.Click
        'shows accountstatement form
        accountstatement.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloanstatements.Click
        'shows loanstatement form
        loanstatement.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloan.Click
        'shows loan form
        loan.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloandetails.Click
        'shows loandetails form
        loandetails.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccdetails.Click
        'shows accountdetails form
        accountdetails.Show()
    End Sub
    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangeuser.Click
        'shows usernamepasswordchange form
        usernamepasswordchange.Show()
        'hides the current form
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeposit.Click
        'shows deposit form
        deposit.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwithdraw.Click
        'shows withdrawmoney form
        withdrawmoney.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloanwithdraw.Click
        'shows loanwithdraw form
        loanwithdraw.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayloan.Click
        'shows payloan form
        payloan.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateuser.Click
        'shows new user form
        New_User.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'codes for the log out
        login.Show()
        usernamepasswordchange.Close()
        Me.Hide()
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
        'hides the current form
        Me.Hide()
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

    Private Sub PayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayToolStripMenuItem.Click
        'opens the payloan form
        payloan.Show()
    End Sub

    Private Sub WithdrawMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawMoneyToolStripMenuItem.Click
        'opens the withdrawmoney form
        withdrawmoney.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        'shows backup dialog
        backup.ShowDialog()
        backup.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        backup.Filter = "databasefile (*.rsb)|*.rsb"
    End Sub

    Private Sub backup_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles backup.FileOk
        'copy banking.mdb to backup.filename and shows success message
        FileCopy("banking.mdb", backup.FileName)
        MsgBox("Back up created", MsgBoxStyle.Information, "SUCESS")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestore.Click
        'opens the restore dailog
        restore.ShowDialog()
        restore.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        restore.Filter = "backup file (*.rsb)|*.rsb"
    End Sub

    Private Sub restore_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles restore.FileOk
        'copy the restore.filename to banking.mdb in bin and shows success message
        FileCopy(restore.FileName, "banking.mdb")
        MsgBox("Restoration complete ", MsgBoxStyle.Information, "SUCESS")
    End Sub

    Private Sub welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select datee,amount,[account id] from savings"
        loaddb(sql)
        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + 0.045) ^ (1 / 12))
                sql = "update savings set [amount]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next

        sql = "select datee,amount,[account id] from [fixed deposit]"
        loaddb(sql)

        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + 0.14) ^ (1 / 12))
                sql = "update [fixed deposit] set [amount]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next

        sql = "select datee,amount,[account id] from [minor]"
        loaddb(sql)
        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + 0.045) ^ (1 / 12))
                sql = "update [minor] set [amount]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next

        sql = "select datee,amount,[account id] from [jointaccount]"
        loaddb(sql)
        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + 0.045) ^ (1 / 12))
                sql = "update [jointaccount] set [amount]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next

        sql = "select [date:],[recommended loan],[account id],[rate of interest] from [home loan]"
        loaddb(sql)
        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + (dtrow(3) / 100)) ^ (1 / 12))
                sql = "update [home loan] set [recommended loan]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next

        sql = "select [date:],[recommended loan],[account id],[rate of interest] from [business loan]"
        loaddb(sql)
        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + (dtrow(3) / 100)) ^ (1 / 12))
                sql = "update [business loan] set [recommended loan]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next

        sql = "select [date:],[recommended loan],[account id],[rate of interest] from [education loan]"
        loaddb(sql)
        For Each dtrow In datatable.Rows
            'assigns the value of id with the account id
            id = dtrow(2)
            'finds date difference and check if exactly divisible by 30,if divisible then adds interest
            datedifferent = DateDiff(DateInterval.Day, dtrow(0), Now.Date)
            If datedifferent Mod 30 = 0 Then
                dtrow(1) = dtrow(1) * ((1 + (dtrow(3) / 100)) ^ (1 / 12))
                sql = "update [education loan] set [recommended loan]=" & "" & dtrow(1) & "" & " where [account id]=" & id
                updaterecord(sql)
            End If
        Next
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub
End Class