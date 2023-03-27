using Hra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerniMechanikyTesty
{
    [TestClass]
    public class HracTesty
    {
        Hrac hrac;

        [TestInitialize]
        public void Initialize()
        {
            hrac = new Hrac();
        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        public void ZapisSpecializace() 
        {
            hrac.Specializace = "Kouzelník";
            Assert.AreEqual("Kouzelník", hrac.Specializace);
            hrac.Specializace = "Berserker";
            Assert.AreEqual("Berserker", hrac.Specializace);
            hrac.Specializace = "Inženýr";
            Assert.AreEqual("Inženýr", hrac.Specializace);
            hrac.Specializace = "Cizák";
            hrac.Specializace = "Test";
            Assert.AreEqual("Cizák", hrac.Specializace);
        }

        [TestMethod]
        public void PridejXP()
        {
            hrac.PridejXP(10);
            Assert.AreEqual(10, hrac.XP);

            hrac.PridejXP(290);
            Assert.AreEqual(3, hrac.GetLevel());
        }

        [TestMethod]
        public void TestToString()
        {
            hrac.Jmeno = "TestJmeno";
            hrac.ZmenaPozice();

            Assert.AreEqual("Jméno: TestJmeno"
                + "\nLevel: 1"
                + "\nPozice X: 5"
                + "\nPozice Y: 5"
                + "\nSpecializace: Kouzelník"
                + "\nObličej: VelkyNos" 
                + "\nVlasy: Drdol"
                + "\nBarva vlasů: Kastanova"
                + "\nXP: 1", hrac.ToString());
        }
    }
}
