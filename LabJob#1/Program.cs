using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabJob_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имя и Отчество");
            string name = Console.ReadLine();            
            Console.Write("Здравствуйте " + name + "");
            Console.Read();    
        }   
    }
}