using System;
using System.Collections.Generic;

namespace alg200_exercises
{
    class BubbleSort
    {
        public BubbleSort(int[] arr1)
        {
        }
        static void SwapInts(int[] arr1, int position1, int position2)
        {
            int temp = arr1[position1];
            arr1[position1] = arr1[position2];
            arr1[position2] = temp;
        }
        public string bubbleSort(int[] arr1)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    if (arr1[i] > arr1[i + 1])
                    {
                        SwapInts(arr1, i, i + 1);
                        isSorted = false;
                    }
                }
            }
            foreach (int t in arr1)
            {
                Console.Write(t + " ");
            }
            return "";
        }
    }
}
