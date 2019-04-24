using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealAudioProvider : IAudioService
{
    private readonly List<AudioSource> sources;
    public const int SOURCE_AMOUNT = 10;

    public RealAudioProvider()
    {
        sources = new List<AudioSource>();
        for (int i = 0; i < SOURCE_AMOUNT; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "AudioSource " + i;
            sources.Add(obj.AddComponent<AudioSource>());
        }
    }

    public void PlaySound(string soundID, GameObject emitter)
    {
        AudioClip clip = (AudioClip)Resources.Load("Sounds/" + soundID, typeof(AudioClip));

        if (!clip)
        {
            return;
        }

        AudioSource source = GetAvaliableAudioSource();

        if (!source)
        {
            return;
        }
        source.transform.position = emitter.transform.position;
        source.PlayOneShot(clip);


    }

    public void StopAll()
    {
        foreach (AudioSource source in sources)
        {
            source.Stop();
        }
    }

    public void StopSound(string soundID)
    {
        AudioClip clip = (AudioClip)Resources.Load("Sounds/" + soundID, typeof(AudioClip));
        if (!clip)
        {
            return;
        }

        foreach (AudioSource source in sources)
        {
            if (source.clip == null)
            {
                continue;
            }

            if (source.clip != clip)
            {
                continue;
            }

            source.Stop();
        }

    }

    private AudioSource GetAvaliableAudioSource()
    {
        AudioSource selected = null;

        foreach (AudioSource source in sources)
        {
            if (!source.isPlaying)
            {
                selected = source;
                break;
            }
        }

        return selected;
    }
}
