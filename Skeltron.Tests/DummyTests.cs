using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeltron.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealtAfterAttack()
        {
            var dummy = new Dummy(10, 10);
            var axe = new Axe(1, 5);


            axe.Attack(dummy);

            Assert.AreEqual(9, dummy.Health, "Dummy don't lose healt after attack");            
        }

        [Test]
        public void AreDummyIsDead()
        {
            var axe = new Axe(10, 10);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }

        [Test]
        public void DummyGiveExpirienceAfterDead()
        {
            var dummy = new Dummy(2, 10);
            var axe = new Axe(10, 10);

            axe.Attack(dummy);
            
            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [Test]
        public void DummyIsDead()
        {
            var dummy = new Dummy(10, 10);
            var axe = new Axe(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(true, dummy.IsDead());
            
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            var dummy = new Dummy(20, 20);
            var axe = new Axe(10, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }


    }
}
