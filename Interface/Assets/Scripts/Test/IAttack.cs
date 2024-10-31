using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack    //  not a class, and doesnt use monobehavior
{
    public int Damage{ get; set; }

    public void Attack();

}
