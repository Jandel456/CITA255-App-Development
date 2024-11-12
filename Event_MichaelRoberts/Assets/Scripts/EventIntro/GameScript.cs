using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    void Start()
    {
        Player player = new Player();
        PlayerHealth playerHealth = new PlayerHealth(player);
        PlayerSanity playerSanity = new PlayerSanity(player);

        player.Damage();   

        Debug.Log(" ========================================== ");
        playerHealth.Unsubscribe(player);
        playerHealth = null;

        player.Damage();        
    }
}
