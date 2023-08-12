using System;

namespace SnakeAndLadderGame
{
    class UC3
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

                int option = random.Next(0, 3); // Simulate option (0: No Play, 1: Ladder, 2: Snake)

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play - Stay in the same position.");
                        break;
                    case 1:
                        Console.WriteLine($"Ladder! Move ahead by {diceRoll} positions.");
                        playerPosition += diceRoll;
                        break;
                    case 2:
                        Console.WriteLine($"Snake! Move back by {diceRoll} positions.");
                        playerPosition -= diceRoll;
                        if (playerPosition < 0)
                            playerPosition = 0; // Restart from position 0 if position goes below 0
                        break;
                }

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