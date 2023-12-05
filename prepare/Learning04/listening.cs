using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think about a time when you were really happy?",
        "What are your best friends?",
        "What is your favorite song?",
        "what your favorite place to visit?",
        "Do you believe in Santa when you were a child?",
        "Something thta you like to do?",
        "A gift thta you remember?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activitity will help to create a list of good things in your life.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can :");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        GenerateCountdownTimer(5);
        Console.WriteLine();
                
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}