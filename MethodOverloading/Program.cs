using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOp math = new MathOp();

            int result1 = math.Addition(5, 3);
            Console.WriteLine("Result of adding integers: " + result1);

            double result2 = math.Addition(2.5, 3.7);
            Console.WriteLine("Result of adding doubles: " + result2);
        }

        class MathOp
        {
            public int Addition(int a, int b)
            {
                return a + b;
            }

            public double Addition(double a, double b)
            {
                return a + b;
            }
        }
    }
}
