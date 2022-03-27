Imports System.IO
Public Class loan

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        'closes the current form
        Me.Close()
        'shows the welcome form
        welcome.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'closes the loan form and go to welcome form
        Me.Close()
        welcome.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'moves the text"Finance Management System" of buttom of form right to left can be used as decoration
        lblevent.Left = lblevent.Left - 6
        If lblevent.Left < -lblevent.Width Then
            lblevent.Left = lblevent.Width
        End If
    End Sub

    Private Sub loan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starts the timer
        Timer1.Start()
        'automatically adds the account id and customer id in tabpage "home loan"
        Dim sql As String
        sql = "select [account id] from [home loan]"
        txthaccid.Text = id(sql)
        sql = "select [customer id] from [home loan]"
        txthcusid.Text = id(sql)

        'automatically adds the account id and customer id in tabpage "business loan"
        sql = "select [account id] from [business loan]"
        txtbaccid.Text = id(sql)
        sql = "select [customer id] from [business loan]"
        txtbcusid.Text = id(sql)

        'automatically adds the account id and customer id in tabpage "education loan"
        sql = "select [account id] from [education loan]"
        txteaccid.Text = id(sql)
        sql = "select [customer id] from [education loan]"
        txtecusid.Text = id(sql)
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
        loandetails.Close()
        loanstatement.Close()
        payloan.Close()
        New_User.Close()
        Form1.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the loan form
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
        'opens the loan details form
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
        'opens the withdraw money form
        withdrawmoney.Show()
    End Sub

    Private Sub PayLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayLoanToolStripMenuItem.Click
        'opens the payloan form
        payloan.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhcreate.Click
        If chkhy.Checked = True Then
            txthreject.Text = "--"
        End If
        If chkhy.Checked = True And chkhtrms.Checked = True And IsNumeric(txthbrnchno.Text) = True And IsNumeric(txthcitizenship.Text) = True And IsNumeric(txthphoneno.Text) = True And IsNumeric(txthfax.Text) = True And IsNumeric(txthrphoneno.Text) = True And IsNumeric(txthrfax.Text) = True Then
            'creates new home loan account if terms and conditions are accepted and customer details are correct
            Dim sql As String
            sql = "Insert into [home loan] values ('" & txthcusid.Text & "','"
            sql = sql & txthaccid.Text & "','"
            sql = sql & txthbrnchno.Text & "','"
            sql = sql & txtbrncho.Text & "','"
            sql = sql & photo.ImageLocation & "','"
            sql = sql & txthname.Text & "','"
            sql = sql & nudhservicecom.Value & "','"
            sql = sql & txthfhname.Text & "','"
            sql = sql & txthdesignation.Text & "','"
            sql = sql & txthcitizenship.Text & "','"
            sql = sql & txthorganization.Text & "','"
            sql = sql & txthaddress.Text & "','"
            sql = sql & txthphoneno.Text & "','"
            sql = sql & txthfax.Text & "','"
            sql = sql & txthresidence.Text & "','"
            sql = sql & txthrphoneno.Text & "','"
            sql = sql & txthrfax.Text & "','"
            sql = sql & nudhdependents.Value & "','"
            sql = sql & nudhchildrens.Value & "','"
            sql = sql & nudhothers.Value & "','"
            sql = sql & nudhloana.Value & "','"
            sql = sql & txthmargin.Value & "','"
            sql = sql & nudhrate.Value & "','"
            sql = sql & nudhrepayment.Value & "','"
            sql = sql & nudhmoratorium.Value & "','"
            sql = sql & nudhsecurity.Value & "','"
            sql = sql & nudhrecommended.Value & "','"
            sql = sql & nudhsactioned.Value & "','"
            sql = sql & txthofficer.Text & "','"
            sql = sql & DateTimePicker11.Value & "','"
            sql = sql & txtbrnchmanager.Text & "','"
            sql = sql & txthreject.Text & "','"
            sql = sql & txtprepared.Text & "','"
            sql = sql & txtverified.Text & "','"
            sql = sql & txtauthorized.Text & "')"

            adddata(sql)
            Me.Close()
        ElseIf chkhtrms.Checked = False Then
            'displays error message
            MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf chkhy.Checked = False Then
            'displays error message
            MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf IsNumeric(txthbrnchno.Text) = False Or IsNumeric(txthcitizenship.Text) = False Or IsNumeric(txthphoneno.Text) = False Or IsNumeric(txthfax.Text) = False Or IsNumeric(txthrphoneno.Text) = False Or IsNumeric(txthrfax.Text) = False Then
            'displays error message
            MsgBox("Branch code number,Phone number,fax and citizenship number should be numbers", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        End If
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photo.Click
        'opens a dialog box to input a picture
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"

    End Sub

    Private Sub open_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles open.FileOk
        Dim direct As String
        direct = CurDir() & "\" & "Resources"
        If Directory.Exists(direct) = True Then
            'copy the file if directory exists
            FileCopy(open.FileName, direct & "\" & open.SafeFileName)
        Else
            'makes a directry named "resources if it does not exists
            Directory.CreateDirectory(direct)
            'copy the file to resources
            FileCopy(open.FileName, direct & "\" & open.SafeFileName)
        End If
        'set imagelocation to the resourses with the image name.
        photo.ImageLocation = direct & "\" & open.SafeFileName
    End Sub

    Private Sub chkhomeloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhomeloan.CheckedChanged
        'selects homeloan tabpage and unckeck chkbusiness and chkeducationloan
        If chkhomeloan.Checked = True Then
            tabloan.SelectTab(0)
            chkbusinessloan.Checked = False
            chkeducationloan.Checked = False
        End If
    End Sub

    Private Sub chkbusinessloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbusinessloan.CheckedChanged
        'selects businessloan tabpage and unckeck chkhomeloan and chkeducationloan
        If chkbusinessloan.Checked = True Then
            tabloan.SelectTab(1)
            chkhomeloan.Checked = False
            chkeducationloan.Checked = False
        End If
    End Sub

    Private Sub chkeducationloan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeducationloan.CheckedChanged
        'selects educationloan tabpage and unckeck chkhomeloan and chkbusinessloan
        If chkeducationloan.Checked = True Then
            tabloan.SelectTab(2)
            chkhomeloan.Checked = False
            chkbusinessloan.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbcreateacc.Click
        If chkby.Checked = True Then
            'sets txtreject value "--"
            txtbreject.Text = "--"
        End If

        If chkbtrms.Checked = True And chkby.Checked = True And IsNumeric(txtbbrnchno.Text) = True And IsNumeric(txtbphoneno.Text) = True And IsNumeric(txtbfax.Text) = True Then
            'creates new business loan account if terms and conditions are accepted and customer details are correct
            Dim sql1 As String
            sql1 = "Insert into [business loan] values ('" & txtbcusid.Text & "','"
            sql1 = sql1 & txtbaccid.Text & "','"
            sql1 = sql1 & txtbbrnchno.Text & "','"
            sql1 = sql1 & txtbbrncho.Text & "','"
            sql1 = sql1 & photo.ImageLocation & "','"
            sql1 = sql1 & txtbname.Text & "','"
            sql1 = sql1 & DateTimePicker2.Value & "','"
            sql1 = sql1 & txtbbusiness.Text & "','"
            sql1 = sql1 & txtbaddress.Text & "','"
            sql1 = sql1 & txtbregisteredo.Text & "','"
            sql1 = sql1 & nudbregistration.Value & "','"
            sql1 = sql1 & txtbphoneno.Text & "','"
            sql1 = sql1 & txtbfax.Text & "','"
            sql1 = sql1 & txtbgname.Text & "','"
            sql1 = sql1 & txtbgnames.Text & "','"
            sql1 = sql1 & nudbloan.Value & "','"
            sql1 = sql1 & nudbmargin.Value & "','"
            sql1 = sql1 & nudbrate.Value & "','"
            sql1 = sql1 & nudbrepayment.Value & "','"
            sql1 = sql1 & nudbmoratorium.Value & "','"
            sql1 = sql1 & nudbsecurity.Value & "','"
            sql1 = sql1 & nudbrecommended.Value & "','"
            sql1 = sql1 & nudbsanctioned.Value & "','"
            sql1 = sql1 & txtbofficer.Text & "','"
            sql1 = sql1 & DateTimePicker3.Value & "','"
            sql1 = sql1 & txtbbrnchmanager.Text & "','"
            sql1 = sql1 & txtbreject.Text & "','"
            sql1 = sql1 & txtbprepared.Text & "','"
            sql1 = sql1 & txtbverified.Text & "','"
            sql1 = sql1 & txtbauthorized.Text & "')"

            adddata(sql1)
            Me.Close()
        ElseIf chkbtrms.Checked = False Then
            'displays error message
            MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf chkby.Checked = False Then
            'displays error message
            MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf IsNumeric(txtbbrncho.Text) = False Or IsNumeric(txtbphoneno.Text) = False Or IsNumeric(txtbfax.Text) = False Then
            'displays error message
            MsgBox("Branch code number,Phone no and fax should be numbers", MsgBoxStyle.Exclamation, "ERROR")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnecreate.Click
        If cmbeducation.Text <> "Others" Then
            'sets txtedu value "--"
            txtsedu.Text = "--"
        End If
        If chkey.Checked = True Then
            txtereject.Text = "--"
        End If
        If chkey.Checked = True And chketrms.Checked = True And IsNumeric(txtebrnchno.Text) = True And IsNumeric(txtephoneno.Text) = True And IsNumeric(txtecitizenship.Text) = True And IsNumeric(txteemail.Text) = True Then
            'creates new education loan account if terms and conditions are accepted and customer details are correct
            Dim sql1 As String
            sql1 = "Insert into [education loan] values ('" & txtecusid.Text & "','"
            sql1 = sql1 & txteaccid.Text & "','"
            sql1 = sql1 & txtebrnchno.Text & "','"
            sql1 = sql1 & txtebrncho.Text & "','"
            sql1 = sql1 & photo.ImageLocation & "','"
            sql1 = sql1 & txtname.Text & "','"
            sql1 = sql1 & txtefhname.Text & "','"
            sql1 = sql1 & txteaddress.Text & "','"
            sql1 = sql1 & txtephoneno.Text & "','"
            sql1 = sql1 & txtecitizenship.Text & "','"
            sql1 = sql1 & txteemail.Text & "','"
            sql1 = sql1 & cmbeducation.Text & "','"
            sql1 = sql1 & txtsedu.Text & "','"
            sql1 = sql1 & nudeloan.Value & "','"
            sql1 = sql1 & nudemargin.Value & "','"
            sql1 = sql1 & nuderate.Value & "','"
            sql1 = sql1 & nuderepayment.Value & "','"
            sql1 = sql1 & nudemoratorium.Value & "','"
            sql1 = sql1 & nudesecurity.Value & "','"
            sql1 = sql1 & nuderecommended.Value & "','"
            sql1 = sql1 & nudesanctioned.Value & "','"
            sql1 = sql1 & txteofficer.Text & "','"
            sql1 = sql1 & DateTimePicker4.Value & "','"
            sql1 = sql1 & txtebrnchmanager.Text & "','"
            sql1 = sql1 & txtereject.Text & "','"
            sql1 = sql1 & txteprepared.Text & "','"
            sql1 = sql1 & txteverified.Text & "','"
            sql1 = sql1 & txteauthorized.Text & "')"

            adddata(sql1)
            Me.Close()
        ElseIf chketrms.Checked = False Then
            'displays error message
            MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf chkey.Checked = False Then
            'displays error message
            MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
        ElseIf IsNumeric(txtebrnchno.Text) = False Or IsNumeric(txtephoneno.Text) = False Or IsNumeric(txtecitizenship.Text) = False Or IsNumeric(txteemail.Text) = False Then
            'displays error message
            MsgBox("Branch code number,Phone number,fax and citizenship number should be numbers", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub chkn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbn.CheckedChanged
        'if the chkn (account details not verified) then disables chky hides chky reject details
        If chkbn.Checked = True Then
            chkby.Checked = False
            Label74.Visible = True
            txtbreject.Visible = True
        Else
            Label74.Visible = False
            txtbreject.Visible = False

        End If
    End Sub

    Private Sub chky_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkby.CheckedChanged
        If chkby.Checked = True Then
            'uncheck chkbn if chky is checked
            chkbn.Checked = False
        End If
    End Sub

    Private Sub CheckBox72_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhy.CheckedChanged
        If chkhy.Checked = True Then
            'uncheck chkhn if chkhy is checked
            chkhn.Checked = False
        End If
    End Sub

    Private Sub CheckBox73_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhn.CheckedChanged
        If chkhn.Checked = True Then
            'uncheck chkhy and show label164 and txthreject
            chkhy.Checked = False
            Label164.Visible = True
            txthreject.Visible = True
        Else
            'hides label164 and txthreject if chkhn is unchecked
            Label164.Visible = False
            txthreject.Visible = False
        End If
    End Sub

    Private Sub cmbeducation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeducation.SelectedIndexChanged
        If cmbeducation.Text = "Others" Then
            'shows label156 and txtsedu
            Label156.Visible = True
            txtsedu.Visible = True
        Else
            'hides label156 and txtsedu
            Label156.Visible = False
            txtsedu.Visible = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkey.CheckedChanged
        If chkey.Checked = True Then
            'uncheck chken
            chken.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chken.CheckedChanged
        If chken.Checked = True Then
            'uncheck ey and shows label81 and txtereject
            chkey.Checked = False
            Label81.Visible = True
            txtereject.Visible = True
        Else
            'hides label81 and txtereject
            Label81.Visible = False
            txtereject.Visible = False
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'opens a dialog box to input a picture
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'opens a dialog box to input a picture
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub
End Class