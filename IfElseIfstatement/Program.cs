using System;

namespace IfElseIfstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            if (x > 0)
            {
                Console.WriteLine("The Number is positive and it came from if ");
            }
            else if (x < 0)
            {
                Console.WriteLine("The Number is negative and it came from else if");
            }
            else
            {
                Console.WriteLine("The Number is zero and it came from else");
            }
            Console.ReadKey();

        }
    }
}
