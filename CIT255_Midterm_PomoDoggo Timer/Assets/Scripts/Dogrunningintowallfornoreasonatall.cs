using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogrunningintowallfornoreasonatall : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 targetPosition = new Vector2(315f, 25f);

    void Update()
    {
        Vector2 movement = Vector2.right * speed * Time.deltaTime;
        transform.Translate(movement);    
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        {
            transform.position = targetPosition;
        }
    }
}
