using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class FindNextSquareKataComplete
    {
        public static long FindNextSquare(long num)
        {
            if (IsSquare(num))
            {
                long nextToSquare = Sqrt(num) + 1;
                return nextToSquare * nextToSquare;
            }

            return -1;
        }

        public static long Sqrt(long num)
        {
            return SqrtIter(1, num);
        }

        private static long SqrtIter(long guess, long num)
        {
            if (GoodEnough(guess, num))
            {
                return guess;
            }
            else
            {
                return SqrtIter(Improve(guess, num), num);
            }
        }

        private static long Improve(long guess, long num)
        {
            return Average(guess, num / guess);
        }

        private static long Average(long x, long y)
        {
            return (x + y) / 2;
        }

        private static bool GoodEnough(long guess, long num)
        {
            return Math.Abs(guess * guess - num) < 0.001;
        }

        public static bool IsSquare(long n)
        {
            // From Quora:
            // If a number does not end in SquareEnding then it is not a square number.
            // If a number's Digital Sum is in the DigitalSumEndings set then it is a square number, otherwise it isn't.

            var squareEndings = new HashSet<long>() { 0, 1, 4, 5, 6, 9 };
            var digitalSumEndings = new HashSet<long>() { 1, 4, 7, 9 };
            return !SetContainsLastDigit(n, squareEndings) ? false : SetContainsDigitalSum(n, digitalSumEndings);
        }

        private static bool SetContainsLastDigit(long n, HashSet<long> set) => set.Contains(LastDigit(n));
        private static bool SetContainsDigitalSum(long n, HashSet<long> set) => set.Contains(DigitalSum(n));

        private static bool Between0And10(long n) => 0 < n && n < 10;
        private static long Increment(long n) => n / 10;
        public static long LastDigit(long n) => n % 10;
        public static long SumDigits(long n) => SumNPFI(n, Between0And10, LastDigit, Increment);
        public static long DigitalSum(long n) => ComposeNPF(n, Between0And10, SumDigits);

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
