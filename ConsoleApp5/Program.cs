using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            /* I am using The switch statement here to check the Sign of the number*/
            
            switch (Math.Sign(number))
            {
                case 1:
                    Console.WriteLine("The number is positive.");
                    break;
                case -1:
                    Console.WriteLine("The number is negative.");
                    break;
                default:
                    Console.WriteLine("The number is zero.");
                    break;
            }
             /*here I am using the Conditonal operator to see if number is odd or even*/
           
            string evenOrOdd = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + evenOrOdd + ".");

            Console.ReadLine();


        }
    }
}
