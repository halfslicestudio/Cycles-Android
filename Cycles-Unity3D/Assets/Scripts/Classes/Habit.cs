using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Habit
{
    public enum WeekDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday

    }
    //Our habit name
    private string HabitName = "#None";
    //Our habit time. We can use this to keep track of minutes
    private DateTime HabitDateTime = DateTime.Now;
    //Our habit days. We can use this to week track of what days we want
    private WeekDays HabitWeekDays = WeekDays.Monday;
   
    public Habit(string HabitName, DateTime HabitDateTime, WeekDays HabitWeekDays)
    {
        this.HabitName = HabitName;
        this.HabitDateTime = HabitDateTime;
        this.HabitWeekDays = HabitWeekDays;
    }
    public void SetName(string s)
    {
        this.HabitName = s;
    }
    public string GetName()
    {
        return this.HabitName;
    }
    
}
