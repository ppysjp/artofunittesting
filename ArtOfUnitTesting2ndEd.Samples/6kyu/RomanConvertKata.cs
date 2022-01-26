using System;
using System.Collections.Generic;
using System.Text;

namespace _6kyu
{
    public class RomanConvertKata
    {
        public static string Solution(int n)
        {
            Dictionary<int, string> intsToNumerals = BuildIntsToNumerals();
            Dictionary<int, Func<int, string>> reduceFunctions = BuildReduceFunctions();
            return Solution(n, intsToNumerals, reduceFunctions);
        }

        private static string Solution(int n, Dictionary<int, string> intsToNumerals, Dictionary<int, Func<int, string>> reduceFunctions)
        {
            if (n > 1000) // untested
            {
                return BuildNumeral(n, 1000);
            }
            else if (Between900And1000(n))
            {
                return BuildNumeral(n, 900);
            }
            else if (Between500And900(n))
            {
                return BuildNumeral(n, 500);
            }
            else if (Between400And500(n))
            {
                return BuildNumeral(n, 400);
            }
            else if (Between100And400(n))
            {
                return BuildNumeral(n, 100);
            }
            else if (Between90And100(n))
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

        private static Dictionary<int, string> BuildIntsToNumerals()
        {
            return new Dictionary<int, string>()
            {
                {1, "I" },
                {5, "V" },
                {10, "X" },
                {50, "L" },
                {100, "C" },
                {500, "D" },
                {1000, "M" }
            };
        }

        private static Dictionary<int, Func<int, string>> BuildReduceFunctions()
        {
            return new Dictionary<int, Func<int, string>>()
            {
                {4,  Reduce4 },
                {9,  Reduce9 },
                {40, Reduce40 },
                {90, Reduce90 },
                {400, Reduce400 },
                {900, Reduce900 }
            };
        }

        private static bool Between900And1000(int n) => NBetweenAAndB(n, 900, 1000);
        private static bool Between500And900(int n) => NBetweenAAndB(n, 500, 900);
        private static bool Between400And500(int n) => NBetweenAAndB(n, 400, 500);
        private static bool Between100And400(int n) => NBetweenAAndB(n, 100, 400);
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
        private static string Reduce400(int n) => ReduceNumeral(n, 100);
        private static string Reduce900(int n) => ReduceNumeral(n, 100);

        private static string BuildNumeral(int n, int a) => Solution(a) + Solution(n - a);
        private static string ReduceNumeral(int n, int a) => Solution(a) + Solution(n + a);
        private static bool NBetweenAAndB(int n, int a, int b) => n > a && n < b;

    }
}
