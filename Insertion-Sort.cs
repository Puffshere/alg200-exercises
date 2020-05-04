using System;
using System.Collections.Generic;

namespace alg200_exercises
{
    class InsertionSort
    {
        public InsertionSort(int[] arr1)
        {
        }
        public string insertionSort(int[] arr1)
        {
            int i, key, j;
            for (i = 1; i < arr1.Length; i++)
            {
                key = arr1[i];
                j = i - 1;
                while (j >= 0 && arr1[j] > key)
                {
                    arr1[j + 1] = arr1[j];
                    j = j - 1;
                }
                arr1[j + 1] = key;
            }
            foreach (int t in arr1)
            {
                Console.Write(t + " ");
            }
            return "";
        }
    }
}
