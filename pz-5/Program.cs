using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Батрутдинов ТИМУР 2пк2
            //ЗАДАНИЕ №1
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Первое задание");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("exercise 1");
            Console.WriteLine();
            Console.ResetColor();
            for (int i = 0; i < 70; i += 2)
            {
                Console.WriteLine(i + 2);
            }
            //Второе задание
            Console.WriteLine("Второе задание");

            char a = 'd';
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(a);
                a++;

            }
            //Третье задание
            Console.WriteLine("Третье Задание");
            int a1 = '#';
            for (int i = 0; i != 5; i++)
            {
                for (int v = 0; v != 5; v++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            //Четвёртое задание 
            Console.WriteLine("четвёртое задание");
            for (int b = 0; b != 100; b++)
            {
                int number = b % 7;
                if (number == 0)
                {
                    Console.WriteLine(b);

                }
            }
        }
    }
}
