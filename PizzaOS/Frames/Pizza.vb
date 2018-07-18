Imports System.Net
Imports System.IO

Public Class Pizza
    Private Sub Pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PizzaLogBox.Text = PizzaLogBox.Text + "PizzaOS " + Application.ProductVersion + " opgestart" + vbNewLine
        Getstarted.Hide()
        Getstarted.ShowInTaskbar = False
        Me.ShowInTaskbar = False
        Me.Visible = False
        TimerSEC.Start()
        TimerUUR.Start()
        TimerMIN.Start()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub


    Private Sub InstellingenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstellingenToolStripMenuItem.Click

    End Sub

    Private Sub AfsluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfsluitenToolStripMenuItem.Click
        PizzaNotify.BalloonTipIcon = ToolTipIcon.Error
        PizzaNotify.BalloonTipTitle = "PizzaOS v" & Application.ProductVersion
        PizzaNotify.BalloonTipText = "PizzaOS is afgesloten"
        PizzaNotify.ShowBalloonTip(50)
        Getstarted.Close()

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub TimerMIN_Tick(sender As Object, e As EventArgs) Handles TimerMIN.Tick
        Dim schermnaam As String
        schermnaam = My.Computer.FileSystem.ReadAllText("C:\PizzaOS\config\user.txt")
        online.onlinecheckapi(schermnaam)
    End Sub
End Class