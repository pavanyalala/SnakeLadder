using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Snake And Ladder Game ");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.initialPosition();

        }
    }
}
