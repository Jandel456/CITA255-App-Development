using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class WorldPosition
{
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera camera)
    {
        // translate the camera's z vale into an absolute value
        // and assign that to my screen position

        screenPosition.z = Mathf.Abs(camera.transform.position.z);

        //translate that screen position with z to a world position accordig to the camera.
        Vector3 worldPosition = camera.ScreenToWorldPoint(screenPosition);

        return worldPosition;
    }

    public static Vector3 MouseWorldPosition()
    {
        Vector3 result = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        result.z = 0;
        return result;
    }

}
