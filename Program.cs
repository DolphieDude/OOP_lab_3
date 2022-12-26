﻿using System;

namespace OOP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tic-tac-toe");
            Console.Write("Enter the username of PLAYER1, who starts with crosses: ");
            User first = new User(Console.ReadLine());
            Console.Write("Enter the username of PLAYER2, who starts with noughts: ");
            User second = new User(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Do you wanna play?\n" +
                    "\t1. YES\n" +
                    "\t2. Check match history of " + first.Name + "\n" +
                    "\t3. Check match history of " + second.Name + "\n" +
                    "\t4. Quit");
                string reply = Console.ReadLine();
                if (reply.Equals("1"))
                {
                    new Match(first, second);
                }
                else if (reply.Equals("2"))
                {
                    first.PrintHistory();
                }
                else if (reply.Equals("3"))
                {
                    second.PrintHistory();
                }
                else break;
            }
        }
    }
}
