using System;

namespace Lommeregner_H1
{
    class Program
    {
        static double Plus(double result, double num)
        {
            return result + num;       
        }
        public static double Minus(double result, double num)
        {
            return result - num;
        }
        static double Addition(double result, double num2)
        {
            return result * num2;
        }
        static double Divide(double result, double num2)
        {
            // Hey Slothman

            return result / num2;
        }

        static void Main()
        { 
            Console.Write("Number 1: ");
            double result = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.Write("Operator type: ");
                string OpType = Console.ReadLine();

                if (OpType != "+" && OpType != "-" && OpType != "*" && OpType != "/")
                {
                    Console.WriteLine($"Your result is {result}");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Number 2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (OpType)
                {
                    case "+":
                        result = plus(result, num2);
                        break;
                    case "-":
                        result = minus(result, num2);
                        break;
                    case "*":
                        //result = Addition
                        break;
                    case "/":
                        //result = Division
                        result += Plus(result, num2);
                        break;
                    case "-":
                        result += Minus(result, num2);
                        break;
                    case "*":
                        result += Addition(result, num2);
                        break;
                    case "/":
                        result += Divide(result, num2);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
