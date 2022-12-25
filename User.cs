using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_3
{
    class User
    {
        private static int UserCounter = 0;

        public static ArrayList<User> UserList = new ArrayList<User>();

        public int ID { get; }
        public string Name { get; }

        public User(string name)
        {
            if (name.Length <= 1) throw new ArgumentException("Username must contain 2 or more characters");
            UserCounter++;
            ID = UserCounter;
            this.Name = name;
        }


    }
}
