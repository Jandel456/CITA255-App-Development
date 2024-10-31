using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector3 GetMouseWorldPosition()
    {
        Vector3 result = Input.mousePosition;

        // translate result.z to somthing the world can understand
        result.z = Camera.main.WorldToScreenPoint(transform.position).z;

        //convert the entire thing to a world position
        result = Camera.main.WorldToScreenPoint(result);

        return result;
    }

    void Update()
    {   
        // when we left click, we record the mouse position and store it.
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("1");
            Vector3 mousePos = GetMouseWorldPosition();

            // check if the mouse position overlaps with a collider 2D.
            Collider2D collider2D = Physics2D.OverlapPoint(mousePos);

            if (collider2D != null)
            {
                Debug.Log("2");
                Debug.Log("I clicked on a 2d collider!");
            
                //using to get componentn to avoid gaving an object that doesn't implement IInteract
                if (collider2D.TryGetComponent(out IInteract interact))
                {
                    Debug.Log("3");
                    interact.Interact();
                }
            }
        }
    }
}
