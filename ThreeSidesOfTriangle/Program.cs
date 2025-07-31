using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Checker");

        // Prompt and read the three sides
        Console.Write("Enter side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        // Check if the sides can form a triangle
        if (IsValidTriangle(sideA, sideB, sideC))
        {
            string triangleType = GetTriangleType(sideA, sideB, sideC);
            Console.WriteLine($"The triangle is: {triangleType}");
        }
        else
        {
            Console.WriteLine("The entered values do not form a valid triangle.");
        }
    }

    // Function to check if it's a valid triangle
    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // Function to determine the triangle type
    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Equilateral";
        else if (a == b || a == c || b == c)
            return "Isosceles";
        else
            return "Scalene";
    }
}
