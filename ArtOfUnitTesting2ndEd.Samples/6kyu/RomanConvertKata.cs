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
            Dictionary<int, Func<int, string>> reduceFunctions = BuildReduceNumeralFunctions();
            List<BuildNumeralFunction> buildNumeralFunctions = BuildBuildNumeralFunctions();
            return Solution(n, intsToNumerals, reduceFunctions, buildNumeralFunctions);
        }

        private static string Solution(int n, Dictionary<int, string> intsToNumerals, Dictionary<int, Func<int, string>> reduceNumeralFunctions, List<BuildNumeralFunction> buildNumeralFunctions)
        {
            foreach (var bNF in buildNumeralFunctions)
            {
                if (bNF.predicateFunction(n))
                {
                    return bNF.buildNumeralFunction(n);
                }           
            }

            if (reduceNumeralFunctions.ContainsKey(n))
            {
                return reduceNumeralFunctions[n](n);
            }
            else
            {
                return intsToNumerals[n];
            }
        }

        private class BuildNumeralFunction
        {
            public delegate bool Predicate(int n);
            public delegate string BuildNumeral(int n);

            public Predicate predicateFunction;
            public BuildNumeral buildNumeralFunction;

        }

        private static List<BuildNumeralFunction> BuildBuildNumeralFunctions()
        {
            return new List<BuildNumeralFunction>()
            {
                { new BuildNumeralFunction() { predicateFunction = Between900And1000, buildNumeralFunction = BuildNumeral900And1000 } },
                { new BuildNumeralFunction() { predicateFunction = Between500And900, buildNumeralFunction = BuildNumeral500And900 } },
                { new BuildNumeralFunction() { predicateFunction = Between400And500, buildNumeralFunction = BuildNumeral400And500 } },
                { new BuildNumeralFunction() { predicateFunction = Between100And400, buildNumeralFunction = BuildNumeral100And400 } },
                { new BuildNumeralFunction() { predicateFunction = Between90And100, buildNumeralFunction = BuildNumeral90And100 } },
                { new BuildNumeralFunction() { predicateFunction = Between50And90, buildNumeralFunction = BuildNumeral50And90 } },
                { new BuildNumeralFunction() { predicateFunction = Between40And50, buildNumeralFunction = BuildNumeral40And50 } },
                { new BuildNumeralFunction() { predicateFunction = Between10And40, buildNumeralFunction = BuildNumeral10And40 } },
                { new BuildNumeralFunction() { predicateFunction = Between5And9, buildNumeralFunction = BuildNumeral5And9 } },
                { new BuildNumeralFunction() { predicateFunction = Between1And4, buildNumeralFunction = BuildNumeral1And4 } },
                { new BuildNumeralFunction() { predicateFunction = Between1And4, buildNumeralFunction = BuildNumeral1And4 } }
            };
        }

        private static Dictionary<int, Func<int, string>> BuildReduceNumeralFunctions()
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
                {1000, "M" },
                {5000, "G" }
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

        private static string BuildNumeral900And1000(int n) => BuildNumeral(n, 900);
        private static string BuildNumeral500And900(int n) => BuildNumeral(n, 500);
        private static string BuildNumeral400And500(int n) => BuildNumeral(n, 400);
        private static string BuildNumeral100And400(int n) => BuildNumeral(n, 100);
        private static string BuildNumeral90And100(int n) => BuildNumeral(n, 90);
        private static string BuildNumeral50And90(int n) => BuildNumeral(n, 50);
        private static string BuildNumeral40And50(int n) => BuildNumeral(n, 40);
        private static string BuildNumeral10And40(int n) => BuildNumeral(n, 10);
        private static string BuildNumeral5And9(int n) => BuildNumeral(n, 5);
        private static string BuildNumeral1And4(int n) => BuildNumeral(n, 1);

        private static string Reduce900(int n) => ReduceNumeral(n, 100);
        private static string Reduce400(int n) => ReduceNumeral(n, 100);
        private static string Reduce90(int n) => ReduceNumeral(n, 10);
        private static string Reduce40(int n) => ReduceNumeral(n, 10);
        private static string Reduce9(int n) => ReduceNumeral(n, 1);
        private static string Reduce4(int n) => ReduceNumeral(n, 1);

        private static string BuildNumeral(int n, int a) => Solution(a) + Solution(n - a);
        private static string ReduceNumeral(int n, int a) => Solution(a) + Solution(n + a);
        private static bool NBetweenAAndB(int n, int a, int b) => n > a && n < b;

    }
}
