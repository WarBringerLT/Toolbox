<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowsSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowsSettings))
        Me.CheckBox_GodMode = New System.Windows.Forms.CheckBox()
        Me.CheckBox_TaskManager = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Defender = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CMD = New System.Windows.Forms.CheckBox()
        Me.Button_GoBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip_Engine = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_TaskMgr = New System.Windows.Forms.Button()
        Me.Button_RegEdit = New System.Windows.Forms.Button()
        Me.Button_msconfig = New System.Windows.Forms.Button()
        Me.Button_Devmgmt = New System.Windows.Forms.Button()
        Me.Button_TaskScheduler = New System.Windows.Forms.Button()
        Me.Button_CMD = New System.Windows.Forms.Button()
        Me.Button_Powershell = New System.Windows.Forms.Button()
        Me.CheckBox_EscalatedStatus = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox_GodMode
        '
        Me.CheckBox_GodMode.AutoSize = True
        Me.CheckBox_GodMode.Location = New System.Drawing.Point(9, 23)
        Me.CheckBox_GodMode.Name = "CheckBox_GodMode"
        Me.CheckBox_GodMode.Size = New System.Drawing.Size(321, 27)
        Me.CheckBox_GodMode.TabIndex = 0
        Me.CheckBox_GodMode.Text = "Enable / Disable Windows God Mode Folder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip_Engine.SetToolTip(Me.CheckBox_GodMode, resources.GetString("CheckBox_GodMode.ToolTip"))
        Me.CheckBox_GodMode.UseVisualStyleBackColor = True
        '
        'CheckBox_TaskManager
        '
        Me.CheckBox_TaskManager.AutoSize = True
        Me.CheckBox_TaskManager.Location = New System.Drawing.Point(9, 45)
        Me.CheckBox_TaskManager.Name = "CheckBox_TaskManager"
        Me.CheckBox_TaskManager.Size = New System.Drawing.Size(301, 27)
        Me.CheckBox_TaskManager.TabIndex = 1
        Me.CheckBox_TaskManager.Text = "Enable / Disable Windows Task Manager"
        Me.ToolTip_Engine.SetToolTip(Me.CheckBox_TaskManager, "Exactly what the title says - Enable or Disable Windows Task Manager." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depends on" &
        " Windows Registry. (regedit)")
        Me.CheckBox_TaskManager.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_Defender)
        Me.GroupBox1.Controls.Add(Me.CheckBox_CMD)
        Me.GroupBox1.Controls.Add(Me.CheckBox_GodMode)
        Me.GroupBox1.Controls.Add(Me.CheckBox_TaskManager)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 122)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toggles"
        '
        'CheckBox_Defender
        '
        Me.CheckBox_Defender.AutoSize = True
        Me.CheckBox_Defender.Enabled = False
        Me.CheckBox_Defender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Defender.Location = New System.Drawing.Point(10, 87)
        Me.CheckBox_Defender.Name = "CheckBox_Defender"
        Me.CheckBox_Defender.Size = New System.Drawing.Size(265, 27)
        Me.CheckBox_Defender.TabIndex = 3
        Me.CheckBox_Defender.Text = "Enable / Disable Windows Defender"
        Me.ToolTip_Engine.SetToolTip(Me.CheckBox_Defender, "Exactly what the title says - Enable or Disable Windows Task Manager." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depends on" &
        " Windows Registry. (regedit)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* CURRENTLY DISABLED *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.CheckBox_Defender.UseVisualStyleBackColor = True
        '
        'CheckBox_CMD
        '
        Me.CheckBox_CMD.AutoSize = True
        Me.CheckBox_CMD.Location = New System.Drawing.Point(10, 66)
        Me.CheckBox_CMD.Name = "CheckBox_CMD"
        Me.CheckBox_CMD.Size = New System.Drawing.Size(268, 27)
        Me.CheckBox_CMD.TabIndex = 2
        Me.CheckBox_CMD.Text = "Enable / Disable Command Prompt"
        Me.ToolTip_Engine.SetToolTip(Me.CheckBox_CMD, "Exactly what the title says - Enable or Disable Windows Task Manager." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depends on" &
        " Windows Registry. (regedit)")
        Me.CheckBox_CMD.UseVisualStyleBackColor = True
        '
        'Button_GoBack
        '
        Me.Button_GoBack.BackColor = System.Drawing.Color.Black
        Me.Button_GoBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_GoBack.ForeColor = System.Drawing.Color.Red
        Me.Button_GoBack.Location = New System.Drawing.Point(247, 416)
        Me.Button_GoBack.Name = "Button_GoBack"
        Me.Button_GoBack.Size = New System.Drawing.Size(104, 38)
        Me.Button_GoBack.TabIndex = 7
        Me.Button_GoBack.Text = "Go Back >>"
        Me.Button_GoBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(38, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "More Will Be Added Soon :)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(1, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 46)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "*Hint: Tooltips are enabled. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hover over settings to see more info"
        '
        'ToolTip_Engine
        '
        Me.ToolTip_Engine.AutomaticDelay = 100
        Me.ToolTip_Engine.AutoPopDelay = 10000
        Me.ToolTip_Engine.InitialDelay = 100
        Me.ToolTip_Engine.ReshowDelay = 20
        '
        'Button_TaskMgr
        '
        Me.Button_TaskMgr.BackColor = System.Drawing.Color.Black
        Me.Button_TaskMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TaskMgr.Location = New System.Drawing.Point(10, 26)
        Me.Button_TaskMgr.Name = "Button_TaskMgr"
        Me.Button_TaskMgr.Size = New System.Drawing.Size(120, 39)
        Me.Button_TaskMgr.TabIndex = 0
        Me.Button_TaskMgr.Text = "Task Manager"
        Me.ToolTip_Engine.SetToolTip(Me.Button_TaskMgr, "Launch Task Manager")
        Me.Button_TaskMgr.UseVisualStyleBackColor = False
        '
        'Button_RegEdit
        '
        Me.Button_RegEdit.BackColor = System.Drawing.Color.Black
        Me.Button_RegEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_RegEdit.Location = New System.Drawing.Point(128, 26)
        Me.Button_RegEdit.Name = "Button_RegEdit"
        Me.Button_RegEdit.Size = New System.Drawing.Size(92, 39)
        Me.Button_RegEdit.TabIndex = 1
        Me.Button_RegEdit.Text = "RegEdit"
        Me.ToolTip_Engine.SetToolTip(Me.Button_RegEdit, "Launch Registry Editor (regedit.exe)")
        Me.Button_RegEdit.UseVisualStyleBackColor = False
        '
        'Button_msconfig
        '
        Me.Button_msconfig.BackColor = System.Drawing.Color.Black
        Me.Button_msconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_msconfig.Location = New System.Drawing.Point(10, 71)
        Me.Button_msconfig.Name = "Button_msconfig"
        Me.Button_msconfig.Size = New System.Drawing.Size(94, 39)
        Me.Button_msconfig.TabIndex = 2
        Me.Button_msconfig.Text = "msconfig"
        Me.ToolTip_Engine.SetToolTip(Me.Button_msconfig, "Launch Windows Boot Configuration (msconfig)")
        Me.Button_msconfig.UseVisualStyleBackColor = False
        '
        'Button_Devmgmt
        '
        Me.Button_Devmgmt.BackColor = System.Drawing.Color.Black
        Me.Button_Devmgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Devmgmt.Location = New System.Drawing.Point(217, 26)
        Me.Button_Devmgmt.Name = "Button_Devmgmt"
        Me.Button_Devmgmt.Size = New System.Drawing.Size(111, 39)
        Me.Button_Devmgmt.TabIndex = 3
        Me.Button_Devmgmt.Text = "Devmgmt.msc"
        Me.ToolTip_Engine.SetToolTip(Me.Button_Devmgmt, "Launch Device Management Utility (devmgmt.msc)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button_Devmgmt.UseVisualStyleBackColor = False
        '
        'Button_TaskScheduler
        '
        Me.Button_TaskScheduler.BackColor = System.Drawing.Color.Black
        Me.Button_TaskScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_TaskScheduler.Location = New System.Drawing.Point(101, 71)
        Me.Button_TaskScheduler.Name = "Button_TaskScheduler"
        Me.Button_TaskScheduler.Size = New System.Drawing.Size(136, 39)
        Me.Button_TaskScheduler.TabIndex = 4
        Me.Button_TaskScheduler.Text = "Task Scheduler"
        Me.ToolTip_Engine.SetToolTip(Me.Button_TaskScheduler, "Launch Windows Task Scheduler")
        Me.Button_TaskScheduler.UseVisualStyleBackColor = False
        '
        'Button_CMD
        '
        Me.Button_CMD.BackColor = System.Drawing.Color.Black
        Me.Button_CMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CMD.Location = New System.Drawing.Point(229, 71)
        Me.Button_CMD.Name = "Button_CMD"
        Me.Button_CMD.Size = New System.Drawing.Size(99, 39)
        Me.Button_CMD.TabIndex = 5
        Me.Button_CMD.Text = "CMD"
        Me.ToolTip_Engine.SetToolTip(Me.Button_CMD, "Launch Windows Command Prompt (cmd.exe)")
        Me.Button_CMD.UseVisualStyleBackColor = False
        '
        'Button_Powershell
        '
        Me.Button_Powershell.BackColor = System.Drawing.Color.Black
        Me.Button_Powershell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Powershell.Location = New System.Drawing.Point(10, 116)
        Me.Button_Powershell.Name = "Button_Powershell"
        Me.Button_Powershell.Size = New System.Drawing.Size(101, 39)
        Me.Button_Powershell.TabIndex = 6
        Me.Button_Powershell.Text = "PowerShell"
        Me.ToolTip_Engine.SetToolTip(Me.Button_Powershell, "Launch Windows PowerShell")
        Me.Button_Powershell.UseVisualStyleBackColor = False
        '
        'CheckBox_EscalatedStatus
        '
        Me.CheckBox_EscalatedStatus.AutoSize = True
        Me.CheckBox_EscalatedStatus.Location = New System.Drawing.Point(216, 303)
        Me.CheckBox_EscalatedStatus.Name = "CheckBox_EscalatedStatus"
        Me.CheckBox_EscalatedStatus.Size = New System.Drawing.Size(135, 27)
        Me.CheckBox_EscalatedStatus.TabIndex = 11
        Me.CheckBox_EscalatedStatus.Text = "Escalated Mode"
        Me.ToolTip_Engine.SetToolTip(Me.CheckBox_EscalatedStatus, "Controls Whether this instance will have access" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to UAC Admin-Rights. If It's in " &
        """Checked"" state it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "means that the program is running in escalated mode.")
        Me.CheckBox_EscalatedStatus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_Powershell)
        Me.GroupBox2.Controls.Add(Me.Button_CMD)
        Me.GroupBox2.Controls.Add(Me.Button_TaskScheduler)
        Me.GroupBox2.Controls.Add(Me.Button_Devmgmt)
        Me.GroupBox2.Controls.Add(Me.Button_msconfig)
        Me.GroupBox2.Controls.Add(Me.Button_RegEdit)
        Me.GroupBox2.Controls.Add(Me.Button_TaskMgr)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 169)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shortcuts"
        '
        'WindowsSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(363, 466)
        Me.Controls.Add(Me.CheckBox_EscalatedStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_GoBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Print", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Orange
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WindowsSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox_GodMode As CheckBox
    Friend WithEvents CheckBox_TaskManager As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_GoBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip_Engine As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button_TaskMgr As Button
    Friend WithEvents Button_Powershell As Button
    Friend WithEvents Button_CMD As Button
    Friend WithEvents Button_TaskScheduler As Button
    Friend WithEvents Button_Devmgmt As Button
    Friend WithEvents Button_msconfig As Button
    Friend WithEvents Button_RegEdit As Button
    Friend WithEvents CheckBox_CMD As CheckBox
    Friend WithEvents CheckBox_EscalatedStatus As CheckBox
    Friend WithEvents CheckBox_Defender As CheckBox
End Class
