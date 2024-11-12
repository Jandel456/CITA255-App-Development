using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShield : MonoBehaviour
{
    public int defense = 5;

    public virtual int DamageAmount(int damage)
    {
        if (defense >- damage)
        {
            return 0;
        }
        else
        {
            return damage - defense;
        }

        
    }
}
