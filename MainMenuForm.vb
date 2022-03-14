Public Class Form1
    Dim PreventKill = True

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing And PreventKill = True Then
            e.Cancel = True

            If MsgBox("Are you sure that you'd like to Exit This App?" & vbCrLf & "Thank you for trying it out!" & vbCrLf & "-WarBringerLT", MsgBoxStyle.YesNo, "Exit?").Equals(MsgBoxResult.Yes) = True Then
                CloseApp()
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label_Version.Text += "1.01b"
        FileHider.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_FileHiderMenu.Click

        FileHider.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FilePumper.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CloseApp()
    End Sub

    Private Sub Button_MemoryExecution_Click(sender As Object, e As EventArgs) Handles Button_MemoryExecution.Click
        MemoryExecution.Show()
        Me.Hide()
    End Sub

    Private Sub Button_WindowsSettings_Click(sender As Object, e As EventArgs) Handles Button_WindowsSettings.Click
        WindowsSettings.Show()
        Me.Hide()
    End Sub

    Sub CloseApp()
        PreventKill = False

        WindowsSettings.Dispose()
        FilePumper.Dispose()
        FileHider.Dispose()
        MemoryExecution.Dispose()

        FileHider.Close()
        FilePumper.Close()
        MemoryExecution.Close()
        WindowsSettings.Close()

        Me.Close()
    End Sub
End Class
