using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace combatTests
{
    public class Tests
    {
        public Unit attacker;
        public Unit defender;

        private const int ATTACKER_DAMAGE = 2;
        private const int DEFENDER_HEALTH = 5;

        [SetUp]
        public void SetUpCombat()
        {
            attacker = new Unit(_damage: ATTACKER_DAMAGE);
            defender = new Unit(_maxHealth: DEFENDER_HEALTH);
        }

        [TearDown]
        public void TearDownCombat()
        {
            attacker = null;
            defender = null;
        }

        [Test]
        public void AttackerDealsDamageToDefender()
        {
            Combat.DoCombat(attacker, defender);
            Assert.AreEqual(defender.health, DEFENDER_HEALTH - ATTACKER_DAMAGE);
        }

        [Test]
        public void AttackerWithNegativeDamageDoesNotHealDefender() // FALSE POSITIVE
        {
            attacker.damage = -ATTACKER_DAMAGE;
            Combat.DoCombat(attacker, defender);
            Assert.AreEqual(defender.health, DEFENDER_HEALTH);
        }
    }
}
