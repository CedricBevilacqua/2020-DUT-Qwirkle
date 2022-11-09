<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_Game))
        Me.PNL_Cases = New System.Windows.Forms.Panel()
        Me.Panelstatique = New System.Windows.Forms.Panel()
        Me.BT_Change = New System.Windows.Forms.Button()
        Me.BT_Validate = New System.Windows.Forms.Button()
        Me.LBL_PlayerName = New System.Windows.Forms.Label()
        Me.LBL_Score = New System.Windows.Forms.Label()
        Me.LBL_NbPioche = New System.Windows.Forms.Label()
        Me.GB_Main = New System.Windows.Forms.GroupBox()
        Me.IMG_Main1 = New System.Windows.Forms.PictureBox()
        Me.IMG_Main2 = New System.Windows.Forms.PictureBox()
        Me.IMG_Main5 = New System.Windows.Forms.PictureBox()
        Me.IMG_Main4 = New System.Windows.Forms.PictureBox()
        Me.IMG_Main6 = New System.Windows.Forms.PictureBox()
        Me.IMG_Main3 = New System.Windows.Forms.PictureBox()
        Me.BT_Cancel = New System.Windows.Forms.Button()
        Me.Panelstatique.SuspendLayout()
        Me.GB_Main.SuspendLayout()
        CType(Me.IMG_Main1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_Main2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_Main5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_Main4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_Main6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_Main3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_Cases
        '
        Me.PNL_Cases.AutoSize = True
        Me.PNL_Cases.Location = New System.Drawing.Point(0, 0)
        Me.PNL_Cases.Name = "PNL_Cases"
        Me.PNL_Cases.Size = New System.Drawing.Size(951, 522)
        Me.PNL_Cases.TabIndex = 0
        '
        'Panelstatique
        '
        Me.Panelstatique.AutoScroll = True
        Me.Panelstatique.Controls.Add(Me.PNL_Cases)
        Me.Panelstatique.Location = New System.Drawing.Point(27, 12)
        Me.Panelstatique.Name = "Panelstatique"
        Me.Panelstatique.Size = New System.Drawing.Size(951, 522)
        Me.Panelstatique.TabIndex = 0
        '
        'BT_Change
        '
        Me.BT_Change.BackColor = System.Drawing.Color.DodgerBlue
        Me.BT_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Change.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Change.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_Change.Location = New System.Drawing.Point(587, 639)
        Me.BT_Change.Name = "BT_Change"
        Me.BT_Change.Size = New System.Drawing.Size(84, 35)
        Me.BT_Change.TabIndex = 4
        Me.BT_Change.Text = "Echanger"
        Me.BT_Change.UseVisualStyleBackColor = False
        '
        'BT_Validate
        '
        Me.BT_Validate.BackColor = System.Drawing.Color.SeaGreen
        Me.BT_Validate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_Validate.Enabled = False
        Me.BT_Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Validate.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Validate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_Validate.Location = New System.Drawing.Point(677, 598)
        Me.BT_Validate.Name = "BT_Validate"
        Me.BT_Validate.Size = New System.Drawing.Size(88, 76)
        Me.BT_Validate.TabIndex = 5
        Me.BT_Validate.Text = "Valider"
        Me.BT_Validate.UseVisualStyleBackColor = False
        '
        'LBL_PlayerName
        '
        Me.LBL_PlayerName.AutoSize = True
        Me.LBL_PlayerName.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PlayerName.Location = New System.Drawing.Point(233, 570)
        Me.LBL_PlayerName.Name = "LBL_PlayerName"
        Me.LBL_PlayerName.Size = New System.Drawing.Size(117, 23)
        Me.LBL_PlayerName.TabIndex = 10
        Me.LBL_PlayerName.Text = "Player Name"
        '
        'LBL_Score
        '
        Me.LBL_Score.AutoSize = True
        Me.LBL_Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Score.Location = New System.Drawing.Point(771, 626)
        Me.LBL_Score.Name = "LBL_Score"
        Me.LBL_Score.Size = New System.Drawing.Size(52, 29)
        Me.LBL_Score.TabIndex = 11
        Me.LBL_Score.Text = "000"
        '
        'LBL_NbPioche
        '
        Me.LBL_NbPioche.AutoSize = True
        Me.LBL_NbPioche.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold)
        Me.LBL_NbPioche.Location = New System.Drawing.Point(158, 617)
        Me.LBL_NbPioche.Name = "LBL_NbPioche"
        Me.LBL_NbPioche.Size = New System.Drawing.Size(78, 42)
        Me.LBL_NbPioche.TabIndex = 12
        Me.LBL_NbPioche.Text = "000"
        '
        'GB_Main
        '
        Me.GB_Main.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GB_Main.Controls.Add(Me.IMG_Main1)
        Me.GB_Main.Controls.Add(Me.IMG_Main2)
        Me.GB_Main.Controls.Add(Me.IMG_Main5)
        Me.GB_Main.Controls.Add(Me.IMG_Main4)
        Me.GB_Main.Controls.Add(Me.IMG_Main6)
        Me.GB_Main.Controls.Add(Me.IMG_Main3)
        Me.GB_Main.Location = New System.Drawing.Point(236, 591)
        Me.GB_Main.Name = "GB_Main"
        Me.GB_Main.Size = New System.Drawing.Size(345, 83)
        Me.GB_Main.TabIndex = 13
        Me.GB_Main.TabStop = False
        '
        'IMG_Main1
        '
        Me.IMG_Main1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_Main1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMG_Main1.Location = New System.Drawing.Point(6, 19)
        Me.IMG_Main1.Name = "IMG_Main1"
        Me.IMG_Main1.Size = New System.Drawing.Size(50, 50)
        Me.IMG_Main1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_Main1.TabIndex = 2
        Me.IMG_Main1.TabStop = False
        '
        'IMG_Main2
        '
        Me.IMG_Main2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_Main2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMG_Main2.Location = New System.Drawing.Point(62, 19)
        Me.IMG_Main2.Name = "IMG_Main2"
        Me.IMG_Main2.Size = New System.Drawing.Size(50, 50)
        Me.IMG_Main2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_Main2.TabIndex = 0
        Me.IMG_Main2.TabStop = False
        '
        'IMG_Main5
        '
        Me.IMG_Main5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_Main5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMG_Main5.Location = New System.Drawing.Point(230, 19)
        Me.IMG_Main5.Name = "IMG_Main5"
        Me.IMG_Main5.Size = New System.Drawing.Size(50, 50)
        Me.IMG_Main5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_Main5.TabIndex = 6
        Me.IMG_Main5.TabStop = False
        '
        'IMG_Main4
        '
        Me.IMG_Main4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_Main4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMG_Main4.Location = New System.Drawing.Point(174, 19)
        Me.IMG_Main4.Name = "IMG_Main4"
        Me.IMG_Main4.Size = New System.Drawing.Size(50, 50)
        Me.IMG_Main4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_Main4.TabIndex = 7
        Me.IMG_Main4.TabStop = False
        '
        'IMG_Main6
        '
        Me.IMG_Main6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_Main6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMG_Main6.Location = New System.Drawing.Point(286, 19)
        Me.IMG_Main6.Name = "IMG_Main6"
        Me.IMG_Main6.Size = New System.Drawing.Size(50, 50)
        Me.IMG_Main6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_Main6.TabIndex = 9
        Me.IMG_Main6.TabStop = False
        '
        'IMG_Main3
        '
        Me.IMG_Main3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_Main3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMG_Main3.Location = New System.Drawing.Point(118, 19)
        Me.IMG_Main3.Name = "IMG_Main3"
        Me.IMG_Main3.Size = New System.Drawing.Size(50, 50)
        Me.IMG_Main3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_Main3.TabIndex = 8
        Me.IMG_Main3.TabStop = False
        '
        'BT_Cancel
        '
        Me.BT_Cancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Cancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_Cancel.Location = New System.Drawing.Point(587, 598)
        Me.BT_Cancel.Name = "BT_Cancel"
        Me.BT_Cancel.Size = New System.Drawing.Size(84, 35)
        Me.BT_Cancel.TabIndex = 3
        Me.BT_Cancel.Text = "Annuler"
        Me.BT_Cancel.UseVisualStyleBackColor = False
        '
        'FORM_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.GB_Main)
        Me.Controls.Add(Me.LBL_NbPioche)
        Me.Controls.Add(Me.LBL_Score)
        Me.Controls.Add(Me.LBL_PlayerName)
        Me.Controls.Add(Me.BT_Validate)
        Me.Controls.Add(Me.BT_Change)
        Me.Controls.Add(Me.BT_Cancel)
        Me.Controls.Add(Me.Panelstatique)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FORM_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qwirkle"
        Me.Panelstatique.ResumeLayout(False)
        Me.Panelstatique.PerformLayout()
        Me.GB_Main.ResumeLayout(False)
        CType(Me.IMG_Main1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_Main2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_Main5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_Main4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_Main6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_Main3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PNL_Cases As Panel
    Friend WithEvents Panelstatique As Panel
    Friend WithEvents IMG_Main1 As PictureBox
    Friend WithEvents IMG_Main2 As PictureBox
    Friend WithEvents BT_Cancel As Button
    Friend WithEvents BT_Change As Button
    Friend WithEvents BT_Validate As Button
    Friend WithEvents IMG_Main5 As PictureBox
    Friend WithEvents IMG_Main4 As PictureBox
    Friend WithEvents IMG_Main3 As PictureBox
    Friend WithEvents IMG_Main6 As PictureBox
    Friend WithEvents LBL_PlayerName As Label
    Friend WithEvents LBL_Score As Label
    Friend WithEvents LBL_NbPioche As Label
    Friend WithEvents GB_Main As GroupBox
End Class
