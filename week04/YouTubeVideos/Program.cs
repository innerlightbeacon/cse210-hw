using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "TechWorld", 600);
        Video video2 = new Video("Top 10 Travel Destinations", "Wanderlust", 900);
        Video video3 = new Video("How to Cook Jollof Rice", "FoodieTV", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "Clear and concise explanation."));
        video1.AddComment(new Comment("Charlie", "I finally understand C#!"));

        // Add comments to video2
        video2.AddComment(new Comment("David", "I want to visit all these places!"));
        video2.AddComment(new Comment("Ella", "Thanks for the travel inspiration."));
        video2.AddComment(new Comment("Frank", "Amazing visuals!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Best jollof recipe I’ve seen."));
        video3.AddComment(new Comment("Henry", "Made this for dinner, so good!"));
        video3.AddComment(new Comment("Ivy", "Love how you explained step by step."));

        // Put videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video and its comments
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.Length} seconds");
            Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($" - {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}