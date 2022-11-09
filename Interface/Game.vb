Public Class FORM_Game

    Dim cliquelig = 0
    Dim cliquecol = 0
    Dim Nbtour = 0
    Dim espacementbas = 0
    Dim Nblignedynamique = 1
    Dim nbcolonnedynamique = 1
    Dim Margedroite = 0

    Dim TuilesIcons(6, 6) As Image 'Couleurs par forme
    Dim DraggedMain As Integer
    Dim SizePlateau As Integer = 10

    Dim MsgResult As MsgBoxResult
    Private Sub Form1_Close(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgResult <> vbYes Then
            MsgResult = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo)
            If MsgResult = vbNo Then
                e.Cancel = True
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub pic_MouseMove(sender As Object, e As MouseEventArgs) Handles IMG_Main1.MouseMove, IMG_Main2.MouseMove, IMG_Main3.MouseMove, IMG_Main4.MouseMove, IMG_Main5.MouseMove, IMG_Main6.MouseMove
        Dim effetRealise As DragDropEffects
        Dim pic As PictureBox = sender

        If e.Button = MouseButtons.Left AndAlso pic.Image IsNot Nothing Then
            pic.AllowDrop = False
            effetRealise = pic.DoDragDrop(pic.Image, DragDropEffects.Move)

            If effetRealise = DragDropEffects.Move Then
                pic.Image = Nothing

            End If
            pic.AllowDrop = True
        End If
    End Sub

    Private Sub pic_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pic_DragDrop(sender As Object, e As DragEventArgs) Handles IMG_Main1.DragDrop, IMG_Main2.DragDrop, IMG_Main3.DragDrop, IMG_Main4.DragDrop, IMG_Main5.DragDrop, IMG_Main6.DragDrop
        Dim NbCol As Integer
        Dim NbLn As Integer

        Dim NbDecale As Integer = 0
        Do
            NbDecale = NbDecale + 1
        Loop While IsNumeric(Mid(sender.Name, NbDecale + 1, 1))
        NbCol = Mid(sender.Name, 2, NbDecale - 1)
        NbLn = Mid(sender.Name, 2 + NbDecale, sender.Name.Length)

        If (QwirkleGame.Plateau.VerifPlacement(NbCol - 1, NbLn - 1)) Then
            Dim pic As PictureBox = sender
            pic.Image = e.Data.GetData(DataFormats.Bitmap)

            BT_Change.Enabled = False
            BT_Validate.Enabled = True

            QwirkleGame.Plateau.AddPieceToAdd(QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(DraggedMain - 1), NbCol - 1, NbLn - 1)
            If (NbCol = SizePlateau Or NbLn = SizePlateau Or NbCol = 1 Or NbLn = 1) Then
                NewLine()
                NewLine()
                NewColomn()
                NewColomn()
                SizePlateau = SizePlateau + 2
                QwirkleGame.Plateau.ExtendSize()
                UpdateToUI()
                UpdatePosToAddToUI()
            End If
        Else
            QwirkleGame.Plateau.ResetPiecesToAdd()
            QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).ResetToChange()
            UpdateToUI()
            UpdateMain()
            ResetSelectionMain()
            BT_Change.Enabled = True
            BT_Validate.Enabled = False
        End If
    End Sub

    Private Sub pb1_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles IMG_Main1.GiveFeedback, IMG_Main2.GiveFeedback, IMG_Main3.GiveFeedback, IMG_Main4.GiveFeedback, IMG_Main5.GiveFeedback, IMG_Main6.GiveFeedback
        e.UseDefaultCursors = False
        Dim myPic As New Bitmap(CType(sender, PictureBox).Image)
        Dim cursorImage
        cursorImage = myPic.GetThumbnailImage(50, 50, Nothing, IntPtr.Zero)
        Try
            Cursor.Current = New Cursor(CType(cursorImage, System.Drawing.Bitmap).GetHicon())
        Catch ex As Exception

        End Try


        DraggedMain = Mid(sender.Name, 9, 1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Qwirkle"
        IMG_Main1.AllowDrop = True
        IMG_Main2.AllowDrop = True
        IMG_Main3.AllowDrop = True
        IMG_Main4.AllowDrop = True
        IMG_Main5.AllowDrop = True
        IMG_Main6.AllowDrop = True


        Dim intervalcolonne = 0
        Dim numerobox = 0
        Dim Nbligne = 1
        For bouclecolonne As Integer = 0 To 9

            For boucleligne As Integer = 0 To 555 - 55 Step 55
                Dim PicBox As New PictureBox
                Const taillebox As Integer = 55
                PicBox.Width = taillebox
                PicBox.Top = intervalcolonne
                PicBox.Left = boucleligne + 275
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage
                PicBox.BorderStyle = BorderStyle.FixedSingle
                PicBox.AllowDrop = True
                If numerobox = 10 Then
                    PicBox.Name = ("C" & 1 & "L" & Nbligne)
                    numerobox = 1
                Else
                    numerobox = numerobox + 1
                    PicBox.Name = ("C" & numerobox & "L" & Nbligne)
                End If

                'AddHandler PicBox.MouseMove, AddressOf pic_MouseMove
                AddHandler PicBox.DragDrop, AddressOf pic_DragDrop
                AddHandler PicBox.DragEnter, AddressOf pic_DragEnter
                AddHandler PicBox.GiveFeedback, AddressOf pb1_GiveFeedback
                Me.PNL_Cases.Controls.Add(PicBox)
                '     Me.Paneldynamique.controls.

            Next
            intervalcolonne = intervalcolonne + 50
            Nbligne = Nbligne + 1


        Next


        Panelstatique.AutoScrollPosition = New Point(Panelstatique.Size.Height / 2, (Panelstatique.Size.Width / 2))

        LoadPictures()
        UpdatePlayerName()
        UpdateMain()
        UpdateNbPioche()
    End Sub

    Sub LoadPictures()
        'Couleur : Yellow, Blue, Pink, Green, Orange, Red
        'Forme : Star, Cross, Lozenge, Flower, Circle, Square
        TuilesIcons(0, 0) = My.Resources.YellowStar
        TuilesIcons(0, 1) = My.Resources.YellowCross
        TuilesIcons(0, 2) = My.Resources.YellowLozenge
        TuilesIcons(0, 3) = My.Resources.YellowFlower
        TuilesIcons(0, 4) = My.Resources.YellowCircle
        TuilesIcons(0, 5) = My.Resources.YellowSquare

        TuilesIcons(1, 0) = My.Resources.BlueStar
        TuilesIcons(1, 1) = My.Resources.BlueCross
        TuilesIcons(1, 2) = My.Resources.BlueLozenge
        TuilesIcons(1, 3) = My.Resources.BlueFlower
        TuilesIcons(1, 4) = My.Resources.BlueCircle
        TuilesIcons(1, 5) = My.Resources.BlueSquare

        TuilesIcons(2, 0) = My.Resources.PinkStar
        TuilesIcons(2, 1) = My.Resources.PinkCross
        TuilesIcons(2, 2) = My.Resources.PinkLozenge
        TuilesIcons(2, 3) = My.Resources.PinkFlower
        TuilesIcons(2, 4) = My.Resources.PinkCircle
        TuilesIcons(2, 5) = My.Resources.PinkSquare

        TuilesIcons(3, 0) = My.Resources.GreenStar
        TuilesIcons(3, 1) = My.Resources.GreenCross
        TuilesIcons(3, 2) = My.Resources.GreenLozenge
        TuilesIcons(3, 3) = My.Resources.GreenFlower
        TuilesIcons(3, 4) = My.Resources.GreenCircle
        TuilesIcons(3, 5) = My.Resources.GreenSquare

        TuilesIcons(4, 0) = My.Resources.OrangeStar
        TuilesIcons(4, 1) = My.Resources.OrangeCross
        TuilesIcons(4, 2) = My.Resources.OrangeLozenge
        TuilesIcons(4, 3) = My.Resources.OrangeFlower
        TuilesIcons(4, 4) = My.Resources.OrangeCircle
        TuilesIcons(4, 5) = My.Resources.OrangeSquare

        TuilesIcons(5, 0) = My.Resources.RedStar
        TuilesIcons(5, 1) = My.Resources.RedCross
        TuilesIcons(5, 2) = My.Resources.RedLozenge
        TuilesIcons(5, 3) = My.Resources.RedFlower
        TuilesIcons(5, 4) = My.Resources.RedCircle
        TuilesIcons(5, 5) = My.Resources.RedSquare
    End Sub

    Sub UpdatePlayerName()
        LBL_PlayerName.Text = QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetName()
    End Sub

    Sub UpdateScore()
        LBL_Score.Text = QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPoint()
    End Sub

    Private Sub UpdateMain()
        'Couleur : Yellow, Blue, Pink, Green, Orange, Red
        'Forme : Star, Cross, Lozenge, Flower, Circle, Square
        Dim ColorCode As Integer
        Dim FormCode As Integer

        For BoucleMainTuiles = 0 To 5
            If QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetCouleur() = "Yellow" Then
                ColorCode = 0
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetCouleur() = "Blue" Then
                ColorCode = 1
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetCouleur() = "Pink" Then
                ColorCode = 2
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetCouleur() = "Green" Then
                ColorCode = 3
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetCouleur() = "Orange" Then
                ColorCode = 4
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetCouleur() = "Red" Then
                ColorCode = 5
            End If

            If QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetForme() = "Star" Then
                FormCode = 0
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetForme() = "Cross" Then
                FormCode = 1
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetForme() = "Lozenge" Then
                FormCode = 2
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetForme() = "Flower" Then
                FormCode = 3
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetForme() = "Circle" Then
                FormCode = 4
            ElseIf QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).GetPieceFromMain(BoucleMainTuiles).GetForme() = "Square" Then
                FormCode = 5
            End If

            For Each MainEmplacement As PictureBox In Me.GB_Main.Controls
                If MainEmplacement.Name = ("IMG_Main" & (BoucleMainTuiles + 1).ToString()) Then
                    MainEmplacement.Image = TuilesIcons(ColorCode, FormCode)
                End If
            Next
        Next
    End Sub

    Private Sub UpdateNbPioche()
        LBL_NbPioche.Text = QwirkleGame.Pioche.GetNbPieces()
        If (QwirkleGame.Pioche.GetNbPieces() = 0) Then
            MsgBox("Le gagnant est " & QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.SeeWinner() - 1).GetName() & " !", MsgBoxStyle.Exclamation)
            End
        End If
    End Sub

    Private Sub UpdateToUI()
        Dim NbCol As Integer
        Dim NbLn As Integer

        For Each Emplacement As PictureBox In PNL_Cases.Controls
            If (Mid(Emplacement.Name, 1, 5) <> "Marge") Then
                Dim NbDecale As Integer = 0
                Do
                    NbDecale = NbDecale + 1
                Loop While IsNumeric(Mid(Emplacement.Name, NbDecale + 1, 1))
                NbCol = Mid(Emplacement.Name, 2, NbDecale - 1)
                NbLn = Mid(Emplacement.Name, 2 + NbDecale, Emplacement.Name.Length)


                If QwirkleGame.Plateau.GetGrilleIndex(NbCol - 1, NbLn - 1) > 0 Then
                    'Couleur : Yellow, Blue, Pink, Green, Orange, Red
                    'Forme : Star, Cross, Lozenge, Flower, Circle, Square
                    Dim ColorCode As Integer
                    Dim FormCode As Integer

                    If QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetCouleur() = "Yellow" Then
                        ColorCode = 0
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetCouleur() = "Blue" Then
                        ColorCode = 1
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetCouleur() = "Pink" Then
                        ColorCode = 2
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetCouleur() = "Green" Then
                        ColorCode = 3
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetCouleur() = "Orange" Then
                        ColorCode = 4
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetCouleur() = "Red" Then
                        ColorCode = 5
                    End If

                    If QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetForme() = "Star" Then
                        FormCode = 0
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetForme() = "Cross" Then
                        FormCode = 1
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetForme() = "Lozenge" Then
                        FormCode = 2
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetForme() = "Flower" Then
                        FormCode = 3
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetForme() = "Circle" Then
                        FormCode = 4
                    ElseIf QwirkleGame.Plateau.GetAddedPieceInformation(NbCol - 1, NbLn - 1).GetForme() = "Square" Then
                        FormCode = 5
                    End If

                    Emplacement.Image = TuilesIcons(ColorCode, FormCode)
                Else
                    Emplacement.Image = Nothing
                End If
            End If
        Next
    End Sub

    Sub UpdatePosToAddToUI()
        For BouclePieceToAdd = 0 To QwirkleGame.Plateau.GetNbPiecesToAdd - 1
            'Couleur : Yellow, Blue, Pink, Green, Orange, Red
            'Forme : Star, Cross, Lozenge, Flower, Circle, Square
            Dim ColorCode As Integer
            Dim FormCode As Integer

            If QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetCouleur() = "Yellow" Then
                ColorCode = 0
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetCouleur() = "Blue" Then
                ColorCode = 1
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetCouleur() = "Pink" Then
                ColorCode = 2
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetCouleur() = "Green" Then
                ColorCode = 3
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetCouleur() = "Orange" Then
                ColorCode = 4
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetCouleur() = "Red" Then
                ColorCode = 5
            End If

            If QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetForme() = "Star" Then
                FormCode = 0
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetForme() = "Cross" Then
                FormCode = 1
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetForme() = "Lozenge" Then
                FormCode = 2
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetForme() = "Flower" Then
                FormCode = 3
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetForme() = "Circle" Then
                FormCode = 4
            ElseIf QwirkleGame.Plateau.GetPieceToAddInCollection(BouclePieceToAdd).GetForme() = "Square" Then
                FormCode = 5
            End If

            For Each Emplacement As PictureBox In PNL_Cases.Controls
                If Emplacement.Name = ("C" & QwirkleGame.Plateau.GetPosToAdd()(BouclePieceToAdd, 0) + 1 & "L" & QwirkleGame.Plateau.GetPosToAdd()(BouclePieceToAdd, 1) + 1) Then
                    Emplacement.Image = TuilesIcons(ColorCode, FormCode)
                End If
            Next
        Next
    End Sub

    Dim clickevenement(6) As Boolean
    Private Sub picjoueur_Click(sender As Object, e As EventArgs) Handles IMG_Main1.Click, IMG_Main2.Click, IMG_Main3.Click, IMG_Main4.Click, IMG_Main5.Click, IMG_Main6.Click
        Dim NbSelectedMain As Integer = Mid(sender.Name, sender.Name.Length, sender.Name.Length)

        If (clickevenement(NbSelectedMain) = False) Then
            sender.BorderStyle = BorderStyle.Fixed3D
            sender.Size = New System.Drawing.Size(40, 40)
            clickevenement(NbSelectedMain) = True
            sender.Location = New Point(sender.Location.X + 5, sender.Location.Y + 5)
            QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).AddToChange(NbSelectedMain - 1)
            BT_Change.Enabled = True

        ElseIf (clickevenement(NbSelectedMain) = True) Then
            sender.BorderStyle = BorderStyle.FixedSingle
            sender.Size = New System.Drawing.Size(50, 50)
            clickevenement(NbSelectedMain) = False
            sender.Location = New Point(sender.Location.X - 5, sender.Location.Y - 5)
            QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).RemoveToChange(NbSelectedMain - 1)

        End If

    End Sub

    Private Sub NewColomn()
        Dim intervalcolonne = 0
        Dim numerobox = 0
        Dim Nbligne = 1
        Dim nom() As String = PNL_Cases.Controls(PNL_Cases.Controls.Count - 1).Name.Split(CChar("L"))


        For bouclecolonne As Integer = 0 To 0



            For boucleligne As Integer = 0 To 9 + cliquecol
                Dim PicBox As New PictureBox
                Const taillebox As Integer = 55
                PicBox.Width = taillebox
                PicBox.Top = intervalcolonne
                PicBox.Left = 10 * 55 + 275 + Nbtour
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage
                PicBox.BorderStyle = BorderStyle.FixedSingle
                PicBox.AllowDrop = True
                PicBox.Name = "C" & 10 + nbcolonnedynamique & "L" & Nbligne
                Nbligne = Nbligne + 1

                'AddHandler PicBox.MouseMove, AddressOf pic_MouseMove
                AddHandler PicBox.DragDrop, AddressOf pic_DragDrop
                AddHandler PicBox.DragEnter, AddressOf pic_DragEnter
                AddHandler PicBox.GiveFeedback, AddressOf pb1_GiveFeedback
                Me.PNL_Cases.Controls.Add(PicBox)
                intervalcolonne = intervalcolonne + 50
            Next
            intervalcolonne = 0
        Next
        cliquelig = cliquelig + 1
        Nbtour = Nbtour + 55
        nbcolonnedynamique = nbcolonnedynamique + 1
        Dim Marge As New PictureBox

        If (Margedroite + 10) >= 12 Then
            If Margedroite >= 3 Then
                Dim T As Control()
                T = Me.PNL_Cases.Controls.Find("Marge" & Margedroite + 9, True)
                Me.PNL_Cases.Controls.Remove(T(0))
            End If
            Margedroite = Margedroite + 10
            Const taillebox As Integer = 55
            Marge.Width = taillebox
            Marge.Top = 9
            Marge.Left = 275 + Margedroite * 55 + 275
            Marge.BorderStyle = BorderStyle.None
            Marge.Name = "Marge" & Margedroite

            Me.PNL_Cases.Controls.Add(Marge)
            Margedroite = Margedroite - 10
        End If
        Margedroite = Margedroite + 1


        Marge = Nothing

    End Sub

    Private Sub NewLine()
        Dim numerobox = 0
        Dim nom() As String = PNL_Cases.Controls(PNL_Cases.Controls.Count - 1).Name.Split(CChar("L"))
        Dim espacement = 0
        Dim nbcolonne = 1

        For bouclecolonne As Integer = 0 To 9 + cliquelig



            For boucleligne As Integer = 0 To 55 - 55 Step 55
                Dim PicBox As New PictureBox
                Const taillebox As Integer = 55
                PicBox.Width = taillebox
                PicBox.Top = 9 * 55 + 5 + espacementbas
                PicBox.Left = 275 + espacement
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage
                PicBox.BorderStyle = BorderStyle.FixedSingle
                PicBox.AllowDrop = True
                PicBox.Name = "C" & nbcolonne & "L" & 10 + Nblignedynamique
                nbcolonne = nbcolonne + 1

                'AddHandler PicBox.MouseMove, AddressOf pic_MouseMove
                AddHandler PicBox.DragDrop, AddressOf pic_DragDrop
                AddHandler PicBox.DragEnter, AddressOf pic_DragEnter
                AddHandler PicBox.GiveFeedback, AddressOf pb1_GiveFeedback
                Me.PNL_Cases.Controls.Add(PicBox)
                espacement = espacement + 55
            Next
        Next
        espacementbas = espacementbas + 50
        cliquecol = cliquecol + 1
        Nblignedynamique = Nblignedynamique + 1


    End Sub

    Private Sub buttonAnnuler_Click(sender As Object, e As EventArgs) Handles BT_Cancel.Click
        QwirkleGame.Plateau.ResetPiecesToAdd()
        QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).ResetToChange()
        UpdateToUI()
        UpdateMain()
        ResetSelectionMain()
        BT_Change.Enabled = True
        BT_Validate.Enabled = False
    End Sub

    Sub ResetSelectionMain()
        For Each Main As PictureBox In GB_Main.Controls
            If Main.Size.Width = 40 And Main.Size.Height = 40 Then
                Main.Size = New System.Drawing.Size(50, 50)
                Main.Location = New Point(Main.Location.X - 5, Main.Location.Y - 5)
                Main.BorderStyle = BorderStyle.FixedSingle
            End If
        Next
        For MainCompteur As Integer = 0 To 6
            clickevenement(MainCompteur) = False
        Next
    End Sub

    Private Sub ButtonEchanger_Click(sender As Object, e As EventArgs) Handles BT_Change.Click
        If (QwirkleGame.Pioche.GetNbPieces() <> 0) Then
            QwirkleGame.Plateau.ResetPiecesToAdd()
            QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).ChangeSelectedPieces()
            UpdateMain()
            UpdateNbPioche()
            BT_Change.Enabled = False
            ResetSelectionMain()
            PNL_Cases.Enabled = False
            BT_Validate.Enabled = True
            BT_Cancel.Enabled = False
        End If
    End Sub

    Private Sub BT_Validate_Click(sender As Object, e As EventArgs) Handles BT_Validate.Click
        'Gestion de la main du joueur
        Dim NbMain As Integer
        QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).AddPoint(QwirkleGame.Plateau.GetNbPiecesToAdd())
        For Each MainControl As PictureBox In GB_Main.Controls
            If (IsNothing(MainControl.Image)) Then
                NbMain = Mid(MainControl.Name, 9, 1)
                QwirkleGame.Joueur.GetPlayerInTab(QwirkleGame.Joueur.GetActualPlayer() - 1).ReplacePieceInMain(NbMain - 1)
            End If
        Next

        'Ajout des pièces nécessaires
        QwirkleGame.Plateau.AddPiece()
        UpdateToUI()
        QwirkleGame.Plateau.ResetPiecesToAdd()

        'Passage au joueur suivant
        QwirkleGame.Joueur.NextPlayer()
        UpdateToUI()
        UpdateMain()
        UpdatePlayerName()
        UpdateNbPioche()
        UpdateScore()

        'Mise à jour des accès à l'interface
        BT_Cancel.Enabled = True
        BT_Change.Enabled = False
        BT_Validate.Enabled = False
        PNL_Cases.Enabled = True
    End Sub
End Class