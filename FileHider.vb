Imports System.IO

Public Class FileHider
    Dim EncryptionMode = True
    Dim MsgNotSupported = "Sorry, But The Feature Is Currently Disabled/Unavailable! Please Try Again Later, or wait for the next Update, Thanks!"

    Private Sub FileHider_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_GoBack.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_BrowseFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select a file to Hide/Embed"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            TextBox_SourceFile.Text = strFileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_BrowseSaveFile.Click
        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim SaveFile As String


        fd.Title = "Select Output Location/File"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            SaveFile = fd.FileName
            TextBox_OutputFile.Text = SaveFile
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_SelectMode.Click
        Dim EncryptTextLabel = "MODE = ENCRYPT (Toggle)"
        Dim DecryptTextLabel = "MODE = DECRYPT (Toggle)"

        Dim EncryptEmbedLabel = "File to Embed... (BROWSE)"
        Dim DecryptEmbedLabel = "File to Extract... (BROWSE)"


        If EncryptionMode = False Then

            Button_Start.Text = "ENCRYPT"
            TextBox_SourceFile.PlaceholderText = EncryptEmbedLabel
            Button_SelectMode.Text = EncryptTextLabel
            Button_SelectMode.ForeColor = Color.LawnGreen
            EncryptionMode = True
        Else

            Button_Start.Text = "DECRYPT"
            TextBox_SourceFile.PlaceholderText = DecryptEmbedLabel
            Button_SelectMode.Text = DecryptTextLabel
            Button_SelectMode.ForeColor = Color.Blue
            EncryptionMode = False
        End If
    End Sub

    Private Sub RadioButton_CMD_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton_INTERNAL_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_PasswordSettings_Click(sender As Object, e As EventArgs) Handles Button_PasswordSettings.Click
        If Button_PasswordSettings.ForeColor = Color.Red Then
            MsgBox("Unable To Perform Encryption in External/CMD mode!")
        Else
            MsgBox(MsgNotSupported, MsgBoxStyle.Exclamation, "Unavailable")
        End If


    End Sub

    Sub systemcmd(ByVal cmd As String)
        Shell("cmd /c """ & cmd & """", AppWinStyle.MinimizedFocus, True)
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        ''' Check If Input/Output Boxes Are Valid, If So = Proceed
        ''' Next Step, If Internal - Execute Commands Through System() Calls
        ''' If External - Call (cmd.exe /c xxxxxxxx)
        ''' 
        If My.Computer.FileSystem.FileExists(TextBox_SourceFile.Text) = False Then
            MsgBox("The Application Coudn't Locate The File! (Error: 404) - Change The File's Location Or Try Another File!", MsgBoxStyle.Exclamation, "Error")
        ElseIf My.Computer.FileSystem.DirectoryExists(TextBox_OutputFile.Text.Substring(0, TextBox_OutputFile.Text.Length - (TextBox_OutputFile.Text.Length - TextBox_OutputFile.Text.LastIndexOf("\")))) = False Then
            MsgBox("The Application Coudn't Open The Output Directory! - Change The Output Location!", MsgBoxStyle.Exclamation, "Error")

        Else

            ''' CONTINUE
            ''' Next, Generate Payload and Execute
            Dim Payload_Encrypt = "type """ & TextBox_SourceFile.Text & """ > """ & TextBox_OutputFile.Text & ":encrypted.dat"""
            Dim Payload_Decrypt = "expand """ & TextBox_SourceFile.Text & ":encrypted.dat"" """ & TextBox_OutputFile.Text & """"

            If EncryptionMode = True Then ''' ENCRYPT MODE '''

                If RadioButton_Internal.Checked = True Then
                    If CheckBox_Debug.Checked = True Then
                        MsgBox("DEBUG_OUTPUT: " & Payload_Encrypt)
                    End If
                    systemcmd(Payload_Encrypt)

                ElseIf RadioButton_CMD.Checked = True Then
                    '''MsgBox(MsgNotSupported, MsgBoxStyle.Exclamation, "Unavailable")
                    '''
                    Dim fs As FileStream = Nothing
                    Dim sw As StreamWriter

                    If (File.Exists("exec.bat")) Then
                        My.Computer.FileSystem.DeleteFile("exec.bat")
                    Else
                        fs = File.Create("exec.bat")
                        fs.DisposeAsync()
                        fs.Close()
                    End If

                    sw = File.AppendText("exec.bat")
                    sw.WriteLine(Payload_Encrypt)
                    sw.DisposeAsync()
                    sw.Close()

                    System.Diagnostics.Process.Start("exec.bat")
                    If (File.Exists("exec.bat")) Then
                        My.Computer.FileSystem.DeleteFile("exec.bat")
                    End If

                End If

                If CheckBox_DeleteSource.Checked = True Then
                    My.Computer.FileSystem.DeleteFile(TextBox_SourceFile.Text)
                End If
                MsgBox("Encryption Process Complete! If 'Delete Source' Option was selected, Original file was Deleted!", MsgBoxStyle.Information, "Success")
            Else                           ''' DECRYPT MODE '''

                If RadioButton_Internal.Checked = True Then
                    If CheckBox_Debug.Checked = True Then
                        MsgBox("DEBUG_OUTPUT: " & Payload_Decrypt)
                    End If
                    systemcmd(Payload_Decrypt)

                ElseIf RadioButton_CMD.Checked = True Then
                    '''MsgBox(MsgNotSupported, MsgBoxStyle.Exclamation, "Unavailable")
                    '''
                    Dim fs As FileStream = Nothing
                    Dim sw As StreamWriter
                    If (File.Exists("exec.bat")) Then
                        My.Computer.FileSystem.DeleteFile("exec.bat")
                    Else
                        fs = File.Create("exec.bat")
                        fs.DisposeAsync()
                        fs.Close()
                    End If

                    sw = File.AppendText("exec.bat")
                    sw.WriteLine(Payload_Decrypt)
                    sw.DisposeAsync()
                    sw.Close()

                    System.Diagnostics.Process.Start("exec.bat")
                    If (File.Exists("exec.bat")) Then
                        My.Computer.FileSystem.DeleteFile("exec.bat")
                    End If

                End If

                If CheckBox_DeleteSource.Checked = True Then
                    Shell("cmd /c rm """ & TextBox_SourceFile.Text & """")
                End If
                MsgBox("Decryption Process Complete! If 'Delete Source' Option was selected, Original file was Deleted!", MsgBoxStyle.Information, "Success")
                If MsgBox("Open Extracted File?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Shell("cmd /c """ & TextBox_OutputFile.Text & """")
                End If


            End If
        End If


    End Sub

    Private Sub CheckBox_Debug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Debug.CheckedChanged
        If CheckBox_Debug.Checked = True Then
            CheckBox_Debug.ForeColor = Color.Lime
        Else
            CheckBox_Debug.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub CheckBox_DeleteSource_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DeleteSource.CheckedChanged
        If CheckBox_DeleteSource.Checked = True Then
            CheckBox_DeleteSource.ForeColor = Color.Red
        Else
            CheckBox_DeleteSource.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub RadioButton_Internal_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton_Internal.CheckedChanged

        If RadioButton_Internal.Checked = 1 Then
            Button_PasswordSettings.ForeColor = Color.Orange
            RadioButton_Internal.ForeColor = Color.Lime
            RadioButton_CMD.ForeColor = Color.Orange

        Else
            Button_PasswordSettings.ForeColor = Color.Orange
            RadioButton_CMD.ForeColor = Color.Orange
            RadioButton_Internal.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub RadioButton_CMD_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton_CMD.CheckedChanged
        If RadioButton_CMD.Checked = 1 Then
            Button_PasswordSettings.ForeColor = Color.Red
            RadioButton_CMD.ForeColor = Color.Lime
            RadioButton_Internal.ForeColor = Color.Red
        Else
            Button_PasswordSettings.ForeColor = Color.Red
            RadioButton_Internal.ForeColor = Color.Orange
            RadioButton_CMD.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub FileHider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class