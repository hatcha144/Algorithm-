using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class HigherLower : Guesser
    {
        int x;
        
        public HigherLower(Random R) : base (R)
        {
            
            int rando = r.Next(1, 101);
            x = rando;
        }
        
        public override int Guess(int input)
        {
            if (x == input)
            {
                return guessCount;
            }
            else if(x > input)
            {
                x--;
                guessCount++;
            }
            else if (x < input)
            {
                x++;
                guessCount++;
            }
            return Guess(input);
        }

    }
}
