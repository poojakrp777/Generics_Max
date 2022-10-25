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
            Console.WriteLine("Maximum Number is: " + findMaximum.findMaxIntValue(45, 89, 67));
        }
    }
}
