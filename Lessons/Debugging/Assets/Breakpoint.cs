using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakpoint : MonoBehaviour
{
    int integerThatWeFollow;

    void Start()
    {
        integerThatWeFollow = 0;
        FirstFunction();
        SecondFunction(); // calls 3'rd and 4'th
        //...
        FifthFunction();
       
    }

    void FirstFunction()
    {
        for (int i = 0; i < 10; i++)
        {
            integerThatWeFollow += 1;
        }
    }

    void SecondFunction()
    {
        ThirdFunction(FourthFunction(integerThatWeFollow));
    }

    int FourthFunction(int nmbr)
    {
        //  Debug.Break(); // pauses the editor
        return (nmbr / 2) + 5;
    }

    int ThirdFunction(int nmbr)
    {
        return nmbr * 2;
    }

    void FifthFunction()
    {
        DebugLogging.CustomDebug("Our number is: " + integerThatWeFollow.ToString(), size: 15);
    }
}
