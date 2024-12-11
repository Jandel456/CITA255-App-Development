using UnityEngine;

public class ShopEventTrigger : MonoBehaviour
{
    // Event for showing the menu
    public event System.Action OnTraderCollision;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Trader")) 
        {
            OnTraderCollision?.Invoke();
        }
    }

    
}
