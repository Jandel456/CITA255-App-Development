using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public event Action<int> OnPlayerDamage;
    
    public void Damage()
    {
        /*
        Make sure the event only fires when it is not null.
        if(OnPlayerDamage != null)
        {
            OnPlayerDamage();
        }
        */
        Debug.Log(" Doing the Damage function");
        OnPlayerDamage.Invoke(5);
    }
}
