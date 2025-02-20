using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    internal class Program
    {
    static void Main()
        {
            // Ввод четырехзначного числа
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            // Проверка, что число действительно четырехзначное
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Ошибка: число должно быть четырехзначным.");
                return;
            }

            // Разбиваем число на цифры
            int firstDigit = number / 1000;          // Первая цифра
            int secondDigit = (number / 100) % 10;   // Вторая цифра
            int thirdDigit = (number / 10) % 10;     // Третья цифра
            int fourthDigit = number % 10;           // Четвертая цифра

            // Меняем местами вторую и четвертую цифры
            int newNumber = firstDigit * 1000 + fourthDigit * 100 + thirdDigit * 10 + secondDigit;

            // Вывод результата
            Console.WriteLine($"Исходное число: {number}");
            Console.WriteLine($"Число после замены: {newNumber}");
        }
    }
}
