using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_3
{
    class Match
    {
        private static int MatchCounter = 0;

        public int ID { get; }
        private User First;
        private User Second;
        public int Winner { get; }

        public Match(int first, int second)
        {
            if (first == second) throw new ArgumentException("User cannot play against themselves");

        }
    }
}
