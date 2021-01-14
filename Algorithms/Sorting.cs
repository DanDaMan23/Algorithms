using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Sorting
    {
        public static int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int minPos = i;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minPos])
                    {
                        minPos = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minPos];
                numbers[minPos] = temp;
            }

            return numbers;
        }

        public static int[] InsertionSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int j = i;
                int currNum = numbers[j];

                while (j > 0 && currNum < numbers[j - 1])
                {
                    numbers[j] = numbers[j - 1];
                    j--;
                }

                numbers[j] = currNum;

            }

            return numbers;
        }

        public static int[] BubbleSort(int[] numbers)
        {
            throw new NotImplementedException();
        } 


    }
}
