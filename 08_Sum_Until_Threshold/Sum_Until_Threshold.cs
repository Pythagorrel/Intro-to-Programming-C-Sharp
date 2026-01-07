using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Con_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int sentinel = 500, sum = 0;
            Console.Write("please enter the initial value : ");
            sum = Convert.ToInt32(Console.ReadLine());
            while (sum<=sentinel)
            { 
                Console.Write("Please enter the value you want to add to {0} : ", sum);
                sum += Convert.ToInt32(Console.ReadLine()); 
            
            }
        Console.Write("Thank you very much the final value is {0}", sum);
            Console.Read();
        }
    }
}
