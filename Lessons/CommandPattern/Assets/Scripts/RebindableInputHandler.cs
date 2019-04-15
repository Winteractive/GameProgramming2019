using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class implementing the command pattern to allow for rebindable controls
/// </summary>
public class RebindableInputHandler : MonoBehaviour
{
    public Actor puppet;

    private Command uButton;
    private Command iButton;

  

    public Commands uButtonCommand;
    public Commands iButtonCommand;

    public enum Commands { Sit, LookUp };

    void Start()
    {
        switch (uButtonCommand)
        {
            case Commands.Sit:
                uButton = new SitCommand();
                break;
            case Commands.LookUp:
                uButton = new LookUpCommand();
                break;
        }

        switch (iButtonCommand)
        {
            case Commands.Sit:
                iButton = new SitCommand();
                break;
            case Commands.LookUp:
                iButton = new LookUpCommand();
                break;
        }
    }

    Command HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            return uButton;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            return iButton;
        }
        return null;
    }

    void Update()
    {
        Command selectedCommand = HandleInput();
        if (selectedCommand != null)
        {
            selectedCommand.Execute(puppet);
        }
    }
}
