using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DividerShield : BasicShield
{
    public float divideBy = 2f;

    public override int DamageAmount(int damage)
    {
        float havledDamage = DamageAmount / divideBy;

        // round the halved damage to the nearest interger
        int round = (int)Math.Round(havledDamage, 0);

        return round;
    }
}
