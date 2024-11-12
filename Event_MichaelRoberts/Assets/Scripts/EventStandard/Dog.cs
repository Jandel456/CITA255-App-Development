using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog
{
    public event EventHandler OnPuppyEats;
    public event EventHandler<int> OnPuppyPlays;
    public event EventHandler<OnSleepArgs> OnPuppySleeps;


    public void Eat()
    {
        OnPuppyEats?.Invoke(this, EventArgs.Empty);
    }

    public void Play()
    {
        OnPuppyPlays?.Invoke(this, 1);
    }

    public void Sleep()
    {
        // Pass the values into the event args
        OnPuppySleeps?.Invoke(this, new OnSleepArgs{ length = 10 });
    }
    public class OnSleepArgs : EventArgs
    {
        public int length;
    }
}
