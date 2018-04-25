using System;
using System.Collections.Generic;
using System.Text;



#region Trapezoid
namespace TrapezoidComputation
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter four sides: ");
                Console.Write("Side A (Base): ");
                float sideA = float.Parse(Console.ReadLine());
                Console.Write("Side B (Base): ");
                float sideB = float.Parse(Console.ReadLine());
                Console.Write("Side C (Leg): ");
                float sideC = float.Parse(Console.ReadLine());
                Console.Write("Side D (Leg): ");
                float sideD = float.Parse(Console.ReadLine());
                Console.Write("Height: ");
                float height = float.Parse(Console.ReadLine());
                Trapezoid trap = new Trapezoid() { BaseA = sideA, BaseB = sideB, LegA = sideC, LegB = sideD, Height = height };
                trap.GetPerimeter();
                trap.GetArea();
            }
            catch (Exception)
            {
                Console.Write("Invalid input");
            }
            Console.Read();
        }
    }
}

class Trapezoid
{
    public float BaseA { get; set; }
    public float BaseB { get; set; }
    public float LegA { get; set; }
    public float LegB { get; set; }
    public float Height { get; set; }

    public void GetPerimeter()
    {
        Console.WriteLine("Perimeter of the trapezoid is: " + (BaseA + BaseB + LegA + LegB).ToString("0.00"));
    }

    public void GetArea()
    {
        Console.WriteLine("Area of the trapezoid is: " + (0.5 * (BaseA + BaseB) * Height).ToString("0.00"));
    }
}
#endregion
