using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random secret number (you can replace this with your logic)
        int secretNumber = new Random().Next(1, 101);

        int correctCount = 0; // Initialize the counter for correct guesses

        Console.WriteLine("Welcome to the Guess My Number game!");
        Console.WriteLine("I've picked a number between 1 and 100. Try to guess it!");

        while (true)
        {
            Console.Write("Enter your guess: ");
            if (int.TryParse(Console.ReadLine(), out int userGuess))
            {
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed it right.");
                    correctCount++; // Increment the correct guess count
                    break;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Try a lower number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        Console.WriteLine($"You made {correctCount} correct guess(es).");
    }
}