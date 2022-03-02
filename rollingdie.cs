using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLaddergame
{
     class rollingdie
    {
        public static void rolldie()
        {
            Random random = new Random();
            int die=random.Next(1,7);
            Console.WriteLine("number on die :" + die);
        }
    }
}
