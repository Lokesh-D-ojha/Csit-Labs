using System;

namespace method_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Draw(); 

            Circle circle = new Circle();
            circle.Draw(); 
        }

        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a shape before overriding");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle due to override");
            }
        }
    }
}
