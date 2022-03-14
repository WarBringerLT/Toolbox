Public Class FilePumper

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Browse.Click
        Dim ofd As New OpenFileDialog
        '''ofd.Filter = "Exe Files|*.exe"
        '''
        ofd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        ofd.ShowDialog()
        Textbox_FileLocation.Text = ofd.FileName

    End Sub

    Private Sub Button_Pump_Click(sender As Object, e As EventArgs) Handles Button_Pump.Click
        Dim sfd As New SaveFileDialog
        Dim filesize As Double = Val(Numeric_Value.Value)

        If RadioButton_NewFile.Checked = True Then
            sfd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            sfd.ShowDialog()
        ElseIf RadioButton_SameFile.Checked = True Then
            sfd.FileName = Textbox_FileLocation.Text
        End If

        Try
            IO.File.Copy(Textbox_FileLocation.Text, sfd.FileName)
        Catch ex As Exception

        End Try

        If RadioButton_KB.Checked Then
            filesize = filesize * 1024
        End If
        If RadioButton_MB.Checked Then
            filesize = filesize * 1048576
        End If


        Dim filetopump = IO.File.OpenWrite(sfd.FileName)
        Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])

        If filesize < size Then
            MsgBox("File size is already larger! - Increase the total file size target if needed.", MsgBoxStyle.Exclamation, "Failed To Pump File!")
        Else

            While size < filesize
                filetopump.WriteByte(0)
                size += 1
            End While
            filetopump.Close()
            Dim StatsMsg = "[Total Size Pumped:" & Str(Math.Round(filesize / 1024, 1)) & "KB (" & Str(Math.Round(filesize / 1048576, 1)) & "MB )]"
            MsgBox("Pump Was Successfully Applied! " & StatsMsg)
        End If

    End Sub


    Private Sub FilePumper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button_GoBack_Click(sender As Object, e As EventArgs) Handles Button_GoBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FileHider_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Form1.Show()
            Me.Hide()
        End If

    End Sub
End Class