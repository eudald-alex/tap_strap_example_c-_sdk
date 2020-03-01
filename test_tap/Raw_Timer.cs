using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

public class Raw_Timer
{
    private static System.Timers.Timer raw_timer;

    public static void init()
    {
        SetTimer();
    }

    private static void SetTimer()
    {
        // Create a timer with a 500 mili_second interval.s
        raw_timer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
        raw_timer.Elapsed += OnTimedEvent;
        raw_timer.AutoReset = true;
        raw_timer.Enabled = true;
        VariablesGlobals.raw_timer_bool = false;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        VariablesGlobals.raw_timer_bool = true;
    }
}

