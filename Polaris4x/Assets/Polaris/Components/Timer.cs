using UnityEngine;
using System;
/// <summary>
/// Intermediate Class for triggering timestep from the UI;
/// </summary>
public class Timer : MonoBehaviour {
    public void Timestep(int days)
    {
        var time = new TimeSpan(days, 0, 0, 0);
        TimeStepModule.TimeStep(time);
    }

}

public static class TimeStepModule
{
    public delegate void TimestepHandler(TimeSpan amount);
    public delegate void UITimestepHandler();
    public static event TimestepHandler TimestepEvent;
    public static event UITimestepHandler TimestepComplete;

    public static DateTime date = new DateTime(2016, 1, 1, 00, 00, 00);
    public static int industryDelay = 5; //Industry will only update every X days

    private static bool finished = true;
    //private static bool autoStep = false;


    public static void GetTimer()
    {

    }

    public static void TimeStep(TimeSpan time)
    {
        
        if (time.Ticks > TimeSpan.TicksPerSecond & finished)
        {
            finished = false;
            if (TimestepEvent != null) //Only trigger if someone is interested.
            {
                TimestepEvent(time);
            }

            date = date.AddDays(time.TotalDays);

            if (TimestepComplete != null) //Same here
            {
                TimestepComplete();
            }
            finished = true;
        }
    }


}

public interface ITimeStep
{
    void TimeStep(TimeSpan time);
}