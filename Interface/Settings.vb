Public Class FORM_Settings
    Dim compteur As Integer

    Private Sub FenetreParametrage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PNL_Player3.Enabled = False
        PNL_Player4.Enabled = False
        compteur = 0
    End Sub

    Private Sub FenetreParametrage_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        FORM_Accueil.Visible = True
    End Sub

    Private Sub BoutonAjoutJoueur(sender As Object, e As EventArgs) Handles BT_Add.Click
        compteur = compteur + 1
        QwirkleGame.Joueur.AddNbJoueur()
        BT_Delete.Enabled = True
        If compteur >= 2 Then
            compteur = 2
            BT_Add.Enabled = False
            BT_Delete.Enabled = True
        End If
        ActionAjoutRetrait()
    End Sub
    Private Sub BoutonEnleverJoueur(sender As Object, e As EventArgs) Handles BT_Delete.Click
        compteur = compteur - 1
        QwirkleGame.Joueur.RemoveNbJoueur()
        If compteur <= 0 Then
            compteur = 0
            BT_Add.Enabled = True
            BT_Delete.Enabled = False
        End If
        ActionAjoutRetrait()
    End Sub
    Sub ActionAjoutRetrait()
        If compteur = 0 Then
            PNL_Player3.Enabled = False
        End If
        If compteur = 1 Then
            PNL_Player3.Enabled = True
            PNL_Player4.Enabled = False
        End If
        If compteur = 2 Then
            PNL_Player4.Enabled = True
        End If
    End Sub

    Private Sub ClearBoxFocus(sender As Object, e As EventArgs) Handles TXT_NamePlayer1.GotFocus, TXT_NamePlayer2.GotFocus, TXT_NamePlayer3.GotFocus, TXT_NamePlayer4.GotFocus, TXT_AgePlayer1.GotFocus, TXT_AgePlayer2.GotFocus, TXT_AgePlayer3.GotFocus, TXT_AgePlayer4.GotFocus
        If sender.Text = ("Nom du joueur") Or sender.Text = ("Age du joueur") Then
            sender.Text = ("")
        End If
    End Sub
    Private Sub ResetBoxFocus(sender As Object, e As EventArgs) Handles TXT_NamePlayer1.LostFocus, TXT_NamePlayer2.LostFocus, TXT_NamePlayer3.LostFocus, TXT_NamePlayer4.LostFocus, TXT_AgePlayer1.LostFocus, TXT_AgePlayer2.LostFocus, TXT_AgePlayer3.LostFocus, TXT_AgePlayer4.LostFocus
        If sender.Name.ToString.Substring(0, 14) = ("TXT_NamePlayer") And sender.Text = ("") Then
            sender.Text = ("Nom du joueur")
        ElseIf sender.Name.ToString.Substring(0, 13) = ("TXT_AgePlayer") And sender.Text = ("") Then
            sender.Text = ("Age du joueur")
        End If

    End Sub

    Private Sub BouttonAnnuler_Click(sender As Object, e As EventArgs) Handles BT_Cancel.Click
        FORM_Accueil.Visible = True
        Me.Close()
    End Sub

    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click
        'Vérification de la saisie
        Dim Invalid As Boolean = False
        If TXT_NamePlayer1.Text = ("") Or TXT_NamePlayer1.Text = ("Nom du joueur") Or TXT_NamePlayer2.Text = ("") Or TXT_NamePlayer2.Text = ("Nom du joueur") Then
            Invalid = True
        End If
        If compteur = 1 And (TXT_NamePlayer3.Text = ("") Or TXT_NamePlayer3.Text = ("Nom du joueur")) Then
            Invalid = True
        End If
        If compteur = 2 And (TXT_NamePlayer4.Text = ("") Or TXT_NamePlayer4.Text = ("Nom du joueur")) Then
            Invalid = True
        End If

        If IsNumeric(TXT_AgePlayer1.Text) = False Or IsNumeric(TXT_AgePlayer2.Text) = False Then
            Invalid = True
        End If
        If compteur = 1 And IsNumeric(TXT_AgePlayer3.Text) = False Then
            Invalid = True
        End If
        If compteur = 2 And IsNumeric(TXT_AgePlayer4.Text) = False Then
            Invalid = True
        End If

        If TXT_NamePlayer1.Text = TXT_NamePlayer2.Text Then
            Invalid = True
        End If
        If compteur = 1 And (TXT_NamePlayer1.Text = TXT_NamePlayer3.Text Or TXT_NamePlayer2.Text = TXT_NamePlayer3.Text) Then
            Invalid = True
        End If
        If compteur = 2 And (TXT_NamePlayer1.Text = TXT_NamePlayer4.Text Or TXT_NamePlayer2.Text = TXT_NamePlayer4.Text Or TXT_NamePlayer3.Text = TXT_NamePlayer4.Text) Then
            Invalid = True
        End If

        If Invalid = True Then
            MsgBox("Une information entrée est incorrecte.", MsgBoxStyle.Critical)
        Else
            'Lancement de la partie
            QwirkleGame.Joueur.GetPlayerInTab(0).AddName(TXT_NamePlayer1.Text)
            QwirkleGame.Joueur.GetPlayerInTab(0).AddAge(TXT_AgePlayer1.Text)
            QwirkleGame.Joueur.GetPlayerInTab(1).AddName(TXT_NamePlayer2.Text)
            QwirkleGame.Joueur.GetPlayerInTab(1).AddAge(TXT_AgePlayer2.Text)
            If compteur >= 1 Then
                QwirkleGame.Joueur.GetPlayerInTab(2).AddName(TXT_NamePlayer3.Text)
                QwirkleGame.Joueur.GetPlayerInTab(2).AddAge(TXT_AgePlayer3.Text)
            End If
            If compteur = 2 Then
                QwirkleGame.Joueur.GetPlayerInTab(3).AddName(TXT_NamePlayer4.Text)
                QwirkleGame.Joueur.GetPlayerInTab(3).AddAge(TXT_AgePlayer4.Text)
            End If
            Me.Visible = False
            QwirkleGame.Joueur.DistributionPion()
            Dim FirstToStart As Integer = QwirkleGame.Joueur.FirstToStart()
            While (QwirkleGame.Joueur.GetActualPlayer() <> FirstToStart + 1)
                QwirkleGame.Joueur.NextPlayer()
            End While
            FORM_Game.Show()
        End If
    End Sub
End Class