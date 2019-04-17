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

        Debug.Log("A <color=red> red </color> message");

        string rainbowColored = string.Empty;
        for (int i = 0; i < rainbowMessage.Length; i++)
        {
            rainbowColored += colorprefix;
            rainbowColored += colors[UnityEngine.Random.Range(0, colors.Count - 1)];
            rainbowColored += rainbowMessage[i];
            rainbowColored += colorSufix;
        }

        Debug.Log("a <size=20>" + rainbowColored + "</size> message");

        DebugLogging.CustomDebug("A custom message", LogType.Log, "blue", 20, true, false);
        DebugLogging.CustomDebug("Another custom message", logType: LogType.Warning, color: "green", italic: true);

    }

    public static void CustomDebug(string text, LogType logType = LogType.Log, string color = "none", int size = 12, bool bold = false, bool italic = false)
    {
        string txt = string.Empty;
        if (color != "none")
        {
            txt += "<color=" + color + ">";
        }

        txt += "<size=" + size.ToString() + ">";

        if (bold)
        {
            txt += "<b>";
        }

        if (italic)
        {
            txt += "<i>";
        }

        txt += text;


        if (italic)
        {
            txt += "</i>";
        }


        if (bold)
        {
            txt += "</b>";
        }

        txt += "</size>";

        if (color != "none")
        {
            txt += "</color>";
        }

        Debug.unityLogger.Log(logType, txt);
    }


}
