using System.Collections.Generic;
using System.Threading;

namespace TestNinja.Fundamentals
{
    public class Math
    {
        public int Add(int a, int b) 
        {
            if (a == b)
            {
                return a;
            }

            return a + b;
        }

        public int Sub(int a, int b)
        {
            if (a == b)
            {
                return a - b;
            }

            if (a > b)
            {
                return a - b;
            }

            return b - a;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                b = 1;
            }

            return a / b;
        }

        public int Max(int a, int b)
        {
            return a >= b ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }

        public IEnumerable<int> GetEvenNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 == 0)
                    yield return i;
        }
    }
}