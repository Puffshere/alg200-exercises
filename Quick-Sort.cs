using System;
using System.Collections.Generic;

namespace alg200_exercises
{
    class QuickSort
    {
        public QuickSort(int[] arr1, int left, int right)
        {
        }
        static public int Partition(int[] arr1, int left, int right)
        {
            int pivot;
            pivot = arr1[left];
            while (true)
            {
                while (arr1[left] < pivot)
                {
                    left++;
                }
                while (arr1[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr1[right];
                    arr1[right] = arr1[left];
                    arr1[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public string quickSort(int[] arr1, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr1, left, right);
                if (pivot > 1)
                {
                    quickSort(arr1, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr1, pivot + 1, right);
                }

            }
            return "";
        }
    }
}