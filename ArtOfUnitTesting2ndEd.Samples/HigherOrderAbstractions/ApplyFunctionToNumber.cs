using System;
using System.Collections.Generic;

namespace HigherOrderAbstractions
{
    public class ApplyFunctionToNumber
    {

        public static long SumNPFI_Rec(long n, Func<long, bool> p, Func<long, long> f, Func<long, long> inc)
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
                return f(n) + SumNPFI_Rec(inc(n), p, f, inc);
            };
        }

        public static long SumNPFI(long n, Func<long, bool> p, Func<long, long> f, Func<long, long> inc)
        {
            /// <summary>Returns the value of longeger n if the predicate is satisfied,
            /// otherwise it returns the following sum: f(n) + f(inc(n)) + f(inc(inc(n))) ... 
            /// until the argument of f satisfies the predicate
            /// </summary>

        }

        public static long SumABPFI(long a, long b, Func<long, bool> p, Func<long, long, long> f, Func<long, long, long> i, Func<long, long, long> j)
        {
            if (p(a))
            {
                return f(a, b);
            }
            else
            {
                return f(a, b) + SumABPFI(i(a, b), j(a, b), p, f, i, j);
            }
        }

        public static long MulABPFIRec(long a, long b, Func<long, bool> p, Func<long, long> f, Func<long, long> inc)
        {
            /// <summary>Returns the value of 1 if the predicate is satisfied,
            /// otherwise it returns the following multiplication: f(n) * f(inc(n)) * f(inc(inc(n))) ... 
            /// until the argument of f satisfies the predicate
            /// </summary>
            if (p(b))
            {
                return 1;
            }
            else
            {
                return f(a) * MulABPFIRec(a, inc(b), p, f, inc);
            };
        }

        public static long MulABPFI(long a, long b, Func<long, bool> p, Func<long, long> f, Func<long, long> inc)
        {
            /// <summary>Returns the value of 1 if p(b) is satisfied,
            /// otherwise it returns the following multiplication: f(a) * f(a) * f(a) ... 
            /// until the argument of f satisfies the predicate
            /// </summary>
            long result = 1;
            while (!p(b))
            {
                result *= f(a);
                b = inc(b);
            }
            return result;
        }

        public static long ComposeNPFRec(long n, Func<long, bool> p, Func<long, long> f)
        {
            /// <summary>Returns the value f(n) if the predicate is satisfied,
            /// otherwise it returns: f(f(f(...f(n)...))) until this satisfies the predicate. 
            /// </summary>
            
            if ((p(f(n))))
            {
                return f(n);
            }

            return ComposeNPFRec(f(n), p, f);
        }

        public static long ComposeNPF(long n, Func<long, bool> p, Func<long, long> f)
        {
            /// <summary>Returns the value f(n) if the predicate is satisfied,
            /// otherwise it returns: f(f(f(...f(n)...))) until this satisfies the predicate. 
            /// </summary>

            long result = f(n);
            while (!p(result))
            {
                result = f(result);
            }
            return result;
        }
    }
}
