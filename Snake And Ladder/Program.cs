using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Snake and Ladder game played with single player at start position 0");
            int Player1_position = 0;
            Console.WriteLine(" Position of Player 1 = " + Player1_position);
            int Player2_position = 0;
            Console.WriteLine(" Position of Player 2 = " + Player2_position);
            Console.WriteLine(" The Player rolls the die to get a number between 1 to 6");
            Random random = new Random();

            while (Player1_position < 100 && Player2_position < 100)
            {
                bool flag = true;
                while (flag)
                {
                    int Die1_num = random.Next(1, 7);
                    Console.WriteLine(" Number after rolling a die:");
                    Console.WriteLine($" {Die1_num}");
                    int option1 = random.Next(3);
                    switch (option1)
                    {
                        case 0:
                            Console.WriteLine("No play");
                            Console.WriteLine("Player 1 is on initial position = " + Player1_position);
                            flag = false;
                            break;
                        case 1:
                            Console.WriteLine("Got Ladder");
                            Player1_position = Player1_position + Die1_num;
                            Console.WriteLine(" Player 1 position is added = " + Player1_position);
                            break;
                        case 2:
                            Console.WriteLine("Got Snake");
                            Player1_position = Player1_position - Die1_num;
                            Console.WriteLine("Player 1 position is subtracted = " + Player1_position);
                            flag = false;
                            break;
                    }

                    if (Player1_position < 0)
                    {
                        Player1_position = 0;
                        Console.WriteLine("Player 1 is back to initial position = " + Player1_position);
                    }
                    else if (Player1_position > 100)
                    {
                        Player1_position = Player1_position - Die1_num;
                    }
                    else if (Player1_position == 100)
                    {
                        Console.WriteLine("  Player 1 wins the game");
                        Environment.Exit(0);
                    }
                }

                flag = true;
                while (flag)
                {
                    int Dice2_num = random.Next(1, 7);
                    int option2 = random.Next(3);
                    switch (option2)
                    {
                        case 0:
                            Console.WriteLine("No play");
                            Console.WriteLine("Player 2 is on initial position = " + Player2_position);
                            flag = false;
                            break;
                        case 1:
                            Console.WriteLine("Got Ladder");
                            Player2_position = Player2_position + Dice2_num;
                            Console.WriteLine("Player 2 position is added = " + Player2_position);
                            break;
                        case 2:
                            Console.WriteLine("Got Snake");
                            Player2_position = Player2_position - Dice2_num;
                            Console.WriteLine("Player 2 position is subtracted = " + Player2_position);
                            flag = false;
                            break;
                    }

                    if (Player2_position < 0)
                    {
                        Player2_position = 0;
                        Console.WriteLine("Player 2 is back to initial position = " + Player2_position);
                    }
                    else if (Player2_position > 100)
                    {
                        Player2_position = Player2_position - Dice2_num;
                    }
                    else if (Player2_position == 100)
                    {
                        Console.WriteLine("Player 2 wins the game");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}