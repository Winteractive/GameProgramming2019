using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamageState : PlayerState
{
    float recoveryTime;

    public override void Enter(Unit unit)
    {
        unit.currentStateName = "Taking Damage";
        recoveryTime = unit.recoveryTime;
    }

    public override void Exit(Unit unit)
    {

    }

    public override PlayerState HandleInput(KeyCode key = KeyCode.None, EventType eventType = EventType.Ignore, Unit.UnitInputs unitInput = Unit.UnitInputs.None)
    {
        if (unitInput == Unit.UnitInputs.GotHealed)
        {
            return new PlayerIdleState();
        }

        return null;
    }

    public override PlayerState Update(Unit unit, float t)
    {
        recoveryTime -= t;
        if (recoveryTime <= 0)
        {
            return new PlayerIdleState();
        }

        return null;
    }
}
