using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return sum;
        }

        public static string Add(int num1, int num2, bool CanShowDollar)
        {
            string dollars = num1 + num2 == 1 ? "dollar" : "dollars";
            return CanShowDollar ? $"{num1 + num2} {dollars}" : $"{num1 + num2}";
        
        }           

        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(3, 6));
            Console.WriteLine(Add(3.2m, 5.4m));
        }
    }
}
