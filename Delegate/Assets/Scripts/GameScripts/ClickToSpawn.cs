using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickToSpawn : MonoBehaviour
{
    public GameObject cubePrefab, spherePrefab;

    delegate void ClickAction();
    ClickAction clickAction;

    void SpawnSphere()
    {
        Vector3 mousePos = WorldPosition.GetMouseWorldPosition();

        // Spawn sphere
        GameObject sphere = Instantiate(spherePrefab, mousePos, Quaternion.identity);

        // destroy after 2 seconds
        Destroy(sphere, 2);
    }

    void SpawnCube()
    {
        Vector3 mmousePos = WorldPosition.GetMouseWorldPosition();

        // Spawn cube
        GameObject cube = Instantiate(cubePrefab, mmousePos, Quaternion.identity);

        // Destroy cube after 2 secoonds
        Destroy(cube, 2);
    }
    void Start()
    {
        clickAction=SpawnSphere;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickAction();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))       // alpha 1 is the number 1 key on your keyboard
        {
            clickAction = SpawnCube;
        }
    }
}
