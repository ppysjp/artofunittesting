using System;
using System.Collections.Generic;

namespace HigherOrderAbstractions
{
    public class ApplyFunctionToNumber
    {

        public static long SumNPFI(long n, Func<long, bool> p, Func<long, long> f, Func<long, long> inc)
        {
            /// <summary>Returns the value of longeger n if the predicate is satisfied,
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

        public static long ComposeNPF(long n, Func<long, bool> p, Func<long, long> f)
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
