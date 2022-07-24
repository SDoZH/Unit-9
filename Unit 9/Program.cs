using System;

namespace Unit_9
{
   public class Program
    {     
        static void Main(string[] args)
        {
            Action showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            Func<int, int, int, int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);
        }
       public static void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

       public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }

}
    
