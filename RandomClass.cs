using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class RandomClass : Guesser

    {
        public RandomClass(Random R) :base(R)
        {

        }
        public override int Guess(int input)
        {
            int randomNum = 0;
            int rando = r.Next(1, 101);
            while(randomNum != input)
            {
                randomNum = r.Next(1,101);
                guessCount++;
            }
            return guessCount;
        }

        
    }
}
