using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Введите Имя и Отчество");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.BackgroundColor= ConsoleColor.Magenta;
            string name = Console.ReadLine();
            Console.ResetColor();
            Console.Write("Здравствуйте " + name + "");
            Console.ReadKey();
        }
    }
}
