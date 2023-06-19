using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Snake & Ladder problem");
            
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.StartPosition();
            snakeLadder.RollsDie();
            Console.ReadLine();
        }
    }
}
