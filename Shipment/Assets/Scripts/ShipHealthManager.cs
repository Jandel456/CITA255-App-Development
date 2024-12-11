using System;
using TMPro;
using UnityEngine;

public class ShipHealthManager : MonoBehaviour
{
    public  float shipMaxHealth = 100f;
    public float lowEfficiencyHealth;
    public float currenthealth = 80f;
    public TextMeshProUGUI healthText;  



    void Start()
    {
        currenthealth = 80f;
    }
    void Update()
    {
        lowEfficiencyHealth = shipMaxHealth * 0.7f;
        healthText.text = "Health: " + currenthealth.ToString();

    }
    public void TakeDamage(float amount)
    {
        currenthealth -= amount;
        if (currenthealth <= 0f)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("Target has died!");
        Destroy(gameObject);
    }
}
