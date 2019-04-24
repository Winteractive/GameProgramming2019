using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    SpriteRenderer rend;
    public Sprite jump;
    public Sprite idle;
    public Sprite attack;
    public Sprite potion;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ServiceLocator.GetAudio().PlaySound("Jump", gameObject);
            rend.sprite = jump;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ServiceLocator.GetAudio().PlaySound("Attack", gameObject);
            rend.sprite = attack;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ServiceLocator.GetAudio().PlaySound("UsePotion", gameObject);
            rend.sprite = potion;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            rend.sprite = idle;
        }

    }
}
