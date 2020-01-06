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

            static void Main()
            {
                Console.Write("Number 1: ");
                double result = Convert.ToDouble(Console.ReadLine());

                while (true)
                {
                    Console.Write("Operator type: ");
                    string OpType = Console.ReadLine();

                    Console.Write("Number 2: ");
                    double numtwo = Convert.ToDouble(Console.ReadLine());

                    switch (OpType)
                    {
                        case "+":
                            //result += Add
                            break;
                        case "-":
                            //result += Subtract
                            break;
                        case "*":
                            //result += Addition
                            break;
                        case "/":
                            //result += Division
                            break;
                        default:
                            Console.WriteLine($"Your result is {result}");
                            Console.ReadKey();
                            return;
                    }
                }
            }
        }
    }
}
