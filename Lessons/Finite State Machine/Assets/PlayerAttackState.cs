using UnityEngine;

public class PlayerAttackState : PlayerState
{

    public float swingTime;

    public override void Enter(Unit unit)
    {
        swingTime = unit.attackTime;
        unit.currentStateName = "Attacking";
    }

    public override void Exit(Unit unit)
    {

    }

    public override PlayerState HandleInput(KeyCode key = KeyCode.None, EventType eventType = EventType.Ignore, Unit.UnitInputs unitInput = Unit.UnitInputs.None)
    {
        if (unitInput == Unit.UnitInputs.TookDamage)
        {
            return new PlayerTakeDamageState();
        }

        return null;
    }

    public override PlayerState Update(Unit unit, float t)
    {
        swingTime -= t;
        if (swingTime <= 0)
        {
            unit.Attack();
            return new PlayerIdleState();
        }


        return null;
    }
}