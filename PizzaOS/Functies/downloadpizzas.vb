Imports System.Net
Imports System.IO

Public Class downloadpizzas


    Friend Shared Function pizzasbakken()
        Dim schermnaam As String
        schermnaam = My.Computer.FileSystem.ReadAllText("C:\PizzaOS\config\user.txt")

        If System.IO.File.Exists("C:\PizzaOS\cache\offline.html") Then
            Getstarted.Label1.Text = "sync offline.html"
            Getstarted.Label1.Update()
            My.Computer.FileSystem.DeleteFile("C:\PizzaOS\cache\offline.html")
            My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/offline.php?" & schermnaam, "C:\PizzaOS\cache\offline.html")
        Else
            Getstarted.Label1.Text = "Download het offline.html"
            Getstarted.Label1.Update()
            My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/offline.php?" & schermnaam, "C:\PizzaOS\cache\offline.html")
        End If

        If Not System.IO.File.Exists("C:\PizzaOS\bat\online-" & Application.ProductVersion & ".bat") Then
            Getstarted.Label1.Text = "download online.bat"
            Getstarted.Label1.Update()
            My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/onlinebat.php?" & schermnaam, "C:\PizzaOS\bat\online-" & Application.ProductVersion & ".bat")
        End If

        If Not System.IO.File.Exists("C:\PizzaOS\bat\offline-" & Application.ProductVersion & ".bat") Then
            Getstarted.Label1.Text = "download offline.bat"
            Getstarted.Label1.Update()
            My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/onlinebat.php?" & schermnaam, "C:\PizzaOS\bat\offline-" & Application.ProductVersion & ".bat")
        End If

        If Not System.IO.File.Exists("C:\PizzaOS\readme-" & Application.ProductVersion & ".md") Then
            Getstarted.Label1.Text = "download het leesmij bestand"
            Getstarted.Label1.Update()
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/hansdeboeck/PizzaOS/master/README.md", "C:\PizzaOS\readme-" & Application.ProductVersion & ".md")
        End If

        If Not System.IO.File.Exists("C:\PizzaOS\LICENSE-" & Application.ProductVersion) Then
            Getstarted.Label1.Text = "download het leesmij bestand"
            Getstarted.Label1.Update()
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/hansdeboeck/PizzaOS/master/LICENSE", "C:\PizzaOS\LICENSE-" & Application.ProductVersion)
        End If


    End Function
End Class
