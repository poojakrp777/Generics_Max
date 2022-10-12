using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxfind_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Max Using Generics Program");

            FindMax findMaximum = new FindMax();
            Console.WriteLine("\nMaximum Integer value is : " + findMaximum.FindMaxInteger<int>(179, 586, 201));
            Console.WriteLine("\nMaximum Floating value is : " + findMaximum.FindMaxInteger<double>(7.3, 6.5, 2.0));
            Console.WriteLine("\nMaximum String is : " + findMaximum.FindMaxInteger<string>("Pooja", "Abhi", "Basava"));
        }
    }
}
