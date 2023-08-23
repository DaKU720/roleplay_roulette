using System;
using System.Threading;

namespace roleplay_roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random roulette = new Random();
            int spin = roulette.Next(1, 38);      

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("** croupier is setting the roulette in motion with a strong movement **");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Roulette stopped at:");
            Console.ResetColor();

            if (spin == 1) // 4%
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GREEN!");
                Console.ResetColor();
            }
            else if(spin >= 18) //48%
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("RED!");
                Console.ResetColor();
            }
            else if(spin <= 18) //48%
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("BLACK!");
                Console.ResetColor();
            }
        }
    }
}
