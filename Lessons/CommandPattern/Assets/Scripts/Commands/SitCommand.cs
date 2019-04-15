using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Command that makes actor sit down(super cute)
/// </summary>
public class SitCommand : Command
{
    public override void Execute(Actor actor)
    {
        actor.Sit();
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }
}
