using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {        
        "Think about a time when you helped someone.",
        "Something very difficult.",
        "Someone who helped you.",
        "The funniest thing that you ever did.",
        "Your best summer.",
        "Think about your favorite Christmas.", 
        "Think about a miracle in your life.",
        "Think about a time when you cry.",
        "When you feels proud of yourself.",
        "A person that make you feel blessed.",
        "Think of a time when you were really happy.",
    };
    private List<string> _questions = new List<string> {
        "What makes this memory special?",
        "What do you learned?",
        "What do feel when that happened?",
        "Do like to do it again?",
        "why makes it count?",
        "What makes this so memorable?",
        "Can you feel the same now?",
        "Do you like to feel the same as you did?",
        "What did you do to feel in that way?",
    };
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void PromptReflecting()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("As soon as you have the asnwer, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}