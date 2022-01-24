using System;
using System.Collections.Generic;
using System.Text;

namespace _6kyu
{
    public class RomanConvertKata
    {
        public static string Solution(int n)
        {
            var  intsToNumerals = new Dictionary<int, string>() 
            {
                {1, "I" },
                {5, "V" },
                {10, "X" },
                {50, "L" },
                {100, "C" },
            };

            var reduceFunctions = new Dictionary<int, Func<int, string>>()
            {
                {4,  Reduce4 },
                {9,  Reduce9 },
                {40, Reduce40 },
                {90, Reduce90 }
            };

            if (Between90And100(n))
            {
                return BuildNumeral(n, 90);
            }
            else if (Between50And90(n))
            {
                return BuildNumeral(n, 50);
            }
            else if (Between40And50(n))
            {
                return BuildNumeral(n, 40);
            }
            else if (Between10And40(n))
            {
                return BuildNumeral(n, 10);
            }
            else if (Between5And9(n))
            {
                return BuildNumeral(n, 5);
            }
            else if (Between1And4(n))
            {
                return BuildNumeral(n, 1);
            }
            else if (reduceFunctions.ContainsKey(n))
            {
                return reduceFunctions[n](n);
            }
            else
            {
                return intsToNumerals[n];
            }
        }



        private static bool Between90And100(int n) => NBetweenAAndB(n, 90, 100);
        private static bool Between50And90(int n) => NBetweenAAndB(n, 50, 90);
        private static bool Between40And50(int n) => NBetweenAAndB(n, 40, 50);
        private static bool Between10And40(int n) => NBetweenAAndB(n, 10, 40);
        private static bool Between5And9(int n) => NBetweenAAndB(n, 5, 9);
        private static bool Between1And4(int n) => NBetweenAAndB(n, 1, 4);

        private static string Reduce4(int n) => ReduceNumeral(n, 1);
        private static string Reduce9(int n) => ReduceNumeral(n, 1);
        private static string Reduce40(int n) => ReduceNumeral(n, 10);
        private static string Reduce90(int n) => ReduceNumeral(n, 10);

        private static string BuildNumeral(int n, int a) => Solution(a) + Solution(n - a);
        private static string ReduceNumeral(int n, int a) => Solution(a) + Solution(n + a);
        private static bool NBetweenAAndB(int n, int a, int b) => n > a && n < b;

    }
}
