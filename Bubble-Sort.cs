//using System;


//namespace alg200_exercises
//{
//    class BubbleSort
//    {
//        private static int[] _arr1;

//        public BubbleSort(int[] arr1)
//        {
//            _arr1 = arr1;
//        }


//        static void SwapInts(int[] arr1, int position1, int position2)
//        {
//            int temp = arr1[position1];
//            arr1[position1] = arr1[position2];
//            arr1[position2] = temp;
//        }



//        public int[] bubbleSort()
//        {
//            int[] swapped = new int[5];
//            bool isSorted = false;
//            while (isSorted)
//            {
//                isSorted = true;
//                for (int i = 0; i < swapped.Length - 1; i++)
//                {
//                    if (swapped[i] > swapped[i + 1])
//                    {
//                        SwapInts(swapped, i, i + 1);
//                        isSorted = false;
//                    }
//                }
//            }
//            return swapped;
//        }

//    }
//}
