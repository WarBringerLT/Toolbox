Public Class Form1
    Dim PreventKill = True
    Dim BorderColour = Color.Red
    Dim RR, GG, BB
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

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, BorderColour, 3, ButtonBorderStyle.Solid, BorderColour, 3, ButtonBorderStyle.Solid, BorderColour, 3, ButtonBorderStyle.Solid, BorderColour, 3, ButtonBorderStyle.Solid)

        ''' e.Graphics.DrawRectangle(BorderColour, 0, 0, Me.Width, 1)
        ''' e.Graphics.DrawRectangle(BorderColour, 0, 0, Me.Width - 3, 0)
        '''  e.Graphics.DrawRectangle(BorderColour, 0, 0, Me.Width - 19, Me.Height - 50)
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


    Sub CloseApp()
        PreventKill = False

        FilePumper.Dispose()
        FileHider.Dispose()
        MemoryExecution.Dispose()
        FileHider.Close()
        FilePumper.Close()
        MemoryExecution.Close()

        Me.Close()
    End Sub



    Private Sub Timer_Rainbow_Tick(sender As Object, e As EventArgs) Handles Timer_Rainbow.Tick
        While RR < 255
            While GG < 255
                While BB < 255
                    BB += 1
                End While
                While BB > 1
                    BB -= 1
                End While
                GG += 1
            End While
            While GG > 1
                GG -= 1
            End While
            RR += 1
        End While
        BorderColour = Color.FromArgb(255, RR, GG, BB)
    End Sub
End Class
