using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeek : MonoBehaviour
{
    string WeekDay = "Saturday";

    // Start is called before the first frame update
    void Start()
    {
        PrintWeekDayAction();
        WeekDayList();
    }

   public void WeekDayList()
    {
        List<string> WeekActivitesList = new List<string>()
        {
            "Monday: Monster",
            "Tuesday: Tiger",
            "Wednesday: Weasel",
            "Thursday: Triceratops",
            "Friday: Flamingo",
            "Saturday: Snake",
            "Sunday: Squirrel"
         };


        for(int i = 0; i < WeekActivitesList.Count; i++)
        {
            Debug.LogFormat("Dagen på Index: {0} siger dette dyr: {1}", i, WeekActivitesList[i]);
        }
    }


    public void PrintWeekDayAction()
    {
        switch (WeekDay)
        {
            case "Monday":
                Debug.Log("Wake up");
                break;
            case "Tuesday":
                Debug.Log("Survive after monday");
                break;
            case "Wednesday":
                Debug.Log("Halfway to weekend, almost there.");
                break;
            case "Thursday":
                Debug.Log("Little friday, almost weekend!");
                break;
            case "Friday":
                Debug.Log("Finally friday! Weekend is here!");
                break;
            case "Saturday":
                Debug.Log("Thank god. Saturday is the best day!");
                break;
            case "Sunday":
                Debug.Log("Last day of weekend, start prepping for monday...");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
