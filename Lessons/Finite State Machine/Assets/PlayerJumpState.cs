using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerState
{
    public override void Enter(Unit unit)
    {
        unit.currentStateName = "Jumping";
    }

    public override void Exit(Unit unit)
    {

    }

    public override PlayerState HandleInput(KeyCode key = KeyCode.None, EventType eventType = EventType.Ignore, Unit.UnitInputs unitInput = Unit.UnitInputs.None)
    {
        if (unitInput == Unit.UnitInputs.HitGround)
        {
            return new PlayerIdleState();
        }

        return null;
    }

    public override PlayerState Update(Unit unit, float t)
    {
        return null;
    }
}
