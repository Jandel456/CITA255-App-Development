using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.SearchService;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if(!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HelloWorld()
    {
        Debug.Log("Hello, Scene 2. -ArrayWithOffset love, Scene1");
    }
    
    void SwitchScene()
    {

    }
}
