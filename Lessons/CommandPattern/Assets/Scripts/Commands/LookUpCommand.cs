using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Command that makes an actor look up.
/// </summary>
public class LookUpCommand : Command
{
    public override void Execute(Actor actor)
    {
        actor.LookUp();
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }


}
