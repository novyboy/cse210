using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("blue", 5, 3);
        Circle circle = new Circle("purple", 10);
        
        shapes = [square, rectangle, circle];
        
        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}