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
                    HistoryChoose(first);
                }
                else if (reply.Equals("4"))
                {
                    HistoryChoose(second);
                }
                
                else break;
            }
        }

        public static void HistoryChoose(User player)
        {
            Console.WriteLine("How many last matches do you want to be shown? (Type \'n\' if you want full history)");
            string reply = Console.ReadLine();
            try
            {
                player.PrintHistory(Convert.ToInt32(reply));
            }
            catch
            {
                player.PrintHistory();
            }
        }
    }
}
