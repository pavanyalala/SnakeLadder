using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeLadder
    {
        //variables
        int startPoint = 0;
        public void RollDice()//method gives dice value
        {
            Random random  = new Random();
            int dice = random.Next(1, 7);//1-6 dice values
            Console.WriteLine("Rolled Dice Value : " + dice);
                
        }
    }
}
