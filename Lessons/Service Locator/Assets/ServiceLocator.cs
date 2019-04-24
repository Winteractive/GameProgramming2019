using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    private static IAudioService audio;


    public static void Initialize()
    {
        Debug.Log("initialized");
        audio = new NullAudioProvider();
    }

    public static void ProvideAudio(IAudioService audioService)
    {
        if (audioService == null)
        {
            audioService = new NullAudioProvider();
        }

        audio = audioService;
    }

    public static IAudioService GetAudio()
    {
        return audio;
    }

}
