using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // [SerializeField] float efficiencyCurrent = 100f;
    // [SerializeField] float efficiencyRate = 3f;
    // [SerializeField] float shipMaxWeight = 100f;
    // [SerializeField] float shipCurrentWeight = 0;
    // [SerializeField] float shipSpeed = 5f;
    // [SerializeField] float minShipSpeed;
    // [SerializeField] float goldBonus = 0f;
    // [SerializeField] float luckBonus = 0f;
    public GameObject healthManagerObject;
    private ShipHealthManager shipHealthManager;
    public float negEfficiencyPerDeficit = 5;
    public float totalHealthEfficiency;


    bool isShinyRock = false;
    bool isGoldUpgrade = false;
    bool isLuckUpgrade = false;
    bool isSpeedUpgrade = false;
    bool isHealthUpgrade = false;

    void Start()
    {
        shipHealthManager = healthManagerObject.GetComponent<ShipHealthManager>();
    }

    void Update()
    {
        EfficiencyCalc();
        // EfficiencyUpdateValues();
    }

    void EfficiencyCalc()
    {
        if (shipHealthManager.currenthealth < shipHealthManager.lowEfficiencyHealth)
        {
            float healthDeficit = shipHealthManager.lowEfficiencyHealth - shipHealthManager.currenthealth;
            float intervals = healthDeficit / 10f;
            totalHealthEfficiency = intervals * negEfficiencyPerDeficit;

        }
    }

    // void EfficiencyUpdateValues()  // this applies the efficiency status to parts of the ship
    // {
    //     shipSpeed *= efficiencyCurrent;
    //     // I dont know how to implement this with item reeling speed yet, but I should do something about each item's reel speed that interacts with efficieucny current.
    //     // for example. reelSpeed = Item.itemindex GetComponent(itemReelSpeed) * efficiencyCurrent
    // }
}
