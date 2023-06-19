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
            //welcome message
            Console.WriteLine("Welcome to Snake & Ladder problem");
            
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.StartPosition();
            Console.ReadLine();
        }
    }
}
