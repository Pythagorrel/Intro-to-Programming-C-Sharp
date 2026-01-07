using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {//65011671
            Console.Write("enter the initial amount : ");
            string IA = Console.ReadLine();
            double initialAmount = Convert.ToDouble(IA);
            Console.Write("\nenter the interest rate : ");
            string IR = Console.ReadLine();
            double interest_Rate = Convert.ToDouble(IR);
            double finalAmount = (1 + interest_Rate / 100)*initialAmount;
            Console.WriteLine("\nFinal amount is " + finalAmount);
            Console.Read();
            

        }
    }
}
