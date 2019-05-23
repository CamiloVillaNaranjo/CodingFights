using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class RexTester
    {
        protected RexTester() { }

        static void Main(string[] args)
        {
            Console.WriteLine("10!= " + Factorial(10));
            Console.WriteLine("11!= " + Factorial(11));
            Console.WriteLine("12!= " + Factorial(12));
            Console.WriteLine("13!= " + Factorial(13));
            Console.WriteLine("20!= " + Factorial(20));
            Console.ReadKey();
        }

        static long Factorial(int n)
        {
            if (n > 2)
                return n * Factorial(n - 1);
            else
                return n;
        }



    }
}
