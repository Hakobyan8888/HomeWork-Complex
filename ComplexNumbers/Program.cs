﻿using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the real Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The fake number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the I");
            Console.WriteLine("for example i or i^2 etc");
            string c = Console.ReadLine();
            ComplexNum complexNum1 = new ComplexNum(a, b, c);
            ComplexNum complexNum2 = new ComplexNum(13, 6, "i^2");
            Console.WriteLine(complexNum1.Sum(complexNum1, complexNum2));
            Console.WriteLine(complexNum1.Subtraction(complexNum1, complexNum2));
            Console.WriteLine(complexNum1.Multiplication(complexNum1, complexNum2));
            Console.WriteLine(complexNum1.Division(complexNum1, complexNum2));
            Console.ReadLine();
        }
    }
}
