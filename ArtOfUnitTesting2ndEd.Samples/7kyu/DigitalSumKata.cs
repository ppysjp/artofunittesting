using HigherOrderAbstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class DigitalSumKata
    {
        private static Func<int, bool> Between0And10 = n => 0 < n && n < 10;
        private static Func<int, int> Increment = inc => inc / 10;
        public static Func<int, int> LastDigit = n => n % 10;
        public static Func<int, int> SumDigits = n => ApplyFunctionToInteger.SumNPFI(n, Between0And10, LastDigit, Increment);
        public static Func<int, int> DigitalSum = n => ApplyFunctionToInteger.ComposeNPF(n, Between0And10, SumDigits);
    }
}
