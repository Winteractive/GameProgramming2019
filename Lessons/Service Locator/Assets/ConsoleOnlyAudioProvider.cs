using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOnlyAudioProvider : IAudioService
{
    public void PlaySound(string soundID, GameObject emitter)
    {
        Debug.Log("sound: " + soundID + " From: " + emitter.name);
    }

    public void StopAll()
    {
        Debug.Log("Stopping all audio");
    }

    public void StopSound(string soundID)
    {
        Debug.Log("Stopping: " + soundID);
    }
}
