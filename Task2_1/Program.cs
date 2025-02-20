using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main()
        {
            // Ввод трех чисел
            Console.WriteLine("Введите три числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // Вывод исходных значений
            Console.WriteLine($"Исходные значения: a = {a}, b = {b}, c = {c}");

            // Циклический обмен значений
            int temp = a; // Сохраняем значение a во временной переменной
            a = c;        // Перемещаем значение c в a
            c = b;       // Перемещаем значение b в c
            b = temp;    // Перемещаем значение из временной переменной (исходное a) в b

            // Вывод результата
            Console.WriteLine($"После обмена: a = {a}, b = {b}, c = {c}");
        }
    }
}
