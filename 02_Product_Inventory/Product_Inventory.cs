using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        { //65011671 
            Console.Write("Enter 1st Product ID : ");
            string productID1 = Console.ReadLine();
            Console.Write("Enter 1st Product Price (THB) : ");
            string pp1 = (Console.ReadLine());
            decimal productPrice1 = Convert.ToDecimal(pp1);
            Console.Write("Enter 1st Product Quantity : ");
            string pQ1 = Console.ReadLine();
            int productQuantity1 = Convert.ToInt32(pQ1);

            Console.Write("Enter 2nd Product ID : ");
            string productID2 = Console.ReadLine();
            Console.Write("Enter 2nd Product Price (THB) : ");
            string pp2 = (Console.ReadLine());
            decimal productPrice2 = Convert.ToDecimal(pp2);
            Console.Write("Enter 2nd Product Quantity : ");
            string pQ2 = Console.ReadLine();
            int productQuantity2 = Convert.ToInt32(pQ2);

            Console.Write("Enter 3rd Product ID : ");
            string productID3 = Console.ReadLine();
            Console.Write("Enter 3rd Product Price (THB) : ");
            string pp3 = (Console.ReadLine());
            decimal productPrice3 = Convert.ToDecimal(pp3);
            Console.Write("Enter 3rd Product Quantity : ");
            string pQ3 = Console.ReadLine();
            int productQuantity3 = Convert.ToInt32(pQ3);

            decimal totalPrice = (productPrice1*productQuantity1 + productPrice2*productQuantity2 + productPrice3*productQuantity3);
            Console.Write("Total Price : "+totalPrice);
            Console.Read();

        }
    }
}
