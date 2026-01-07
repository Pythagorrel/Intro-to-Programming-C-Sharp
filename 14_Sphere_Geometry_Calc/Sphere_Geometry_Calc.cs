using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Function_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the radius of the sphere : ");
            radius = Convert.ToDouble(Console.ReadLine());
            double C = Circum(), A = Area();
            Console.Write("\nThe circumference of the sphere is {0:f2}. \nThe area of the sphere is {1:f2}. ", C, A);
            Console.Read();

        }
        static double radius;
        static double Circum()
        {
            double circumference = (2 * Math.PI * radius);
                return circumference; }
        static double Area ()
        { double area = 4 * Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
