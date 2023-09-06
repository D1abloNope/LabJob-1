using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Введите Имя и Отчество");
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Здравствуйте " + name + "");
            Console.ReadKey();
        }
    }
}
