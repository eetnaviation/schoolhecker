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
        minecraft = New Button()
        tlegacy = New Button()
        schoolbatcher = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' minecraft
        ' 
        minecraft.Location = New Point(12, 11)
        minecraft.Margin = New Padding(3, 2, 3, 2)
        minecraft.Name = "minecraft"
        minecraft.Size = New Size(210, 22)
        minecraft.TabIndex = 0
        minecraft.Text = "Vanilla Launcher (MC)"
        minecraft.UseVisualStyleBackColor = True
        ' 
        ' tlegacy
        ' 
        tlegacy.Location = New Point(12, 38)
        tlegacy.Name = "tlegacy"
        tlegacy.Size = New Size(210, 23)
        tlegacy.TabIndex = 1
        tlegacy.Text = "TL Legacy (MC)"
        tlegacy.UseVisualStyleBackColor = True
        ' 
        ' schoolbatcher
        ' 
        schoolbatcher.Location = New Point(12, 67)
        schoolbatcher.Name = "schoolbatcher"
        schoolbatcher.Size = New Size(210, 23)
        schoolbatcher.TabIndex = 2
        schoolbatcher.Text = "schoolhecker legacy (schoolbatcher)"
        schoolbatcher.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 15)
        Label1.TabIndex = 3
        Label1.Text = "made by eetnaviation"
        ' 
        ' main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(410, 338)
        Controls.Add(Label1)
        Controls.Add(schoolbatcher)
        Controls.Add(tlegacy)
        Controls.Add(minecraft)
        Margin = New Padding(3, 2, 3, 2)
        Name = "main"
        Text = "schoolhecker v1.0"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents minecraft As Button
    Friend WithEvents tlegacy As Button
    Friend WithEvents schoolbatcher As Button
    Friend WithEvents Label1 As Label
End Class
