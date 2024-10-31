using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnDelegate : MonoBehaviour
{
    // a delegate that takes in a return type (int) and takes in a string as a parameter
    delegate int IntDelegate(string str);
    private IntDelegate intDelegate;

    //create a return type (int) with a string parameter
    int ReturnZero(string text)
    {
        Debug.Log("Returning 0!");
        return 0;
    }

    // Create a return type (int) without a string parameter
    int ReturnOne()
    {
        Debug.Log("Returning 1.");
        return 1;
    }

    void Start()
    {
        // intDelegate = ReturnZero;

        // intDelegate("Hi");
        

    }
    

}
