using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rainbow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i = 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Thread.Sleep(i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Thread.Sleep(i);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Thread.Sleep(i);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Thread.Sleep(i);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Thread.Sleep(i);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Thread.Sleep(i);
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Thread.Sleep(i);
            }
        }
    }
}
