﻿Imports System.Net
Imports System.IO
Imports System.Diagnostics

Public Class NoPizza_Firstime
    Dim pogingen As Integer = 3
    Function GetPage(ByVal pageUrl As String) As String
        Dim s As String = ""
        Try
            Dim request As HttpWebRequest = WebRequest.Create(pageUrl)
            Dim response As HttpWebResponse = request.GetResponse()
            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                s = reader.ReadToEnd()
            End Using
        Catch ex As Exception
            Label2.Text = ("FAIL: " + ex.Message)
        End Try
        Return s
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim page As String = GetPage("https://pizzaos.hacemedia.com/api/check.php?naam=" & TextBox1.Text)
        If page = TextBox1.Text Then
            If System.IO.File.Exists("C:\PizzaOS\DONTDELETEME") Then
                Label2.Visible = True
                Label2.Text = "Pizza's worden gedownload"
                My.Computer.FileSystem.DeleteFile("C:\PizzaOS\DONTDELETEME")
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & TextBox1.Text, "C: \PizzaOS\DONTDELETEME")
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & TextBox1.Text, "C:\PizzaOS\config\user.txt")
                Restart.Show()
                Me.Close()
            Else
                Label2.Visible = True
                Label2.Text = "Pizza's worden gedownload"
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & TextBox1.Text, "C:\PizzaOS\DONTDELETEME")
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php?naam=" & TextBox1.Text, "C:\PizzaOS\config\user.txt")
                Restart.Show()
                Me.Close()
            End If

        Else
            If page = "LICENTIE" Then
                Label2.Visible = True
                Label2.Text = "Je licentie is verlopen"
                MsgBox("licentie")
                Licentie.Show()
                Me.Close()
            End If
            If pogingen = 1 Then
                    MsgBox("Laatse waarschuwing! Je hebt nog maar 1 poging neem contact op met je account manager", MsgBoxStyle.Critical)
                End If
            If pogingen = 0 Then
                My.Computer.Network.DownloadFile("https://pizzaos.hacemedia.com/api/create.php", "C:\PizzaOS\black.txt")
                MsgBox("Tijdelijk geblokkeerd", MsgBoxStyle.Critical)
                Getstarted.Close()
            End If
            Label2.Visible = True
            Label2.Text = "Opgepast! Je hebt nog maar " & pogingen & " pogingen. Dan word je geblokeerd door ons programma"
            pogingen = pogingen - 1
            End If

    End Sub

    Private Sub NoPizza_Firstime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getstarted.Visible = False
        Getstarted.Opacity = 0%
        Label3.Text = "PizzaOS v" & Application.ProductVersion
        TextBox1.Select()
    End Sub
End Class