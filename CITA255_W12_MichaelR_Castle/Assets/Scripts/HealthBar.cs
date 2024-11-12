using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public CastleHp castleHp;
    public Image hpFill;
    public int totalHp = 100;
    private int hp;
    
    void Start()
    {
        castleHp.OnHpChanged += CastleHP_OnHPChaged;
    }

    private void CastleHP_OnHPChaged(int health)
    {
        float curretHPPercent = (float)health / totalHp;
        hpFill.fillAmount = curretHPPercent;

        if (health == 0)
        {
            hpFill.fillAmount = 0;
        }
    }
}
