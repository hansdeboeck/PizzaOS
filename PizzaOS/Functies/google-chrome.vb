Public Class google_chrome


    Friend Shared Function CheckIfRunning()
        Dim p() As Process
        p = Process.GetProcessesByName("chrome")
        If p.Count > 0 Then

            Dim foo() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses

            For Each temp As Diagnostics.Process In foo



                If temp.ProcessName = "chrome" Then

                    ' temp.Kill() -- verwijder comment
                    Exit For
                End If
            Next
        End If
        End

    End Function

    Friend Shared Function CheckIfinstalled()
        If Not System.IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
            Process.Start("https://www.google.com/chrome/")
        End If
    End Function

End Class
