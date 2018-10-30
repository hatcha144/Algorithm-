using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            GuessingGameApp ga = new GuessingGameApp(r);
              Guesser rando = new BruteForce(r);
           // Guesser rando = new RandomClass(r);
           // Guesser rando = new HigherLower(r);

            Console.WriteLine();
            int code = ga.num;
            
            int guess = rando.Guess(code);
            
            rando.PrintGuesses();
            Console.ReadLine();
        }
    }
}
