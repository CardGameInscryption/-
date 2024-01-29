using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите знак");
            string vibor_znaka = Console.ReadLine();

            Console.Clear();
            Console.Write("Ответ: ");
            if (vibor_znaka == "+")
            {
                double result = a + b;
                Console.WriteLine(result);
            }
            else if (vibor_znaka == "-")
            {
                double result = a - b;
                Console.WriteLine(result);
            }
            else if (vibor_znaka == "-")
            {
                double result = a - b;
                Console.WriteLine(result);
            }
            else if (vibor_znaka == "/")
            {
                double result = a / b;
                Console.WriteLine(result);
            }
        }
    }
}
