using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {//65011671
            Console.Write("Enter width of building: ");
            string BW = Console.ReadLine();
            double buildingWidth = Convert.ToDouble(BW);
            Console.Write("Enter Length of building: ");
            string BL = Console.ReadLine();
            double buildingLength = Convert.ToDouble(BL);
            Console.Write("Enter number of floors: ");
            string nOF = Console.ReadLine();
            int numberOfFloors = Convert.ToInt32(nOF);
            Console.Write("Enter foundation cost: ");
            string FC = Console.ReadLine();
            double foundationCost = Convert.ToDouble(FC);
            Console.Write("Enter the overall cost: ");
            string OC = Console.ReadLine();
            double overallCost = Convert.ToDouble(OC);
            double numerator = overallCost - foundationCost;
            double denominator = buildingWidth * buildingLength * numberOfFloors;
            double costPerSquareMetre = numerator / denominator;
            Console.Write("The cost per square meter is "+costPerSquareMetre);
            Console.Read();

        }
    }
}
