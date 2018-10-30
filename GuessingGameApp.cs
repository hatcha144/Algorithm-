using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class GuessingGameApp
    {
        Random r;
        public int num { get; }

        
        
        public GuessingGameApp(Random R)
        {
            r = R;
            num = r.Next(1, 101);
            Console.WriteLine(num);
        }

        public GuessingGameApp(int num)
        {
            this.num = num;
        }

        public bool GuessAnswer(int input,out int result)
        {
            
            int diff = 0;
            if (input == num)
            {
                Console.WriteLine("Match! You win!");
                result = 0;
                return true;
            }
            else if (input > num)
            {
                diff = input - num;
                if (diff > 10)
                {
                    Console.WriteLine("Way too high");
                    result = -1;
                }
                else
                {
                    Console.WriteLine("Too high!");
                    result = -1;
                }
            }
            else
            {
                diff = num - input;
                if (diff > 10)
                {
                    Console.WriteLine("Way too low!");
                    result = 1;
                }
                else
                {
                    Console.WriteLine("Too low");
                    result = 1;
                }
            }

            return false;
        }

      


    }
}
