﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_3
{
    class RankedMatch : Match
    {
        private const int WIN_RATING_CHANGE = 20;
        private const int LOSE_RATING_CHANGE = WIN_RATING_CHANGE - (WIN_RATING_CHANGE / 4);

        public RankedMatch (User first, User second)
        {
            if (first.ID == second.ID) throw new ArgumentException("User cannot play against themself");
            this.First = first;
            this.Second = second;
            Console.WriteLine("You will gain" + WIN_RATING_CHANGE + " rating points in case of your win, otherwise you lose " + LOSE_RATING_CHANGE);
            Play();
            if (Winner != null)
            {
                Console.WriteLine(Winner.Name + " gains " + WIN_RATING_CHANGE + " rating points");
                if (this.First.ID != Winner.ID) Console.Write(First.Name);
                else Console.Write(this.Second.Name);
                Console.WriteLine("loses " + LOSE_RATING_CHANGE + " rating points");
            }
            else Console.WriteLine("Your ratings do not change");
        }

        private void RatingChange(User player)
        {
            if (Winner.ID == player.ID) player.Rating += WIN_RATING_CHANGE;
            else
            {
                player.Rating -= LOSE_RATING_CHANGE;
                if (player.Rating < 0) player.Rating += -(player.Rating);
            }
        }
    }
}
