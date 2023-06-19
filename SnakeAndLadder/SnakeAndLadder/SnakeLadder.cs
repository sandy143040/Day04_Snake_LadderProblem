using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        public void StartPosition()
        {
            int startPosition = 0;
            Console.WriteLine("Game played with single player at start position: "+ startPosition);

        }
        public void RollsDie()
        {
            Random random = new Random();
            int rollsdie = random.Next(1, 7);
            Console.WriteLine("Player gets a number after rolling die: "+rollsdie);
        }
    }
}
