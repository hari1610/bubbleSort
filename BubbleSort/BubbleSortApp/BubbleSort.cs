using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    
        public class BubbleSort
        {
            public static int[] Sort(int[] intArray)
            {
                if (intArray == null)
                {
                    throw new ArgumentNullException("Input array was null");
                }
                bool swapped = false;

                do
                {
                    swapped = false;
                    for (int i = 0; i < intArray.Length - 1; i++)
                    {
                        int num1 = intArray[i];
                        int num2 = intArray[i + 1];
                        if (intArray[i] > intArray[i + 1])
                        {
                            swapped = true;
                            intArray[i] = num2;
                            intArray[i + 1] = num1;
                        }
                    }
                }
                while (swapped == true);
                return intArray;
            }

        }

    
}
