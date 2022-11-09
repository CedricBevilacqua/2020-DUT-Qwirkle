using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleGame;

namespace QwirkleGameTests
{
    [TestClass]
    public class JoueurTests
    {
        [TestMethod]
        public void AddNameTest()
        {
            Joueur Louis = new Joueur();
            Louis.AddName("Louis");
            Assert.AreEqual("Louis", Louis.GetName());
        }

        [TestMethod]
        public void AddAgeTest()
        {
            Joueur Louis = new Joueur();

            Louis.AddAge(20);
            Assert.AreEqual(20, Louis.GetAge());

            Louis.AddAge(-5);
            Assert.AreEqual(20, Louis.GetAge());

            Louis.AddAge(0);
            Assert.AreEqual(20, Louis.GetAge());
        }

        [TestMethod]
        public void AddPointsTest()
        {
            Joueur Louis = new Joueur();

            Louis.AddPoint(0);
            Louis.AddPoint(30);
            Louis.AddPoint(54);
            Louis.AddPoint(0);
            Louis.AddPoint(-4);

            Assert.AreEqual(84,Louis.GetPoint());
        }

        [TestMethod]
        public void AddToChangeTest()
        {
            Joueur.GetPlayerInTab(1).AddToChange(1);
            Assert.AreEqual(true,Joueur.GetPlayerInTab(1).GetToChange()[1]);
        }

        [TestMethod]
        public void RemoveToChangeTest()
        {
            Joueur.GetPlayerInTab(1).RemoveToChange(1);
            Assert.AreEqual(false, Joueur.GetPlayerInTab(1).GetToChange()[1]);
        }

        [TestMethod]
        public void ResetToChangeTest()
        {
            Joueur.GetPlayerInTab(1).AddToChange(0);
            Joueur.GetPlayerInTab(1).AddToChange(1);
            Joueur.GetPlayerInTab(1).AddToChange(5);
            Joueur.GetPlayerInTab(1).ResetToChange();
            Assert.AreEqual(false, Joueur.GetPlayerInTab(1).GetToChange()[0]);
            Assert.AreEqual(false, Joueur.GetPlayerInTab(1).GetToChange()[1]);
            Assert.AreEqual(false, Joueur.GetPlayerInTab(1).GetToChange()[5]);
        }

        [TestMethod]
        public void VerifAvaiablePossibilitiesTest()
        {
        }

        [TestMethod]
        public void AddNbJoueurTest()
        {
            Joueur.AddNbJoueur();
            Joueur.AddNbJoueur();
            Joueur.AddNbJoueur();
            Joueur.AddNbJoueur();
            Joueur.AddNbJoueur();

            Assert.AreEqual(4,Joueur.GetNbJoueur());
        }

        [TestMethod]
        public void RemoveNbJoueurTest()
        {
            for (int Boucle = 0; Boucle < 4; Boucle++)
            {
                Joueur.RemoveNbJoueur();
            }
            Joueur.RemoveNbJoueur();
            Joueur.AddNbJoueur();
            Joueur.AddNbJoueur();
            Joueur.AddNbJoueur();
            Joueur.RemoveNbJoueur();
            Joueur.RemoveNbJoueur();

            Assert.AreEqual(1,Joueur.GetNbJoueur());
        }

        [TestMethod]
        public void DistributionPionsTest()
        {
            while (Joueur.GetNbJoueur() < 4)
            {
                Joueur.AddNbJoueur();
            }
            Joueur.DistributionPion();
        }

        [TestMethod]
        public void ReplacePieceInMainTest()
        {
            string Color = Joueur.GetPlayerInTab(0).GetPieceFromMain(1).GetCouleur();
            string Form = Joueur.GetPlayerInTab(0).GetPieceFromMain(1).GetForme();
            do
            {
                Joueur.GetPlayerInTab(0).ReplacePieceInMain(1);
            } while ((Joueur.GetPlayerInTab(0).GetPieceFromMain(1).GetCouleur() != Color) || (Joueur.GetPlayerInTab(0).GetPieceFromMain(1).GetForme() != Form)); //Essaie jusqu'à ce que la pioche soit vide et qu'une erreur se produise
        }

        [TestMethod]
        public void SeeMainTest()
        {
            if (Joueur.GetPlayerInTab(0).GetPieceFromMain(0).GetCouleur() != "Yellow") { }
            else if (Joueur.GetPlayerInTab(0).GetPieceFromMain(0).GetCouleur() != "Blue") { }
            else if (Joueur.GetPlayerInTab(0).GetPieceFromMain(0).GetCouleur() != "Pink") { }
            else if (Joueur.GetPlayerInTab(0).GetPieceFromMain(0).GetCouleur() != "Green") { }
            else if (Joueur.GetPlayerInTab(0).GetPieceFromMain(0).GetCouleur() != "Orange") { }
            else if (Joueur.GetPlayerInTab(0).GetPieceFromMain(0).GetCouleur() != "Red") { }
            else
            {
                throw new Exception();
            }
        }

        [TestMethod]
        public void SeeActualPlayerTest()
        {
            Assert.AreEqual(1, Joueur.GetActualPlayer());
        }

        [TestMethod]
        public void NextPlayerTest()
        {
            Assert.AreEqual(1, Joueur.GetActualPlayer());
            Joueur.NextPlayer();
            Assert.AreEqual(2, Joueur.GetActualPlayer());
            Joueur.NextPlayer();
            Assert.AreEqual(3, Joueur.GetActualPlayer());
            Joueur.NextPlayer();
            Assert.AreEqual(4, Joueur.GetActualPlayer());
            Joueur.NextPlayer();
            Assert.AreEqual(1, Joueur.GetActualPlayer());
        }

        [TestMethod]
        public void SeeWinnerTest()
        {
            while(Joueur.GetNbJoueur()<4)
            {
                Joueur.AddNbJoueur();
            }

            Joueur.GetPlayerInTab(0).AddPoint(100);
            Joueur.GetPlayerInTab(1).AddPoint(200);
            Joueur.GetPlayerInTab(2).AddPoint(300);
            Joueur.GetPlayerInTab(3).AddPoint(400);

            Assert.AreEqual(4,Joueur.SeeWinner());

            Joueur.GetPlayerInTab(2).AddPoint(300);
            Assert.AreEqual(3, Joueur.SeeWinner());
        }

        [TestMethod]
        public void GetPlayerTabTest()
        {
            Joueur.GetPlayerInTab(0).AddName("A");
            Joueur.GetPlayerInTab(1).AddName("B");
            Joueur.GetPlayerInTab(2).AddName("C");
            Joueur.GetPlayerInTab(3).AddName("D");

            Assert.AreEqual("A",Joueur.GetPlayerInTab(0).GetName());
            Assert.AreEqual("B", Joueur.GetPlayerInTab(1).GetName());
            Assert.AreEqual("C", Joueur.GetPlayerInTab(2).GetName());
            Assert.AreEqual("D", Joueur.GetPlayerInTab(3).GetName());
        }
    }
}
