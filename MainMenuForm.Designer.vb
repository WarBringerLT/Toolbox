<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_FileHiderMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_MemoryExecution = New System.Windows.Forms.Button()
        Me.ToolTip_Manager = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_WindowsSettings = New System.Windows.Forms.Button()
        Me.Timer_Rainbow = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_FileHiderMenu
        '
        Me.Button_FileHiderMenu.BackColor = System.Drawing.Color.Black
        Me.Button_FileHiderMenu.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button_FileHiderMenu.Location = New System.Drawing.Point(12, 279)
        Me.Button_FileHiderMenu.Name = "Button_FileHiderMenu"
        Me.Button_FileHiderMenu.Size = New System.Drawing.Size(308, 49)
        Me.Button_FileHiderMenu.TabIndex = 0
        Me.Button_FileHiderMenu.Text = "File Hider (Alternate Data Stream)"
        Me.ToolTip_Manager.SetToolTip(Me.Button_FileHiderMenu, resources.GetString("Button_FileHiderMenu.ToolTip"))
        Me.Button_FileHiderMenu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(82, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Created By: WarBringerLT"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Version.Location = New System.Drawing.Point(112, 31)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(54, 17)
        Me.Label_Version.TabIndex = 2
        Me.Label_Version.Text = "Version:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label_Version)
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 574)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(70, 541)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "EXIT"
        Me.ToolTip_Manager.SetToolTip(Me.Button2, "Goodbye")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Toolbox.My.Resources.Resources.kisspng_black_circle_logo_clip_art_5b0d39c2e38f83_6944326215275934109321
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(77, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 61)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Toolbox"
        '
        'Button_MemoryExecution
        '
        Me.Button_MemoryExecution.BackColor = System.Drawing.Color.Black
        Me.Button_MemoryExecution.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button_MemoryExecution.Location = New System.Drawing.Point(12, 389)
        Me.Button_MemoryExecution.Name = "Button_MemoryExecution"
        Me.Button_MemoryExecution.Size = New System.Drawing.Size(308, 49)
        Me.Button_MemoryExecution.TabIndex = 8
        Me.Button_MemoryExecution.Text = "Memory Execution (RunPE)"
        Me.ToolTip_Manager.SetToolTip(Me.Button_MemoryExecution, "Uses RunPE Module/Mechanics to Execute Any App Within (Parent) this Toolbox " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tha" &
        "t would be otherwise restricted or blocked. Useful for running hidden or restric" &
        "ted apps.")
        Me.Button_MemoryExecution.UseVisualStyleBackColor = False
        '
        'ToolTip_Manager
        '
        Me.ToolTip_Manager.AutomaticDelay = 100
        Me.ToolTip_Manager.AutoPopDelay = 20000
        Me.ToolTip_Manager.BackColor = System.Drawing.Color.Black
        Me.ToolTip_Manager.ForeColor = System.Drawing.Color.Orange
        Me.ToolTip_Manager.InitialDelay = 100
        Me.ToolTip_Manager.ReshowDelay = 20
        '
        'Button_WindowsSettings
        '
        Me.Button_WindowsSettings.BackColor = System.Drawing.Color.Black
        Me.Button_WindowsSettings.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button_WindowsSettings.Location = New System.Drawing.Point(12, 444)
        Me.Button_WindowsSettings.Name = "Button_WindowsSettings"
        Me.Button_WindowsSettings.Size = New System.Drawing.Size(308, 49)
        Me.Button_WindowsSettings.TabIndex = 9
        Me.Button_WindowsSettings.Text = "Windows Advanced Settings"
        Me.ToolTip_Manager.SetToolTip(Me.Button_WindowsSettings, "Quick Toggles For In-accessible or hard-to-find settings. ")
        Me.Button_WindowsSettings.UseVisualStyleBackColor = False
        '
        'Timer_Rainbow
        '
        Me.Timer_Rainbow.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "File Pumper (Add Size to File)"
        Me.ToolTip_Manager.SetToolTip(Me.Button1, "Adds extra Size on File, filled with NULL bytes, It doesn't affect any app, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jus" &
        "t adds a lot of blank space so the file appears to be larger in size.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(332, 628)
        Me.Controls.Add(Me.Button_WindowsSettings)
        Me.Controls.Add(Me.Button_MemoryExecution)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_FileHiderMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toolbox"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_FileHiderMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Version As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_MemoryExecution As Button
    Friend WithEvents ToolTip_Manager As ToolTip
    Friend WithEvents Timer_Rainbow As Timer
    Friend WithEvents Button_WindowsSettings As Button
    Friend WithEvents Button1 As Button
End Class
