using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class DogalogueScript : MonoBehaviour
{
    [SerializeField] AudioClip SmalllBark;
    public TextMeshProUGUI DogText;
    const string FILE_DIR = "/Data/";
    const string FILE_NAME = "Dogalogue.txt";
    string FILE_PATH; 
    string[] dogalogueArray;
    int currentLine;

    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;

        if (File.Exists(FILE_PATH))
        {
            dogalogueArray = File.ReadAllLines(FILE_PATH);
        }
        else
        {
            Debug.Log("Something Is wrong with the path.");
        }
        currentLine = 1;
        DogText.text = dogalogueArray[currentLine];
    }

    public void ClickNextButton()
    {
        if (currentLine < dogalogueArray.Length - 1)
        {
            currentLine++;
            DogText.text = dogalogueArray[currentLine];
            GetComponent<AudioSource>().PlayOneShot(SmalllBark);
        }
    }

}
