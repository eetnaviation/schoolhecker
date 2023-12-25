<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.minecraft = New System.Windows.Forms.Button()
        Me.tlegacy = New System.Windows.Forms.Button()
        Me.schoolbatcher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'minecraft
        '
        Me.minecraft.Location = New System.Drawing.Point(12, 11)
        Me.minecraft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.minecraft.Name = "minecraft"
        Me.minecraft.Size = New System.Drawing.Size(210, 22)
        Me.minecraft.TabIndex = 0
        Me.minecraft.Text = "Vanilla Launcher (MC)"
        Me.minecraft.UseVisualStyleBackColor = True
        '
        'tlegacy
        '
        Me.tlegacy.Location = New System.Drawing.Point(12, 38)
        Me.tlegacy.Name = "tlegacy"
        Me.tlegacy.Size = New System.Drawing.Size(210, 23)
        Me.tlegacy.TabIndex = 1
        Me.tlegacy.Text = "TL Legacy (MC)"
        Me.tlegacy.UseVisualStyleBackColor = True
        '
        'schoolbatcher
        '
        Me.schoolbatcher.Location = New System.Drawing.Point(12, 67)
        Me.schoolbatcher.Name = "schoolbatcher"
        Me.schoolbatcher.Size = New System.Drawing.Size(210, 23)
        Me.schoolbatcher.TabIndex = 2
        Me.schoolbatcher.Text = "schoolhecker legacy (schoolbatcher)"
        Me.schoolbatcher.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 338)
        Me.Controls.Add(Me.schoolbatcher)
        Me.Controls.Add(Me.tlegacy)
        Me.Controls.Add(Me.minecraft)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "main"
        Me.Text = "schoolhecker v1.0 - slimegamerc"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents minecraft As Button
    Friend WithEvents tlegacy As Button
    Friend WithEvents schoolbatcher As Button
End Class
