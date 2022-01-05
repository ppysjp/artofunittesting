using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class SumToSquareKata
    {

        public static int Square(int n)
        {
            return Sum2kMinus1(1, n);
        }

        public static int Sum2kMinus1(int k, int n)
        {
            return SumTerm(1, n, k => 2 * k - 1, i => i + 1);
        }

        public static int SumTerm(int i, int n, Func<int, int> term, Func<int, int> inc)
        {
            if (i > n)
            {
                return 0;
            }
            else
            {
                return term(i) + SumTerm(inc(i), n, term, inc);
            }
        }
    }
}
