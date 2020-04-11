using System;


namespace alg200_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            int a = 0;
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

            Console.WriteLine(n.factorial1(a));







            Console.Read();
        }
    }
}
