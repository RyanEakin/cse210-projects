using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> blocks = new List<Shape>();

        Rectangle chest = new Rectangle(5,4,"red");
        Circle orb = new Circle(5,"green");
        Square box = new Square(5,"blue");

        blocks.Add(chest);
        blocks.Add(orb);
        blocks.Add(box);

        foreach(Shape element in blocks)
        {
            Console.WriteLine($"Color: {element.GetColor()}");
            Console.WriteLine($"Area: {element.GetArea()}");
            Console.WriteLine($"The {element.GetColor()} shape has an area of {element.GetArea}."); 
            // added this after exercise to ensure I don't mess this up with the code since it ONLY stated showing the color and area
            Console.WriteLine();
        }

    }
}