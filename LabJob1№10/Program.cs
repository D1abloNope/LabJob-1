using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            const int year = 2023;
            Console.WriteLine("Введите год рождения");
            int yearold = Convert.ToInt32(Console.ReadLine());
            Console.Write(year - yearold);
            Console.ReadKey();           
        }
    }
}
