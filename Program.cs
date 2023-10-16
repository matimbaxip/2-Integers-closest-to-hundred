using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Integers_closest_to_hundred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer values:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = ClosestTo100(num1, num2);

            Console.WriteLine("Result: " + result);
        }

        static int ClosestTo100(int num1, int num2)
        {
            if (num1 == num2)
                return 0;

            int diff1 = Math.Abs(100 - num1);
            int diff2 = Math.Abs(100 - num2);

            if (diff1 < diff2)
                return num1;
            else
                return num2;
        }
    }

}
    

