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
            return SumLastDigitsMultipliedByRespectiveBase2Exponents(n, 0, MultiplyLastDigitByBase2Exponent); 
        }

        private static long SumLastDigitsMultipliedByRespectiveBase2Exponents(long a, long b, Func<long, long, long> f) => ApplyFunctionToNumber.SumABPFI(a, b, IsEqualToZero, MultiplyLastDigitByBase2Exponent, DivideBy10, Inc);
        private static long MultiplyLastDigitByBase2Exponent(long a, long b) => LastDigit(a) * Base2Exponent(2, b);
        private static long Base2Exponent(long a, long b) => ApplyFunctionToNumber.MulABPFI(a, b, IsEqualToZero, Identity, Dec);
        private static long LastDigit(long n) => n % 10;
        private static long DivideBy10(long n) => n / 10;
        private static long Inc(long n) => n + 1;
        private static long Dec(long n) => n - 1;
        private static long Identity(long n) => n;
        private static bool IsEqualToZero(long n) => n == 0;

    }
}
