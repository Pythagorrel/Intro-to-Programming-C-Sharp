using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI, conversionFactor = pi / 180, sin = 0, cos = 1, tan, angle;
            Console.Write("Input in (degree): ");
            angle = Convert.ToDouble(Console.ReadLine());
            sin = Math.Sin(conversionFactor * angle);
            cos = Math.Cos(conversionFactor * angle);
            tan = sin / cos;
            Console.Write("Sine value of {0} degree: {1:f3}", angle, sin);
            Console.Write("\nCosine value of {0} degree: {1:f3}", angle, cos);
            Console.Write("\nTangent value of {0} degree: {1:f3}", angle, tan);
            Console.Read();

        }
    }
}
