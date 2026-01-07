using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Loop_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, sentinel = 100, sum =0; 
            while(count!=sentinel)
            { Console.Write("Enter a two-digit number: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count == sentinel)
                { break; }
                if (count<10 || count>99)
                { Console.Write("Please enter only two-digit number!\n");
                    continue;
                }
                sum += count;
            }
            Console.Write("Total sum of two-digit numbers is {0}", sum);
            Console.Read();



        }
    }
}
