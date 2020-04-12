using System;


//namespace alg200_exercises
//{
//    class BubbleSort
//    {
//        private static int[] _array;

//        public void BubbeSort(int[] array)
//        {
//            _array = array;
//        }


//        static void SwapInts(int[] array, int position1, int position2)
//        {
//            //
//            // Swaps elements in an array.
//            //
//            int temp = array[position1]; // Copy the first position's element
//            array[position1] = array[position2]; // Assign to the second element
//            array[position2] = temp; // Assign to the first element
//        }



//        public int[] bubbleSort()
//        {
//            //int[] swapped = 0;
//            bool isSorted = false;
//            while (isSorted)
//            {
//                isSorted = true;
//                for (int i = 0; i < _array.Length - 1; i++)
//                {
//                    if (_array[i] > _array[i + 1])
//                    {
//                        SwapInts(_array, i, i + 1);
//                        isSorted = false;
//                    }
//                }
//            }
//            //return swapped;
//        }

//    }
//}
