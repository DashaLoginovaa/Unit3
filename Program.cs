using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модуль3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            var age = Console.ReadLine();
            Console.WriteLine($"Your name is {Name} and age is {age}");
            Console.WriteLine("Enter your birthdate:");
            var birthdate = Console.ReadLine();
            Console.WriteLine($"Your birthdate is {birthdate}");
            Console.ReadKey();

        }
    }
}
