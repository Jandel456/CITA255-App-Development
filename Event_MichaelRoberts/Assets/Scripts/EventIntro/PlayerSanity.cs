using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSanity
{
    public PlayerSanity(Player player)
    {
        player.OnPlayerDamage += Player_OnPlayerDamaged;
    }

    private void Player_OnPlayerDamaged(int i)
    {
        Debug.Log("Player_OnPlayerDaammaged fired in PlayerSanity");
    }

    public void Unsubscribe(Player player)
    {
        player.OnPlayerDamage -= Player_OnPlayerDamaged;
    }
}

