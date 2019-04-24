using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAudioService
{
    void PlaySound(string soundID, GameObject emitter);
    /// <summary>
    /// This stops all sound
    /// </summary>
    /// <param name="soundID">the ID of the soundclip (aka name)</param>
    void StopSound(string soundID);
    void StopAll();

}
