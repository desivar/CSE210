using System;
using System.Globalization;
using System.Security.Principal;
class Program
{
    static void Main(string[] args)
{
const int STOPVALUE = 0;
     int inputNumber, count = 0;

     Random generator = new Random();

     int magicNumber = generator.Next(1, 50);  
      Console.WriteLine(magicNumber);  
      {
         Console.Write("(Stop Value: 0) Insert a number: ");
         inputNumber = int.Parse(Console.ReadLine());

         count++;
         if (magicNumber == inputNumber)
         {
             Console.WriteLine("Your guess is correct.");
             Console.WriteLine("Number of turns: " + count);

             count = 0;   
             Console.WriteLine("Do you want to play again? (Y/N)");
             char startOver = char.Parse(Console.ReadLine());

             if (startOver == 'Y')
             {
                 return;
             }

             if (startOver == 'N')
             {
                 Environment.Exit(0);
             }
         }      if (inputNumber > magicNumber)
         {
             Console.WriteLine("Higher");
         }

         if (inputNumber < magicNumber)
         {
             Console.WriteLine("Lower");
         }
     } 
    
     while (inputNumber != STOPVALUE);
 }

}


      
      