using System;
using System.Collections.Generic;

namespace HigherOrderAbstractions
{
    public class ApplyFunctionToInteger
    {

        public static int SumNPFI(int n, Func<int, bool> p, Func<int, int> f, Func<int, int> inc)
        {
            /// <summary>Returns the value of integer n if the predicate is satisfied,
            /// otherwise it returns the following sum: f(n) + f(inc(n)) + f(inc(inc(n))) ... 
            /// until the argument of f satisfies the predicate
            /// </summary>
            if (p(n))
            {
                return n;
            }
            else
            {
                return f(n) + SumNPFI(inc(n), p, f, inc);
            };
        }

        public static int ComposeNPF(int n, Func<int, bool> p, Func<int, int> f)
        {
            /// <summary>Returns the value f(n) if the predicate is satisfied,
            /// otherwise it returns: f(f(f(...f(n)...))) until this satisfies the predicate. 
            /// </summary>
            
            if ((p(f(n))))
            {
                return f(n);
            }

            return ComposeNPF(f(n), p, f);
        }
    }
}
