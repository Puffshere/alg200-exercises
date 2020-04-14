using System;
using System.Collections.Generic;

namespace alg200_exercises
{
    class MergeSort
    {
        public MergeSort(int[] arr1)
        {
        }
        public string mergeSort(int[] arr1)
        {
            mergeSort(arr1, new int[arr1.Length], 0, arr1.Length - 1);
            return "";
        }
        public static string mergeSort(int[] arr1, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return "";
            }
            int middle = (leftStart + rightEnd) / 2;
            mergeSort(arr1, temp, leftStart, middle);
            mergeSort(arr1, temp, middle + 1, rightEnd);
            mergeHalves(arr1, temp, leftStart, rightEnd);
            return "";
        }
        public static string mergeHalves(int[] arr1, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (arr1[left] <= arr1[right])
                {
                    temp[index] = arr1[left];
                    index++;
                    left++;
                }
                else
                {
                    temp[index] = arr1[right];
                    right++;
                }
                index++;
            }
            foreach (int num in arr1)
            {
                Console.Write(num + " ");
            }
            return "";
        }
    }
}