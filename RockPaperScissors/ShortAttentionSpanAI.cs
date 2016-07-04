using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        Random random = new Random();
       // int myMove;
        int otherMove;
        public int NextMove()
        {
            //0 for rock, 1 for paper, 2 for scissors
            if (otherMove == 0)
            {
                return 1;
            }
            else if (otherMove == 1)
            {
                return 2;
            }
            else if (otherMove == 2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //this.myMove = myMove;
            this.otherMove = otherMove;
        }
    }
}
