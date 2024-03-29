//For exceeding requirments, The program keeps track of how many times the user used X Activity during the session. It will increment a variable each time the user select that activity, and the user can see the full log with the option number 4.
class Program
{
    static void Main(string[] args)
    {
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        bool runProgram = true;
        while (runProgram)
        {
            string MENU = "\nMenu options:\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Activity Log\n5. Quit";
            Console.WriteLine(MENU);
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput) 
            {
                case 1: //BREATHING ACTIVITY
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.StartActivity();
                    breathingLog += 1;
                    break;
                
                case 2: //REFLECTING ACTIVITY
                    ReflectingActivity reflecting = new ReflectingActivity("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.StartActivity();
                    reflectingLog += 1;
                    break;
                
                case 3: //LISTING ACTIVITY
                    ListingActivity listing = new ListingActivity("Listing Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.StartActivity();
                    listingLog += 1;
                    break;
                
                case 4: //ACTIVITY LOG
                    Console.WriteLine("Activity - Number of times performed in this session");
                    Console.WriteLine($"Breathing Activity: {breathingLog} times");
                    Console.WriteLine($"Reflecting Activity: {reflectingLog} times");
                    Console.WriteLine($"Listing Activity: {listingLog} times");
                    break;

                case 5: //QUIT
                    Console.WriteLine("Thanks for using the app! :)");
                    runProgram = false;
                    break;
                
            }
        }
        
    }
    
}