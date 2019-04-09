using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public static void DoCombat(Unit attacker, Unit defender)
    {
        if (attacker.damage <= 0)
        {
            Debug.Log("no damage");
            return;
        }
        defender.RemoveHealth(attacker.damage); // commenting this out creates false positive in a test
    }
}
