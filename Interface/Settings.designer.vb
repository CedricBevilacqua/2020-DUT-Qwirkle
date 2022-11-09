<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_Settings))
        Me.BT_Start = New System.Windows.Forms.Button()
        Me.BT_Cancel = New System.Windows.Forms.Button()
        Me.LBL_Player1 = New System.Windows.Forms.Label()
        Me.LBL_Player2 = New System.Windows.Forms.Label()
        Me.TXT_NamePlayer1 = New System.Windows.Forms.TextBox()
        Me.TXT_AgePlayer1 = New System.Windows.Forms.TextBox()
        Me.TXT_NamePlayer2 = New System.Windows.Forms.TextBox()
        Me.TXT_AgePlayer2 = New System.Windows.Forms.TextBox()
        Me.PNL_Player3 = New System.Windows.Forms.Panel()
        Me.PB_IconJ3 = New System.Windows.Forms.PictureBox()
        Me.TXT_AgePlayer3 = New System.Windows.Forms.TextBox()
        Me.TXT_NamePlayer3 = New System.Windows.Forms.TextBox()
        Me.LBL_Player3 = New System.Windows.Forms.Label()
        Me.PNL_Player4 = New System.Windows.Forms.Panel()
        Me.PB_IconJ4 = New System.Windows.Forms.PictureBox()
        Me.TXT_AgePlayer4 = New System.Windows.Forms.TextBox()
        Me.TXT_NamePlayer4 = New System.Windows.Forms.TextBox()
        Me.LBL_Player4 = New System.Windows.Forms.Label()
        Me.PNL_AddButtons = New System.Windows.Forms.Panel()
        Me.BT_Add = New System.Windows.Forms.Button()
        Me.BT_Delete = New System.Windows.Forms.Button()
        Me.PB_IconJ2 = New System.Windows.Forms.PictureBox()
        Me.PB_IconJ1 = New System.Windows.Forms.PictureBox()
        Me.PNL_Player3.SuspendLayout()
        CType(Me.PB_IconJ3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_Player4.SuspendLayout()
        CType(Me.PB_IconJ4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_AddButtons.SuspendLayout()
        CType(Me.PB_IconJ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_IconJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_Start
        '
        Me.BT_Start.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Start.AutoSize = True
        Me.BT_Start.BackColor = System.Drawing.Color.Transparent
        Me.BT_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_Start.FlatAppearance.BorderSize = 0
        Me.BT_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BT_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Start.Font = New System.Drawing.Font("Lucida Sans Unicode", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Start.ForeColor = System.Drawing.Color.Black
        Me.BT_Start.Location = New System.Drawing.Point(796, 25)
        Me.BT_Start.Name = "BT_Start"
        Me.BT_Start.Size = New System.Drawing.Size(200, 55)
        Me.BT_Start.TabIndex = 2
        Me.BT_Start.Text = "Démarrer"
        Me.BT_Start.UseVisualStyleBackColor = False
        '
        'BT_Cancel
        '
        Me.BT_Cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Cancel.AutoSize = True
        Me.BT_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.BT_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_Cancel.FlatAppearance.BorderSize = 0
        Me.BT_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Cancel.Font = New System.Drawing.Font("Lucida Sans Unicode", 27.75!)
        Me.BT_Cancel.ForeColor = System.Drawing.Color.Black
        Me.BT_Cancel.Location = New System.Drawing.Point(12, 25)
        Me.BT_Cancel.Name = "BT_Cancel"
        Me.BT_Cancel.Size = New System.Drawing.Size(174, 57)
        Me.BT_Cancel.TabIndex = 2
        Me.BT_Cancel.Text = "Annuler"
        Me.BT_Cancel.UseVisualStyleBackColor = False
        '
        'LBL_Player1
        '
        Me.LBL_Player1.AutoSize = True
        Me.LBL_Player1.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Player1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Player1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Player1.Location = New System.Drawing.Point(90, 61)
        Me.LBL_Player1.Name = "LBL_Player1"
        Me.LBL_Player1.Size = New System.Drawing.Size(164, 42)
        Me.LBL_Player1.TabIndex = 4
        Me.LBL_Player1.Text = "Joueur 1"
        '
        'LBL_Player2
        '
        Me.LBL_Player2.AutoSize = True
        Me.LBL_Player2.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Player2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Player2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Underline)
        Me.LBL_Player2.Location = New System.Drawing.Point(572, 61)
        Me.LBL_Player2.Name = "LBL_Player2"
        Me.LBL_Player2.Size = New System.Drawing.Size(164, 42)
        Me.LBL_Player2.TabIndex = 5
        Me.LBL_Player2.Text = "Joueur 2"
        '
        'TXT_NamePlayer1
        '
        Me.TXT_NamePlayer1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NamePlayer1.Location = New System.Drawing.Point(118, 123)
        Me.TXT_NamePlayer1.Name = "TXT_NamePlayer1"
        Me.TXT_NamePlayer1.Size = New System.Drawing.Size(283, 34)
        Me.TXT_NamePlayer1.TabIndex = 6
        Me.TXT_NamePlayer1.Text = "Nom du joueur"
        '
        'TXT_AgePlayer1
        '
        Me.TXT_AgePlayer1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_AgePlayer1.Location = New System.Drawing.Point(118, 185)
        Me.TXT_AgePlayer1.Name = "TXT_AgePlayer1"
        Me.TXT_AgePlayer1.Size = New System.Drawing.Size(283, 34)
        Me.TXT_AgePlayer1.TabIndex = 7
        Me.TXT_AgePlayer1.Text = "Age du joueur"
        '
        'TXT_NamePlayer2
        '
        Me.TXT_NamePlayer2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_NamePlayer2.Location = New System.Drawing.Point(600, 123)
        Me.TXT_NamePlayer2.Name = "TXT_NamePlayer2"
        Me.TXT_NamePlayer2.Size = New System.Drawing.Size(283, 34)
        Me.TXT_NamePlayer2.TabIndex = 8
        Me.TXT_NamePlayer2.Text = "Nom du joueur"
        '
        'TXT_AgePlayer2
        '
        Me.TXT_AgePlayer2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_AgePlayer2.Location = New System.Drawing.Point(600, 185)
        Me.TXT_AgePlayer2.Name = "TXT_AgePlayer2"
        Me.TXT_AgePlayer2.Size = New System.Drawing.Size(283, 34)
        Me.TXT_AgePlayer2.TabIndex = 9
        Me.TXT_AgePlayer2.Text = "Age du joueur"
        '
        'PNL_Player3
        '
        Me.PNL_Player3.Controls.Add(Me.PB_IconJ3)
        Me.PNL_Player3.Controls.Add(Me.TXT_AgePlayer3)
        Me.PNL_Player3.Controls.Add(Me.TXT_NamePlayer3)
        Me.PNL_Player3.Controls.Add(Me.LBL_Player3)
        Me.PNL_Player3.Location = New System.Drawing.Point(37, 277)
        Me.PNL_Player3.Name = "PNL_Player3"
        Me.PNL_Player3.Size = New System.Drawing.Size(403, 251)
        Me.PNL_Player3.TabIndex = 10
        '
        'PB_IconJ3
        '
        Me.PB_IconJ3.BackColor = System.Drawing.Color.Transparent
        Me.PB_IconJ3.Cursor = System.Windows.Forms.Cursors.No
        Me.PB_IconJ3.Image = Global.[Interface].My.Resources.Resources.Joueur3icon
        Me.PB_IconJ3.Location = New System.Drawing.Point(8, 5)
        Me.PB_IconJ3.Name = "PB_IconJ3"
        Me.PB_IconJ3.Size = New System.Drawing.Size(39, 39)
        Me.PB_IconJ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PB_IconJ3.TabIndex = 15
        Me.PB_IconJ3.TabStop = False
        '
        'TXT_AgePlayer3
        '
        Me.TXT_AgePlayer3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_AgePlayer3.Location = New System.Drawing.Point(81, 139)
        Me.TXT_AgePlayer3.Name = "TXT_AgePlayer3"
        Me.TXT_AgePlayer3.Size = New System.Drawing.Size(283, 34)
        Me.TXT_AgePlayer3.TabIndex = 2
        Me.TXT_AgePlayer3.Text = "Age du joueur"
        '
        'TXT_NamePlayer3
        '
        Me.TXT_NamePlayer3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_NamePlayer3.Location = New System.Drawing.Point(81, 77)
        Me.TXT_NamePlayer3.Name = "TXT_NamePlayer3"
        Me.TXT_NamePlayer3.Size = New System.Drawing.Size(283, 34)
        Me.TXT_NamePlayer3.TabIndex = 1
        Me.TXT_NamePlayer3.Text = "Nom du joueur"
        '
        'LBL_Player3
        '
        Me.LBL_Player3.AutoSize = True
        Me.LBL_Player3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Underline)
        Me.LBL_Player3.Location = New System.Drawing.Point(53, 15)
        Me.LBL_Player3.Name = "LBL_Player3"
        Me.LBL_Player3.Size = New System.Drawing.Size(164, 42)
        Me.LBL_Player3.TabIndex = 0
        Me.LBL_Player3.Text = "Joueur 3"
        '
        'PNL_Player4
        '
        Me.PNL_Player4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_Player4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PNL_Player4.BackColor = System.Drawing.Color.Transparent
        Me.PNL_Player4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PNL_Player4.Controls.Add(Me.PB_IconJ4)
        Me.PNL_Player4.Controls.Add(Me.TXT_AgePlayer4)
        Me.PNL_Player4.Controls.Add(Me.TXT_NamePlayer4)
        Me.PNL_Player4.Controls.Add(Me.LBL_Player4)
        Me.PNL_Player4.Location = New System.Drawing.Point(520, 277)
        Me.PNL_Player4.Name = "PNL_Player4"
        Me.PNL_Player4.Size = New System.Drawing.Size(412, 251)
        Me.PNL_Player4.TabIndex = 11
        '
        'PB_IconJ4
        '
        Me.PB_IconJ4.BackColor = System.Drawing.Color.Transparent
        Me.PB_IconJ4.Cursor = System.Windows.Forms.Cursors.No
        Me.PB_IconJ4.Image = Global.[Interface].My.Resources.Resources.Joueur4icon
        Me.PB_IconJ4.Location = New System.Drawing.Point(7, 5)
        Me.PB_IconJ4.Name = "PB_IconJ4"
        Me.PB_IconJ4.Size = New System.Drawing.Size(39, 39)
        Me.PB_IconJ4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PB_IconJ4.TabIndex = 15
        Me.PB_IconJ4.TabStop = False
        '
        'TXT_AgePlayer4
        '
        Me.TXT_AgePlayer4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_AgePlayer4.Location = New System.Drawing.Point(80, 139)
        Me.TXT_AgePlayer4.Name = "TXT_AgePlayer4"
        Me.TXT_AgePlayer4.Size = New System.Drawing.Size(283, 34)
        Me.TXT_AgePlayer4.TabIndex = 2
        Me.TXT_AgePlayer4.Text = "Age du joueur"
        '
        'TXT_NamePlayer4
        '
        Me.TXT_NamePlayer4.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!)
        Me.TXT_NamePlayer4.Location = New System.Drawing.Point(80, 77)
        Me.TXT_NamePlayer4.Name = "TXT_NamePlayer4"
        Me.TXT_NamePlayer4.Size = New System.Drawing.Size(283, 34)
        Me.TXT_NamePlayer4.TabIndex = 1
        Me.TXT_NamePlayer4.Text = "Nom du joueur"
        '
        'LBL_Player4
        '
        Me.LBL_Player4.AutoSize = True
        Me.LBL_Player4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Underline)
        Me.LBL_Player4.Location = New System.Drawing.Point(52, 15)
        Me.LBL_Player4.Name = "LBL_Player4"
        Me.LBL_Player4.Size = New System.Drawing.Size(164, 42)
        Me.LBL_Player4.TabIndex = 0
        Me.LBL_Player4.Text = "Joueur 4"
        '
        'PNL_AddButtons
        '
        Me.PNL_AddButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_AddButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PNL_AddButtons.BackColor = System.Drawing.Color.Transparent
        Me.PNL_AddButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PNL_AddButtons.Controls.Add(Me.BT_Add)
        Me.PNL_AddButtons.Controls.Add(Me.BT_Delete)
        Me.PNL_AddButtons.Controls.Add(Me.BT_Start)
        Me.PNL_AddButtons.Controls.Add(Me.BT_Cancel)
        Me.PNL_AddButtons.Location = New System.Drawing.Point(0, 560)
        Me.PNL_AddButtons.Name = "PNL_AddButtons"
        Me.PNL_AddButtons.Size = New System.Drawing.Size(1024, 119)
        Me.PNL_AddButtons.TabIndex = 12
        '
        'BT_Add
        '
        Me.BT_Add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_Add.AutoSize = True
        Me.BT_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Add.BackColor = System.Drawing.Color.Transparent
        Me.BT_Add.FlatAppearance.BorderSize = 0
        Me.BT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Add.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Add.Image = Global.[Interface].My.Resources.Resources.AddPlayer
        Me.BT_Add.Location = New System.Drawing.Point(539, 3)
        Me.BT_Add.Name = "BT_Add"
        Me.BT_Add.Size = New System.Drawing.Size(117, 116)
        Me.BT_Add.TabIndex = 1
        Me.BT_Add.UseVisualStyleBackColor = False
        '
        'BT_Delete
        '
        Me.BT_Delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_Delete.AutoSize = True
        Me.BT_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BT_Delete.BackColor = System.Drawing.Color.Transparent
        Me.BT_Delete.Enabled = False
        Me.BT_Delete.FlatAppearance.BorderSize = 0
        Me.BT_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Delete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Delete.Image = Global.[Interface].My.Resources.Resources.LessPlayer
        Me.BT_Delete.Location = New System.Drawing.Point(369, 3)
        Me.BT_Delete.Name = "BT_Delete"
        Me.BT_Delete.Size = New System.Drawing.Size(117, 116)
        Me.BT_Delete.TabIndex = 1
        Me.BT_Delete.UseVisualStyleBackColor = False
        '
        'PB_IconJ2
        '
        Me.PB_IconJ2.BackColor = System.Drawing.Color.Transparent
        Me.PB_IconJ2.Cursor = System.Windows.Forms.Cursors.No
        Me.PB_IconJ2.Image = Global.[Interface].My.Resources.Resources.Joueur2icon
        Me.PB_IconJ2.Location = New System.Drawing.Point(527, 51)
        Me.PB_IconJ2.Name = "PB_IconJ2"
        Me.PB_IconJ2.Size = New System.Drawing.Size(39, 39)
        Me.PB_IconJ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PB_IconJ2.TabIndex = 14
        Me.PB_IconJ2.TabStop = False
        '
        'PB_IconJ1
        '
        Me.PB_IconJ1.BackColor = System.Drawing.Color.Transparent
        Me.PB_IconJ1.Cursor = System.Windows.Forms.Cursors.No
        Me.PB_IconJ1.Image = Global.[Interface].My.Resources.Resources.Joueur1icon
        Me.PB_IconJ1.Location = New System.Drawing.Point(45, 51)
        Me.PB_IconJ1.Name = "PB_IconJ1"
        Me.PB_IconJ1.Size = New System.Drawing.Size(39, 39)
        Me.PB_IconJ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PB_IconJ1.TabIndex = 13
        Me.PB_IconJ1.TabStop = False
        '
        'FORM_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.PB_IconJ2)
        Me.Controls.Add(Me.PB_IconJ1)
        Me.Controls.Add(Me.PNL_AddButtons)
        Me.Controls.Add(Me.PNL_Player4)
        Me.Controls.Add(Me.PNL_Player3)
        Me.Controls.Add(Me.TXT_AgePlayer2)
        Me.Controls.Add(Me.TXT_NamePlayer2)
        Me.Controls.Add(Me.TXT_AgePlayer1)
        Me.Controls.Add(Me.TXT_NamePlayer1)
        Me.Controls.Add(Me.LBL_Player2)
        Me.Controls.Add(Me.LBL_Player1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FORM_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.PNL_Player3.ResumeLayout(False)
        Me.PNL_Player3.PerformLayout()
        CType(Me.PB_IconJ3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_Player4.ResumeLayout(False)
        Me.PNL_Player4.PerformLayout()
        CType(Me.PB_IconJ4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_AddButtons.ResumeLayout(False)
        Me.PNL_AddButtons.PerformLayout()
        CType(Me.PB_IconJ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_IconJ1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_Add As Button
    Friend WithEvents BT_Delete As Button
    Friend WithEvents BT_Start As Button
    Friend WithEvents BT_Cancel As Button
    Friend WithEvents LBL_Player1 As Label
    Friend WithEvents LBL_Player2 As Label
    Friend WithEvents TXT_NamePlayer1 As TextBox
    Friend WithEvents TXT_AgePlayer1 As TextBox
    Friend WithEvents TXT_NamePlayer2 As TextBox
    Friend WithEvents TXT_AgePlayer2 As TextBox
    Friend WithEvents PNL_Player3 As Panel
    Friend WithEvents TXT_AgePlayer3 As TextBox
    Friend WithEvents TXT_NamePlayer3 As TextBox
    Friend WithEvents LBL_Player3 As Label
    Friend WithEvents PNL_Player4 As Panel
    Friend WithEvents TXT_AgePlayer4 As TextBox
    Friend WithEvents TXT_NamePlayer4 As TextBox
    Friend WithEvents LBL_Player4 As Label
    Friend WithEvents PNL_AddButtons As Panel
    Friend WithEvents PB_IconJ1 As PictureBox
    Friend WithEvents PB_IconJ3 As PictureBox
    Friend WithEvents PB_IconJ4 As PictureBox
    Friend WithEvents PB_IconJ2 As PictureBox
End Class
