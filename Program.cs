using System;

namespace OOP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tic-tac-toe");
            Console.Write("Enter the username of PLAYER1: ");
            string first = Console.ReadLine();
            Console.Write("Enter the username of PLAYER2: ");
            string second = Console.ReadLine();
            Console.WriteLine("Who starts with cross? (By default PLAYER1)\n\t1. " + first + "\n\t2. " + second);
            string whoIsCross = Console.ReadLine();
            int cross = 1;
            if (String.Equals(whoIsCross, "2")) cross = 2;
            do
            {

            } while (true);
        }
    }
}
