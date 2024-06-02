using System;

namespace WhileAndDo_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i+".This is while loop");
                i++;
            }
            Console.WriteLine("\n");
            int j = 0;
            do
            {
                Console.WriteLine(j+".THis is do-While loop");
                j++;
            } while (j < 5);

        }
    }
}
