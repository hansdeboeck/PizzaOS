Public Class Getstarted
    Private Sub getstarted(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Launching"
        start()
    End Sub
    Public Sub start()
        Label1.Text = "Launching 10%"
        If System.IO.File.Exists("C:\PizzaOS\black.txt") Then
            Label1.Text = "STOPPED"
            Geblokeerd.Show()
        Else
            If System.IO.File.Exists("C:\PizzaOS\DONTDELETEME") Then
                Label1.Text = "Launching 20%"
            Else
                NoPizza_Firstime.Show()

            End If
        End If


    End Sub
End Class
