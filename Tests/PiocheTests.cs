using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleGame;

namespace QwirkleGameTests
{
    [TestClass]
    public class PiocheTests
    {
        [TestMethod]
        public void GetNbPiecesTest()
        {
            Pioche.ResetPioche();
            Assert.AreEqual(108,Pioche.GetNbPieces());
        }

        [TestMethod]
        public void RandomPieceTest()
        {
            int[,] TabListTuiles = new int[6, 6]; //Forme par couleur
            int FormDetected = 0;
            int ColorDetected = 0;

            for (int Boucle = 0; Boucle < 108; Boucle++) //Référencement des éléments dans le tableau
            {
                Tuile tuile = Pioche.RandomPiece();
                
                //Identification de la forme
                if (tuile.GetForme() == "Star")
                {
                    FormDetected = 0;
                }
                else if (tuile.GetForme() == "Cross")
                {
                    FormDetected = 1;
                }
                else if (tuile.GetForme() == "Lozenge")
                {
                    FormDetected = 2;
                }
                else if (tuile.GetForme() == "Flower")
                {
                    FormDetected = 3;
                }
                else if (tuile.GetForme() == "Circle")
                {
                    FormDetected = 4;
                }
                else if (tuile.GetForme() == "Square")
                {
                    FormDetected = 5;
                }

                //Identification de la couleur
                if (tuile.GetCouleur() == "Yellow")
                {
                    ColorDetected = 0;
                }
                else if (tuile.GetCouleur() == "Blue")
                {
                    ColorDetected = 1;
                }
                else if (tuile.GetCouleur() == "Pink")
                {
                    ColorDetected = 2;
                }
                else if (tuile.GetCouleur() == "Green")
                {
                    ColorDetected = 3;
                }
                else if (tuile.GetCouleur() == "Orange")
                {
                    ColorDetected = 4;
                }
                else if (tuile.GetCouleur() == "Red")
                {
                    ColorDetected = 5;
                }

                TabListTuiles[FormDetected, ColorDetected]++;
            }

            for(int BoucleForm = 0; BoucleForm<6; BoucleForm++) //Vérification si toutes les pièces étaient présentes dans la pioche
            {
                for(int BoucleColor = 0; BoucleColor < 6; BoucleColor++)
                {
                    if (TabListTuiles[BoucleForm,BoucleColor] < 3)
                    {
                        throw new Exception("Toutes les tuiles du jeu ne sont pas présentes dans la pioche");
                    }
                }
            }
            Assert.AreEqual(0,Pioche.GetNbPieces());

            try
            {
                Pioche.RandomPiece();
            }
            catch (Exception)
            {
                throw new Exception("La fonction de tirage d'une pièce dans la pioche plante lorsque celle-ci est vide.");
            }

            Assert.AreEqual(0, Pioche.GetNbPieces());
        }
    }
}
