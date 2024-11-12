using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaisePuppy : MonoBehaviour
{
    void Start()
    {
        Dog dog = new Dog();
        DogHealth dogHealth = new DogHealth(dog);
        DogHappy dogHappy = new DogHappy(dog);
        DogGrowth dogGrowth = new DogGrowth(dog);

        dog.Eat();
        dog.Play();
        dog.Sleep();
    }
}
