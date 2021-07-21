using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeLadder
    {
        public void PlayerMoves()//method gives palyer to go head or not
        {
            int startPoint = 0;

          
                while(startPoint <= 100)
                {
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    int choice = random.Next(0, 3);
                    switch (choice)
                    {
                        case 0://0 refers to no play
                            startPoint = startPoint;
                            break;
                        case 1://1 refers to ladder
                            startPoint=startPoint+dice;
                            break;
                        case 2://refers to snake
                        startPoint = startPoint - dice;
                        if (startPoint < 0)
                            startPoint = 0;
                        break;
                    }
                    if (startPoint > 100)
                    {
                        startPoint = startPoint - dice;
                    }
                    else if (startPoint == 100)
                    {
                        break;
                    }

                }
                Console.WriteLine("Current Position of Player : " + startPoint);
            
        }
    }
}
