using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DogHealth
{
    public int health;

    public DogHealth(Dog dog)
    {
        health = 10;

        //subscribe to the dog eats event
        dog.OnPuppyEats += Dog_OnPuppyEats; 
    }

    private void Dog_OnPuppyEats([CanBeNull] object sender, EventArgs e)
    {
        health++;
        Debug.Log("Pupp's health is: " + health);
    }
}
