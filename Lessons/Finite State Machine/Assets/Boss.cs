using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Unit
{

    public enum States { Idle, Searching, Attacking, TakingDamage, Rage, Die, Dead }
    public States currentState;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.Searching:
                break;
            case States.Attacking:
                break;
            case States.TakingDamage:
                break;
            case States.Rage:
                break;
            case States.Die:
                break;
            case States.Dead:
                break;
            case States.Idle:
                break;
            default:
                break;
        }
    }
}
