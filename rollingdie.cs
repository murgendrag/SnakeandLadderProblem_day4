using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLaddergame
{
     class rollingdie
    {
        //public const int ladder = 1,3,5;
        public static void rolldie( )
        {
           
            int playerPosition = 0;

        Random random = new Random();
            int die=random.Next(1,7);
            Console.WriteLine("number on die :" + die);

            switch (die)
            {
                default:
                    playerPosition =0; // at start
                    break;
                case 1 :           //ladder at 1,3,5
                    playerPosition = playerPosition + die;
                    break;
                case 2:             //snake at 2,4,6
                    playerPosition= playerPosition + die;
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
                    playerPosition = playerPosition -die;
                    break;
                     
            }
            Console.WriteLine("player position :" + playerPosition);
        }
    }
}
