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




        public int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }






        public int factorial1(int a)
        {
            int i = 1;
            int x = a;
            bool p = i < x;

            //while (p)
            //{
            //i++;
            if (i % 3 == 0 && i % 5 == 0)
            {
                //Console.WriteLine("Bang");
                return 1;
            }
            else if (i % 3 == 0)
            {
                //Console.WriteLine("Fizz");
                return 2;
            }
            else if (i % 5 == 0)
            {
                //Console.WriteLine("Buzz");
                return 3;
            }
            else
            {
                return i;
            }
            //}
            //if (i <= x) factorial1();
        }


        //int cntr = 1;
        //while (cntr <= _a)
        //{
        //    return cntr;
        //    cntr++;
        //}




    }
}