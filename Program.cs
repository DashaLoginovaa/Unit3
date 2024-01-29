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
            /*Console.WriteLine("Enter your name:");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            var age = Console.ReadLine();
            Console.WriteLine($"Your name is {Name} and age is {age}");
            Console.WriteLine("Enter your birthdate:");
            var birthdate = Console.ReadLine();
            Console.WriteLine($"Your birthdate is {birthdate}");
            Console.ReadKey();*/
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                Console.ReadKey();
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                Console.ReadKey();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                Console.ReadKey();

            }
    }
}
