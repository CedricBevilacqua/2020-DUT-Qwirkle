using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleGame;

namespace QwirkleGameTests
{
    [TestClass]
    public class TuilesTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Tuile MaTuile = new Tuile("Star","Yellow");
            Assert.AreEqual("Star",MaTuile.GetForme());
            Assert.AreEqual("Yellow", MaTuile.GetCouleur());
        }

    }
}
