using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {

        public interface Shape
        {
            void Draw();
        }

        public class Circle : Shape
        {
            public void Draw()
            {
                Console.WriteLine("Shape: Circle");
            }
        }

        public class Rectangle : Shape
        {
            public void Draw()
            {
                Console.WriteLine("Shape: Rectangle");
            }
        }

        public abstract class ShapeDecorator : Shape
        {
            protected Shape decoratorShape;

            public ShapeDecorator(Shape shape)
            {
                this.decoratorShape = shape;
            }

            public virtual void Draw()
            {
                decoratorShape.Draw();
            }
        }

        public class RedShapeDecorator : ShapeDecorator
        {
            public RedShapeDecorator(Shape shape) : base(shape) { }

            public override void Draw()
            {
                decoratorShape.Draw();
                SetRedBorder(decoratorShape);
            }

            private void SetRedBorder(Shape decoratedShape)
            {
                Console.WriteLine("Border Color: Red");
            }
        }

        public class GreenShapeDecorator : ShapeDecorator
        {
            public GreenShapeDecorator(Shape shape) : base(shape) { }

            public override void Draw()
            {
                decoratorShape.Draw();
                setGreenBorder(decoratorShape);
            }

            private void setGreenBorder(Shape decoratedShape)
            {
                Console.WriteLine("Border Color: Green");
            }
        }

        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();
            Shape redCircle = new RedShapeDecorator(circle);
            Shape greenRectangle = new GreenShapeDecorator(rectangle);

            Console.WriteLine("Circle with normal border : ");
            circle.Draw();

            Console.WriteLine("\nCircle with red border : ");
            redCircle.Draw();

            Console.WriteLine("\nRectangle with green border : ");
            greenRectangle.Draw();

            Console.ReadKey();
        }
    }
}
