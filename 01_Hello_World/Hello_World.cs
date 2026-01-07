using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{ 

    //A Simple Program to display the words Hello World

        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int[] userAge = new int[5]; //Initialising an array using new to specify the data type and # of data entries
            userAge = new[] { 21, 22, 23, 24, 25, }; //Providing the values of the array 
            userAge[2] += 20; 
            //Adding two to the specific array value - notice 2 is the third one. 
            //Same as saying userAge[2] = userage[2]+20
            Console.WriteLine(userAge[2]);
            Console.WriteLine("Lemme see if I remember this right {0} as well as {1}...", userAge[0], userAge[1]); 
            //Using placeholders (could be pretty useful in case variable names aren't immediately handy. 
            //Remember variables are case sensitive; also when using writeline for a variable, don't include ""
            Console.Read();
        }
    }
}