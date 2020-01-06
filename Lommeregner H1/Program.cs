using System;

namespace Lommeregner_H1
{
    class Program
    {

        public static double minus(double result, double num)
        {
            return result - num;
        }

        public static double plus(double result, double num)
        {
            return result + num;
        }

        static void Main(string[] args)
        {


            Console.Write("Number 1: ");
            double result = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.Write("Operator type: ");
                string OpType = Console.ReadLine();

                Console.Write("Number 2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (OpType)
                {
                    case "+":
                        result += plus(result, num2);
                        break;
                    case "-":
                        result += minus(result, num2);
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
