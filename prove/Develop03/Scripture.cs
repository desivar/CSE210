using System;
namespace Scripture
{
    class Program
     {
    static void Main()
       {
           Scripture scripture=new Scripture("2 Nephi",25,26,"And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.");
           Console.Clear();
           scripture.Display();
           Console.WriteLine("\n Press enter to continue or type 'quit' to exit.");
           while(true)
           {
               string input=Console.ReadLine();
               if(input.ToLower()=="quit")
               break;
               if (!scripture.HideRandomWord())
               {
                Console.WriteLine("\n Congratulations! You memorized the scripture!");
                break;
               }
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\n Press Enter to continue or type 'quit' to exit");
           }
       }

    }
}