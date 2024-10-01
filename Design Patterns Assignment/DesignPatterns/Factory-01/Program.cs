using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_01
{
    internal class Program
    {

        public interface Shape
        {
            void draw();
        }

        public class Circle : Shape 
        { 
            public void draw()
            {
                Console.WriteLine("Drawing a circle.");
            }
        }

        public class Square : Shape
        {
            public void draw()
            {
                Console.WriteLine("Drawing a Square.");
            }
        }

        public class Rectangle : Shape
        {
            public void draw()
            {
                Console.WriteLine("Drawing a rectangle.");
            }
        }

        public class ShapeFactory
        {
            public Shape GetShape(string shapeType)
            {
                if(shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
                {
                    return new Circle();
                }
                else if(shapeType.Equals("Square", StringComparison.OrdinalIgnoreCase))
                {
                    return new Square();
                }
                else if(shapeType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
                {
                    return new Rectangle();
                }
                else
                {
                    return null;
                }
            }
        }

        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape shape1 = shapeFactory.GetShape("Circle");
            shape1.draw();

            Shape shape2 = shapeFactory.GetShape("Square");
            shape2.draw();

            Shape shape3 = shapeFactory.GetShape("Rectangle");
            shape3.draw();

            Console.ReadKey();
        }
    }
}
