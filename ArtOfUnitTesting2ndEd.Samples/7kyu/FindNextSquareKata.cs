using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class FindNextSquareKata
    {
        public static long FindNextSquare(long num)
        {
            if (IsSquareNumberKata.IsSquare(num))
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
            return Math.Abs(guess*guess - num) < 0.001;
        }


    }
}
