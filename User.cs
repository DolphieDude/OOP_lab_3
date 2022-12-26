using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_3
{
    class User
    {
        private static int UserCounter = 0;
        public static List<User> UserList = new List<User>();

        public int ID { get; }
        public string Name { get; }
        public List<Match> UserHistory = new List<Match>();

        public User(string name)
        {
            if (name.Length <= 1) throw new ArgumentException("Username must contain 2 or more characters");
            UserCounter++;
            ID = UserCounter;
            this.Name = name;
            UserList.Add(this);
        }


    }
}
