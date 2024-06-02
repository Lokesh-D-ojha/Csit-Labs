using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp3_class.Program;

namespace ConsoleApp3_class
{
    class Program
    {
        static void Main()
        {
            int sum = Mathsum.Add(10,5);
            Console.WriteLine("\nThis is the static class ");
            Console.WriteLine($"Sum of numbers : {sum}");

            Circle circle = new Circle { Radius = 5 };
            double area = circle.CalculateArea();
            Console.WriteLine("\nThis is the Abstract class ");
            Console.WriteLine($"Area of a Circle : {area}");

            FinalClass finalObj = new FinalClass();
            Console.WriteLine();
            finalObj.DisplayMessage();

            Student student = new Student { FirstName = "Lokesh", LastName = "Ojha" };
            Console.WriteLine("\nThis is the partial class ");
            student.DisplayFullName();
        }
    }
}
