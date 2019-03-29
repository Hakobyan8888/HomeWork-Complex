using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum complexNum1 = new ComplexNum(10, 5, "i^2");
            ComplexNum complexNum2 = new ComplexNum(13, 6, "i^2");
            Console.WriteLine(complexNum1.Division(complexNum1, complexNum2));
            Console.ReadLine();
        }
    }
}
