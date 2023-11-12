using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactory
    {
        // AbstractProductA
        abstract class Figure
        {
            public abstract void Info();
        }

        // ConcreteProductA1
        class Rectangle : Figure
        {
            public override void Info()
            {
                Console.WriteLine("Rectangle");
            }
        }
        // ConcreteProductA2
        class Square : Figure
        {
            public override void Info()
            {
                Console.WriteLine("Square");
            }
        }
        // ConcreteProductA3
        class Circle : Figure
        {
            public override void Info()
            {
                Console.WriteLine("Circle");
            }
        }
        // AbstractProductB
        abstract class Area
        {
            public virtual void GetMethodOfAreaCalculating() { }
        }
        // ConcreteProductB1
        class RectangleArea : Area
        {
            public override void GetMethodOfAreaCalculating()
            {
                Console.WriteLine("Area of rectangle = length * width");
            }
        }
        // ConcreteProductB2
        class SquareArea : Area
        {
            public override void GetMethodOfAreaCalculating()
            {
                Console.WriteLine("Area of square = side * side");
            }
        }
        // ConcreteProductB3: DZ7
        class CircleArea : Area
        {
            public override void GetMethodOfAreaCalculating()
            {
                Console.WriteLine("Area of circle = pi * radius * radius");
            }
        }
        // AbstractFactory
        interface IFigureFactory
        {
            Figure CreateFigure();
            Area CreateArea();
        }
        // ConcreteFactory1
        class RectangleFactory : IFigureFactory
        {
            // from CarFactory
            Figure IFigureFactory.CreateFigure()
            {
                return new Rectangle();
            }
            Area IFigureFactory.CreateArea()
            {
                return new RectangleArea();
            }
        }
        // ConcreteFactory2
        class SquareFactory : IFigureFactory
        {
            // from CarFactory
            Figure IFigureFactory.CreateFigure()
            {
                return new Square();
            }
            Area IFigureFactory.CreateArea()
            {
                return new SquareArea();
            }
        }
        // ConcreteFactory3
        class CircleFactory : IFigureFactory
        {
            // from CarFactory
            Figure IFigureFactory.CreateFigure()
            {
                return new Circle();
            }
            Area IFigureFactory.CreateArea()
            {
                return new CircleArea();
            }
        }
        static void Main(string[] args)
        {
            // Rectangle
            IFigureFactory figureFactory = new RectangleFactory();
            Figure myFigure = figureFactory.CreateFigure();
            myFigure.Info();
            Area myArea = figureFactory.CreateArea();
            myArea.GetMethodOfAreaCalculating();
            Console.WriteLine();

            // Square
            figureFactory = new SquareFactory();
            myFigure = figureFactory.CreateFigure();
            myFigure.Info();
            myArea = figureFactory.CreateArea();
            myArea.GetMethodOfAreaCalculating();
            Console.WriteLine();

            // Circle
            figureFactory = new CircleFactory();
            myFigure = figureFactory.CreateFigure();
            myFigure.Info();
            myArea = figureFactory.CreateArea();
            myArea.GetMethodOfAreaCalculating();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
