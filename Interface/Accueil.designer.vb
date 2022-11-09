<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_Accueil))
        Me.BT_Play = New System.Windows.Forms.Button()
        Me.BT_Exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_Play
        '
        Me.BT_Play.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Play.AutoSize = True
        Me.BT_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Play.BackColor = System.Drawing.Color.DodgerBlue
        Me.BT_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_Play.Location = New System.Drawing.Point(397, 87)
        Me.BT_Play.Name = "BT_Play"
        Me.BT_Play.Padding = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.BT_Play.Size = New System.Drawing.Size(194, 63)
        Me.BT_Play.TabIndex = 1
        Me.BT_Play.Text = "Jouer"
        Me.BT_Play.UseVisualStyleBackColor = False
        '
        'BT_Exit
        '
        Me.BT_Exit.BackColor = System.Drawing.Color.DodgerBlue
        Me.BT_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_Exit.Location = New System.Drawing.Point(397, 222)
        Me.BT_Exit.Name = "BT_Exit"
        Me.BT_Exit.Size = New System.Drawing.Size(194, 63)
        Me.BT_Exit.TabIndex = 2
        Me.BT_Exit.Text = "Quitter"
        Me.BT_Exit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.[Interface].My.Resources.Resources.TitleQwirkle
        Me.PictureBox1.Location = New System.Drawing.Point(-30, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(996, 267)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.BT_Play)
        Me.Panel1.Controls.Add(Me.BT_Exit)
        Me.Panel1.Location = New System.Drawing.Point(13, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(90, 0, 90, 0)
        Me.Panel1.Size = New System.Drawing.Size(983, 403)
        Me.Panel1.TabIndex = 4
        '
        'FORM_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FORM_Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_Play As Button
    Friend WithEvents BT_Exit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
