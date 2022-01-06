using HigherOrderAbstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class DigitalSumKata
    {
        private static bool Between0And10(long n) => 0 < n && n < 10;
        private static long Increment(long n) => n / 10;
        public static long LastDigit(long n) => n % 10;
        public static long SumDigits(long n) => ApplyFunctionToNumber.SumNPFI(n, Between0And10, LastDigit, Increment);
        public static long DigitalSum(long n) => ApplyFunctionToNumber.ComposeNPF(n, Between0And10, SumDigits);
    }
}
