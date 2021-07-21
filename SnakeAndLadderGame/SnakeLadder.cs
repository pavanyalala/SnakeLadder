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
            while(startPoint != 100)
            {
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    Console.WriteLine("Dice Value :"+dice);
                   
                    int choice = random.Next(0, 3);
                    Console.WriteLine("Choice :"+choice);
                    switch (choice)
                    {
                        case 0://0 refers to no play
                            startPoint = startPoint;
                            Console.WriteLine("Player will be remain at same position ");
                            break;

                        case 1://1 refers to ladder
                            startPoint=startPoint+dice;
                            Console.WriteLine("Player moved by position "+startPoint);
                            if (startPoint > 100)
                            {
                                startPoint = startPoint - dice;
                            }
                            else if (startPoint == 100)
                            {
                                break;
                            }
                            break;

                        case 2://refers to snake
                            startPoint = startPoint - dice;
                            Console.WriteLine("Player dropped by position "+startPoint);
                            if (startPoint < 0)
                            {
                                startPoint = 0;
                            }
                            Console.WriteLine("You got the Zero value Restart the game");
                            break;
                    }
                    

            }
                Console.WriteLine("Current Position of Player : " + startPoint);
            
        }
    }
}
