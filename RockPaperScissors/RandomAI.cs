using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random();
        public int NextMove()
        {
            //0 for rock, 1 for paper, 2 for scissors
           return random.Next(0, 2);
            
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //blank on purpose
        }
    }
}
