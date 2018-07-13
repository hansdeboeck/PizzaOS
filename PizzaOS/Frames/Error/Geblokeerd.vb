Public Class Geblokeerd


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://hansdeboeck.be")
    End Sub

    Private Sub Geblokeerd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getstarted.Opacity = 0%
        Label3.Text = Application.ProductVersion
    End Sub

    Private Sub Geblokeerd_Sluiten(sender As Object, e As EventArgs) Handles MyBase.Closing
        Getstarted.Close()
    End Sub

End Class