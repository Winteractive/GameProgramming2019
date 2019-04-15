using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public enum UnitInputs { None, TookDamage, HitGround, GotHealed };

    public string currentStateName;
    public int health;
    public int damage;
    public float attackTime;
    public float recoveryTime;
    public float danceTime;

    public virtual void TakeDamage(int nmbr)
    {
        health -= nmbr;
    }

    public virtual void GetHealed(int amount)
    {
        health += amount;
    }

    public void Jump(float force)
    {
        // Do some add force etc here with force
    }

    public void Attack()
    {
        Debug.Log("do attack!");
    }
}
