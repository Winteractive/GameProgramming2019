using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Windows;

public class DebugLogging : MonoBehaviour
{

    string rainbowMessage = "rainbow";

    string colorprefix = "<color=";
    List<string> colors = new List<string>()
    {
        "red>",
        "orange>",
        "yellow>",
        "green>",
        "blue>"
    };

    string colorSufix = "</color>";

    void Start()
    {
        Debug.Log("A log");

        Debug.LogWarning("A Warning");

        Debug.LogError("An Error");

        Debug.Log("A <b>Bold</b> log");

        Debug.LogWarning("An <i>Italic</i> Warning");

        Debug.LogError("A <size=20> Sized up</size> Error");

        Debug.Log("A debug log with an object reference", gameObject);

        Debug.unityLogger.Log("A unitylogger message");

        Debug.Log("A <color=red> red </color> message");

        string rainbowColored = string.Empty;
        for (int i = 0; i < rainbowMessage.Length; i++)
        {
            rainbowColored += colorprefix;
            rainbowColored += colors[UnityEngine.Random.Range(0, colors.Count - 1)];
            rainbowColored += rainbowMessage[i];
            rainbowColored += colorSufix;
        }

        Debug.Log("a " + rainbowColored + " message");

    }



}
