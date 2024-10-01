using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SwitchScene();
        }
    }

    public void HelloWorld()
    {
        Debug.Log("Hello, Scene 2. -ArrayWithOffset love, Scene1");
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
