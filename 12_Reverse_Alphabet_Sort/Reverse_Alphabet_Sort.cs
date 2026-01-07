using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of letters : ");
            int n = Convert.ToInt32(Console.ReadLine());
            char[] userLetter = new char[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("letter - {0} : ", i + 1);
                userLetter[i] = Convert.ToChar(Console.ReadLine());
            }
            Array.Sort(userLetter);
            Console.Write("Reverse order: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(userLetter[n-(j+1)] + " ");
            }
            Console.Read();
        }
    }
}
