using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chapter 3 exercise 31
// Written by Muna Shabab
//date: 9-10-2020

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will accept two integers from the user and display their sum, product, difference, quotient, and remainder ");
            
            //get the first integer from the user
            Console.WriteLine("Please enter the first integer: ");
            int firstInteger = int.Parse(Console.ReadLine());
            
            //get the second integer from the user
            Console.WriteLine("Please enter the second integer: ");
            int secondInteger = int.Parse(Console.ReadLine());

            //perform the calculations
            int sum = firstInteger + secondInteger;
            int product = firstInteger * secondInteger;
            int difference = firstInteger - secondInteger;
            int quotient = firstInteger / secondInteger;
            int remainder = firstInteger % secondInteger;

            //display the results
            Console.WriteLine($"the sum of {firstInteger:n0} and {secondInteger:n0} is {sum:n0}");
            Console.WriteLine($"the product of {firstInteger:n0} and {secondInteger:n0} is {product:n0}");
            Console.WriteLine($"the difference of {firstInteger:n0} and {secondInteger:n0} is {difference:n0}");
            Console.WriteLine($"the quotient of {firstInteger:n0} and {secondInteger:n0} is {quotient:n0}");
            Console.WriteLine($"the remainder of {firstInteger:n0} divided by {secondInteger:n0} is {remainder:n0}");

            Console.ReadLine();


        }
    }
}
