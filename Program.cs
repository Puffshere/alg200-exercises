using System;
using System.Collections.Generic;

namespace alg200_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            int a = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int[] arr1 = new int[5];
            int b = a;

//-----------------Fizz-Buzz-Bang-------------------

            while (!repeat)
            {
            Console.WriteLine();
            Console.Write("Enter a number for the Fizz-Buzz-Bang exercise?  ");
            bool isNumber = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine();
                if (isNumber)
                {
                Console.WriteLine("Thank you for the input!");
                    repeat = true;
                }
                    if (!isNumber)
                    {
                    Console.WriteLine("Please enter a valid number!");
                    repeat = false;
                    }
            }
            Console.WriteLine();

            //works
            Buzz n = new Buzz(a);

            Console.WriteLine("The factorial of " + a + " is : {0}", n.factorial1(a));
            Console.WriteLine();
            Console.WriteLine(n.factorial(a));

//-------------------Bubble-Sort---------------------
                 
            //number 1
            while (repeat)
                 {
                 Console.Write("Enter 1 of 5 numbers to be sorted in the Sorting exercises:  ");
                 bool isNumber = int.TryParse(Console.ReadLine(), out one);
                 Console.WriteLine();
                    if (isNumber)
                    {
                    Console.WriteLine("Thank you for the input!");
                    repeat = false;
                    }
                        if (!isNumber)
                        {
                        Console.WriteLine("Please enter a valid number!");
                        repeat = true;
                        }
                 }  
            //number 2
            while (!repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the second of the 5 numbers to be sorted in the Sorting exercises:  ");
                 bool isNumber = int.TryParse(Console.ReadLine(), out two);
                 Console.WriteLine();
                    if (isNumber)
                    {
                    Console.WriteLine("Thank you for the input!");
                    repeat = true;
                    }
                        if (!isNumber)
                        {
                        Console.WriteLine("Please enter a valid number!");
                        repeat = false;
                        }
                 }  
            //number 3
            while (repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the third of 5 numbers to be sorted in the Sorting exercises:  ");
                 bool isNumber = int.TryParse(Console.ReadLine(), out three);
                 Console.WriteLine();
                    if (isNumber)
                    {
                    Console.WriteLine("Thank you for the input!");
                    repeat = false;
                    }
                        if (!isNumber)
                        {
                        Console.WriteLine("Please enter a valid number!");
                        repeat = true;
                        }
                 }  
            //number 4
            while (!repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the fourth of 5 numbers to be sorted in the Sorting exercises:  ");
                 bool isNumber = int.TryParse(Console.ReadLine(), out four);
                 Console.WriteLine();
                    if (isNumber)
                    {
                    Console.WriteLine("Thank you for the input!");
                    repeat = true;
                    }
                        if (!isNumber)
                        {
                        Console.WriteLine("Please enter a valid number!");
                        repeat = false;
                        }
                 }  
            //number 5
            while (repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the fifth and final of 5 numbers to be sorted in the Sorting exercises:  ");
                 bool isNumber = int.TryParse(Console.ReadLine(), out five);
                 Console.WriteLine();
                    if (isNumber)
                    {
                    Console.WriteLine("Thank you for the input!");
                    repeat = false;
                    }
                        if (!isNumber)
                        {
                        Console.WriteLine("Please enter a valid number!");
                        repeat = true;
                        }
                 }

            int[] Sorting()
                {
                arr1[0] = one;    
                arr1[1] = two;
                arr1[2] = three;
                arr1[3] = four;
                arr1[4] = five;
                return arr1;
                }  
            Console.WriteLine();
            Console.Write("Before Sorting:  ");
                foreach (int id in Sorting())
                {
                Console.Write(id + " ");
                }
            Console.WriteLine();
            Console.Write("After Bubble Sort:  ");    
            BubbleSort bSorting = new BubbleSort(arr1);
            Console.Write(bSorting.bubbleSort(arr1));
            Console.WriteLine();
            Console.Write("After Insertion Sort:  ");    
            InsertionSort iSorting = new InsertionSort(arr1);
            Console.Write(iSorting.insertionSort(arr1));
            Console.WriteLine();
            Console.Write("After Merge Sort:  ");    
            //MergeSort mSorting = new MergeSort(arr1);
            //Console.Write(mSorting.mergeSort(arr1)Console.WriteLine();
            Console.WriteLine();
            Console.Write("After Quick Sort:  ");    
            QuickSort qSorting = new QuickSort(arr1);
            Console.Write(qSorting.quickSort(arr1));Console.WriteLine();
            Console.Write("Linked List Reversed:  ");    
            LinkedList lList = new LinkedList(arr1);
            Console.Write(lList.linkedList(arr1));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to exit program");
            Console.Read();
        }
    }
}    
