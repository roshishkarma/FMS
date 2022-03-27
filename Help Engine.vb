Public Class Help_Engine

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Index = 0 Then
            'shows help file for login form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\login.htm")
        End If
        If TreeView1.SelectedNode.Index = 1 Then
            'shows help file for forgot password form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\forgot password.htm")
        End If
        If TreeView1.SelectedNode.Index = 2 Then
            'shows help file for welcome form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\welcome.htm")
        End If
        If TreeView1.SelectedNode.Index = 3 Then
            'shows help file for add user form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\add user.htm")
        End If
        If TreeView1.SelectedNode.Index = 4 Then
            'shows help file for username password change form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\usernamepasswordchange.htm")
        End If
        If TreeView1.SelectedNode.Index = 5 Then
            'shows help file for creating back up
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\back up.htm")
        End If
        If TreeView1.SelectedNode.Index = 6 Then
            'shows help file for restore back up
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\restore.htm")
        End If
        If TreeView1.Nodes.Item(7).Nodes.Item(0).IsSelected = True Then
            'shows help file for create account form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\create account.htm")
        End If
        If TreeView1.Nodes.Item(7).Nodes.Item(1).IsSelected = True Then
            'shows help file for account details form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\account details.htm")
        End If
        If TreeView1.Nodes.Item(7).Nodes.Item(2).IsSelected = True Then
            'shows help file for account statements form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\account statements.htm")
        End If
        If TreeView1.Nodes.Item(7).Nodes.Item(3).IsSelected = True Then
            'shows help file for deposit form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\deposit.htm")
        End If
        If TreeView1.Nodes.Item(7).Nodes.Item(4).IsSelected = True Then
            'shows help file for withdraw money form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\withdraw.htm")
        End If
        If TreeView1.Nodes.Item(8).Nodes.Item(0).IsSelected = True Then
            'shows help file for loan form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\loan.htm")
        End If
        If TreeView1.Nodes.Item(8).Nodes.Item(1).IsSelected = True Then
            'shows help file for loan details form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\loan details.htm")
        End If
        If TreeView1.Nodes.Item(8).Nodes.Item(2).IsSelected = True Then
            'shows help file for loan statements form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\loan statements.htm")
        End If
        If TreeView1.Nodes.Item(8).Nodes.Item(3).IsSelected = True Then
            'shows help file for payloan form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\pay loan.htm")
        End If
        If TreeView1.Nodes.Item(8).Nodes.Item(4).IsSelected = True Then
            'shows help file for withdraw loan form
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\withdraw loan.htm")
        End If
        If TreeView1.SelectedNode.Index = 9 Then
            'shows help file for menu tools
            helpbrowser.Navigate(My.Computer.FileSystem.CurrentDirectory & "\Help Engine\menu tools.htm")
        End If
    End Sub
End Class