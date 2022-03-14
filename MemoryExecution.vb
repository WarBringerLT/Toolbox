Imports System.IO
Imports System.Reflection

Public Class MemoryExecution
    Private Sub Button_GoBack_Click(sender As Object, e As EventArgs) Handles Button_GoBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Browse_Click(sender As Object, e As EventArgs) Handles Button_Browse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Exe Files (.exe)|*.exe"
        ofd.ShowDialog()
        TextBox_FileLocation.Text = ofd.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Execute.Click
        ''' Dim data() As Byte = File.ReadAllBytes(TextBox_FileLocation.Text)
        '''RunPE.mRunpe.InjectPE(data, "toolbox.exe")
    End Sub

    Private Sub FileHider_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Form1.Show()
            Me.Hide()
        End If

    End Sub
End Class