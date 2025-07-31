// If you have two integers stored in variables var1 and var2, what Boolean test can you perform to see if one or the other (but not both) is greater than 10?
using System;

namespace DotNet
{
    public class Q3_BooleanTest
    {
        public static void Main(string[] args)
        {
            int var1 = 12;
            int var2 = 8;
            // Boolean test: one or the other (but not both) is greater than 10
            bool result = (var1 > 10) ^ (var2 > 10); // XOR: true if only one is true
            Console.WriteLine($"var1 = {var1}, var2 = {var2}");
            Console.WriteLine($"Exactly one is greater than 10: {result}");
        }
    }
}
