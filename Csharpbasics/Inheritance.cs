using System;
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetCircumference();
    public virtual void PrintResult()
    {
        Console.WriteLine("Printing the results");
    }

}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth {get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2 * (Length * Breadth);

    public override void PrintResult()
    {
        Console.WriteLine($"Printing the results of the rectangle {Length}*{Breadth}");
        Console.WriteLine($"Area: {this.GetArea()}");
        Console.WriteLine($"Perimeter: {this.GetCircumference()}");

    }
}
public class Square : Rectangle
{
    public Square(double sides) : base(sides,sides)  // base calls parent class constructor .
    {
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea() => Math.PI * Radius * Radius;

    public override double GetCircumference() => 2 * Math.PI * Radius;

}

// Multilevel or Hirarchical Inheritance
class A
{

}

class B : A
{

}

class D : B
{

}

// Multiple Inheritance

class E : IA, IB
{

}

interface IA
{}

interface IB
{}