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

            var squareEndings = new HashSet<int>() { 0, 1, 4, 5, 6, 9 };
            var digitalSumEndings = new HashSet<int>() { 1, 4, 7, 9 };
            return !SetContainsLastDigit(n, squareEndings) ? false : SetContainsDigitalSum(n, digitalSumEndings);
        }

        private static bool SetContainsLastDigit(int n, HashSet<int> set) => set.Contains(DigitalSumKata.LastDigit(n));
        private static bool SetContainsDigitalSum(int n, HashSet<int> set)  => set.Contains(DigitalSumKata.DigitalSum(n));

    }
}
