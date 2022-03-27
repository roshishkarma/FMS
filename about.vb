Public Class about
    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starts the timer.
        loadtimer.Start()
    End Sub

    Private Sub loadtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadtimer.Tick
        'codes to make loading bar work
        If loadingbar.Value < loadingbar.Maximum Then
            loadingbar.Value = loadingbar.Value + 5

        ElseIf loadingbar.Value = loadingbar.Maximum Then
            loadtimer.Stop()
            'closes the current form
            Me.Hide()
            'opens the login form
            login.Show()
        End If
    End Sub
End Class