using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DogHappy
{
    public int happiness;

    public DogHappy(Dog dog)
    {
        happiness = 5;
        dog.OnPuppyPlays += Dog_OnPuppyPlays;
    }

    private void Dog_OnPuppyPlays([CanBeNull] object sender, int e)
    {
        happiness += e;
        Debug.Log("Puppy is happy!!" + happiness);
    }
}
