using System;

// Завдання 3: Принцип підстановки Лісков (LSP) (The Liskov Substitution Principle)
interface IFigure
{
    double GetArea();
}
class Rectangle: IFigure
{
    private double _width;
    private double _height;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Width), "The entered number must be greater than 0");
            }
            _width = value;
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Height), "The entered number must be greater than 0");
            }
            _height = value;
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

class Square : IFigure
{
    private double _side;
    public double Side
    {
        get { return _side; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Side), "The entered number must be greater than 0");
            }
            _side = value;
        }
    }

    public Square(int side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFigure rect = new Rectangle(5, 10);
        IFigure square = new Square(5);
        Console.WriteLine("Rectangle area:" + rect.GetArea());
        Console.WriteLine("Square area:" + square.GetArea());
        Console.ReadKey();
    }
}

