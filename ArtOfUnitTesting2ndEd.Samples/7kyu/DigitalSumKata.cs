using HigherOrderAbstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class DigitalSumKata
    {
        private static bool Between0And10(int n) => 0 < n && n < 10;
        private static int Increment(int n) => n / 10;
        public static int LastDigit(int n) => n % 10;
        public static int SumDigits(int n) => ApplyFunctionToInteger.SumNPFI(n, Between0And10, LastDigit, Increment);
        public static int DigitalSum(int n) => ApplyFunctionToInteger.ComposeNPF(n, Between0And10, SumDigits);
    }
}
