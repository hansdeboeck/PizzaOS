Imports System.Net
Imports System.IO

Public Class online
    Friend Shared Async Function checklicence(name As String) As Task(Of Integer)

        Dim page As String = onlinecheckapi("https://pizzaos.hacemedia.com/api/online.php?naam=" & name)
        If page = name Then

        Else
            Licentie.Show()
            Getstarted.Timer1.Stop()
            Getstarted.Hide()
            Getstarted.ShowInTaskbar = False

        End If

    End Function
    Friend Shared Function onlinecheckapi(ByVal pageUrl As String) As String
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
End Class
