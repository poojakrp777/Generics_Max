using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxfind_Generics
{
    class FindMaximum<T>
    {
        public T findMaxValue(T first, T second, T third)
        {
            if (Comparer<T>.Default.Compare(first, second) > 0 && Comparer<T>.Default.Compare(first, third) > 0)
            {
                return first;
            }
            else if (Comparer<T>.Default.Compare(second, first) > 0 && Comparer<T>.Default.Compare(second, third) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
