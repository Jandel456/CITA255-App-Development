using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


// i messed up in like 8 ways in here  :< 
public class PomoUses : MonoBehaviour
{
    public TextMeshProUGUI totalTimeSpentText;
    List<int> totalTimeSpentList = new List<int>();
    string totalTimeSpentString, currentTimeSpentString;
    int currentTimeSpent = 0;
    public int CurrentTimeSpent 
    {
        get { return currentTimeSpent; }
        set
        {
            currentTimeSpent = value;
        }
    }

    private void Start() 
    {
        totalTimeSpentString = "Total Minutes Worked:  ";
        currentTimeSpentString = "Current Time Spent: ";

        CurrentTimeSpent = 0;
    }

    public void Update()
    {
        totalTimeSpentList.Add(currentTimeSpent);
        CurrentTimeSpent = 0;
        UpdateTotalTimeSpentText();

        // CurrentScore++;
        // Debug.Log("Current Score is" + CurrentScore);
    }

    void UpdateTotalTimeSpentText()
    {
        string text = totalTimeSpentString;

        foreach(int time in totalTimeSpentList)
        {
            text += "\n" + time;
        }

        totalTimeSpentText.text = text;
    }

}