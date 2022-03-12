<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemoryExecution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemoryExecution))
        Me.Button_Browse = New System.Windows.Forms.Button()
        Me.TextBox_FileLocation = New System.Windows.Forms.TextBox()
        Me.Button_Execute = New System.Windows.Forms.Button()
        Me.Button_GoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Browse
        '
        Me.Button_Browse.BackColor = System.Drawing.Color.Black
        Me.Button_Browse.ForeColor = System.Drawing.Color.Orange
        Me.Button_Browse.Location = New System.Drawing.Point(409, 5)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(106, 46)
        Me.Button_Browse.TabIndex = 0
        Me.Button_Browse.Text = "Browse"
        Me.Button_Browse.UseVisualStyleBackColor = False
        '
        'TextBox_FileLocation
        '
        Me.TextBox_FileLocation.BackColor = System.Drawing.Color.Black
        Me.TextBox_FileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_FileLocation.ForeColor = System.Drawing.Color.Red
        Me.TextBox_FileLocation.Location = New System.Drawing.Point(13, 15)
        Me.TextBox_FileLocation.Name = "TextBox_FileLocation"
        Me.TextBox_FileLocation.PlaceholderText = "File Location (Browse)"
        Me.TextBox_FileLocation.ReadOnly = True
        Me.TextBox_FileLocation.Size = New System.Drawing.Size(390, 27)
        Me.TextBox_FileLocation.TabIndex = 1
        '
        'Button_Execute
        '
        Me.Button_Execute.BackColor = System.Drawing.Color.Black
        Me.Button_Execute.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_Execute.ForeColor = System.Drawing.Color.Orange
        Me.Button_Execute.Location = New System.Drawing.Point(13, 53)
        Me.Button_Execute.Name = "Button_Execute"
        Me.Button_Execute.Size = New System.Drawing.Size(390, 46)
        Me.Button_Execute.TabIndex = 2
        Me.Button_Execute.Text = "Execute"
        Me.Button_Execute.UseVisualStyleBackColor = False
        '
        'Button_GoBack
        '
        Me.Button_GoBack.BackColor = System.Drawing.Color.Black
        Me.Button_GoBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_GoBack.ForeColor = System.Drawing.Color.Red
        Me.Button_GoBack.Location = New System.Drawing.Point(409, 53)
        Me.Button_GoBack.Name = "Button_GoBack"
        Me.Button_GoBack.Size = New System.Drawing.Size(106, 46)
        Me.Button_GoBack.TabIndex = 5
        Me.Button_GoBack.Text = "Go Back >>"
        Me.Button_GoBack.UseVisualStyleBackColor = False
        '
        'MemoryExecution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Toolbox.My.Resources.Resources.kisspng_black_circle_logo_clip_art_5b0d39c2e38f83_6944326215275934109321
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 111)
        Me.Controls.Add(Me.Button_GoBack)
        Me.Controls.Add(Me.Button_Execute)
        Me.Controls.Add(Me.TextBox_FileLocation)
        Me.Controls.Add(Me.Button_Browse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MemoryExecution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Execution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Browse As Button
    Friend WithEvents TextBox_FileLocation As TextBox
    Friend WithEvents Button_Execute As Button
    Friend WithEvents Button_GoBack As Button
End Class
