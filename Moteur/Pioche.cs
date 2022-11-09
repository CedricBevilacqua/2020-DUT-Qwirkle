using System;
using System.Collections.Generic;

namespace QwirkleGame
{
    public class Pioche
    {
        private static int NbPieces = 108;
        private static List<Tuile> ListTuiles = new List<Tuile>();
        private static Random rand = new Random();

        static Pioche()
        {
            List<string> FormsListOrder = new List<string> { "Star", "Cross", "Lozenge", "Flower", "Circle", "Square" };
            List<string> ColorsListOrder = new List<string> { "Yellow", "Blue", "Pink", "Green", "Orange", "Red" };
            Tuile[] TabPioche = new Tuile[NbPieces];
            int CreatingNumber = 0;
            foreach (string FormBoucle in FormsListOrder)
            {
                foreach (string ColorBoucle in ColorsListOrder)
                {
                    for (int Boucle = 0; Boucle < 3; Boucle++) //3 tuiles de chaque
                    {
                        TabPioche[CreatingNumber] = new Tuile(FormBoucle, ColorBoucle);
                        ListTuiles.Add(TabPioche[CreatingNumber]);
                        CreatingNumber++;
                    }
                }
            }
        }

        public static Tuile RandomPiece()
        {
            int Aleat = rand.Next(NbPieces);
            int EachCompteur = 0;
            foreach (Tuile tuiles in ListTuiles)
            {
                if (Aleat == EachCompteur)
                {
                    ListTuiles.RemoveAt(Aleat);
                    NbPieces--;
                    return tuiles;
                }
                EachCompteur++;
            }
            return null;
        }

        public static void ResetPioche() //Utilisé dans les tests
        {
            NbPieces = 108;
            ListTuiles.Clear();

            List<string> FormsList = new List<string> { "Star", "Cross", "Lozenge", "Flower", "Circle", "Square" };
            List<string> ColorsList = new List<string> { "Yellow", "Blue", "Pink", "Green", "Orange", "Red" };
            int CreatingNumber = 0;
            Tuile[] TabPioche = new Tuile[NbPieces];
            foreach (string FormBoucle in FormsList) //Star, Cross, Lozenge, Flower, Circle, Square
            {
                foreach (string ColorBoucle in ColorsList) //Yellow, Blue, Pink, Green, Orange, Red
                {
                    for (int Boucle = 0; Boucle < 3; Boucle++) //3 tuiles de chaque
                    {
                        TabPioche[CreatingNumber] = new Tuile(FormBoucle, ColorBoucle);
                        ListTuiles.Add(TabPioche[CreatingNumber]);
                        CreatingNumber++;
                    }
                }
            }
        }

        //Accesseurs
        public static int GetNbPieces()
        {
            return NbPieces;
        }
    }
}
