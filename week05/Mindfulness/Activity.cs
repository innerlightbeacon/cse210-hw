using System;
using System.Threading;

public class Activity
{
    // Protected so derived classes can access these values
    protected string _name;
    protected string _description;
    protected int _duration; // seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Display a standard starting message and ask for duration
    public virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter the duration in seconds: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Using default duration of 30 seconds.");
            _duration = 30;
        }
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display standard ending message
    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

    // Simple spinner animation for n seconds
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = new string[] { "|", "/", "-", "\\" };
        int idx = 0;
        DateTime end = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < end)
        {
            Console.Write(spinner[idx]);
            Thread.Sleep(250);
            Console.Write("\b");
            idx = (idx + 1) % spinner.Length;
        }
    }

    // Countdown from n to 1 (shows numbers)
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // erase the number
        }
    }

    // Virtual Run method to be overridden
    public virtual void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(_duration);
        DisplayEndingMessage();
    }
}
