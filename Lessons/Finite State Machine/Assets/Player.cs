using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : Unit
{
    PlayerState currentState;
    PlayerState returnedState;

    public TextMeshPro stateprinter;

    public static KeyCode attackKey = KeyCode.A;
    public static KeyCode jumpKey = KeyCode.J;
    public static KeyCode danceKey = KeyCode.D;

    public static KeyCode debugTakeDamageKey = KeyCode.T;
    public static KeyCode debugHitGroundKey = KeyCode.G;
    public static KeyCode debugGetHealedKey = KeyCode.H;


    void Start()
    {
        currentState = new PlayerIdleState();
        currentState.Enter(this);
        stateprinter.text = currentStateName; // just for visualisation
    }

    public override void TakeDamage(int nmbr)
    {
        base.TakeDamage(nmbr);
        returnedState = currentState.HandleInput(unitInput: UnitInputs.TookDamage);
        CheckStateSwap();

        if (health <= 0)
        {
            currentState = new PlayerDeadState();
            currentState.Enter(this);
        }
    }

    public override void GetHealed(int amount)
    {
        base.GetHealed(amount);
        returnedState = currentState.HandleInput(unitInput: UnitInputs.GotHealed);
        CheckStateSwap();

    }

    void Update()
    {
        returnedState = currentState.Update(this, Time.deltaTime);
        CheckStateSwap();
        HandleInputs();


    }

    private void HandleInputs()
    {
        if (Input.GetKeyDown(attackKey))
        {
            returnedState = currentState.HandleInput(key: attackKey, eventType: EventType.KeyDown);
        }

        if (Input.GetKeyDown(jumpKey))
        {
            returnedState = currentState.HandleInput(key: jumpKey, eventType: EventType.KeyDown);
        }

        if (Input.GetKeyDown(danceKey))
        {
            returnedState = currentState.HandleInput(key: danceKey, eventType: EventType.KeyDown);
        }

        DebugInputs();

        CheckStateSwap();
    }

    private void DebugInputs()
    {
        if (Input.GetKeyDown(debugGetHealedKey))
        {
            returnedState = currentState.HandleInput(unitInput: UnitInputs.GotHealed);
        }

        if (Input.GetKeyDown(debugHitGroundKey))
        {
            returnedState = currentState.HandleInput(unitInput: UnitInputs.HitGround);
        }

        if (Input.GetKeyDown(debugTakeDamageKey))
        {
            returnedState = currentState.HandleInput(unitInput: UnitInputs.TookDamage);
        }
    }

    private void CheckStateSwap()
    {
        if (returnedState != null)
        {
            currentState.Exit(this);
            currentState = returnedState;
            currentState.Enter(this);
            stateprinter.text = currentStateName; // just for visualisation
        }
    }
}
