using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DogGrowth
{
    public DogGrowth(Dog dog)
    {
        dog.OnPuppySleeps += Dog_OnPuppySleeps;
    }

    private void Dog_OnPuppySleeps([CanBeNull] object sender, Dog.OnSleepArgs e)
    {
        e.length += 1;
        int newLength = e.length;
        Debug.Log("Puppy grows bigger in sleep! " + newLength);
    }
}
