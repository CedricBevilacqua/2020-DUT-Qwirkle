Public Class FORM_Accueil

    Private Sub BT_Exit_Click(sender As Object, e As EventArgs) Handles BT_Exit.Click
        Application.Exit()
    End Sub

    Private Sub BT_Play_Click(sender As Object, e As EventArgs) Handles BT_Play.Click
        FORM_Settings.Show()
        Me.Visible = False
    End Sub
End Class
