using System;

namespace Unit_9
{
   public class Program
    {
        public delegate void CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calcDelegate = Calculate1;
            calcDelegate += Calculate2;
            calcDelegate(105, 125);
        }
        static void Calculate1(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Calculate2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

}
    
