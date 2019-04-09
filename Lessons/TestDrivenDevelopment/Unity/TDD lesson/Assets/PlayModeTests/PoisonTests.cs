using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class PoisonTests
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

    [UnityTest]
    public IEnumerator PoisonDealsDamage()
    {

        GameObject obj = new GameObject();
        obj.AddComponent<Unit>();
        unit = obj.GetComponent<Unit>();
        unit.health = 3;
        unit.poisoned = true;
        float startHealth = unit.health;
        Time.timeScale = 100.0f;

        yield return new WaitForSeconds(5);

        Assert.AreNotEqual(unit.health, startHealth);

        yield break;
    }

    [Test]
    public void UnitStartsNotPoisoned()
    {
        Assert.IsFalse(unit.poisoned);
    }

}
