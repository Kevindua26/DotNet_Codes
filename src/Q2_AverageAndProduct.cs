// Write a C# Sharp program that takes four numbers as input to calculate and print the average and product.
using System;

namespace DotNet
{
    public class Q2_AverageAndProduct
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4.0;
            double product = num1 * num2 * num3 * num4;

            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Product: {product}");
        }
    }
}
