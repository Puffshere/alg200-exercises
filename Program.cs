using System;


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

            //int b = 0;
            //int ret;

            while (!repeat)
            {
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

            Buzz n = new Buzz(a);
            Console.WriteLine("The factorial of " + a + " is : {0}", n.factorial(a));

            //Console.WriteLine(n.factorial1(a));


            for (int i = 1; i <= a; i++)
            {  
                if (i % 3 == 0 && i % 5 == 0)
                {  
                Console.WriteLine("FizzBuzz");  
                }    
                else if (i % 3 == 0)
                {  
                Console.WriteLine("Fizz");  
                }
                else if (i % 5 == 0)
                {  
                Console.WriteLine("Buzz");  
                }
                else
                {  
                Console.WriteLine(i);  
            }  
        }

                 
            
            while (repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter 1 of 5 numbers to be sorted for the Bubble Sort exercise:  ");
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
            
            while (!repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the second of the 5 numbers to be sorted for the Bubble Sort exercise:  ");
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
            
            while (repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the third of 5 numbers to be sorted for the Bubble Sort exercise:  ");
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
            
            while (!repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the fourth of 5 numbers to be sorted for the Bubble Sort exercise:  ");
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
            
            while (repeat)
                 {
                 Console.WriteLine();
                 Console.Write("Enter the fifth and final of 5 numbers to be sorted for the Bubble Sort exercise:  ");
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

                 Console.WriteLine();

            int[] arr1 = new int[] {one, two, three, four, five};
            Console.WriteLine(arr1);
           // BubbleSort o = new BubbleSort(b);
           // Console.WriteLine("The sorted array appears as follows : {0}", o.bubbleSort(b));


                     

            Console.Read();
    }
}
}
