using System;

abstract class Shape
{
    
    public virtual float Area { get; set; }
    public virtual float Perimeter { get; set; }

    public abstract void CalculateArea();
    public abstract void CalculatePerimeter();
}

class Rectangle : Shape
{
    
    public override float Area { get; set; }
    public override float Perimeter { get; set; }

    private float Height { get; set; }
    private float Width { get; set; }

    public override void CalculateArea()
    {
        Area = Height * Width;
        Console.WriteLine("Area: " + Area);
    }

    public override void CalculatePerimeter()
    {
        Perimeter = 2 * (Height + Width);
        Console.WriteLine("Perimeter: " + Perimeter);
    }

    // Constructor để khởi tạo Height và Width
    public Rectangle(float height, float width)
    {
        Height = height;
        Width = width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter height: ");
        float height = float.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        float width = float.Parse(Console.ReadLine());

        Rectangle abcd = new Rectangle(height, width);
        abcd.CalculateArea();
        abcd.CalculatePerimeter();
    }
}