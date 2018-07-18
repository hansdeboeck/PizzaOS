Public Class Restart
    Private Sub Restart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "PizzaOS v" & Application.ProductVersion
        Getstarted.Hide()
        Getstarted.ShowInTaskbar = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub
End Class