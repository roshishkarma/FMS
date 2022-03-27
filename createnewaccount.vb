Imports System.IO
Public Class createnewaccount

    Private Sub createnewaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        'sets account id and customer id automatically in all the form
        Dim sql As String
        sql = "select [account id] from savings"
        Label81.Text = id(sql)
        sql = "select [customer id] from savings"
        txtcusid.Text = id(sql)

        sql = "select [account id] from [fixed deposit]"
        txtfcusid.Text = id(sql)
        sql = "select [customer id] from [fixed deposit]"
        txtfaccid.Text = id(sql)

        sql = "select [account id] from [minor]"
        txtmcusid.Text = id(sql)
        sql = "select [customer id] from [minor]"
        txtmaccid.Text = id(sql)

        sql = "select [account id] from [jointaccount]"
        txtjaccid.Text = id(sql)
        sql = "select [customer id] from [jointaccount]"
        txtjcusid1.Text = id(sql)
        sql = "select [2customer id] from [jointaccount]"
        txtjcusid2.Text = id(sql)

    End Sub

    Private Sub chknormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksaving.CheckedChanged
        If chksaving.Checked = True Then
            'selects first tab page
            createaccount.SelectTab(0)
            chkfixed.Checked = False
            chkminor.Checked = False
            chkjoint.Checked = False
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        welcome.Show()
    End Sub

    Private Sub chkfixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfixed.CheckedChanged
        If chkfixed.Checked = True Then
            btncancel.Visible = True
            'selects second tab page
            createaccount.SelectTab(1)
            chksaving.Checked = False
            chkminor.Checked = False
            chkjoint.Checked = False
        End If
    End Sub

    Private Sub chkminor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkminor.CheckedChanged
        If chkminor.Checked = True Then
            'selects third tabpage
            createaccount.SelectTab(2)
            chksaving.Checked = False
            chkfixed.Checked = False
            chkjoint.Checked = False
        End If
    End Sub

    Private Sub chkjoint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkjoint.CheckedChanged
        If chkjoint.Checked = True Then
            'selects fourth tabpage
            createaccount.SelectTab(3)
            chksaving.Checked = False
            chkminor.Checked = False
            chkfixed.Checked = False
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photo.Click
        'shows a dialog box with initial directory as "my documents" and scans picture files
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"

    End Sub

    Private Sub open_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles open.FileOk
        Dim direct As String
        direct = CurDir() & "\" & "Resources"
        If Directory.Exists(direct) = True Then
            'copies the file 
            FileCopy(open.FileName, direct & "\" & open.SafeFileName)
        Else
            'creates directory
            Directory.CreateDirectory(direct)
            'copies the file
            FileCopy(open.FileName, direct & "\" & open.SafeFileName)

        End If
        'sets imagelocation
        photo.ImageLocation = direct & "\" & open.SafeFileName

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marital.SelectedIndexChanged
        If marital.SelectedItem = "Others" Then
            txtspecify.Visible = True
            lblspecify.Visible = True
        Else
            txtspecify.Visible = False
            lblspecify.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbcurrency.SelectedItem = "Other Foreigh Currency" Then
            txtscurr.Visible = True
            Label8.Visible = True
        Else
            txtscurr.Visible = False
            Label8.Visible = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreligion.SelectedIndexChanged
        If cmbreligion.SelectedItem = "Others" Then
            txtsreligion.Visible = True
            Label153.Visible = True
        Else
            txtsreligion.Visible = False
            Label153.Visible = False
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbocc.SelectedIndexChanged
        If cmbocc.SelectedItem = "Others" Then
            txtsocc.Visible = True
            Label154.Visible = True
        Else
            txtsocc.Visible = False
            Label154.Visible = False
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbeducation.SelectedIndexChanged
        If cmbeducation.SelectedItem = "Others" Then
            txtsedu.Visible = True
            Label156.Visible = True
        Else
            txtsedu.Visible = False
            Label156.Visible = False
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbemployed.SelectedIndexChanged
        If cmbemployed.SelectedItem = "Others" Then
            txtsemp.Visible = True
            Label155.Visible = True
        Else
            txtsemp.Visible = False
            Label155.Visible = False
        End If
    End Sub


    Private Sub CheckBox73_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkn.CheckedChanged
        If chkn.Checked = True Then
            chky.Checked = False
            Label164.Visible = True
            txtreject.Visible = True
        Else
            Label164.Visible = False
            txtreject.Visible = False
        End If

    End Sub

    Private Sub CheckBox72_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chky.CheckedChanged
        If chky.Checked = True Then
            chkn.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateacc.Click

        If marital.Text <> "Others" Then
            txtspecify.Text = "--"
        End If
        If cmbcurrency.Text <> "Other Foreigh Currency" Then
            txtscurr.Text = "--"
        End If
        If cmbreligion.Text <> "Others" Then
            txtsreligion.Text = "--"
        End If
        If cmbocc.Text <> "Others" Then
            txtsocc.Text = "--"
        End If
        If cmbemployed.Text <> "Others" Then
            txtsemp.Text = "--"
        End If
        If cmbeducation.Text <> "Others" Then
            txtsedu.Text = "--"
        End If
        If chky.Checked = True Then
            txtreject.Text = "--"
        End If
        'checks whether the value entered is numeric or not
        If IsNumeric(txtpas.Text) = True And IsNumeric(txtbhno.Text) = True And IsNumeric(txtppn.Text) = True And IsNumeric(txtmno.Text) = True And IsNumeric(txtrpn.Text) = True And IsNumeric(txtrmn.Text) = True Then
            If chky.Checked = True And chktrms.Checked = True Then
                'creates new savings account if terms and conditions are accepted and customer details are correct
                Dim sql1 As String
                sql1 = "Insert into [savings] values ('" & txtcusid.Text & "','"
                sql1 = sql1 & Label81.Text & "','"
                sql1 = sql1 & txtbhno.Text & "','"
                sql1 = sql1 & txtbho.Text & "','"
                sql1 = sql1 & photo.ImageLocation & "','"
                sql1 = sql1 & txtfn.Text & "','"
                sql1 = sql1 & txtmn.Text & "','"
                sql1 = sql1 & txtln.Text & "','"
                sql1 = sql1 & gender.Text & "','"
                sql1 = sql1 & marital.Text & "','"
                sql1 = sql1 & txtspecify.Text & "','"
                sql1 = sql1 & DateTimePicker2.Value & "','"
                sql1 = sql1 & DateTimePicker3.Value & "','"
                sql1 = sql1 & txtnat.Text & "','"
                sql1 = sql1 & txtpas.Text & "','"
                sql1 = sql1 & txtpoi.Text & "','"
                sql1 = sql1 & DateTimePicker4.Value & "','"
                sql1 = sql1 & txtoth.Text & "','"
                sql1 = sql1 & txtpoio.Text & "','"
                sql1 = sql1 & DateTimePicker5.Value & "','"
                sql1 = sql1 & txtpm.Text & "','"
                sql1 = sql1 & txtpd.Text & "','"
                sql1 = sql1 & txtpc.Text & "','"
                sql1 = sql1 & txtppn.Text & "','"
                sql1 = sql1 & txtmno.Text & "','"
                sql1 = sql1 & txtpem.Text & "','"
                sql1 = sql1 & txtrm.Text & "','"
                sql1 = sql1 & txtrd.Text & "','"
                sql1 = sql1 & txtrc.Text & "','"
                sql1 = sql1 & txtrpn.Text & "','"
                sql1 = sql1 & txtrmn.Text & "','"
                sql1 = sql1 & txtrem.Text & "','"
                sql1 = sql1 & cmbcurrency.Text & "','"
                sql1 = sql1 & txtscurr.Text & "','"
                sql1 = sql1 & nuda.Value & "','"
                sql1 = sql1 & txtfhn.Text & "','"
                sql1 = sql1 & txtgfn.Text & "','"
                sql1 = sql1 & cmbreligion.Text & "','"
                sql1 = sql1 & txtsreligion.Text & "','"
                sql1 = sql1 & cmbocc.Text & "','"
                sql1 = sql1 & txtsocc.Text & "','"
                sql1 = sql1 & cmbemployed.Text & "','"
                sql1 = sql1 & txtsemp.Text & "','"
                sql1 = sql1 & cmbeducation.Text & "','"
                sql1 = sql1 & txtsedu.Text & "','"
                sql1 = sql1 & DateTimePicker6.Value & "','"
                sql1 = sql1 & txtintroo.Text & "','"
                sql1 = sql1 & txtreject.Text & "','"
                sql1 = sql1 & txtprp.Text & "','"
                sql1 = sql1 & txtvb.Text & "','"
                sql1 = sql1 & txtab.Text & "')"

                adddata(sql1)
                Me.Close()

            ElseIf chktrms.Checked = False Then
                MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
            ElseIf chky.Checked = False Then
                MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
            End If
        ElseIf IsNumeric(txtbhno.Text) = False Or IsNumeric(txtpas.Text) = False Or IsNumeric(txtppn.Text) = False Or IsNumeric(txtmno.Text) = False Or IsNumeric(txtrpn.Text) = False Or IsNumeric(txtrmn.Text) = False Then
            MsgBox("Branch code number,Phone number, mobile number  and citizenship number should contain numeric value", MsgBoxStyle.Exclamation, "ERROR")
        End If



    End Sub

    Private Sub TextBox181_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaccnoo.TextChanged
        txtaccnoo.Text = Label81.Text
    End Sub

    Private Sub TextBox184_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtintroo.TextChanged
        txtintroo.Text = txtintro.Text
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfmarital.SelectedIndexChanged
        If cmbfmarital.Text = "Others" Then
            Label25.Visible = True
            txtfomarital.Visible = True
        Else
            Label25.Visible = False
            txtfomarital.Visible = False
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
        accountstatement.Close()
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

    Private Sub cmbcurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcurrency.SelectedIndexChanged
        If cmbcurrency.Text = "Other Foreigh Currency" Then
            Label185.Visible = True
            txtscurr.Visible = True
        Else
            Label185.Visible = False
            txtscurr.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox2.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfcurrency.SelectedIndexChanged
        If cmbfcurrency.Text = "Other Foreigh Currency" Then
            Label44.Visible = True
            txtfocurrency.Visible = True
        Else
            Label44.Visible = False
            txtfocurrency.Visible = False
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfreligion.SelectedIndexChanged
        If cmbfreligion.Text = "Others" Then
            Label70.Visible = True
            txtforeligion.Visible = True
        Else
            Label70.Visible = False
            txtforeligion.Visible = False
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfoccoupation.SelectedIndexChanged
        If cmbfoccoupation.Text = "Others" Then
            Label72.Visible = True
            txtfooccupation.Visible = True
        Else
            Label72.Visible = False
            txtfooccupation.Visible = False
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfemployed.SelectedIndexChanged
        If cmbfemployed.Text = "Others" Then
            Label71.Visible = True
            txtfoemployed.Visible = True
        Else
            Label71.Visible = False
            txtfoemployed.Visible = False
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.Text = "Others" Then
            Label73.Visible = True
            TextBox38.Visible = True
        Else
            Label73.Visible = False
            TextBox38.Visible = False
        End If
    End Sub

    Private Sub CheckBox123_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfy.CheckedChanged
        If chkfy.Checked = True Then
            chkfn.Checked = False
        End If
    End Sub

    Private Sub CheckBox122_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfn.CheckedChanged
        If chkfn.Checked = True Then
            chkfy.Checked = False
            Label192.Visible = True
            txtfrejects.Visible = True
        Else
            Label192.Visible = False
            txtfrejects.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfcreate.Click
        If cmbfmarital.Text <> "Others" Then
            txtfomarital.Text = "--"
        End If
        If cmbfcurrency.Text <> "Other Foreigh Currency" Then
            txtfocurrency.Text = "--"
        End If
        If cmbfreligion.Text <> "Others" Then
            txtforeligion.Text = "--"
        End If
        If cmbfoccoupation.Text <> "Others" Then
            txtfooccupation.Text = "--"
        End If
        If cmbfemployed.Text <> "Others" Then
            txtfoemployed.Text = "--"
        End If
        If ComboBox12.Text <> "Others" Then
            TextBox38.Text = "--"
        End If
        If chkfy.Checked = True Then
            txtfrejects.Text = "--"
        End If
        If IsNumeric(txtfbrnchno.Text) = True And IsNumeric(txtfpas.Text) = True And IsNumeric(txtfphn.Text) = True And IsNumeric(txtfmn.Text) = True And IsNumeric(txtfrphn.Text) = True And IsNumeric(txtfrmn.Text) = True Then
            If chkfy.Checked = True And chkftrms.Checked = True Then
                'creates new fixed deposit account if terms and conditions are accepted and customer details are correct
                Dim sql1 As String
                sql1 = "Insert into [fixed deposit] values ('" & txtfcusid.Text & "','"
                sql1 = sql1 & txtfaccid.Text & "','"
                sql1 = sql1 & txtfbrnchno.Text & "','"
                sql1 = sql1 & txtfbrncho.Text & "','"
                sql1 = sql1 & photo.ImageLocation & "','"
                sql1 = sql1 & txtffname.Text & "','"
                sql1 = sql1 & txtfmname.Text & "','"
                sql1 = sql1 & txtflname.Text & "','"
                sql1 = sql1 & cmbfgender.Text & "','"
                sql1 = sql1 & cmbfmarital.Text & "','"
                sql1 = sql1 & txtfomarital.Text & "','"
                sql1 = sql1 & DateTimePicker8.Value & "','"
                sql1 = sql1 & DateTimePicker7.Value & "','"
                sql1 = sql1 & txtfnationality.Text & "','"
                sql1 = sql1 & txtfpas.Text & "','"
                sql1 = sql1 & txtfplc.Text & "','"
                sql1 = sql1 & DateTimePicker10.Value & "','"
                sql1 = sql1 & txtfotherpass.Text & "','"
                sql1 = sql1 & txtfoplc.Text & "','"
                sql1 = sql1 & DateTimePicker9.Value & "','"
                sql1 = sql1 & txtfmunicipality.Text & "','"
                sql1 = sql1 & txtfdistrict.Text & "','"
                sql1 = sql1 & txtfcountry.Text & "','"
                sql1 = sql1 & txtfphn.Text & "','"
                sql1 = sql1 & txtfmn.Text & "','"
                sql1 = sql1 & txtfemail.Text & "','"
                sql1 = sql1 & txtfrmunicipality.Text & "','"
                sql1 = sql1 & txtfrdistrict.Text & "','"
                sql1 = sql1 & txtfrcountry.Text & "','"
                sql1 = sql1 & txtfrphn.Text & "','"
                sql1 = sql1 & txtfrmn.Text & "','"
                sql1 = sql1 & txtfremail.Text & "','"
                sql1 = sql1 & cmbfcurrency.Text & "','"
                sql1 = sql1 & txtfocurrency.Text & "','"
                sql1 = sql1 & nudfamount.Value & "','"
                sql1 = sql1 & txtfawords.Text & "','"
                sql1 = sql1 & txtffhname.Text & "','"
                sql1 = sql1 & txtfgfname.Text & "','"
                sql1 = sql1 & cmbfreligion.Text & "','"
                sql1 = sql1 & txtforeligion.Text & "','"
                sql1 = sql1 & cmbfoccoupation.Text & "','"
                sql1 = sql1 & txtfooccupation.Text & "','"
                sql1 = sql1 & cmbfemployed.Text & "','"
                sql1 = sql1 & txtfoemployed.Text & "','"
                sql1 = sql1 & ComboBox12.Text & "','"
                sql1 = sql1 & TextBox38.Text & "','"
                sql1 = sql1 & DateTimePicker11.Value & "','"
                sql1 = sql1 & txtfvintroducer.Text & "','"
                sql1 = sql1 & txtfrejects.Text & "','"
                sql1 = sql1 & txtfprepared.Text & "','"
                sql1 = sql1 & txtfverified.Text & "','"
                sql1 = sql1 & txtfauthorized.Text & "')"

                adddata(sql1)
                Me.Close()

            ElseIf chkftrms.Checked = False Then
                MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
            ElseIf chkfy.Checked = False Then
                MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
            End If
        ElseIf IsNumeric(txtfbrnchno.Text) = False Or IsNumeric(txtfpas.Text) = False Or IsNumeric(txtfphn.Text) = False Or IsNumeric(txtfmn.Text) = False Or IsNumeric(txtfrphn.Text) = False Or IsNumeric(txtfrmn.Text) = False Then
            MsgBox("Branch code number,Phone number, mobile number  and citizenship number should contain numeric value", MsgBoxStyle.Exclamation, "ERROR")
        End If

    End Sub

    Private Sub TextBox130_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfvaccid.TextChanged
        txtfvaccid.Text = txtfaccid.Text
    End Sub

    Private Sub TextBox127_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfvintroducer.TextChanged
        txtfvintroducer.Text = txtfintroducer.Text
    End Sub

    Private Sub CheckBox27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            CheckBox23.Checked = False
            CheckBox27.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox27.Checked = False
            CheckBox26.Checked = False
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox27.Checked = False
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            CheckBox27.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
            CheckBox26.Checked = False
        End If
    End Sub

    Private Sub CheckBox38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            CheckBox35.Checked = False
            CheckBox36.Checked = False
            CheckBox37.Checked = False
            CheckBox34.Checked = False
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked = True Then
            CheckBox34.Checked = False
            CheckBox36.Checked = False
            CheckBox37.Checked = False
            CheckBox38.Checked = False
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked = True Then
            CheckBox35.Checked = False
            CheckBox36.Checked = False
            CheckBox37.Checked = False
            CheckBox38.Checked = False
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked = True Then
            CheckBox35.Checked = False
            CheckBox36.Checked = False
            CheckBox34.Checked = False
            CheckBox38.Checked = False
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked = True Then
            CheckBox35.Checked = False
            CheckBox34.Checked = False
            CheckBox37.Checked = False
            CheckBox38.Checked = False
        End If
    End Sub

    Private Sub CheckBox151_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmy.CheckedChanged
        If chkmy.Checked = True Then
            chkmn.Checked = False
        End If
    End Sub

    Private Sub CheckBox150_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmn.CheckedChanged
        If chkmn.Checked = True Then
            chkmy.Checked = False
            Label212.Visible = True
            txtmreject.Visible = True
        Else
            Label212.Visible = False
            txtmreject.Visible = False
        End If
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmeducation.SelectedIndexChanged
        If cmbmeducation.Text = "Others" Then
            Label90.Visible = True
            txtmoeducation.Visible = True
        Else
            Label90.Visible = False
            txtmoeducation.Visible = False
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmemployed.SelectedIndexChanged
        If txtmemployed.Text = "Others" Then
            Label88.Visible = True
            txtmoemployed.Visible = True
        Else
            Label88.Visible = False
            txtmoemployed.Visible = False
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmoccupation.SelectedIndexChanged
        If cmbmoccupation.Text = "Others" Then
            Label86.Visible = True
            txtmooccupation.Visible = True
        Else
            Label86.Visible = False
            txtmooccupation.Visible = False
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmreligion.SelectedIndexChanged
        If cmbmreligion.Text = "Others" Then
            Label85.Visible = True
            txtmoreligion.Visible = True
        Else
            Label85.Visible = False
            txtmoreligion.Visible = False
        End If
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmcurrency.SelectedIndexChanged
        If cmbmcurrency.Text = "Other Foreigh Currency" Then
            Label92.Visible = True
            txtmocurrenry.Visible = True
        Else
            Label92.Visible = False
            txtmocurrenry.Visible = False
        End If
    End Sub

    Private Sub CheckBox127_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox127.CheckedChanged
        If CheckBox127.Checked = True Then
            cmbmrelation.Enabled = False
            Label201.Visible = True
            txtmorelation.Visible = True
        Else
            cmbmrelation.Enabled = True
            Label201.Visible = False
            txtmorelation.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmcreate.Click
        If CheckBox127.Checked = False Then
            txtmorelation.Text = "--"
        End If
        If cmbmcurrency.Text <> "Other Foreigh Currency" Then
            txtmocurrenry.Text = "--"
        End If
        If cmbmreligion.Text <> "Others" Then
            txtmoreligion.Text = "--"
        End If
        If cmbmoccupation.Text <> "Others" Then
            txtmooccupation.Text = "--"
        End If
        If txtmemployed.Text <> "Others" Then
            txtmoemployed.Text = "--"
        End If
        If cmbmeducation.Text <> "Others" Then
            txtmoeducation.Text = "--"
        End If
        If chkmy.Checked = True Then
            txtmreject.Text = "--"
        End If
        If IsNumeric(txtmbrnchno.Text) = True And IsNumeric(txtmpas.Text) = True And IsNumeric(txtmphn.Text) = True And IsNumeric(txtmmn.Text) = True And IsNumeric(txtmrphn.Text) = True And IsNumeric(txtmrmn.Text) = True Then
            If chkmy.Checked = True And chkmtrms.Checked = True Then
                'creates new minor account if terms and conditions are accepted and customer details are correct
                Dim sql1 As String
                sql1 = "Insert into [minor] values ('" & txtmcusid.Text & "','"
                sql1 = sql1 & txtmaccid.Text & "','"
                sql1 = sql1 & txtmbrnchno.Text & "','"
                sql1 = sql1 & txtmbrncho.Text & "','"
                sql1 = sql1 & photo.ImageLocation & "','"
                sql1 = sql1 & txtmfname.Text & "','"
                sql1 = sql1 & txtmmname.Text & "','"
                sql1 = sql1 & txtmlname.Text & "','"
                sql1 = sql1 & cmbmgender.Text & "','"
                sql1 = sql1 & DateTimePicker13.Value & "','"
                sql1 = sql1 & DateTimePicker12.Value & "','"
                sql1 = sql1 & TextBox43.Text & "','"
                sql1 = sql1 & txtmpas.Text & "','"
                sql1 = sql1 & txtmplc.Text & "','"
                sql1 = sql1 & DateTimePicker20.Value & "','"
                sql1 = sql1 & txtmotherp.Text & "','"
                sql1 = sql1 & txtmplco.Text & "','"
                sql1 = sql1 & DateTimePicker19.Value & "','"
                sql1 = sql1 & txtmpmunicipality.Text & "','"
                sql1 = sql1 & txtmpdistrict.Text & "','"
                sql1 = sql1 & txtmpcountry.Text & "','"
                sql1 = sql1 & txtmphn.Text & "','"
                sql1 = sql1 & txtmmn.Text & "','"
                sql1 = sql1 & txtmpemail.Text & "','"
                sql1 = sql1 & txtmrmunicipality.Text & "','"
                sql1 = sql1 & txtmrdistrict.Text & "','"
                sql1 = sql1 & txtmrcountry.Text & "','"
                sql1 = sql1 & txtmrphn.Text & "','"
                sql1 = sql1 & txtmrmn.Text & "','"
                sql1 = sql1 & txtmremail.Text & "','"
                sql1 = sql1 & txtmguardiann.Text & "','"
                sql1 = sql1 & cmbmrelation.Text & "','"
                sql1 = sql1 & txtmorelation.Text & "','"
                sql1 = sql1 & txtmgaddress.Text & "','"
                sql1 = sql1 & txtmproof.Text & "','"
                sql1 = sql1 & cmbmcurrency.Text & "','"
                sql1 = sql1 & txtmocurrenry.Text & "','"
                sql1 = sql1 & nudmamount.Value & "','"
                sql1 = sql1 & txtmffname.Text & "','"
                sql1 = sql1 & txtmfgfname.Text & "','"
                sql1 = sql1 & cmbmreligion.Text & "','"
                sql1 = sql1 & txtmoreligion.Text & "','"
                sql1 = sql1 & cmbmoccupation.Text & "','"
                sql1 = sql1 & txtmooccupation.Text & "','"
                sql1 = sql1 & txtmemployed.Text & "','"
                sql1 = sql1 & txtmoemployed.Text & "','"
                sql1 = sql1 & cmbmeducation.Text & "','"
                sql1 = sql1 & txtmoeducation.Text & "','"
                sql1 = sql1 & DateTimePicker14.Value & "','"
                sql1 = sql1 & txtvintroducer.Text & "','"
                sql1 = sql1 & txtmreject.Text & "','"
                sql1 = sql1 & txtmprepared.Text & "','"
                sql1 = sql1 & txtmverified.Text & "','"
                sql1 = sql1 & txtmauthorized.Text & "')"

                adddata(sql1)
                Me.Close()
            ElseIf chkmtrms.Checked = False Then
                MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
            ElseIf chkmy.Checked = False Then
                MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
            End If
        ElseIf IsNumeric(txtmbrnchno.Text) = False Or IsNumeric(txtmpas.Text) = False Or IsNumeric(txtmphn.Text) = False Or IsNumeric(txtmmn.Text) = False Or IsNumeric(txtmrphn.Text) = False Or IsNumeric(txtmrmn.Text) = False Then
            MsgBox("Branch code number,Phone number, mobile number  and citizenship number should contain numeric value", MsgBoxStyle.Exclamation, "ERROR")
        End If

    End Sub

    Private Sub TextBox163_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvintroducer.TextChanged
        txtvintroducer.Text = txtmintroducer.Text
    End Sub

    Private Sub TextBox166_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmvaccid.TextChanged
        txtmvaccid.Text = txtmaccid.Text
    End Sub

    Private Sub CheckBox160_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox160.CheckedChanged
        If CheckBox160.Checked = True Then
            CheckBox159.Checked = False
            CheckBox158.Checked = False
            CheckBox157.Checked = False
            CheckBox156.Checked = False
        End If
    End Sub

    Private Sub CheckBox157_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox157.CheckedChanged
        If CheckBox157.Checked = True Then
            CheckBox159.Checked = False
            CheckBox158.Checked = False
            CheckBox160.Checked = False
            CheckBox156.Checked = False
        End If
    End Sub

    Private Sub CheckBox158_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox158.CheckedChanged
        If CheckBox158.Checked = True Then
            CheckBox159.Checked = False
            CheckBox160.Checked = False
            CheckBox157.Checked = False
            CheckBox156.Checked = False
        End If
    End Sub

    Private Sub CheckBox159_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox159.CheckedChanged
        If CheckBox159.Checked = True Then
            CheckBox160.Checked = False
            CheckBox158.Checked = False
            CheckBox157.Checked = False
            CheckBox156.Checked = False
        End If
    End Sub

    Private Sub CheckBox156_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox156.CheckedChanged
        If CheckBox156.Checked = True Then
            CheckBox159.Checked = False
            CheckBox158.Checked = False
            CheckBox157.Checked = False
            CheckBox160.Checked = False
        End If
    End Sub

    Private Sub CheckBox165_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox165.CheckedChanged
        If CheckBox165.Checked = True Then
            CheckBox154.Checked = False
            CheckBox155.Checked = False
            CheckBox164.Checked = False
            CheckBox153.Checked = False
        End If
    End Sub

    Private Sub CheckBox154_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox154.CheckedChanged
        If CheckBox154.Checked = True Then
            CheckBox165.Checked = False
            CheckBox155.Checked = False
            CheckBox164.Checked = False
            CheckBox153.Checked = False
        End If
    End Sub

    Private Sub CheckBox155_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox155.CheckedChanged
        If CheckBox155.Checked = True Then
            CheckBox154.Checked = False
            CheckBox165.Checked = False
            CheckBox164.Checked = False
            CheckBox153.Checked = False
        End If
    End Sub

    Private Sub CheckBox164_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox164.CheckedChanged
        If CheckBox164.Checked = True Then
            CheckBox154.Checked = False
            CheckBox155.Checked = False
            CheckBox165.Checked = False
            CheckBox153.Checked = False
        End If
    End Sub

    Private Sub CheckBox153_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox153.CheckedChanged
        If CheckBox153.Checked = True Then
            CheckBox154.Checked = False
            CheckBox155.Checked = False
            CheckBox164.Checked = False
            CheckBox165.Checked = False
        End If
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbjcurrency.SelectedIndexChanged
        If cmbjcurrency.Text = "Other Foreigh Currency" Then
            Label182.Visible = True
            txtocurrency.Visible = True
        Else
            Label182.Visible = False
            txtocurrency.Visible = False
        End If
    End Sub

    Private Sub CheckBox172_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkjy.CheckedChanged
        If chkjy.Checked = True Then
            chkjn.Checked = False
        End If
    End Sub

    Private Sub CheckBox171_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkjn.CheckedChanged
        If chkjn.Checked = True Then
            chkjy.Checked = False
            Label292.Visible = True
            txtjreject.Visible = True
        Else
            Label292.Visible = False
            txtjreject.Visible = False
        End If
    End Sub

    Private Sub TextBox272_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjvaccid.TextChanged
        txtjvaccid.Text = txtjaccid.Text
    End Sub

    Private Sub TextBox269_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjvintroducer.TextChanged
        txtjvintroducer.Text = txtjintroducer.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjcreate.Click
        If cmbjcurrency.Text <> "Other Foreigh Currency" Then
            txtocurrency.Text = "--"
        End If
        If chkjy.Checked = True Then
            txtjreject.Text = "--"
        End If
        If IsNumeric(txtjbrnchno.Text) = True And IsNumeric(txtjpass.Text) = True And IsNumeric(txtj1phn.Text) = True And IsNumeric(txtj1mn.Text) = True And IsNumeric(txtj1rphn.Text) = True And IsNumeric(txtj1rmn.Text) = True And IsNumeric(txtj2pas.Text) = True And IsNumeric(txtj2phn.Text) = True And IsNumeric(txtj2mn.Text) = True And IsNumeric(txtj2rphn.Text) = True And IsNumeric(txtj2rmn.Text) = True Then
            If chkjy.Checked = True And chkjtrms.Checked = True Then
                'creates new joint account account if terms and conditions are accepted and customer details are correct
                Dim sql1 As String
                sql1 = "Insert into [jointaccount] values ('" & txtjcusid1.Text & "','"
                sql1 = sql1 & txtjcusid2.Text & "','"
                sql1 = sql1 & txtjaccid.Text & "','"
                sql1 = sql1 & txtjbrnchno.Text & "','"
                sql1 = sql1 & txtjbrncho.Text & "','"
                sql1 = sql1 & txtjfname.Text & "','"
                sql1 = sql1 & txtjmname.Text & "','"
                sql1 = sql1 & txtjlname.Text & "','"
                sql1 = sql1 & cmbjgender.Text & "','"
                sql1 = sql1 & photo.ImageLocation & "','"
                sql1 = sql1 & DateTimePicker16.Value & "','"
                sql1 = sql1 & DateTimePicker15.Value & "','"
                sql1 = sql1 & txtjfname2.Text & "','"
                sql1 = sql1 & txtjmname2.Text & "','"
                sql1 = sql1 & txtjlname2.Text & "','"
                sql1 = sql1 & cmbjgender2.Text & "','"
                sql1 = sql1 & photo.ImageLocation & "','"
                sql1 = sql1 & DateTimePicker18.Value & "','"
                sql1 = sql1 & DateTimePicker17.Value & "','"
                sql1 = sql1 & txtjffname.Text & "','"
                sql1 = sql1 & txtjgfname.Text & "','"
                sql1 = sql1 & txtjffname2.Text & "','"
                sql1 = sql1 & txtjgfname2.Text & "','"
                sql1 = sql1 & txtjmunicipality.Text & "','"
                sql1 = sql1 & txtjdistrict.Text & "','"
                sql1 = sql1 & txtjcountry.Text & "','"
                sql1 = sql1 & txtj1phn.Text & "','"
                sql1 = sql1 & txtj1mn.Text & "','"
                sql1 = sql1 & txtjemail.Text & "','"
                sql1 = sql1 & txtjrmunicipality.Text & "','"
                sql1 = sql1 & txtjrdistrict.Text & "','"
                sql1 = sql1 & txtjrcountry.Text & "','"
                sql1 = sql1 & txtj1rphn.Text & "','"
                sql1 = sql1 & txtj1rmn.Text & "','"
                sql1 = sql1 & txtjremail.Text & "','"
                sql1 = sql1 & txtjmunicipality2.Text & "','"
                sql1 = sql1 & txtjdistrict2.Text & "','"
                sql1 = sql1 & txtjcountry2.Text & "','"
                sql1 = sql1 & txtj2phn.Text & "','"
                sql1 = sql1 & txtj2mn.Text & "','"
                sql1 = sql1 & txtjemail2.Text & "','"
                sql1 = sql1 & txtjrmunicipality2.Text & "','"
                sql1 = sql1 & txtjrdistrict2.Text & "','"
                sql1 = sql1 & txtjrcountry2.Text & "','"
                sql1 = sql1 & txtj2rphn.Text & "','"
                sql1 = sql1 & txtj2rmn.Text & "','"
                sql1 = sql1 & txtjremail2.Text & "','"
                sql1 = sql1 & txtjnationality.Text & "','"
                sql1 = sql1 & txtjpass.Text & "','"
                sql1 = sql1 & txtjplc.Text & "','"
                sql1 = sql1 & DateTimePicker22.Value & "','"
                sql1 = sql1 & txtjotherpass.Text & "','"
                sql1 = sql1 & txtjopplc.Text & "','"
                sql1 = sql1 & DateTimePicker21.Value & "','"
                sql1 = sql1 & txtjnationality2.Text & "','"
                sql1 = sql1 & txtj2pas.Text & "','"
                sql1 = sql1 & txtjpplc2.Text & "','"
                sql1 = sql1 & DateTimePicker24.Value & "','"
                sql1 = sql1 & txtjopass2.Text & "','"
                sql1 = sql1 & txtjoplc2.Text & "','"
                sql1 = sql1 & DateTimePicker23.Value & "','"
                sql1 = sql1 & cmbjcurrency.Text & "','"
                sql1 = sql1 & txtocurrency.Text & "','"
                sql1 = sql1 & nudjamount.Value & "','"
                sql1 = sql1 & DateTimePicker25.Value & "','"
                sql1 = sql1 & txtjvintroducer.Text & "','"
                sql1 = sql1 & txtjreject.Text & "','"
                sql1 = sql1 & txtjprepared.Text & "','"
                sql1 = sql1 & txtjverified.Text & "','"
                sql1 = sql1 & txtjauthorized.Text & "')"

                adddata(sql1)
                Me.Close()
            ElseIf chkjtrms.Checked = False Then
                MsgBox("Terms and conditions are not accepted", MsgBoxStyle.Exclamation, "ERROR")
            ElseIf chkjy.Checked = False Then
                MsgBox("Customer details are not verified", MsgBoxStyle.Exclamation, "ERROR")
            End If
        ElseIf IsNumeric(txtjbrnchno.Text) = False Or IsNumeric(txtjpass.Text) = False Or IsNumeric(txtj1phn.Text) = False Or IsNumeric(txtj1mn.Text) = False Or IsNumeric(txtj1rphn.Text) = False Or IsNumeric(txtj1rmn.Text) = False Or IsNumeric(txtj2pas.Text) = False Or IsNumeric(txtj2phn.Text) = False Or IsNumeric(txtj2mn.Text) = False Or IsNumeric(txtj2rphn.Text) = False Or IsNumeric(txtj2rmn.Text) = False Then
            MsgBox("Branch code number,Phone number, mobile number  and citizenship number should contain numeric value", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'shows a dialog box with initial directory as "my documents" and scans picture files
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'shows a dialog box with initial directory as "my documents" and scans picture files
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'shows a dialog box with initial directory as "my documents" and scans picture files
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        'shows a dialog box with initial directory as "my documents" and scans picture files
        open.ShowDialog()
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        open.Filter = "Image Files (*.jpg)|*.jpg,*.png,*.gif,*.jpeg"
    End Sub

    Private Sub btncncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncncl.Click
        'closes the current form
        Me.Close()
        'shows the welcome form
        welcome.Show()
    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        'closes the current form
        Me.Close()
        'shows the welcome form
        welcome.Show()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        'shows help engine
        Help_Engine.Show()
    End Sub
End Class