using System;
using System.Collections.Generic;
using System.Text;
using HigherOrderAbstractions;

namespace _7kyu
{
    public class BinaryToDecimalKata
    {
        public static int BinaryToDecimal_For(string bin)
        {
            double s = 0;

            for (int i = 0; i < bin.Length; i++)
                s += double.Parse(bin[i].ToString()) * Math.Pow(2, bin.Length - i - 1);

            return (int) s;
        }

        public static long BinaryToDecimal(string bin)
        {
            long n = Convert.ToInt32(bin);
            return SumLastDigitMultipliedByRespectiveBase2Exponent(n, 0, MultiplyLastDigitByBase2Exponent); 
        }

        private static long SumLastDigitMultipliedByRespectiveBase2Exponent(long a, long b, Func<long, long, long> f) => ApplyFunctionToNumber.SumABPFI(a, b, IsEqualToZero, MultiplyLastDigitByBase2Exponent, DivideABy10, IncB);
        private static long MultiplyLastDigitByBase2Exponent(long a, long b) => LastDigit(a) * Base2Exponent(b);
        private static long Base2Exponent(long b) => Exponent(2, b);
        private static long Exponent(long a, long b) => ApplyFunctionToNumber.MulABPFI(a, b, IsEqualToZero, Identity, Dec);
        private static long LastDigit(long n) => n % 10;
        private static long DivideABy10(long a, long b) => a / 10;
        private static long IncB(long a, long b) => b + 1;
        private static long Dec(long n) => n - 1;
        private static long Identity(long n) => n;
        private static bool IsEqualToZero(long n) => n == 0;

    }
}
