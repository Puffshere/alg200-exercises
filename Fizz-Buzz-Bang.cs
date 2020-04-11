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
        public int factorial()
        {
            int x = _a;
            int i = 1;
            for (i = 1; i <= x; i++)
            {
                //i++;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Bang");
                    return 1;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    return 2;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    return 3;
                }
                else
                {
                    return i;
                }

                //if (i <= _a) factorial();
            }
        }
    }
}