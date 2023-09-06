using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Введите Имя и Отчество");
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Здравствуйте " + name + "");
            Console.ReadKey();
        }
    }
}
