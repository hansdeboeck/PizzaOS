Imports System.Net
Imports System.IO

Public Class Checklicence
    Friend Shared Function GetPage(ByVal pageUrl As String) As String
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

    Friend Shared Async Function check(name As String) As Task(Of Integer)

        Dim page As String = GetPage("https://pizzaos.hacemedia.com/api/check.php?naam=" & name)
        If page = name Then
            If System.IO.File.Exists("C:\PizzaOS\DONTDELETEME") Then
                My.Computer.FileSystem.DeleteFile("C:\PizzaOS\DONTDELETEME")
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & name, "C: \PizzaOS\DONTDELETEME")
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & name, "C:\PizzaOS\config\user.txt")
                MsgBox("Restart Requirerd")
                Getstarted.Close()
            Else
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & name, "C:\PizzaOS\DONTDELETEME")
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & name, "C:\PizzaOS\config\user.txt")
                MsgBox("Restart Requirerd")
                Getstarted.Close()
            End If

        Else

        End If

    End Function

End Class