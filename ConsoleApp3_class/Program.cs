using System;

namespace ConsoleApp3_class
{
        public static class Mathsum
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }

        public abstract class Area
        {
            public abstract double CalculateArea();
        }

        public class Circle : Area
        {
            public double Radius { get; set; }
            public override double CalculateArea()
            {
                double Pi = 3.14;
                return Pi* Radius * Radius;
            }
        }

        public sealed class FinalClass
        {
            public void DisplayMessage()
            {
                Console.WriteLine("This is a sealed class.");
            }
        }

        public partial class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public partial class Student
        {
            public void DisplayFullName()
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
        }
}
