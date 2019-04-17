using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]

public class Character : MonoBehaviour
{
    public int health;
    public int damage;

    public bool isAlive;
    public string characterName;

    public float critChance;

    public float jumpStrength;

}
