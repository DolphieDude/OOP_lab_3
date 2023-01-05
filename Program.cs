using System;

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
                    "\t1. Yeah (Casual yes)\n" +
                    "\t2. YAS!!! (RANKED yes)\n" +
                    "\t3. Check match history of " + first.Name + " (current rating: " + first.Rating + ")\n" +
                    "\t4. Check match history of " + second.Name + " (current rating: " + second.Rating + ")\n" +
                    "\t5. Quit");
                string reply = Console.ReadLine();
                if (reply.Equals("1"))
                {
                    new Match(first, second);
                }
                else if (reply.Equals("2"))
                {
                    new RankedMatch(first, second);
                }
                else if (reply.Equals("3"))
                {
                    first.PrintHistory();
                }
                else if (reply.Equals("4"))
                {
                    second.PrintHistory();
                }
                else break;
            }
        }
    }
}
