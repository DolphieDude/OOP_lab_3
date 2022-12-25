using System;
using System.Collections;
using System.Text;

namespace OOP_Lab_3
{
    class User
    {
        private static int UserCounter = 0;
        public static ArrayList UserList = new ArrayList();

        public int ID { get; }
        public string Name { get; }
        public ArrayList UserHistory = new ArrayList();

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
