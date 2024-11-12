using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth
{
    // Create a constructor so I can references this class
    public PlayerHealth()
    {

    }

    public PlayerHealth(Player player)
    {
        // Follow the event (listening)
        player.OnPlayerDamage += Player_OnPlayerDamage;
    }

    // Just like deligate!
    // The function signurature must match the event signurature
    private void Player_OnPlayerDamage(int i)
    {
        Debug.Log("Player_OnPlayerDamaged called in PlayerHealth");
    }

    // Wwe can also stop listening to that event, for our meetaphor, we're unsubbing
    public void Unsubscribe(Player player)
    {
        player.OnPlayerDamage -= Player_OnPlayerDamage;
        Debug.Log("Unsubscribing from the OnPlayerDamaged event!");
    }
}
