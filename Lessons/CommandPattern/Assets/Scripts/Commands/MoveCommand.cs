using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Command class that moves an actor in a direction set from the constructor
/// </summary>
public class MoveCommand : Command
{

    Directions.Direction direction;
    Actor actor;

    /// <summary>
    /// Constructor for the MoveCommand class
    /// </summary>
    /// <param name="_actor">the actor to affect</param>
    /// <param name="_direction">the direction to move the actor</param>
    public MoveCommand(Actor _actor, Directions.Direction _direction)
    {
        actor = _actor;
        direction = _direction;
    }

    /// <summary>
    /// calls the Move function on the selected actor
    /// </summary>
    /// <param name="actor">the actor to move</param>
    public override void Execute(Actor actor)
    {
        actor.Move(Directions.GetDirection(direction));
    }

    /// <summary>
    /// Uses the saved direction and actor from the constructor to move the actor in the reverse direction
    /// <see cref="Directions"/> for how the mirroring works
    /// </summary>
    public override void Undo()
    {
        actor.Move(Directions.GetMirroredDirection(direction));
    }
}
