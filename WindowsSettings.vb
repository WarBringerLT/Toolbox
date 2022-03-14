Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Public Class WindowsSettings

    Dim Setup = True
    Dim Escalated = False
    Dim desktopPath = My.Computer.FileSystem.SpecialDirectories.Desktop
    Dim full_GodMode_Path = desktopPath + "/GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}"
    Dim identity = WindowsIdentity.GetCurrent()
    Dim principal = New WindowsPrincipal(identity)
    Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)

    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True)>
    Shared Function SendMessage(
        ByVal hWnd As IntPtr,
        ByVal Msg As UInt32,
        ByVal wParam As Integer,
        ByVal lParam As IntPtr) _
        As Integer
    End Function
    Const BCM_SETSHIELD As UInt32 = &H160C

    Private Sub Button_GoBack_Click(sender As Object, e As EventArgs) Handles Button_GoBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox_GodMode_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_GodMode.CheckedChanged

        If Not (Setup = True) Then

            If (CheckBox_GodMode.Checked = True) Then
                Try
                    My.Computer.FileSystem.CreateDirectory(full_GodMode_Path)
                    MsgBox("'GodMode' Folder Was Created Succesfully!" & vbCrLf & "Look for an unnamed shortcut with a control panel icon.", MsgBoxStyle.Information, "Success!")
                Catch ex As Exception
                    MsgBox(ex)
                End Try

            ElseIf CheckBox_GodMode.Checked = False Then
                Try
                    My.Computer.FileSystem.DeleteDirectory(full_GodMode_Path, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    MsgBox("'GodMode' Folder was Disabled/Removed!", MsgBoxStyle.Information, "Success!")

                Catch ex As Exception
                    MsgBox(ex)
                End Try

            End If



        End If
    End Sub

    Private Sub Button_TaskMgr_Click(sender As Object, e As EventArgs) Handles Button_TaskMgr.Click
        Shell("cmd /c taskmgr && exit")
    End Sub

    Private Sub Button_RegEdit_Click(sender As Object, e As EventArgs) Handles Button_RegEdit.Click
        Shell("cmd /c regedit && exit")
    End Sub

    Private Sub Button_Devmgmt_Click(sender As Object, e As EventArgs) Handles Button_Devmgmt.Click
        Shell("cmd /c devmgmt && exit")
    End Sub

    Private Sub Button_msconfig_Click(sender As Object, e As EventArgs) Handles Button_msconfig.Click
        Shell("cmd /c msconfig && exit")
    End Sub

    Private Sub Button_TaskScheduler_Click(sender As Object, e As EventArgs) Handles Button_TaskScheduler.Click
        Shell("cmd /c taskschd && exit")
    End Sub

    Private Sub Button_CMD_Click(sender As Object, e As EventArgs) Handles Button_CMD.Click
        Shell("cmd /c start")
    End Sub

    Private Sub Button_Powershell_Click(sender As Object, e As EventArgs) Handles Button_Powershell.Click
        Shell("cmd /c powershell")
    End Sub

    Private Sub CheckBox_TaskManager_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_TaskManager.CheckedChanged



        If Not (Setup = True) Then
            Try
                Dim systemRegistry As RegistryKey = Registry.CurrentUser.CreateSubKey(“Software\Microsoft\Windows\CurrentVersion\Policies\System”)


                If CheckBox_TaskManager.Checked = True And Escalated = True Then
                    systemRegistry.SetValue(“DisableTaskMgr”, 1)
                    MsgBox("Task Manager Has Been Disabled Successfully!", MsgBoxStyle.Information, "Disabled!")

                    systemRegistry.Close()
                ElseIf CheckBox_TaskManager.Checked = True And Escalated = False Then
                    CheckBox_TaskManager.Checked = False
                Else
                    systemRegistry.SetValue(“DisableTaskMgr”, 0)
                    systemRegistry.DeleteSubKey("DisableTaskMgr")
                    MsgBox("Task Manager Has Been Re-Enabled Successfully!", MsgBoxStyle.Information, "Re-Enabled!")
                End If
            Catch ex As System.UnauthorizedAccessException

                If MsgBox("Failed (Most Likely because the program is not elevated." & vbCrLf & "Would You Like To Restart In Elevated Mode? (UAC)", MsgBoxStyle.YesNo, "Failed") = MsgBoxResult.Yes Then
                    Escalate()
                End If

            Catch ex As System.ArgumentException
                MsgBox("Attempted to delete the registry key files - already deleted", MsgBoxStyle.Information, "Warning")
            End Try
        End If



    End Sub

    Private Sub CheckBox_CMD_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_CMD.CheckedChanged

        If Not Setup = True Then
            Try
                Dim systemRegistry As RegistryKey = Registry.CurrentUser.CreateSubKey(“Software\Policies\Microsoft\Windows\System”)

                If CheckBox_CMD.Checked = True And Escalated = True Then
                    systemRegistry.SetValue(“DisableCMD”, 1)
                    MsgBox("Command Prompt Has Been Disabled Successfully!", MsgBoxStyle.Information, "Disabled!")

                    systemRegistry.Close()
                ElseIf CheckBox_CMD.Checked = True And Escalated = False Then
                    CheckBox_CMD.Checked = False
                Else
                    systemRegistry.SetValue(“DisableCMD”, 0)
                    systemRegistry.DeleteSubKey("DisableCMD")
                    MsgBox("Command Prompt Has Been Re-Enabled Successfully!", MsgBoxStyle.Information, "Re-Enabled!")
                End If
            Catch ex As System.UnauthorizedAccessException

                If MsgBox("Failed (Most Likely because the program is not elevated." & vbCrLf & "Would You Like To Restart In Elevated Mode? (UAC)", MsgBoxStyle.YesNo, "Failed") = MsgBoxResult.Yes Then
                    Escalate()
                End If

            Catch ex As System.ArgumentException
                MsgBox("Attempted to delete the registry key files - already deleted", MsgBoxStyle.Information, "Warning")
            End Try
        End If


    End Sub

    Private Sub CheckBox_EscalatedStatus_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_EscalatedStatus.CheckedChanged
        If CheckBox_EscalatedStatus.Checked = True And Escalated = False Then
            Escalate()
        ElseIf CheckBox_EscalatedStatus.Checked = True And Escalated = True Then
            ' Do Nothing
        ElseIf CheckBox_EscalatedStatus.Checked = False And Escalated = True Then
            CheckBox_EscalatedStatus.Checked = True
        End If
    End Sub

    Private Sub WindowsSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Setup = True

        If isElevated Then
            Escalated = True
            CheckBox_EscalatedStatus.Checked = True
        End If


        If My.Computer.FileSystem.DirectoryExists(full_GodMode_Path) Then
            CheckBox_GodMode.Checked = True
        End If

        Dim Status_Taskmgr = Registry.CurrentUser.GetValue(“Software\Microsoft\Windows\CurrentVersion\Policies\System\”, "DisableTaskMgr", Nothing)
        Dim Status_CMD = Registry.CurrentUser.GetValue("Software\Policies\Microsoft\Windows\System\", "DisableCMD", Nothing)
        If Status_Taskmgr = "1" Then
            CheckBox_TaskManager.Checked = True
        Else
            CheckBox_TaskManager.Checked = False
        End If
        If Status_CMD = "1" Then
            CheckBox_CMD.Checked = True
        Else
            CheckBox_CMD.Checked = False
        End If

        Setup = False
    End Sub


    Sub Escalate()
        Dim proc As New ProcessStartInfo
        proc.UseShellExecute = True
        proc.WorkingDirectory = Environment.CurrentDirectory
        proc.FileName = Application.ExecutablePath
        proc.Verb = "runas"

        Try
            Process.Start(proc)
        Catch
            MsgBox("Failed to Escalate! Exit code handled, Returning to normal operation.")
            Return
        End Try

        Application.Exit()
    End Sub


End Class