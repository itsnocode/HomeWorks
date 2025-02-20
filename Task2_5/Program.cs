using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    internal class Program
    {
        static void Main()
        {
            // Ввод длины трубы
            Console.Write("Введите длину трубы в метрах: ");
            double length = double.Parse(Console.ReadLine());

            // Округление в большую сторону
            int roundedLength = (int)Math.Ceiling(length);

            // Вывод результата
            Console.WriteLine($"Округленная длина: {roundedLength} м");
        }
    }
}
