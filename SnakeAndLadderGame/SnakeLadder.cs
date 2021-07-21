using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeLadder
    {  
        public void PlayerChecks()//method gives palyer to go head or not
        {
            int startPoint = 0;
            Random random  = new Random();
            int dice = random.Next(1, 7);//1-6 dice values
            int choice = random.Next(0, 3);//0,1,2 for choices
            switch (choice)
            {
                case 0://0 refer to no play
                    startPoint = startPoint ;
                    Console.WriteLine("Player remains at same position " + startPoint);
                    break;

                case 1://refer to ladder 
                    startPoint = startPoint + dice;
                    break;

                case 2://refer to snake
                    startPoint = startPoint - dice;
                    break;

            }
            Console.WriteLine("Current Position of Player : "+ startPoint);
                
        }
    }
}
