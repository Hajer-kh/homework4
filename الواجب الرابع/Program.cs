
using System;
using System.Collections.Generic;

class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius;
    public Circle(double r) { Radius = r; }
    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width, Height;
    public Rectangle(double w, double h) { Width = w; Height = h; }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program4
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(4, 6));

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetType().Name + " Area: " + s.CalculateArea());
        }
    }
}
