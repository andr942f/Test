using System;

namespace Lommeregner_H1
{
    class Program
    {
        static double result;

        static void CalculateProblem()
        {
            Console.Write("Operator type: ");
            string OpType = Console.ReadLine();

            if (OpType != "+" && OpType != "-" && OpType != "*" && OpType != "/")
                Finished();

            Console.Write("Second Number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            switch (OpType)
            {
                case "+":
                    result += num;
                    break;
                case "-":
                    result -= num;
                    break;
                case "*":
                    result *= num;
                    break;
                case "/":
                    result /= num;
                    break;
                default:
                    break;
            }
        }
        static void Finished()
        {
            Console.WriteLine($"Your result is {result}");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void Main()
        { 
            Console.Write("Number 1: ");
            result = Convert.ToDouble(Console.ReadLine());

            while (true)
                CalculateProblem();
        }

    }
}
