using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    void Start()
    {
        ServiceLocator.Initialize();
        ServiceLocator.ProvideAudio(new LoggedAudioProvider());
    }


    void Update()
    {

    }
}
