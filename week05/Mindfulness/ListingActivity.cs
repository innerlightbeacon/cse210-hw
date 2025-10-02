using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("You will have a few seconds to think, then you will list items. Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("Start listing items (press Enter after each).");

        Stopwatch sw = new Stopwatch();
        sw.Start();

        List<string> items = new List<string>();

        while (sw.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            // To avoid blocking past the duration too much, check remaining time.
            int remaining = _duration - (int)sw.Elapsed.TotalSeconds;
            if (remaining <= 0) break;

            // ReadLine will block; we still allow the user to submit but stop if time up after entering.
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                items.Add(response.Trim());
            }
            // loop checks elapsed again
        }

        sw.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items:");
        foreach (var it in items)
        {
            Console.WriteLine(" - " + it);
        }

        DisplayEndingMessage();
    }
}
