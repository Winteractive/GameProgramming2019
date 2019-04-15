using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadState : PlayerState
{
    public override void Enter(Unit unit)
    {
        unit.currentStateName = "Dead";
    }

    public override void Exit(Unit unit)
    {

    }

    public override PlayerState HandleInput(KeyCode key = KeyCode.None, EventType eventType = EventType.Ignore, Unit.UnitInputs unitInput = Unit.UnitInputs.None)
    {
        return null;
    }

    public override PlayerState Update(Unit unit, float t)
    {
        return null;
    }


}
