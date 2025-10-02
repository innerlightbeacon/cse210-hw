using System;

class Program
{

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    var breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    var reflection = new ReflectionActivity();
                    reflection.Run();
                    break;
                case "3":
                    var listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye — take care!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}