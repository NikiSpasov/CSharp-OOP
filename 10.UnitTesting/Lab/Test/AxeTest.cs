using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class AxeTest
    {
        [TestMethod]
        public void AxeLosesDurabilityAfterEachAtack()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);
            var durabilityPoints = axe.DurabilityPoints;
            axe.Attack(dummy);
            var durabilityPointsAfterAttack = axe.DurabilityPoints;
            Assert.IsTrue(durabilityPoints > durabilityPointsAfterAttack, "Axe does not loose Durability after attack");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AttackingWithBrokenAxe()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 0);
            axe.Attack(dummy);           
        }
    }
}
