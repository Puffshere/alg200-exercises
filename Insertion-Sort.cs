using System;
using System.Collections.Generic;

namespace alg200_exercises
{
    class InsertionSort
    {
        public InsertionSort(int one, int two, int three, int four, int five)
        {
            int[] arr1 = new int[5];
            arr1[0] = one;
            arr1[1] = two;
            arr1[2] = three;
            arr1[3] = four;
            arr1[4] = five;
        }
        public string insertionSort(int one, int two, int three, int four, int five)
        {
            int[] arr1 = new int[5];
            arr1[0] = one;
            arr1[1] = two;
            arr1[2] = three;
            arr1[3] = four;
            arr1[4] = five;
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