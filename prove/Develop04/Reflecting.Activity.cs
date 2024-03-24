public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Can you think about a time when you were really happy.",
        "Did you remember the first time that you attend to the school?",
        "Can you thik about a time when you did something good to an extranger?",
        "Can you think about something funny that you did?",
        "Think about a time when you learned something difficult",
    };
    private List<string> _questions = new List<string> {
        "Why did you remember this experience?",
        "What did you learned from this experience?",
        "What make that experience so imporatnat that you remember it?",
        
    };

    public ReflectingActivity(string name, string description) : base (name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        Console.WriteLine($"---- {PromptGenerator()} ----");
        DisplayQuestion();
        DisplayEnd();
    }
    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string QuestionGenerator()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    private void DisplayQuestion()
    {
        int seconds = GetDuration();
        while (seconds > 0)
        {
            string question = QuestionGenerator();
            Console.WriteLine(question);
            Countdown();
            seconds -= 3;
        }
    }
    
}