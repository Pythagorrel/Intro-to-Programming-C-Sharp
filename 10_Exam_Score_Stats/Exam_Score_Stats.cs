using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] examScore = new double[10];
            double totalScore = 0, averageScore = 0;
            
            for (int i =0; i<10; i++)
            { Console.Write("Enter exam score {0} : ", i+1);
                examScore[i] = Convert.ToDouble(Console.ReadLine());
                totalScore += examScore[i];
            }
            averageScore = totalScore / 10;
            Array.Sort(examScore);
            Console.Write("The average score is {0:f2} and the highest score is {1:f2}.", averageScore, examScore[9] );
            Console.Read();
        }
    }
}
