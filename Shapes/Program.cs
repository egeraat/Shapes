using System;
using System.Collections.Generic;

//
abstract class Shape //van een abstracte class kan je geen object maken dus handig voor classes met namen zoals 'Shape', 'Animal' etc
{
    public abstract double CalculateArea(); //geeft waarde terug als een double
}

class Rectangle : Shape //child van parent shape
{
    public double Width { get; set; } //public anders kan de double waarde niet worden aangepast door de som onderaan de code
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Triangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return 0.5 * Width * Height;
    }
}

class Icosagon : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
class Tridecagon : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    class Program
{
    static void Main()
    {
        List<Shape> shapeObjects = new List<Shape>(); //maakt een lijst met shape objecten

        shapeObjects.Add(new Rectangle() { Width = 5, Height = 10 });
        shapeObjects.Add(new Circle() { Radius = 7 });
        shapeObjects.Add(new Triangle() { Width = 4, Height = 6 });
        shapeObjects.Add(new Icosagon() { Radius = 20 });
        shapeObjects.Add(new Tridecagon() { Radius= 15 });

        foreach (Shape shape in shapeObjects)
        {
            Console.WriteLine($"{shape.GetType().Name} Area: {shape.CalculateArea()}\n");
        }
    }
}
}
