using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Введите Имя и Отчество");
            Console.BackgroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Здравствуйте " + name + "");
            Console.ReadKey();
        }

    }
}
