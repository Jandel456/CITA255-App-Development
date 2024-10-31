using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Player: IAttack // make sure to delete monobehavior, and if you implement a member in interface, it has to be implemented in Player
{
    public int Damage { get; set; }

    public void Attack()
    {
        Damage = 2;
        Debug.Log("Damage " + Damage);
    }

    // camel case: someName
    // pascel case for function names: SomeName
    // snake case: some_name
    // for demonstration purposes


    // int playerHp;
    // public int PlayerHp
    // {
    //     get { return playerHp; }
    //     set { playerHp = value; }
    // }

    // //string playerName;
    // public string PlayerName { get; set;}
}
