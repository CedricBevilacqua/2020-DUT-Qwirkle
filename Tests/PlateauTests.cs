using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleGame;
using System;

namespace QwirkleGameTests
{
    [TestClass]
    public class PlateauTests
    {
        [TestMethod]
        public void AddPieceTest()
        {
            Plateau.AddPieceToAdd(Joueur.GetPlayerInTab(0).GetPieceFromMain(1), 3, 9);
            Plateau.AddPiece();
            if (Plateau.GetGrilleIndex()[3, 9] == 0)
            {
                throw new Exception();
            }
            Tuile Test = Plateau.GetAddedPieceInformation(3, 9);
            Plateau.ResetPiecesToAdd();
        }

        [TestMethod]
        public void VerifPlacementTest()
        {
        }

        [TestMethod]
        public void AddPiecesToAddTest()
        {
            Plateau.ResetPiecesToAdd();
            Plateau.AddPieceToAdd(Joueur.GetPlayerInTab(0).GetPieceFromMain(0), 10, 5);
        }

        [TestMethod]
        public void GetToAddPieceInformationTest()
        {
            try
            {
                Tuile RecuperatedPiece = Plateau.GetToAddPieceInformation(0);
                Assert.IsNull(Plateau.GetToAddPieceInformation(1));
            }
            catch
            {
                throw new Exception();
            }
        }

        [TestMethod]
        public void ResetPiecesToAddTest()
        {
            Plateau.ResetPiecesToAdd();

            Assert.AreEqual(0, Plateau.GetPiecesToAdd());
            Assert.AreEqual(0, Plateau.GetNbPiecesToAdd());

            for (int ParcoursCol = 0; ParcoursCol < 2; ParcoursCol++)
            {
                for (int ParcoursLn = 0; ParcoursLn < 6; ParcoursLn++)
                {
                    if (Plateau.GetPosToAdd()[ParcoursLn, ParcoursCol] != 0)
                    {
                        throw new Exception();
                    }
                }
            }
        }

        [TestMethod]
        public void GetCaseInformationTest()
        {
            int ToTestValue;
            try
            {
                for (int ParcoursCol = 0; ParcoursCol < 10; ParcoursCol++)
                {
                    for (int ParcoursLn = 0; ParcoursLn < 10; ParcoursLn++)
                    {
                        ToTestValue = Plateau.GetGrilleIndex()[ParcoursLn, ParcoursCol];
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        [TestMethod]
        public void GetToAddCaseInformationTest()
        {
            int ToTestValue;
            try
            {
                for (int ParcoursCol = 0; ParcoursCol < 2; ParcoursCol++)
                {
                    for (int ParcoursLn = 0; ParcoursLn < 6; ParcoursLn++)
                    {
                        ToTestValue = Plateau.GetToAddCaseInformation()[ParcoursLn, ParcoursCol];
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        //Test du comptage des points

        [TestMethod]
        public void ScoreFirstTuileLn()
        {
            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 3, 5);
            Assert.AreEqual(3, Plateau.ScoreFirstTuileLn(3,5));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 4, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 6, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 7, 5);
            Assert.AreEqual(3, Plateau.ScoreFirstTuileLn(3,5));
            Assert.AreEqual(3, Plateau.ScoreFirstTuileLn(6, 5));
            Assert.AreEqual(3, Plateau.ScoreFirstTuileLn(7, 5));
        }

        [TestMethod]
        public void ScoreNbTuileLn()
        {
            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 3, 5);
            Assert.AreEqual(1, Plateau.ScoreNbTuileLn(3, 5));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 4, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 6, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 7, 5);
            Assert.AreEqual(5, Plateau.ScoreNbTuileLn(3, 5));
            Assert.AreEqual(5, Plateau.ScoreNbTuileLn(6, 5));
            Assert.AreEqual(5, Plateau.ScoreNbTuileLn(7, 5));
        }

        [TestMethod]
        public void ScoreDoubleLn()
        {
            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 3, 5);
            Assert.AreEqual(0, Plateau.ScoreDoubleLn(3, 5));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 3, 4);
            Assert.AreEqual(1, Plateau.ScoreDoubleLn(3, 5));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 2, 5);
            Assert.AreEqual(1, Plateau.ScoreDoubleLn(2, 5));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 2, 6);
            Assert.AreEqual(2, Plateau.ScoreDoubleLn(2, 5));

            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 1, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 2, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 3, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 4, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 5);
            Assert.AreEqual(0, Plateau.ScoreDoubleLn(2, 5));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 1, 4);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 2, 6);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 4);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 6);
            Assert.AreEqual(3, Plateau.ScoreDoubleLn(2, 5));
        }

        [TestMethod]
        public void ScoreFirstTuileCol()
        {
            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 3);
            Assert.AreEqual(3, Plateau.ScoreFirstTuileCol(5, 3));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 4);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 6);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 7);
            Assert.AreEqual(3, Plateau.ScoreFirstTuileCol(3, 5));
            Assert.AreEqual(3, Plateau.ScoreFirstTuileCol(6, 5));
            Assert.AreEqual(3, Plateau.ScoreFirstTuileCol(7, 5));
        }

        [TestMethod]
        public void ScoreNbTuileCol()
        {
            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 3);
            Assert.AreEqual(1, Plateau.ScoreNbTuileCol(5, 3));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 4);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 6);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 7);
            Assert.AreEqual(5, Plateau.ScoreNbTuileCol(5, 3));
            Assert.AreEqual(5, Plateau.ScoreNbTuileCol(5, 6));
            Assert.AreEqual(5, Plateau.ScoreNbTuileCol(5, 7));
        }

        [TestMethod]
        public void ScoreDoubleCol()
        {
            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 3);
            Assert.AreEqual(0, Plateau.ScoreDoubleCol(5, 3));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 4, 3);
            Assert.AreEqual(1, Plateau.ScoreDoubleCol(4, 3));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 2);
            Assert.AreEqual(1, Plateau.ScoreDoubleCol(5, 2));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 6, 2);
            Assert.AreEqual(2, Plateau.ScoreDoubleCol(5, 2));

            Plateau.ResetAllPlateau();

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 1);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 2);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 3);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 4);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 5, 5);
            Assert.AreEqual(0, Plateau.ScoreDoubleCol(5, 2));

            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 4, 1);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 6, 2);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 4, 5);
            Plateau.AddPieceToAdd(Pioche.RandomPiece(), 6, 5);
            Assert.AreEqual(3, Plateau.ScoreDoubleCol(5, 2));
        }

        [TestMethod]
        public void CountPointTest()
        {
        }
    }
}
