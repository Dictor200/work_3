using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            int x = 201; // начинаем с числа, большего 200
            while (x % 17 != 0)
            {
                x++; // увеличиваем число на 1 до тех пор, пока оно не станет кратным 17
            }
            Console.WriteLine($"Минимальное число, большее 200 и кратное 17: {x}"); // выводим результат в консоль
            Console.WriteLine("Второе задание");
            double distance = 10; // начальная дистанция в первый день - 10 км
            int day = 1; // начинаем с первого дня

            // вычисляем, в какой день человек достигнет 20 км
            while (distance < 20)
            {
                day++;
                distance *= 1.05; // увеличиваем дистанцию на 5% каждый день
            }
            Console.WriteLine($"Человек пробежит 20 км на {day}-й день");

            // вычисляем, в какой день сумма пробега будет больше 100 км
            distance = 10; // сбрасываем дистанцию до начальной
            day = 1; // сбрасываем день до начального
            double totalDistance = distance; // общая дистанция равна дистанции первого дня
            while (totalDistance < 100)
            {
                day++;
                distance *= 1.05; // увеличиваем дистанцию на 5% каждый день
                totalDistance += distance; // добавляем дневную дистанцию к общей
            }
            Console.WriteLine($"Сумма пробега будет больше 100 км на {day}-й день");
            Console.WriteLine("Третие задание ");
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Факториал числа {n} равен {factorial}");
            Console.WriteLine("Четвёртое задание");
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"Наименьший делитель числа {number} равен {i}");
                    break;
                }
            Console.ReadKey();
            }
        }
    }
}




