using System;

namespace NumberGuessingGame
{
    class Program
    {
        // My first ever program. Written on my 11th day of coding.
        static void Main(string[] args)
        {
            Console.Title = "vYORKv's Number Guessing Game";
            do
            {
                Console.Clear();
                Console.Write("\nWelcome to vYORKv's number guessing game! Please enter your name: ");
                string username = Console.ReadLine();

                if (username.Equals("vYORKv", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nCongratulations! You're a winner! You're always the winner! Yay!\n\nPress any key to play again!");
                }

                else
                {
                    Console.WriteLine($"\nHello, {username}. \n\nPlease guess a number between 1-100. You will be permitted five attempts. Good luck!");

                    Random random = new Random();
                    int targetNumber = random.Next(100);
                    targetNumber += 1;
                    int userNumber = 0;
                    int attempts = 5;

                    while (attempts > 0 && userNumber != targetNumber)
                    {
                        userNumber = Int32.Parse(Console.ReadLine().Trim());
                        attempts--;
                        if (userNumber < targetNumber && attempts >= 1)
                        {
                            Console.WriteLine($"Too low! Guess again! You have {attempts} attempt(s) remaining!");
                        }
                        else if (userNumber > targetNumber && attempts >= 1)
                        {
                            Console.WriteLine($"Too high! Guess again! You have {attempts} attempts(s) remaining!");
                        }

                    }

                    if (userNumber == targetNumber)
                    {
                        Console.WriteLine("\nCongratulations! You win! Press any key to play again!");
                    }
                    else if (attempts == 0)
                    {
                        Console.WriteLine("\nSorry! You lose! Press any key to play again!");
                    }
                }
                Console.ReadKey(true);
            } while (true);
            
        }
    }
}
