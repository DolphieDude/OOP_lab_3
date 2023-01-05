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
            Rating = 0;
            UserList.Add(this); 
        }

        public void PrintHistory()
        {
            Console.WriteLine(Name + "'s history of matches");
            int count = 1;
            foreach (Match m in UserHistory)
            {
                Console.Write("Match #" + count + ": ID=" + m.ID + "; Opponent=");
                if (this.ID != m.First.ID) Console.Write(m.First.Name);
                else Console.Write(m.Second.Name);
                Console.Write("; Result=");
                if (m.Winner.ID == this.ID) Console.WriteLine("WIN;");
                else if (m.Winner == null) Console.WriteLine("TIE;");
                else Console.WriteLine("LOSE;");
                count++;
            }
            Console.WriteLine("*****END OF HISTORY*****");
        }

        public void PrintHistory(int amount)
        {
            Console.WriteLine(Name + "'s history of matches. Last " + amount);
            for (int i = UserHistory.Count - 1; i >= 0 && i >= UserHistory.Count - amount; i--)
            {
                Console.Write("Match #" + (i + 1) + ": ID=" + UserHistory[i].ID + "; Opponent=");
                if (this.ID != UserHistory[i].First.ID) Console.Write(UserHistory[i].First.Name);
                else Console.Write(UserHistory[i].Second.Name);
                Console.Write("; Result=");
                if (UserHistory[i].Winner.ID == this.ID) Console.WriteLine("WIN;");
                else if (UserHistory[i].Winner == null) Console.WriteLine("TIE;");
                else Console.WriteLine("LOSE;");
            }
            Console.WriteLine("*****END OF HISTORY*****");
        }
    }
}
