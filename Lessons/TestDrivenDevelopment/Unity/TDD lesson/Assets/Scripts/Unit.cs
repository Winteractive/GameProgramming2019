using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public bool poisoned;

    public float health;
    public readonly int maxHealth;

    public int damage;

    public void Update()
    {
        if (poisoned)
        {
            RemoveHealth(1 * Time.deltaTime);
        }
    }

    public Unit(int _maxHealth = 5, int _damage = 1)
    {
        maxHealth = _maxHealth;
        health = maxHealth;
        damage = _damage;
        poisoned = false;
    }

    public void SetHealth(int newVal)
    {
        health = newVal;
        health = health > maxHealth ? maxHealth : health;
        health = health < 0 ? 0 : health;
    }

    public void AddHealth(int val)
    {
        val = Mathf.Abs(val);
        health += val;
        health = health > maxHealth ? maxHealth : health;
    }

    public void RemoveHealth(float val)
    {
        val = Mathf.Abs(val);
        health -= val;
        health = health < 0 ? 0 : health;
    }


}
