using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array : ");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] userNum = new int[index];
            int even = 0, odd = 0;
            Console.WriteLine("Input {0} elements in the array : ", index);

            for (int i = 0; i<index; i++)
            {
                Console.Write("element - {0} : ", i + 1);
                userNum[i] = Convert.ToInt32(Console.ReadLine());
                if (userNum[i]%2 ==0) 
                { even += 1; }
                else
                { odd += 1; }
            }
            int[] evenNum = new int[even];
            int[] oddNum = new int[odd];
            int k = 0, l = 0;
            for (int j =0; j<index; j++)
            { 
                if (userNum[j]%2 ==0)
                { 
                    evenNum[k] = userNum[j];
                    k++;
                }

                else
                {
                    oddNum[l] = userNum[j];
                    l++;

                }
                    
                        }
            Console.WriteLine("The Even elements are : \n" + String.Join(" ", evenNum));
            Console.WriteLine("The odd elements are : \n" + String.Join(" ", oddNum));
            Console.Read();

        }
    }
}
