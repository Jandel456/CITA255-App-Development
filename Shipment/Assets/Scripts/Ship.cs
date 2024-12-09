using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] float efficiencyCurrent = 100f;
    [SerializeField] float efficiencyRate = 3f;
    [SerializeField] float shipMaxHealth = 100f;
    [SerializeField] float shipHealth = 100f;
    [SerializeField] float shipMaxWeight = 100f;
    [SerializeField] float shipCurrentWeight = 0;
    [SerializeField] float shipSpeed = 5f;
    [SerializeField] float minShipSpeed;
    [SerializeField] float goldBonus = 0f;
    [SerializeField] float luckBonus = 0f;

    
    bool isShinyRock = false;
    bool isGoldUpgrade = false;
    bool isLuckUpgrade = false;
    bool isSpeedUpgrade = false;
    bool isHealthUpgrade = false;

    void EfficiencyCalc()
    {
        //REQUIRES UPDATING TO REFLECT THE WEIGHT MECHANIC
        efficiencyCurrent = 0.7f * shipMaxHealth * efficiencyRate; // When under 70% of your health for every 5% of health you lose, you should lose 15% efficiency
    }

    void EfficiencyUpdateValues()  // this applies the efficiency status to parts of the ship
    {
        //REQUIRES UPDATING TO REFLECT ITEM REELING SPEED
        shipSpeed *= efficiencyCurrent;
        // I dont know how to implement this with item reeling speed yet, but I should do something about each item's reel speed that interacts with efficieucny current.
        // for example. reelSpeed = Item.itemindex GetComponent(itemReelSpeed) * efficiencyCurrent
    }

    void Start()
    {
        shipHealth = 80f;
        
    }

    void Update()
    {
        EfficiencyCalc();
        EfficiencyUpdateValues();
    }
}
