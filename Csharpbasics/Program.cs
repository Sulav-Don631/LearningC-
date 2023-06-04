using System;
using LearnCollectiion;

class Program
{
    static void Main()
    {
      Square square = new Square(23.45);
      var rectangle = new Rectangle(223.5,445.6);
      var x = square.GetArea();
      rectangle.PrintResult();

      Console.WriteLine($"Area: {x}");
    }
}