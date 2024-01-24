using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace praktikum15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Пракикум 15 - Сакары Анны";

            //            Составьте таблицу значений функции y = -5x² +2x + 1 на отрезке[-5; 5] с шагом h = 2.
            //            int x = -5;
            //            for (x = -5; x <= 5; x += 2)
            //            {
            //                Console.WriteLine($"x = {x} \ty= {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //            }
            //            Console.ReadKey();

            //            //2 cпособ

            //            while (x <= 5)
            //            {
            //                Console.WriteLine($"x = {x} \ty= {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //                x += 2;
            //            }
            //            Console.ReadKey();

            //            //3 способ

            //            do
            //            {
            //                Console.WriteLine($"x = {x} \ty= {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //                x += 2;
            //            }
            //            while (x <= 5);
            //            Console.ReadKey();

            //            //Вывести двузначные чётные числа.

            //            int number;
            //            for (number = 10; number <= 99; number++)
            //            {
            //                if (number % 2 == 0)
            //                {
            //                    Console.WriteLine(number);
            //                }
            //            }
            //            Console.ReadKey();

            //            //Вывести двузначные чётные числа. Вывести количество чётных чисел - d. Вывести сумму двузначных чётных чисел - sum.

            //            int number, d = 0, summa = 0;
            //            for (number = 10; number <= 99; number++)
            //            {
            //                if (number % 2 == 0)
            //                {
            //                    Console.WriteLine(number);
            //                    d++;
            //                    summa = summa + number;
            //                }
            //            }
            //            Console.WriteLine($"d = {d}, summa = {summa}");

            //            вариант 11
            //            Составьте таблицу значений функции y = 1 / 4 * x ^ 2 + x + 1 на отрезке[-5; 5] с шагом h = 0,2

            //            double x = -5;
            //            for (x = -5; x <= 5; x += 0.2) //при значении х<=5.1  - х принимает значение 5, при x <= 5  - принимает значение 4.8.
            //            {
            //                Console.WriteLine($"x = {x:f2} \ty= {0.25 * Math.Pow(x, 2) + x + 1:f2}");
            //            }
            Console.ReadKey();
        }
    }
}
