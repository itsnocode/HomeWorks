using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main()
        {
            // Ввод градусов, минут и секунд
            Console.WriteLine("Введите угол в градусах, минутах и секундах:");
            Console.Write("Градусы: ");
            int degrees = int.Parse(Console.ReadLine());
            Console.Write("Минуты: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Секунды: ");
            int seconds = int.Parse(Console.ReadLine());

            // Перевод в радианы
            double angleInDegrees = degrees + (minutes / 60.0) + (seconds / 3600.0);
            double angleInRadians = angleInDegrees * (Math.PI / 180);

            // Вывод результата
            Console.WriteLine($"Угол в радианах: {angleInRadians}");
        }
    }
}
