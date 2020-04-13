using System;


namespace alg200_exercises
{
    class Buzz
    {
        private static int _a;

        public Buzz(int a)
        {
            _a = a;
        }

        //non-recursion
        public string factorial(int num)
        {
            if (num == 1)
            {
                return "";
            }
            else
            {
                for (int i = 1; i <= num; i++)
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
                string s = num.ToString();
                return "";
            }
        }
        public int factorial1(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                int q = factorial1(number - 1) * number;
                return q;
            }
        }
    }
}