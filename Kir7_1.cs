using System;
using System.Collections.Generic;

namespace calc2
{
    class Program
    {
        class calc2
        {
            static void Sum()
            {
                int x = 368;
                int y = 32;
                int result = x + y;
                Console.WriteLine("Сумма = " + result);
            }
            static void Minus()
            {
                int x = 99;
                int y = 9;
                int result = x - y;
                Console.WriteLine("Разность = " + result);
            }
            static void Multiply()
            {
                int x = 332;
                int y = 3;
                int result = x * y;
                Console.WriteLine("Умножение = " + result);
            }
            static void Divide()
            {
                double x = 300;
                double y = 100;
                double result = x / y;
                Console.WriteLine("Деление = " + result);
            }
            static void Stepen()
            {
                double x = 2;
                double y = 4;
                double result = Math.Pow(x, y);
                Console.WriteLine("Степень = " + result);
            }
            static void Kvadrat()
            {
                double x = 256;
                double result = Math.Sqrt(x);
                Console.WriteLine("Квадрат = " + result);
            }

        }

        static void Main(string[] args)
        {
            

        }
    }
}