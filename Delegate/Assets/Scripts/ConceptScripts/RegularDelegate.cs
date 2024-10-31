using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularDelegate : MonoBehaviour
{
    //Define a delegate type
    //Taes in void: aka, return nothing
    //Any functions stored in this delegaate do not have any parameters (the stuff in parathesis)
    delegate void AttackDelegate();             // tells C# you're declaring a delegate 

    //Declaring a field for that delegate (similar to doing Player player = new Player)
    AttackDelegate attackAction;

    //we can store functions inside this delegte variable now!

    // first, create some functions
    void MeleeAtack()
    {
        Debug.Log("Attacking with melee");
    }

    void Start()
    {
        // then, assign the attackAction to melee attack
        //basically asking attackAction when called, to do a melee attack       think of turn based rps when it ask you to attack, and you can choose different attacks.
        attackAction = MeleeAtack;

        //dont forget to call the function!
        attackAction();                     // Now this will serve the same purpose as Melee Attack, atleast for now. Cool right?
    }
}
