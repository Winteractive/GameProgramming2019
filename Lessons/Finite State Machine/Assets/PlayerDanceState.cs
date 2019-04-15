using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDanceState : PlayerState
{
    float timeLeftToDance;

    public override void Enter(Unit unit)
    {
        unit.currentStateName = "Dancing";
        timeLeftToDance = unit.danceTime;
    }

    public override void Exit(Unit unit)
    {
    }

    public override PlayerState HandleInput(KeyCode key = KeyCode.None, EventType eventType = EventType.Ignore, Unit.UnitInputs unitInput = Unit.UnitInputs.None)
    {

        if (key == Player.attackKey)
        {
            return new PlayerAttackState();
        }

        if (key == Player.jumpKey)
        {
            return new PlayerJumpState();
        }

        // if (unitInput == Unit.UnitInputs.TookDamage)
        // {
        //     return new PlayerTakeDamageState();
        // }

        return null;
    }

    public override PlayerState Update(Unit unit, float t)
    {
        timeLeftToDance -= t;
        if (timeLeftToDance <= 0)
        {
            return new PlayerIdleState();
        }
        return null;
    }
}
