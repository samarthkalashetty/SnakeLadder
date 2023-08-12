using System;

namespace SnakeAndLadderGame
{
    class UC1
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            bool gameOver = false;
            Random random = new Random();

            Console.WriteLine("Welcome to Snake and Ladder Game!");

            while (!gameOver)
            {
                Console.WriteLine($"You are currently at position {playerPosition}");

                Console.Write("Press Enter to roll the dice...");
                Console.ReadLine();

                int diceRoll = random.Next(1, 7); // Simulate dice roll (1 to 6)
                Console.WriteLine($"You rolled a {diceRoll}");

                playerPosition += diceRoll;

                // Snake and ladder rules...
                // (same as previous implementation)

                if (playerPosition >= 100)
                {
                    Console.WriteLine("Congratulations! You reached the top.");
                    gameOver = true;
                }
            }

            Console.WriteLine("Game Over. Thank you for playing!");
        }
    }
}
