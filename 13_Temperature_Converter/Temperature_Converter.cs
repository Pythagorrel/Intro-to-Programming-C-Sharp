using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Function_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        { for (int i = 0; i < 2; i++)
            {
                Console.Write("Choose, 1: C to F or 2: F to C conversion : ");
                char userSelect = Convert.ToChar(Console.ReadLine());
                double celsius, farenheit;
                if (userSelect == '1')
                {
                    Console.Write("Enter Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    farenheit = CtoF(celsius);
                    Console.Write("Farenheit is {0:f1} F\n\n", farenheit);
                }
                else
                {
                    Console.Write("Enter Farenheit: ");
                    farenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = FtoC(farenheit);
                    Console.Write("Celsius is {0:f1} C\n\n", celsius);
                }
            }
            Console.Read();

        }
        static double CtoF(double C)
        { double F;
            F = ((C * 9) / 5) + 32;
            return F;
        }
        static double FtoC(double F)
        { double C;
            C = (5 * (F - 32)) / 9;
            return C;
        }
    }
}