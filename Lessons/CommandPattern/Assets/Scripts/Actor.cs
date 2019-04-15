using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that we manipulate with our commands
/// </summary>
public class Actor : MonoBehaviour
{
    public Sprite sitSprite;
    public Sprite lookUpSprite;
    SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// Move the actor in a specified direction
    /// </summary>
    /// <param name="direction">The direction the actor will move in</param>
    public void Move(Vector3Int direction)
    {
        this.transform.position += direction;
    }

    public void Sit()
    {
        rend.sprite = sitSprite;
    }

    public void LookUp()
    {
        rend.sprite = lookUpSprite;
    }
}
