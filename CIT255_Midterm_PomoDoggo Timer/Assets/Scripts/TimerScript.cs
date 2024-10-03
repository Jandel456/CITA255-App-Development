using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;
using UnityEngine.Lumin;

public class TimerSscript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] float StartTime = 25f * 60f;
    public float remainingtime;
    [SerializeField] TextMeshProUGUI PomoUsesText;
    [SerializeField] public int PomoUses = 1;
    float TimeActuallySpent;
    public int Minutes;

    void Start()
    {
        remainingtime = StartTime;
        Time.timeScale = 0;
    }
    public void Update()
    {
        if (remainingtime > 0)
        {
            remainingtime -= Time.deltaTime;
        }
        else if (remainingtime < 0)
        {
            TimesUp();
        }

        int Minutes = Mathf.FloorToInt(remainingtime / 60);
        int Seconds = Mathf.FloorToInt(remainingtime % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", Minutes, Seconds);
        PomoUsesText.text = "Total Uses: " + PomoUses.ToString();
    }    

    public void PauseTme()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Debug.Log("Time is paused");
        }
    }
    public void RunTime()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Debug.Log("Time is running");
        }
        if (remainingtime == 0)
        {
            PomoUses ++;
            remainingtime = 25f * 60f;
            TimerText.color = Color.white;

        }
        
        if (remainingtime > 0)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.loop = false;
            audioSource.Stop();
        }
    }

    public void SkipTime()
    {
        TimesUp();
    }

    void TimesUp()
    {
        remainingtime = 0;              // this is to make sure that remaining time doesnt go negative in the update function
        TimerText.color = Color.red;
        GetComponent<AudioSource>().Play();
    }
}