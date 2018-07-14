Imports System.Net
Imports System.IO
Imports System.Diagnostics

Public Class Getstarted
    Private Sub getstarted(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Launching"
        start()
    End Sub
    Function GetPage(ByVal pageUrl As String) As String
        Dim s As String = ""
        Try
            Dim request As HttpWebRequest = WebRequest.Create(pageUrl)
            Dim response As HttpWebResponse = request.GetResponse()
            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                s = reader.ReadToEnd()
            End Using
        Catch ex As Exception

        End Try
        Return s
    End Function


    Public Sub start()
        Label1.Text = "Launching 10%"
        If System.IO.File.Exists("C:\PizzaOS\black.txt") Then
            Label1.Text = "STOPPED"
            Geblokeerd.Show()
        Else
            If System.IO.File.Exists("C:\PizzaOS\DONTDELETEME") Then
                Label1.Text = "Launching 20%"
                Timer1.Start()


                'offline

            Else
                NoPizza_Firstime.Show()

            End If
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        checkupdate.xxx()
        downloadpizzas.pizzasbakken()
        Try
            Dim page As String = GetPage("https://pizzaos.hacemedia.com/api/online.php")
            If page = 1 Then
                Label1.Text = "Launching 30%"

                Try
                    google_chrome.CheckIfinstalled()
                Catch ex As Exception

                End Try
                Try
                    ' google_chrome.CheckIfRunning()
                Catch ex As Exception

                End Try
                Process.Start("C:\PizzaOS\bat\online-" & Application.ProductVersion & ".bat")

            End If
        Catch ex As Exception
            Process.Start("C:\PizzaOS\bat\offline-" & Application.ProductVersion & ".bat")
        End Try
        Timer1.Stop()
        Label1.Text = "Klaar"
    End Sub
End Class
