using System;
using System.Collections.Generic;

namespace OOP_Lab_3
{
    class User
    {   
        private static int UserCounter { get;  set; } = 0;
        public static List<User> UserList { get; } = new List<User>();

        public int ID { get; }
        public string Name { get; }
        public int Rating { get; set; }
        public List<Match> UserHistory { get; } = new List<Match>();

        public User(string name)
        {
            if (name.Length <= 1) throw new ArgumentException("Username must contain 2 or more characters");
            ID = UserCounter;
            UserCounter++;
            this.Name = name;
            UserList.Add(this); 
        }

        public void PrintHistory()
        {
            Console.WriteLine(Name + "'s history of matches");
            int count = 1;
            foreach (Match m in UserHistory)
            {
                Console.Write("Match #" + count + ": ID=" + m.ID + "; Opponent=");
                if (this != m.First) Console.Write(m.First.Name);
                else Console.Write(m.Second.Name);
                Console.Write("; Result=");
                if (m.Winner == this) Console.WriteLine("WIN;");
                else if (m.Winner == null) Console.WriteLine("TIE;");
                else Console.WriteLine("LOSE;");
                count++;
            }
            Console.WriteLine("*****END OF HISTORY*****");
        }
    }
}
