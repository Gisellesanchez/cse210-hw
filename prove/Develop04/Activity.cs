using System;
using System.Collections.Generic;
using MindfulProve;


abstract class Activity
{
    protected string _name;
    protected string _description;

    protected int _duration;

    public void Start()
    {
        Console.Clear();
        SetDuration(30);
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready to begin!");
        Thread.Sleep(2000);
        Console.Clear();
        PerformActivity();
        End();
    }
    protected abstract void PerformActivity();
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void End()
    {
        Console.WriteLine($"Ending {_name} activity...");
        Console.WriteLine("Thank you for participating!");
        Thread.Sleep(2000); // Simulate a short delay before ending
    }
    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b \b \b");
        }
        Console.WriteLine();
    }
    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index++ % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
        
    }
