using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public override void Enter(Unit unit)
    {
        unit.currentStateName = "Idle";
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

        if (key == Player.danceKey)
        {
            return new PlayerDanceState();
        }

        if (unitInput == Unit.UnitInputs.TookDamage)
        {
            return new PlayerTakeDamageState();
        }

        return null;
    }

    public override PlayerState Update(Unit unit, float t)
    {
        return null;
    }
}
