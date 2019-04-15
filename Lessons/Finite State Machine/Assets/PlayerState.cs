using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    public abstract void Enter(Unit unit);
    public abstract void Exit(Unit unit);
    public abstract PlayerState Update(Unit unit, float t);
    public abstract PlayerState HandleInput(KeyCode key = KeyCode.None, EventType eventType = EventType.Ignore, Unit.UnitInputs unitInput = Unit.UnitInputs.None);

}
