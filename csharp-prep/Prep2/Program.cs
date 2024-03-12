using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (plus or minus)
        char sign;
        int lastDigit = percent % 10;
        if (lastDigit >= 7)
            sign = '+';
        else if (lastDigit < 3)
            sign = '-';
            
        else
            sign = ' ';

        // Display results
        Console.WriteLine($"Grade: {letter}{sign}");
    }
}

