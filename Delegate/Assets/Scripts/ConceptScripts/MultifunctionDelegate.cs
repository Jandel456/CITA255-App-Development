using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultifunctionDelegate : MonoBehaviour
{
    //how to store many fucnctions in a single delegate
    delegate void AttackDelegate();
    AttackDelegate attackAction;

    void meleeAttack()
    {
        Debug.Log("Doing a Melee attack! REAL");
    }

    void SwordAttack()
    {
        Debug.Log("Weiglingg my GIANT sword");
    }

    void MagicAttack()
    {
        Debug.Log("ABRA KABOOM");
    }
    void Start()
    {
        // instead of using =, I am using += to assign the delegate to multiple functions.
        attackAction = meleeAttack;
        attackAction += SwordAttack;
        attackAction += MagicAttack;
        attackAction();

        Debug.Log("--------------------------------");      // Seperator for each action
        attackAction -= meleeAttack;
        attackAction -= SwordAttack;
        attackAction(); 
    }
}
