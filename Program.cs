using System;

namespace alg200_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            int x = 0;

            while (!repeat)
            {
            Console.Write("What is your number?  ");
            bool isNumber = int.TryParse(Console.ReadLine(), out x);
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
            Console.WriteLine(x);


            Console.Read();
        }
    }
}
