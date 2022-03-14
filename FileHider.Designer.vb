<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileHider
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileHider))
        Me.TextBox_SourceFile = New System.Windows.Forms.TextBox()
        Me.Button_BrowseFile = New System.Windows.Forms.Button()
        Me.Button_BrowseSaveFile = New System.Windows.Forms.Button()
        Me.TextBox_OutputFile = New System.Windows.Forms.TextBox()
        Me.Button_GoBack = New System.Windows.Forms.Button()
        Me.GroupBox_Parameters = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Internal = New System.Windows.Forms.RadioButton()
        Me.RadioButton_CMD = New System.Windows.Forms.RadioButton()
        Me.CheckBox_DeleteSource = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Debug = New System.Windows.Forms.CheckBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_PasswordSettings = New System.Windows.Forms.Button()
        Me.Button_SelectMode = New System.Windows.Forms.Button()
        Me.GroupBox_Parameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_SourceFile
        '
        Me.TextBox_SourceFile.BackColor = System.Drawing.Color.Black
        Me.TextBox_SourceFile.ForeColor = System.Drawing.Color.YellowGreen
        Me.TextBox_SourceFile.Location = New System.Drawing.Point(12, 21)
        Me.TextBox_SourceFile.Name = "TextBox_SourceFile"
        Me.TextBox_SourceFile.PlaceholderText = "File to Embed... (BROWSE)"
        Me.TextBox_SourceFile.ReadOnly = True
        Me.TextBox_SourceFile.Size = New System.Drawing.Size(459, 27)
        Me.TextBox_SourceFile.TabIndex = 0
        '
        'Button_BrowseFile
        '
        Me.Button_BrowseFile.BackColor = System.Drawing.Color.Black
        Me.Button_BrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_BrowseFile.Location = New System.Drawing.Point(477, 18)
        Me.Button_BrowseFile.Name = "Button_BrowseFile"
        Me.Button_BrowseFile.Size = New System.Drawing.Size(106, 33)
        Me.Button_BrowseFile.TabIndex = 1
        Me.Button_BrowseFile.Text = "Browse..."
        Me.Button_BrowseFile.UseVisualStyleBackColor = False
        '
        'Button_BrowseSaveFile
        '
        Me.Button_BrowseSaveFile.BackColor = System.Drawing.Color.Black
        Me.Button_BrowseSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_BrowseSaveFile.Location = New System.Drawing.Point(477, 62)
        Me.Button_BrowseSaveFile.Name = "Button_BrowseSaveFile"
        Me.Button_BrowseSaveFile.Size = New System.Drawing.Size(106, 33)
        Me.Button_BrowseSaveFile.TabIndex = 3
        Me.Button_BrowseSaveFile.Text = "Browse..."
        Me.Button_BrowseSaveFile.UseVisualStyleBackColor = False
        '
        'TextBox_OutputFile
        '
        Me.TextBox_OutputFile.BackColor = System.Drawing.Color.Black
        Me.TextBox_OutputFile.ForeColor = System.Drawing.Color.YellowGreen
        Me.TextBox_OutputFile.Location = New System.Drawing.Point(12, 65)
        Me.TextBox_OutputFile.Name = "TextBox_OutputFile"
        Me.TextBox_OutputFile.PlaceholderText = "Output File (If File Doesn't Exist EMPTY file will be created)"
        Me.TextBox_OutputFile.ReadOnly = True
        Me.TextBox_OutputFile.Size = New System.Drawing.Size(459, 27)
        Me.TextBox_OutputFile.TabIndex = 2
        '
        'Button_GoBack
        '
        Me.Button_GoBack.BackColor = System.Drawing.Color.Black
        Me.Button_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_GoBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_GoBack.ForeColor = System.Drawing.Color.Red
        Me.Button_GoBack.Location = New System.Drawing.Point(363, 218)
        Me.Button_GoBack.Name = "Button_GoBack"
        Me.Button_GoBack.Size = New System.Drawing.Size(220, 51)
        Me.Button_GoBack.TabIndex = 4
        Me.Button_GoBack.Text = "Go Back >>"
        Me.Button_GoBack.UseVisualStyleBackColor = False
        '
        'GroupBox_Parameters
        '
        Me.GroupBox_Parameters.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_Parameters.Controls.Add(Me.RadioButton_Internal)
        Me.GroupBox_Parameters.Controls.Add(Me.RadioButton_CMD)
        Me.GroupBox_Parameters.Controls.Add(Me.CheckBox_DeleteSource)
        Me.GroupBox_Parameters.Controls.Add(Me.CheckBox_Debug)
        Me.GroupBox_Parameters.Controls.Add(Me.Button_Start)
        Me.GroupBox_Parameters.ForeColor = System.Drawing.Color.Coral
        Me.GroupBox_Parameters.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox_Parameters.Name = "GroupBox_Parameters"
        Me.GroupBox_Parameters.Size = New System.Drawing.Size(345, 166)
        Me.GroupBox_Parameters.TabIndex = 5
        Me.GroupBox_Parameters.TabStop = False
        Me.GroupBox_Parameters.Text = "Parameters"
        '
        'RadioButton_Internal
        '
        Me.RadioButton_Internal.AutoSize = True
        Me.RadioButton_Internal.Checked = True
        Me.RadioButton_Internal.ForeColor = System.Drawing.Color.Lime
        Me.RadioButton_Internal.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton_Internal.Name = "RadioButton_Internal"
        Me.RadioButton_Internal.Size = New System.Drawing.Size(264, 24)
        Me.RadioButton_Internal.TabIndex = 13
        Me.RadioButton_Internal.TabStop = True
        Me.RadioButton_Internal.Text = "Process Through Internal (This App)"
        Me.RadioButton_Internal.UseVisualStyleBackColor = True
        '
        'RadioButton_CMD
        '
        Me.RadioButton_CMD.AutoSize = True
        Me.RadioButton_CMD.ForeColor = System.Drawing.Color.Orange
        Me.RadioButton_CMD.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton_CMD.Name = "RadioButton_CMD"
        Me.RadioButton_CMD.Size = New System.Drawing.Size(214, 24)
        Me.RadioButton_CMD.TabIndex = 12
        Me.RadioButton_CMD.Text = "Process Through CMD (.bat)"
        Me.RadioButton_CMD.UseVisualStyleBackColor = True
        '
        'CheckBox_DeleteSource
        '
        Me.CheckBox_DeleteSource.AutoSize = True
        Me.CheckBox_DeleteSource.Location = New System.Drawing.Point(6, 85)
        Me.CheckBox_DeleteSource.Name = "CheckBox_DeleteSource"
        Me.CheckBox_DeleteSource.Size = New System.Drawing.Size(214, 24)
        Me.CheckBox_DeleteSource.TabIndex = 11
        Me.CheckBox_DeleteSource.Text = "Delete Original(Source) File"
        Me.CheckBox_DeleteSource.UseVisualStyleBackColor = True
        '
        'CheckBox_Debug
        '
        Me.CheckBox_Debug.AutoSize = True
        Me.CheckBox_Debug.Location = New System.Drawing.Point(6, 63)
        Me.CheckBox_Debug.Name = "CheckBox_Debug"
        Me.CheckBox_Debug.Size = New System.Drawing.Size(155, 24)
        Me.CheckBox_Debug.TabIndex = 10
        Me.CheckBox_Debug.Text = "Debug Commands"
        Me.CheckBox_Debug.UseVisualStyleBackColor = True
        '
        'Button_Start
        '
        Me.Button_Start.BackColor = System.Drawing.Color.Black
        Me.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Start.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_Start.ForeColor = System.Drawing.Color.SlateBlue
        Me.Button_Start.Location = New System.Drawing.Point(47, 115)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(234, 47)
        Me.Button_Start.TabIndex = 6
        Me.Button_Start.Text = "ENCRYPT"
        Me.Button_Start.UseVisualStyleBackColor = False
        '
        'Button_PasswordSettings
        '
        Me.Button_PasswordSettings.BackColor = System.Drawing.Color.Black
        Me.Button_PasswordSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_PasswordSettings.ForeColor = System.Drawing.Color.Magenta
        Me.Button_PasswordSettings.Location = New System.Drawing.Point(363, 160)
        Me.Button_PasswordSettings.Name = "Button_PasswordSettings"
        Me.Button_PasswordSettings.Size = New System.Drawing.Size(220, 52)
        Me.Button_PasswordSettings.TabIndex = 7
        Me.Button_PasswordSettings.Text = "Password Settings (Avoidance)"
        Me.Button_PasswordSettings.UseVisualStyleBackColor = False
        '
        'Button_SelectMode
        '
        Me.Button_SelectMode.BackColor = System.Drawing.Color.Black
        Me.Button_SelectMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectMode.ForeColor = System.Drawing.Color.LawnGreen
        Me.Button_SelectMode.Location = New System.Drawing.Point(363, 112)
        Me.Button_SelectMode.Name = "Button_SelectMode"
        Me.Button_SelectMode.Size = New System.Drawing.Size(220, 42)
        Me.Button_SelectMode.TabIndex = 0
        Me.Button_SelectMode.Text = "MODE = ENCRYPT (Toggle)"
        Me.Button_SelectMode.UseVisualStyleBackColor = False
        '
        'FileHider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Toolbox.My.Resources.Resources.kisspng_black_circle_logo_clip_art_5b0d39c2e38f83_6944326215275934109321
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 277)
        Me.Controls.Add(Me.GroupBox_Parameters)
        Me.Controls.Add(Me.Button_GoBack)
        Me.Controls.Add(Me.Button_BrowseSaveFile)
        Me.Controls.Add(Me.TextBox_OutputFile)
        Me.Controls.Add(Me.Button_PasswordSettings)
        Me.Controls.Add(Me.Button_SelectMode)
        Me.Controls.Add(Me.Button_BrowseFile)
        Me.Controls.Add(Me.TextBox_SourceFile)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileHider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Hider"
        Me.GroupBox_Parameters.ResumeLayout(False)
        Me.GroupBox_Parameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_SourceFile As TextBox
    Friend WithEvents Button_BrowseFile As Button
    Friend WithEvents Button_BrowseSaveFile As Button
    Friend WithEvents TextBox_OutputFile As TextBox
    Friend WithEvents Button_GoBack As Button
    Friend WithEvents GroupBox_Parameters As GroupBox
    Friend WithEvents Button_SelectMode As Button
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_PasswordSettings As Button
    Friend WithEvents CheckBox_Debug As CheckBox
    Friend WithEvents CheckBox_DeleteSource As CheckBox
    Friend WithEvents RadioButton_Internal As RadioButton
    Friend WithEvents RadioButton_CMD As RadioButton
End Class
