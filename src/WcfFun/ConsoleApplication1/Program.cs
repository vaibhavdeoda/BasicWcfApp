using System;
using System.Collections.Generic;
using ConsoleApplication1.ServiceReference1;
using WcfFun;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperationsClient proxy = new MathOperationsClient();
            var list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum = " + proxy.Sum(new Operator { Operators = list }));
            Console.WriteLine("Multiplication = " + proxy.Multiply(new Operator { Operators = list }));
            Console.ReadLine();
        }

    }
}
