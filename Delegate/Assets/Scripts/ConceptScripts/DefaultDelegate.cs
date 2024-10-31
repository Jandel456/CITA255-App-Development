using System;           // DO NOT FORGET ABOUT USING SYSTEM NAMESPACE FOR THE DEFAULT DELEGATES.
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DefaultDelegate : MonoBehaviour
{
    // Action is a default delegate, we dont need to delcare it as a delegate for it to work
    private Action<int> action;

    // This is a default delegate that takes in void functions without parameters
    // you can take in as many as you want! Action<int, int, int, int> action;
    Action myAction;

    // A default delegate that takes in return types and parameters
    private Func<int> myFunc;

    void MeleeAttack()
    {
        Debug.Log("Attacking with melee! 2");

    }

    void Count(int number)
    {
        Debug.Log("I am counting " + number);
    }

    int ReturnOne()
    {
        Debug.Log("I am returning 1");
        return 1;
    }

    void Start()
    {
        // Assign the delegate to melee attack()
        myAction = MeleeAttack;
        myAction();     // Don't forget to call the function!

        // Assign the delegate to Count(Int)
        action = Count;
        action(10);

        // assign the delegate to int()
        myFunc = ReturnOne;
        myFunc();

        // Defult Delegates PROS
        // Easy and quick

        // Regular Delegates Pros
        // I can have custom names, making my code easier to read

        // LAMBDA
        // Take no parameters and returns nothing (aka void)
        Action lambAction = () => { };
        Action newAction = () =>
        {
            Debug.Log("Taking newAtion without parameters and return void");
        };

        newAction();

        Action<int> intLambAction = (int i) =>
        {
            Debug.Log("Taking intLambAction with an int as a aparameter, returning void");
        };

        intLambAction(1);

        //taking in an interger and returning a boolean
        Func<int, bool> lambFunc = (int I) => 
        {
            Debug.Log("Taking lambFunc with an int as a parameter, returning bool" + false);
            return false;
        };

        lambFunc(1);
    }

}
