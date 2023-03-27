using System;
using Hra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HerniMechanikyTesty
{
    [TestClass]
    public class HerniPostavaTesty
    {
        HerniPostava herniPostava;

        [TestInitialize] 
        public void Initialize()
        {
            herniPostava = new HerniPostava();
        }

        [TestCleanup]
        public void Cleanup() 
        {
            
        }


        [TestMethod]
        public void ZapisJmeno()
        {
            herniPostava.Jmeno = "TestJmeno";
            Assert.IsTrue(herniPostava.Jmeno == "TestJmeno");
        }

        [TestMethod]
        public void ZapisJmenoVetsiJakDeset()
        {
            herniPostava.Jmeno = "TestJmenoVetsiJakDeset";
            Assert.AreNotEqual("TestJmenoVetsiJakDeset", herniPostava.Jmeno);
        }

        [TestMethod]
        public void ZmenaPozice()
        {
            herniPostava.ZmenaPozice();
            Assert.AreEqual(5, herniPostava.PoziceX);
            Assert.AreEqual(5, herniPostava.PoziceY);
        }

        [TestMethod]
        public void TestToString()
        {
            herniPostava.Jmeno = "TestJmeno";
            herniPostava.ZmenaPozice();

            Assert.AreEqual("Jm�no: TestJmeno"
                + "\nLevel: 1"
                + "\nPozice X: 5"
                + "\nPozice Y: 5", herniPostava.ToString());
        }
    }
}