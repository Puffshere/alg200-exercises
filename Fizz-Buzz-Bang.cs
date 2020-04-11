//using System;

namespace alg200_exercises
{
    class Buzz
    {
        private static int _a;

        public Buzz(int a)
        {
            _a = a;
        }
        public int Hello()
        {
            int x = _a + _a;
            return x;
        }
    }
}