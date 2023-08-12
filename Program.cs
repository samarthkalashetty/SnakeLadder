using System;

namespace SnakeAndLadderGame
{
    class UC6
    {
        static void Main(string[] args)
        {
            int[] playerPositions = new int[2];
            int[] diceRollCounts = new int[2];
            bool[] ladderRollAgain = new bool[2];
            bool gameOver = false;
            Random random = new Random();

            Console.WriteLine("Welcome to Snake and Ladder Game!");

            int currentPlayer = 0; // Start with player 0
            while (!gameOver)
            {
                Console.WriteLine($"Player {currentPlayer + 1}, you are currently at position {playerPositions[currentPlayer]}");

                Console.Write("Press Enter to roll the dice...");
                Console.ReadLine();

                int diceRoll = random.Next(1, 7); // Simulate dice roll (1 to 6)
                diceRollCounts[currentPlayer]++;
                Console.WriteLine($"You rolled a {diceRoll}");

                int option = random.Next(0, 3); // Simulate option (0: No Play, 1: Ladder, 2: Snake)

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play - Stay in the same position.");
                        break;
                    case 1:
                        Console.WriteLine($"Ladder! Move ahead by {diceRoll} positions.");
                        if (playerPositions[currentPlayer] + diceRoll <= 100)
                        {
                            playerPositions[currentPlayer] += diceRoll;
                            ladderRollAgain[currentPlayer] = true; // Player gets another turn
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Snake! Move back by {diceRoll} positions.");
                        playerPositions[currentPlayer] -= diceRoll;
                        if (playerPositions[currentPlayer] < 0)
                            playerPositions[currentPlayer] = 0; // Restart from position 0 if position goes below 0
                        break;
                }

                // Snake and ladder rules...
                // (same as previous implementation)

                Console.WriteLine($"Player {currentPlayer + 1}, current position: {playerPositions[currentPlayer]}");

                if (playerPositions[currentPlayer] == 100)
                {
                    Console.WriteLine($"Player {currentPlayer + 1} won the game with {diceRollCounts[currentPlayer]} dice rolls.");
                    gameOver = true;
                }

                if (!ladderRollAgain[currentPlayer])
                    currentPlayer = (currentPlayer + 1) % 2; // Switch to the other player's turn

                ladderRollAgain[currentPlayer] = false; // Reset ladder roll again flag
            }

            Console.WriteLine("Game Over. Thank you for playing!");
        }
    }
}
