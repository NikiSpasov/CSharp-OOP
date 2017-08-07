using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class DummyTests
    {
        private const int health = 10;
        private const int durability = 10;
        private const int attack = 5;
        private const int axeDurability = 5;
        private Dummy dummy;
        private Axe axe;

        [TestInitialize]
        public void CreateDummyAndAxe()
        {
            this.dummy = new Dummy(health, durability);
            this.axe = new Axe(attack, axeDurability);
        }


        [TestMethod]
        public void DummyHasToLoseHealthIfAttacked()
        {
            var initialHealth = dummy.Health;
            axe.Attack(dummy);
            var afterAttackHealth = dummy.Health;
            Assert.IsTrue(initialHealth > afterAttackHealth, "Dummy does not loose health");

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowExeptionIfDeadDummyIsAttacked()
        {
            Dummy deadDummy = new Dummy(0, 10);
            axe.Attack(deadDummy);
        }

        [TestMethod]
        public void DeadDummyCanGiveXP()
        {
            Dummy deadDummy = new Dummy(0, 10);
            deadDummy.GiveExperience();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AliveDummyCannotGiveXp()
        {
            dummy.GiveExperience();
        }
    }
}
