Public Class Geblokeerd


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://hansdeboeck.be")
    End Sub

    Private Sub Geblokeerd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getstarted.Opacity = 0%
        Label3.Text = "PizzaOS v" & Application.ProductVersion
        Getstarted.Hide()
        Getstarted.ShowInTaskbar = False
    End Sub


End Class