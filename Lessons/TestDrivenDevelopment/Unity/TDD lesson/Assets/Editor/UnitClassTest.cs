using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnitClassTests
{
    public class Tests
    {


        private const int MAX_HEALTH = 5;
        private const int START_HEALTH = 3;
        private Unit unit;

        [SetUp]
        public void InitializeAUnit()
        {
            unit = new Unit(MAX_HEALTH);
            unit.health = START_HEALTH;
        }

        [TearDown]
        public void RemoveUnit()
        {
            unit = null;
        }

        [Test]
        public void CanAddHealth()
        {
            unit.AddHealth(1);
            Assert.AreEqual(unit.health, START_HEALTH + 1);
        }

        [Test]
        public void NegativeValueStillRemovesHealth()
        {
            unit.RemoveHealth(-1);
            Assert.AreEqual(unit.health, START_HEALTH - 1);
        }

        [Test]
        public void NegativeValueStillAddsHealth()
        {
            unit.AddHealth(-1);
            Assert.AreEqual(unit.health, START_HEALTH + 1);
        }

        [Test]
        public void CanRemoveHealth()
        {
            unit.RemoveHealth(1);
            Assert.AreEqual(unit.health, START_HEALTH - 1);
        }

        [Test]
        public void TruncateHealthToZero()
        {
            unit.RemoveHealth(100);
            Assert.AreEqual(unit.health, 0);
        }

        [Test]
        public void HealthStopsAtMaxHealthLimit()
        {
            unit.AddHealth(100);
            Assert.AreEqual(unit.health, MAX_HEALTH);
        }


        [Test]
        public void SetHealthChangesHealth()
        {
            unit.SetHealth(1);
            Assert.AreEqual(unit.health, 1);
        }

        [Test]
        public void SetHealthToNegativeTruncatesToZero()
        {
            unit.SetHealth(-3);
            Assert.AreEqual(unit.health, 0);
        }

        [Test]
        public void SetHealthStopsAtMaxHealthLimit()
        {
            unit.SetHealth(100);
            Assert.AreEqual(unit.health, MAX_HEALTH);
        }

        [Test]
        public void NewUnitHasHealthSetToMax()
        {
            unit = new Unit();
            Assert.AreEqual(unit.health, MAX_HEALTH);
        }



   


    }
}
