using System;
using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Stopwatch sw = new Stopwatch();
        sw.Start();

        // We'll alternate: "Breathe in..." (countdown 4), "Breathe out..." (countdown 6)
        // Continue until elapsed >= _duration
        while (sw.Elapsed.TotalSeconds < _duration)
        {
            if (sw.Elapsed.TotalSeconds >= _duration) break;
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();

            if (sw.Elapsed.TotalSeconds >= _duration) break;
            Console.Write("Breathe out... ");
            ShowCountdown(6);
            Console.WriteLine();
        }

        sw.Stop();
        DisplayEndingMessage();
    }
}
