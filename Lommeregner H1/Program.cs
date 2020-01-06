using System;

namespace Lommeregner_H1
{
    class Program
    {

        static double minus()
        {

            double num1;
            double num2;
            double result;
            double operators;

            double number = double.Parse(Console.ReadLine());

            num1 = number;
            operators = number;
            num2 = number;
            result = num1 - num2;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            minus();
        }
    }
}
