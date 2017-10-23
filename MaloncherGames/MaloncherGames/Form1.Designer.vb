<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Malônecheur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Malônecheur))
        Me.Jeu1 = New System.Windows.Forms.Button()
        Me.Jeu2 = New System.Windows.Forms.Button()
        Me.Jeu3 = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SuspendLayout()
        '
        'Jeu1
        '
        Me.Jeu1.BackgroundImage = CType(resources.GetObject("Jeu1.BackgroundImage"), System.Drawing.Image)
        Me.Jeu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Jeu1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Jeu1.Location = New System.Drawing.Point(12, 12)
        Me.Jeu1.Name = "Jeu1"
        Me.Jeu1.Size = New System.Drawing.Size(88, 62)
        Me.Jeu1.TabIndex = 0
        Me.Jeu1.UseVisualStyleBackColor = True
        '
        'Jeu2
        '
        Me.Jeu2.BackgroundImage = CType(resources.GetObject("Jeu2.BackgroundImage"), System.Drawing.Image)
        Me.Jeu2.Location = New System.Drawing.Point(106, 12)
        Me.Jeu2.Name = "Jeu2"
        Me.Jeu2.Size = New System.Drawing.Size(87, 62)
        Me.Jeu2.TabIndex = 1
        Me.Jeu2.UseVisualStyleBackColor = True
        '
        'Jeu3
        '
        Me.Jeu3.BackgroundImage = CType(resources.GetObject("Jeu3.BackgroundImage"), System.Drawing.Image)
        Me.Jeu3.Location = New System.Drawing.Point(199, 12)
        Me.Jeu3.Name = "Jeu3"
        Me.Jeu3.Size = New System.Drawing.Size(87, 62)
        Me.Jeu3.TabIndex = 2
        Me.Jeu3.UseVisualStyleBackColor = True
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(12, 114)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(274, 29)
        Me.Quitter.TabIndex = 3
        Me.Quitter.Text = "Quitter"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'FontDialog1
        '
        '
        'Malônecheur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 148)
        Me.ControlBox = False
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.Jeu3)
        Me.Controls.Add(Me.Jeu2)
        Me.Controls.Add(Me.Jeu1)
        Me.Name = "Malônecheur"
        Me.Text = "Malônecheur"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Jeu1 As Button
    Friend WithEvents Jeu2 As Button
    Friend WithEvents Jeu3 As Button
    Friend WithEvents Quitter As Button
    Friend WithEvents FontDialog1 As FontDialog
End Class
