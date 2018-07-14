Imports System.Net
Imports System.IO

Public Class checkupdate

    Friend Shared Function updatecheck2(ByVal pageUrl As String) As String
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


    Friend Shared Function xxx()
        Getstarted.Label1.Text = "Controleren op updates"
        Dim updatepage As String = updatecheck2("https://pizzaos.hacemedia.com/api/update.php")
        If updatepage = Application.ProductVersion Then

        Else
            MsgBox("Er is een update beschikbaar, deze zal eerst moeten geinstaleerd worden voor je verder gaat.", MsgBoxStyle.Critical)
            If vbOK Then
                Process.Start("http://pizzaos.hacemedia.com/download/" & updatepage)
                Getstarted.Close()
            End If
        End If
    End Function



End Class
