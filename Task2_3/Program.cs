using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main()
        {
            // Ввод длины в дюймах
            Console.Write("Введите длину в дюймах: ");
            double inches = double.Parse(Console.ReadLine());

            // Переводим дюймы в сантиметры
            double centimeters = inches * 2.54;

            // Переводим сантиметры в метры, сантиметры и миллиметры
            int meters = (int)(centimeters / 100); // Целая часть метров
            int remainingCentimeters = (int)(centimeters % 100); // Оставшиеся сантиметры
            double millimeters = (centimeters - (meters * 100 + remainingCentimeters)) * 10; // Миллиметры

            // Вывод результата
            Console.WriteLine($"{inches} дюймов = {meters} м {remainingCentimeters} см {millimeters:F1} мм");
        }
    }
}
