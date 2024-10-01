using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private const string FILE_PATH = "/Data/";
    private string FILE_NAME = "empty.txt";
    private string FILE_DIR, contentText;


    void Start()
    {
        FILE_DIR = Application.dataPath + FILE_PATH  + FILE_NAME;
        //ReadText();
        //LoadText();

        ExceptionClass exception = new ExceptionClass();
        exception.TestCustomException();
    }

    void LoadText()
    {
        try
        {
            ReadText();
        }

        catch
        {
            Debug.Log("There is something wrong with the directory?");
        }
        
        finally
        {
            Debug.Log("FINALLY!!!!!!!");
            FILE_NAME = "text.txt";
            FILE_DIR = Application.dataPath + FILE_PATH + FILE_NAME;
            ReadText(); 
        }
    }

    void ReadText()
    {
        contentText = File.ReadAllText(FILE_DIR);
        Debug.Log("We found the path!!\n" + contentText);
    }

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
        Debug.Log("Hello, Scene 2. love, Scene1");
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
