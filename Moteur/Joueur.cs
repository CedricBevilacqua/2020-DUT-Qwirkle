using System;
using System.Collections.Generic;

namespace QwirkleGame
{
    public class Joueur
    {
        // Attributs
        private string Name;
        private int Age;
        private List<Tuile> Main = new List<Tuile>();
        private int Points = 0;
        private static int NbJoueurs = 2;
        private static int ActualPlayer = 1; //Joueur actuellement en jeu
        private static Joueur[] TabPlayers = new Joueur[4];
        private static bool[] MainToChange = new bool[6];

        // Constructeur

        static Joueur()
        {
            for (int Boucle = 0; Boucle < 4; Boucle++)
            {
                TabPlayers[Boucle] = new Joueur();
            }
        }

        // Méthodes
        public void AddName(string Name)
        {
            this.Name = Name;
        }

        public void AddAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
        }

        public void AddPoint(int PointsToAdd)
        {
            if (PointsToAdd > 0)
            {
                Points = Points + PointsToAdd;
            }
        }

        public void AddToChange(int NbMain)
        {
            MainToChange[NbMain] = true;
        }

        public void RemoveToChange(int NbMain)
        {
            MainToChange[NbMain] = false;
        }

        public void ResetToChange()
        {
            for (int CompteurMain = 0; CompteurMain < 6; CompteurMain++)
            {
                MainToChange[CompteurMain] = false;
            }
        }

        public void ChangeSelectedPieces()
        {
            for (int NbMainCompteur = 0; NbMainCompteur < 6; NbMainCompteur++)
            {
                if (MainToChange[NbMainCompteur] == true)
                {
                    ReplacePieceInMain(NbMainCompteur);
                }
            }
            MainToChange = new bool[6];
        }

        public void ReplacePieceInMain(int IndexToReplace)
        {
            if(Pioche.GetNbPieces() != 0)
            {
                Main.RemoveAt(IndexToReplace);
                List<Tuile> TuileToIncrust = new List<Tuile>();
                TuileToIncrust.Add(Pioche.RandomPiece());
                Main.InsertRange(IndexToReplace, TuileToIncrust);
            }
        }

        public static void AddNbJoueur()
        {
            if (NbJoueurs < 4)
            {
                NbJoueurs++;
            }
        }

        public static void RemoveNbJoueur()
        {
            if (NbJoueurs > 0)
            {
                NbJoueurs--;
            }
        }

        public static void DistributionPion()
        {
            for (int JoueurTirage = 0; JoueurTirage < NbJoueurs; JoueurTirage++)
            {
                for (int PiecesTirees = 0; PiecesTirees < 6; PiecesTirees++)
                {
                    TabPlayers[JoueurTirage].Main.Add(Pioche.RandomPiece());
                }
            }
        }

