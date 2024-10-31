using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// everything in static classes belong to the class itsef, not to any instances of that class
public class WorldPosition
{
    public static Vector3 GetMmouseWorldPositionWithZ(Vector3 screenPos, Camera worldCamera)
    {
        screenPos.z = Mathf.Abs(worldCamera.transform.position.z);
        Vector3 worldPos = worldCamera.ScreenToWorldPoint(screenPos);
        return worldPos;
    }

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 result = GetMmouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        result.z = 0f;
        return result;
    }
}
