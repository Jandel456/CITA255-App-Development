using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] float steerSpeed = 125;
    [SerializeField] float moveSpeed = 25f;
    [SerializeField] float defaultSpeed = 25f;


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed *Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}