using System;
using System.Text;

namespace reflectionCS2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
        }

   
        public static void Log(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Log(int integer, ConsoleColor color = ConsoleColor.Gray) => Log(integer.ToString(), color);

    }
}
