// For extra credit/more than 1 scripture/ user can pick the scripture than want to learn
class Program
{
    static void Main(string[] args)
    {
        string MENU = " 1. Alma 48:17 \n 2. 2 Nephi 25:26 \n 3. 4 Nephi 1: 15-16 \n What scripture do you want to memorize?: ";
        Console.WriteLine(MENU);
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                string text = "Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; yea, the devil would never have power over the hearts of the children of men.";
                Scripture scripture1 = new Scripture(text);
                Reference reference1 = new Reference("Alma", 48, 17);
                UserInterface(scripture1,reference1);
                break;

            case 2:
                text = "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.";
                Scripture scripture2 = new Scripture(text);
                Reference reference2 = new Reference("2 Nephi", 25, 26);

                UserInterface(scripture2,reference2);
                break;

            case 3:
            text = "And it came to pass that there was no contention in the land, because of the blove of God which did dwell in the hearts of the people. And it came to pass that there was no contention in the land, because of the love of God which did dwell in the hearts of the people.";
            Scripture scripture3 = new Scripture(text);
            Reference reference3 = new Reference("4 Nephi", 1, 15,16);

            UserInterface(scripture3,reference3);
            break;
        }
    } 
    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Write ENTER to hide more words or type QUIT to end.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }  
}