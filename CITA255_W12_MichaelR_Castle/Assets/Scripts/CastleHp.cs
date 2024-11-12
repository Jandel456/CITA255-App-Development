using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleHp : MonoBehaviour
{
    public int hp = 100;
    private BasicShield shield;

    delegate void SwitchShield();
    private SwitchShield switchShield;

    private ClickToAttack clickToAttack;

    //an event to handle health bar
    public event Action<int> OnHpChanged;

    void HpChanges()
    {
        OnHpChanged?.Invoke(hp);
    }

    void UseBasicShield()
    {
        //Debug.Log("Trying to use the basic shield");

        // if we are already using the basic shield
        if (gameObject.GetComponent<BasicShield>() != null && shield != GetComponent<DividerShield>())
        {
            return; 
        }

        Destroy(GetComponent<DividerShield>());
        shield = gameObject.AddComponent<BasicShield>();    
    }

    void UseDividerShield()
    {
        //Debug.Log("Trying to use the divider shield");

        // check if we are already using the divider shiled
        if (gameObject.GetComponent<DividerShield>() != null)
        {
            return;     // Don't do anything please.
        }

        // first destroy the basic shield
        Destroy(GetComponent<BasicShield>());

        //then, add and assign the divider shield to the castle        
        shield = gameObject.AddComponent<DividerShield>();

    }

    void Subscribe(ClickToAttack clickToAttack)
    {
        clickToAttack.OnPlayerClicked += AttackScript_OnPlayerClicked;
    }

    void AttackScript_OnPlayerClicked()
    {
        int newHeath = hp - shield.DamageAmount(clickToAttack.PlayerAttack);

        // if after the attack we will end up with a negative hp, cap it at 0
        if (newHeath < 0)
        {
            hp = 0;
            //Debug.Log("AAAH! The castle has fallen!");
        }
        else 
        {
            hp -= shield.DamageAmount(clickToAttack.PlayerAttack);
            //Debug.Log("Castle's Hp: " + hp);
        }

        HpChanges();
    }

    void Start()
    {
        // default: add a basic shield to the castle game obkect.
        shield = gameObject.AddComponent<BasicShield>();

        switchShield = UseDividerShield;

        clickToAttack = GameManager.instance.GetComponent<ClickToAttack>();

        //subscribe to the event on ClickToAttack class
        Subscribe(clickToAttack);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //switch shield to basic shield
            switchShield = UseBasicShield;
            switchShield();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //switch to diviner shield
            switchShield = UseDividerShield;
            switchShield();
        }
    }

}
