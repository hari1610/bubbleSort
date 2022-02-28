using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    public class SortArrayMerge
    {
        public static int[] MergeArray(int[] array1, int[] array2)//this method merges two arrays together
        {
            int[] output = new int[array1.Length + array2.Length];
            if (array1.Length == 0 && array2.Length == 0)
            {
                return output;
            }
            else if (array1.Length == 0 || array2.Length == 0)
            {
                throw new ArgumentException("One of the string is empty");
            }
            else
            {

                array1.CopyTo(output, 0);
                array2.CopyTo(output, array1.Length);
                Array.Sort(output);

                return output;
            }
        }
    }
}
