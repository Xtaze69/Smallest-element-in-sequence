using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наименьший_элемент_в_последовательности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            int number;
            int min = int.MaxValue;

            Console.WriteLine("Введите длину последовательности: ");
            length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Введите число: ");
                number = int.Parse(Console.ReadLine());
                min = min > number ? number : min;
            }

            Console.WriteLine($"Минимальное из чисел = {min}");
            Console.ReadKey();
        }
    }
}
