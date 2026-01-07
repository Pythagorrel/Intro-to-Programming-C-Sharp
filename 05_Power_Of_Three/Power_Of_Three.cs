using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Input: ");
            
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0)
                { num1 = num1 * (-1); }
                double lognum = Math.Log10(num1), logbase = Math.Log10(3);
                int r = Convert.ToInt32(lognum / logbase);
                double result = Convert.ToDouble(r);
                if (Math.Pow(3, result) == num1)
                { Console.Write("Output: true\n"); }
                else
                { Console.Write("Output: False\n"); }
            }
            Console.Read();

            


        }
    }
}
