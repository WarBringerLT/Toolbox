<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilePumper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilePumper))
        Me.Button_Browse = New System.Windows.Forms.Button()
        Me.Textbox_FileLocation = New System.Windows.Forms.TextBox()
        Me.Numeric_Value = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_KB = New System.Windows.Forms.RadioButton()
        Me.RadioButton_MB = New System.Windows.Forms.RadioButton()
        Me.Button_Pump = New System.Windows.Forms.Button()
        Me.Button_GoBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_NewFile = New System.Windows.Forms.RadioButton()
        Me.RadioButton_SameFile = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Numeric_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Browse
        '
        Me.Button_Browse.BackColor = System.Drawing.Color.Black
        Me.Button_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Browse.Location = New System.Drawing.Point(551, 7)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(104, 36)
        Me.Button_Browse.TabIndex = 0
        Me.Button_Browse.Text = "Browse..."
        Me.Button_Browse.UseVisualStyleBackColor = False
        '
        'Textbox_FileLocation
        '
        Me.Textbox_FileLocation.BackColor = System.Drawing.Color.Black
        Me.Textbox_FileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox_FileLocation.ForeColor = System.Drawing.Color.YellowGreen
        Me.Textbox_FileLocation.Location = New System.Drawing.Point(16, 16)
        Me.Textbox_FileLocation.Name = "Textbox_FileLocation"
        Me.Textbox_FileLocation.PlaceholderText = "File Location (Click Browse)"
        Me.Textbox_FileLocation.ReadOnly = True
        Me.Textbox_FileLocation.Size = New System.Drawing.Size(519, 27)
        Me.Textbox_FileLocation.TabIndex = 1
        '
        'Numeric_Value
        '
        Me.Numeric_Value.BackColor = System.Drawing.SystemColors.MenuText
        Me.Numeric_Value.ForeColor = System.Drawing.Color.Lime
        Me.Numeric_Value.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Numeric_Value.Location = New System.Drawing.Point(92, 31)
        Me.Numeric_Value.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Numeric_Value.Name = "Numeric_Value"
        Me.Numeric_Value.Size = New System.Drawing.Size(77, 27)
        Me.Numeric_Value.TabIndex = 2
        Me.Numeric_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Numeric_Value.ThousandsSeparator = True
        '
        'RadioButton_KB
        '
        Me.RadioButton_KB.AutoSize = True
        Me.RadioButton_KB.Checked = True
        Me.RadioButton_KB.Location = New System.Drawing.Point(7, 19)
        Me.RadioButton_KB.Name = "RadioButton_KB"
        Me.RadioButton_KB.Size = New System.Drawing.Size(123, 24)
        Me.RadioButton_KB.TabIndex = 3
        Me.RadioButton_KB.TabStop = True
        Me.RadioButton_KB.Text = "Kilobytes (KB)"
        Me.RadioButton_KB.UseVisualStyleBackColor = True
        '
        'RadioButton_MB
        '
        Me.RadioButton_MB.AutoSize = True
        Me.RadioButton_MB.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton_MB.Name = "RadioButton_MB"
        Me.RadioButton_MB.Size = New System.Drawing.Size(139, 24)
        Me.RadioButton_MB.TabIndex = 4
        Me.RadioButton_MB.Text = "Megabytes (MB)"
        Me.RadioButton_MB.UseVisualStyleBackColor = True
        '
        'Button_Pump
        '
        Me.Button_Pump.BackColor = System.Drawing.Color.Black
        Me.Button_Pump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Pump.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_Pump.ForeColor = System.Drawing.Color.Lime
        Me.Button_Pump.Location = New System.Drawing.Point(16, 124)
        Me.Button_Pump.Name = "Button_Pump"
        Me.Button_Pump.Size = New System.Drawing.Size(519, 53)
        Me.Button_Pump.TabIndex = 5
        Me.Button_Pump.Text = "Add Selected Size"
        Me.Button_Pump.UseVisualStyleBackColor = False
        '
        'Button_GoBack
        '
        Me.Button_GoBack.BackColor = System.Drawing.Color.Black
        Me.Button_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_GoBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_GoBack.ForeColor = System.Drawing.Color.Red
        Me.Button_GoBack.Location = New System.Drawing.Point(551, 53)
        Me.Button_GoBack.Name = "Button_GoBack"
        Me.Button_GoBack.Size = New System.Drawing.Size(104, 124)
        Me.Button_GoBack.TabIndex = 6
        Me.Button_GoBack.Text = "Go Back >>"
        Me.Button_GoBack.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Numeric_Value)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Coral
        Me.GroupBox1.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 75)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RadioButton_KB)
        Me.GroupBox3.Controls.Add(Me.RadioButton_MB)
        Me.GroupBox3.Location = New System.Drawing.Point(186, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 75)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton_NewFile)
        Me.GroupBox2.Controls.Add(Me.RadioButton_SameFile)
        Me.GroupBox2.Location = New System.Drawing.Point(381, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 75)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'RadioButton_NewFile
        '
        Me.RadioButton_NewFile.AutoSize = True
        Me.RadioButton_NewFile.Checked = True
        Me.RadioButton_NewFile.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_NewFile.Name = "RadioButton_NewFile"
        Me.RadioButton_NewFile.Size = New System.Drawing.Size(87, 24)
        Me.RadioButton_NewFile.TabIndex = 7
        Me.RadioButton_NewFile.TabStop = True
        Me.RadioButton_NewFile.Text = "New File"
        Me.RadioButton_NewFile.UseVisualStyleBackColor = True
        '
        'RadioButton_SameFile
        '
        Me.RadioButton_SameFile.AutoSize = True
        Me.RadioButton_SameFile.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton_SameFile.Name = "RadioButton_SameFile"
        Me.RadioButton_SameFile.Size = New System.Drawing.Size(94, 24)
        Me.RadioButton_SameFile.TabIndex = 8
        Me.RadioButton_SameFile.Text = "Same File"
        Me.RadioButton_SameFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Label2.Location = New System.Drawing.Point(343, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PUMP"
        '
        'FilePumper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Toolbox.My.Resources.Resources.kisspng_black_circle_logo_clip_art_5b0d39c2e38f83_6944326215275934109321
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(667, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_GoBack)
        Me.Controls.Add(Me.Button_Pump)
        Me.Controls.Add(Me.Textbox_FileLocation)
        Me.Controls.Add(Me.Button_Browse)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FilePumper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FilePumper"
        CType(Me.Numeric_Value, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Browse As Button
    Friend WithEvents Textbox_FileLocation As TextBox
    Friend WithEvents Numeric_Value As NumericUpDown
    Friend WithEvents RadioButton_KB As RadioButton
    Friend WithEvents RadioButton_MB As RadioButton
    Friend WithEvents Button_Pump As Button
    Friend WithEvents Button_GoBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_SameFile As RadioButton
    Friend WithEvents RadioButton_NewFile As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
