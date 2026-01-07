using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows : ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the character : ");
            
            char character = Convert.ToChar(Console.ReadLine()); 
            
            for (int i = 0; i < num; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(character); 
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}