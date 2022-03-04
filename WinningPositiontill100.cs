using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLaddergame
{
    public class WinningPositiontill100
    {
        public static void ExactWinningPosition()
        {
            int INITIAL_POSITION = 0;
            int MAX_POSITION = 100;
            int playerPosition = 0;
            int Count = 0;
            while (playerPosition < 100)
            {
                if (playerPosition >= 95)  // problematic scenario
                {
                    Random ram = new Random();
                    int DIE = ram.Next(1, 5);
                    playerPosition = playerPosition + DIE;
                    Count++;
                }
                else
                {
                    Random random = new Random();
                    int die = random.Next(1, 7);
                    Console.WriteLine("number on die :" + die);

                    switch (die)
                    {
                        default:
                            playerPosition = INITIAL_POSITION; // at start
                            break;
                        case 1:           //ladder at 1,3,5
                            playerPosition = playerPosition + die;
                            break;
                        case 2:             //snake at 2,4,6
                            playerPosition = playerPosition - die;
                            break;
                        case 3:
                            playerPosition = playerPosition + die;
                            break;
                        case 4:
                            playerPosition = playerPosition - die;
                            break;
                        case 5:
                            playerPosition = playerPosition + die;
                            break;
                        case 6:
                            playerPosition = playerPosition - die;
                            break;
                    }

                    if (playerPosition < INITIAL_POSITION)  // to prevent below zero 
                    {
                        playerPosition = INITIAL_POSITION;
                    }

                    Console.WriteLine("player position :" + playerPosition);
                    Count++;
                }
                if (playerPosition == MAX_POSITION)
                {
                    Console.WriteLine("player reached winning position" + playerPosition);
                    Console.WriteLine("player reached winning position and roll dice" + Count);
                }
            }
        }
    }
}
