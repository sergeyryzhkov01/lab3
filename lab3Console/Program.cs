using System;

namespace lab3Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber;
            do
            {
                Console.Clear();

                Console.WriteLine("Лабораторная работа №3");
                Console.WriteLine("Вариант 4");
                Console.WriteLine();
                Console.WriteLine("1 - Задание 2");
                Console.WriteLine("2 - Задание 3");
                Console.WriteLine("3 - Задание 4*");
                Console.WriteLine("0 - Выход");
                Console.WriteLine();
                Console.Write("Введите номер задания: ");

                taskNumber = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (taskNumber)
                {
                    case 1:
                        Task2();
                        break;

                    case 2:
                        Task3();
                        break;

                    case 3:
                        Task4();
                        break;

                    case 0:
                        Console.WriteLine("Выход из программы.");
                        break;

                    default:
                        Console.WriteLine("Такого задания нет.");
                        break;
                }

                if (taskNumber != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                    Console.ReadKey();
                }

            } while (taskNumber != 0);
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите целые числа.");
            Console.WriteLine("Для окончания ввода введите 0.");

            int count = 0;

            while (true)
            {
                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                    break;

                if (Math.Abs(number) >= 100 && Math.Abs(number) <= 999)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Количество трехзначных чисел: " + count);
        }

        static void Task3()
        {
            Console.WriteLine("Задание 3");

            for (int number = 1000; number <= 9999; number++)
            {
                if (number % 133 == 125 && number % 134 == 111)
                {
                    Console.WriteLine("Искомое число: " + number);
                    break;
                }
            }
        }

        static void Task4()
        {
            Console.WriteLine("Задание 4*");
            Console.WriteLine("Введите последовательность целых чисел.");
            Console.WriteLine("Для окончания ввода введите 0.");

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = number;

            while (number != 0)
            {
                if (number > max)
                {
                    max = number;
                }

                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Наибольшее число: " + max);
        }
    }

}

