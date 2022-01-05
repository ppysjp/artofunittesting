using HigherOrderAbstractions;
using System;
using System.Collections.Generic;

namespace _7kyu
{
    public class IsSquareNumberKata 
    {
        public static bool IsSquare(int n)
        {
            // From Quora:
            // If a number does not end in SquareEnding then it is not a square number.
            // If a number's Digital Sum is in the DigitalSumEndings set then it is a square number, otherwise it isn't.

            HashSet<int> SquareEndings = new HashSet<int>() { 0, 1, 4, 5, 6, 9 };
            HashSet<int> DigitalSumEndings = new HashSet<int>() { 1, 4, 7, 9 };
            bool result = !SetContains_LastDigit(n, SquareEndings) ? false : SetContains_DigitalSum(n, DigitalSumEndings);
            return result;
        }

        private static Func<int,bool> Between0And10 = n => 0 < n && n < 10;
        private static Func<int, int> Increment = inc => inc / 10;
        private static Func<int, HashSet<int>, bool> SetContains_LastDigit = (n ,set) => set.Contains(DigitalSumKata.LastDigit(n));
        private static Func<int, HashSet<int>, bool> SetContains_DigitalSum = (n, set) => set.Contains(DigitalSumKata.DigitalSum(n));

    }
}
