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

            //selecting an option (No Play, Ladder, Snake)
            int option = random.Next(0, 3);
            switch(option)
            {
                case 0:
                    Console.WriteLine("No Play!");
                    break;
                case 1:
                    Console.WriteLine("You got a ladder: "+rollsdie+" Number of position player moved ahead");
                    break;
                case 2:
                    Console.WriteLine("Oops! You encountered a snake: " + rollsdie +" Number of position player moved behind ");
                    break;
                default:
                    break;
            }
        }
    }
}
