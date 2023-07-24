using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random n = new Random();
            int wNum = n.Next(0, 10);
            bool win = false;

            do
            {

                Console.WriteLine("Guess a number between 0 and 10");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if(i > wNum)
                {
                    Console.WriteLine("Number is too high... try another number");
                }
                else if(i < wNum)
                {
                    Console.WriteLine("Number is too low... try another number");

                }
                else if(i == wNum)
                {
                    Console.WriteLine("You win");
                    win = true;
                }

                Console.WriteLine();

            } while(win == false);


            Console.WriteLine("Thanks for playing");
            Console.Write("Press any key to continue");
            Console.ReadKey();


        }
    }
}
