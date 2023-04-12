﻿using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Snake and Ladder game played with single player at start position 0");
            int Player_position = 0;
            Console.WriteLine(" Position = " + Player_position);
            Console.WriteLine(" The Player rolls the die to get a number between 1 to 6");
            Random random = new Random();

            while (Player_position <= 100)
            {
                int Die_num = random.Next(1, 7);
                Console.WriteLine(" Number after rolling a die:");
                Console.WriteLine($" {Die_num}");
                int option = random.Next(3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        Console.WriteLine("The Position is " + Player_position);
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        Player_position = Player_position + Die_num;
                        Console.WriteLine("The Position is " + Player_position);
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        Player_position = Player_position - Die_num;
                        Console.WriteLine("The Position is " + Player_position);
                        break;
                }

                if (Player_position < 0)
                {
                    Player_position = 0;
                    Console.WriteLine("Player's Position = " + Player_position);
                }
            }    

        }
    }
}