using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbordAI :IPlayer
    {
        Random random = new Random();
        int favoriteMove;
        public StubbordAI()
        {
            favoriteMove = random.Next(0, 2);
            //this.favoriteMove = favoriteMove;
        }


        public int NextMove()
        {
            //0 for rock, 1 for paper, 2 for scissors

            return favoriteMove;

        }



        public void SaveResult(int myMove, int otherMove)
        {
            //blank on purpose
        }
    }
}
