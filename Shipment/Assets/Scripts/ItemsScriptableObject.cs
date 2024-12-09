using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Add Shipment Item", fileName = "New Item")]
public class ItemsScriptableObject : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string itemDescription = "Enter Item Description Here";
    [SerializeField] float reelTime = 5f;
    [SerializeField] float pullRate = 5f; // in percentage
    [SerializeField] float goldAmmount = 5f; 
    [SerializeField] float itemWeight = 5f;

    public string GetDescription()
    {
        return itemDescription;
    }
}