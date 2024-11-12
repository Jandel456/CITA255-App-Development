using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickToAttack : MonoBehaviour
{
    private Vector3  mousePosition;
    private Collider2D collider2D;

    public event Action OnPlayerClicked;
    public event Action OnPlayerReleased;

    public int PlayerAttack = 20;

    void PlayerClicks()
    {
        OnPlayerClicked?.Invoke();
    }

    void PlayerReleases()
    {
        OnPlayerReleased?.Invoke();

    }

    void CheckVollsion()
    {
        mousePosition = WorldPosition.MouseWorldPosition();

        // Get the 2D collider that overlapse wth my mouse
        // Note: this collider may not exist, aka the value is null

        collider2D = Physics2D.OverlapPoint(mousePosition);
    }

    void Update()
    {
        //When I'm pressing down the left kep of my mouse
        if (Input.GetMouseButtonDown(0))
        {
            CheckVollsion();

            // if we are ineed clicking on something with a 2D collider
            if (collider2D != null)
            {
                //Debug.Log("Clicking on something with a 2d collier");
                // FIRE THE CLICKING EVENT
                PlayerClicks();
            }
        }

        //When I'm releasing the left part of my mouse.
        if (Input.GetMouseButtonUp(0))
        {
            CheckVollsion();
            
            // if we are ineed clicking on something with a 2D collider
            if(collider2D != null)
            {
                //Debug.Log("Releasing something with a 2d collier");
                // FIRE THE RELEASING EVENT
                PlayerReleases();
            }
        }
    }
}
