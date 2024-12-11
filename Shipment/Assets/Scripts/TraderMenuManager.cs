using UnityEngine;

public class TraderMenuManager : MonoBehaviour
{
    public ShopEventTrigger playership;
    public GameObject menu;

    private void Start()
    {
        playership.OnTraderCollision += ShowMenu;
        menu.SetActive(false);  
    }

    private void ShowMenu()
    {
        Debug.Log("Showing menu...");

        menu.SetActive(true);
    }

    private void OnDestroy()
    {
        playership.OnTraderCollision -= ShowMenu;
    }
}
