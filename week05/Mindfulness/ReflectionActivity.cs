using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        // Show a random prompt
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("When you are ready to continue, press Enter.");
        Console.ReadLine();

        Stopwatch sw = new Stopwatch();
        sw.Start();

        // Ask questions until duration reached; show spinner between questions
        while (sw.Elapsed.TotalSeconds < _duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine();
            Console.WriteLine("Reflect on: " + question);
            // Pause for a few seconds (spinner) - use 5 seconds or remaining time if smaller
            int pause = 5;
            int remaining = Math.Max(0, _duration - (int)sw.Elapsed.TotalSeconds);
            if (remaining < pause) pause = remaining;
            if (pause <= 0) break;
            ShowSpinner(pause);
        }

        sw.Stop();
        DisplayEndingMessage();
    }
}
