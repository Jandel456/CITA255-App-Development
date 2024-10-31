using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : IAttack
{
    public int Damage { get; set;}

    public void Attack()
    {
        Damage = 3;
        Debug.Log("Enemy damage: " + Damage);
    }
}
