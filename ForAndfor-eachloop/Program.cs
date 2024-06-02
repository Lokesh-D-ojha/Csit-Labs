using System;

namespace ForAndforEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+".This is For Loop");
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
                Console.WriteLine(num+ ".This came From For each loop");
            }

        }
    }
}