        public static int FirstToStart()
        {
            int[] CommonCar = new int[NbJoueurs];

            for (int BouclePlayer = 0; BouclePlayer < NbJoueurs; BouclePlayer++)
            {
                int[] TriFormes = new int[6];
                int[] TriCouleurs = new int[6];
                //Classement des caractéristiques
                for (int NbMainCompteur = 0; NbMainCompteur < 6; NbMainCompteur++)
                {
                    Tuile MainTuile = TabPlayers[BouclePlayer].GetPieceFromMain(NbMainCompteur);
                    //Formes communes : Star, Cross, Lozenge, Flower, Circle, Square
                    if (MainTuile.GetForme() == "Star")
                    {
                        TriFormes[0]++;
                    }
                    else if (MainTuile.GetForme() == "Cross")
                    {
                        TriFormes[1]++;
                    }
                    else if (MainTuile.GetForme() == "Lozenge")
                    {
                        TriFormes[2]++;
                    }
                    else if (MainTuile.GetForme() == "Flower")
                    {
                        TriFormes[3]++;
                    }
                    else if (MainTuile.GetForme() == "Circle")
                    {
                        TriFormes[4]++;
                    }
                    else if (MainTuile.GetForme() == "Square")
                    {
                        TriFormes[5]++;
                    }
                    //Couleurs communes : Yellow, Blue, Pink, Green, Orange, Red
                    if (MainTuile.GetCouleur() == "Yellow")
                    {
                        TriCouleurs[0]++;
                    }
                    else if (MainTuile.GetCouleur() == "Blue")
                    {
                        TriCouleurs[1]++;
                    }
                    else if (MainTuile.GetCouleur() == "Pink")
                    {
                        TriCouleurs[2]++;
                    }
                    else if (MainTuile.GetCouleur() == "Green")
                    {
                        TriCouleurs[3]++;
                    }
                    else if (MainTuile.GetCouleur() == "Orange")
                    {
                        TriCouleurs[4]++;
                    }
                    else if (MainTuile.GetCouleur() == "Red")
                    {
                        TriCouleurs[5]++;
                    }
                }
                //Calcul du plus grand nombre de correspondances
                for (int ParcoursFormes = 0; ParcoursFormes < 6; ParcoursFormes++)
                {
                    if (TriFormes[ParcoursFormes] > CommonCar[BouclePlayer])
                    {
                        CommonCar[BouclePlayer] = TriFormes[ParcoursFormes];
                    }
                }
                for (int ParcoursCouleurs = 0; ParcoursCouleurs < 6; ParcoursCouleurs++)
                {
                    if (TriFormes[ParcoursCouleurs] > CommonCar[BouclePlayer])
                    {
                        CommonCar[BouclePlayer] = TriCouleurs[ParcoursCouleurs];
                    }
                }
            }
            
            int PlayerWhoStart = 0;
            if (UnicityCaracteristics(CommonCar, CalcNbCommonCar(PlayerWhoStart, CommonCar)) > 1) //Si le nombre de caractéristiques communes est supérieur à 1
            {
                return ChoiceFromAge(UnicityCaracteristics(CommonCar, CalcNbCommonCar(PlayerWhoStart, CommonCar))); //Choix en fonction de l'âge
            }
            else
            {
                return PlayerWhoStart;
            }
        }

        private static int ChoiceFromAge(int NbIdenticCommons)
        {
                int Older = 0;
                int OlderPlayer = 0;
                for (int BoucleJoueur = 0; BoucleJoueur < NbJoueurs; BoucleJoueur++)
                {
                    if (TabPlayers[BoucleJoueur].GetAge() > Older)
                    {
                        Older = TabPlayers[BoucleJoueur].GetAge();
                        OlderPlayer = BoucleJoueur;
                    }
                }
                return OlderPlayer;
        }

        private static int UnicityCaracteristics(int[] CommonCar, int BestCommonCar)
        {
            int NbIdenticCommons = 0;
            for (int BoucleJoueur = 0; BoucleJoueur < NbJoueurs; BoucleJoueur++)
            {
                if (CommonCar[BoucleJoueur] == BestCommonCar)
                {
                    NbIdenticCommons++;
                }
            }
            return NbIdenticCommons;
        }

        private static int CalcNbCommonCar(int PlayerWhoStart, int[] CommonCar)
        {
            int BestCommonCar = 0;
            for (int BoucleJoueur = 0; BoucleJoueur < NbJoueurs; BoucleJoueur++)
            {
                if (CommonCar[BoucleJoueur] > BestCommonCar)
                {
                    BestCommonCar = CommonCar[BoucleJoueur];
                    PlayerWhoStart = BoucleJoueur;
                }
            }
            return BestCommonCar;
        }

        public static void NextPlayer()
        {
            ActualPlayer++;
            if (ActualPlayer > NbJoueurs)
            {
                ActualPlayer = 1;
            }
        }

        public static int SeeWinner()
        {
            int NbPlayerWinner = 0;
            int BestScore = TabPlayers[0].Points;
            for (int Boucle = 1; Boucle < NbJoueurs; Boucle++)
            {
                if (TabPlayers[Boucle].Points > BestScore)
                {
                    NbPlayerWinner = Boucle;
                    BestScore = TabPlayers[Boucle].Points;
                }
            }
            return NbPlayerWinner + 1;
        }

        public Boolean VerifAvailablePossibilities()
        {
            throw new NotImplementedException();
        }

        //Getter et Setter utiles pour les tests
        public Tuile GetPieceFromMain(int IndexToSee)
        {
            return this.Main[IndexToSee];
        }

        public static Joueur GetPlayerInTab(int PlayerNumber)
        {
            return TabPlayers[PlayerNumber];
        }

        public static int GetActualPlayer()
        {
            return ActualPlayer;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetPoint()
        {
            return Points;
        }

        public static int GetNbJoueur()
        {
            return NbJoueurs;
        }

        public bool[] GetToChange()
        {
            return MainToChange;
        }
    }
}
