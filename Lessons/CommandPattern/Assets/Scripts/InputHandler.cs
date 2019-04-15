using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Reads user inputs and calls on commands to move Actors
/// </summary>
public class InputHandler : MonoBehaviour
{
    public Actor puppet;


    public Stack<Command> history;


    const KeyCode W = KeyCode.W;
    const KeyCode A = KeyCode.A;
    const KeyCode S = KeyCode.S;
    const KeyCode D = KeyCode.D;


    void Start()
    {
        history = new Stack<Command>();
    }

    /// <summary>
    /// takes assigned button inputs and returns mapped Commands
    /// </summary>
    /// <returns>A command associated with the selected input. Returns null if no button was pressed.</returns>
    Command HandleInput()
    {
        if (Input.GetKeyDown(W))
        {
            MoveCommand moveCommand = new MoveCommand(puppet, Directions.Direction.Up);
            return moveCommand;
        }
        if (Input.GetKeyDown(A))
        {
            MoveCommand moveCommand = new MoveCommand(puppet, Directions.Direction.Left);
            return moveCommand;
        }
        if (Input.GetKeyDown(S))
        {
            MoveCommand moveCommand = new MoveCommand(puppet, Directions.Direction.Down);
            return moveCommand;
        }
        if (Input.GetKeyDown(D))
        {
            MoveCommand moveCommand = new MoveCommand(puppet, Directions.Direction.Right);
            return moveCommand;
        }

        return null;
    }


    void Update()
    {
        Command selectedCommand = HandleInput();
        if (selectedCommand != null)
        {
            history.Push(selectedCommand);
            selectedCommand.Execute(puppet);
        }

        if (Input.GetKeyDown(KeyCode.Z) && history.Count > 0)
        {
            Undo();
        }
    }

    /// <summary>
    /// Undoes the latest action if any history exists
    /// <see cref="Stack"/>
    /// </summary>
    void Undo()
    {
        history.Pop().Undo();
    }

    /// <summary>
    /// Switches out the current actor (puppet) for a new one
    /// </summary>
    /// <param name="_puppet">the new actor to be controlled by the input handler</param>
    public void SwapPuppet(Actor _puppet)
    {
        puppet = _puppet;
    }
}
