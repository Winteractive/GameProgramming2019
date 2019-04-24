using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggedAudioProvider : IAudioService
{
    private static ConsoleOnlyAudioProvider consoleProvider;
    private static RealAudioProvider audioProvider;

    public LoggedAudioProvider()
    {
        consoleProvider = new ConsoleOnlyAudioProvider();
        audioProvider = new RealAudioProvider();
    }

    public void PlaySound(string soundID, GameObject emitter)
    {
        consoleProvider.PlaySound(soundID, emitter);
        audioProvider.PlaySound(soundID, emitter);
    }

    public void StopAll()
    {
        consoleProvider.StopAll();
        audioProvider.StopAll();
    }

    public void StopSound(string soundID)
    {
        consoleProvider.StopSound(soundID);
        audioProvider.StopSound(soundID);
    }
}
