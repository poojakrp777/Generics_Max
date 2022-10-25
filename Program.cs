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
            Console.WriteLine("Welcome to Find Maximum Using Generics");
            FindMax findMaximum = new FindMax();
            Console.WriteLine("Maximum of three floating values is: " + findMaximum.findMaxDoubleValue(8.9, 5.7, 3.4));
        }
    }
}
