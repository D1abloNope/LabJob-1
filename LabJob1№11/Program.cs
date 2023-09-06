using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите сторону а");
            Console.ResetColor();   
            int a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите сторону b");
            Console.ResetColor();
            int b = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write((a + b)*2);
            Console.ReadKey();
        }
    }
}
