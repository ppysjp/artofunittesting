using System;
using System.Collections.Generic;
using System.Text;

using HigherOrderAbstractions;

namespace _7kyu
{
    public class SquareEveryDigitKata
    {
        public static long SquareDigits(long n) => SumSquareScaleLastDigit(n);
        private static long SumSquareScaleLastDigit(long n) => SumSquareScaleLastDigit(n, 0);
        private static long SumSquareScaleLastDigit(long a, long b) => ApplyFunctionToNumber.SumABPFI(a, b, IsSingleDigit, MultiplySquareLastDigitBase10Exponent, DivideABy10, IncrementB);
        private static long IncrementB(long a,long b) => IsSingleDigit(SquareLastDigit(a)) ? Inc(b) : Add2(b) ;
        private static long MultiplySquareLastDigitBase10Exponent(long a, long b) => SquareLastDigit(a) * Base10Exponent(b);
        private static long Base10Exponent(long b) => Exponent(10, b);
        private static long Exponent(long a, long b) => ApplyFunctionToNumber.MulABPFI(a, b, IsEqualToZero, Identity, Dec);
        private static long DivideABy10(long a, long b) => DivideBy10(a);
        private static long CountDigitsSquareLastDigit(long n) => CountDigits(SquareLastDigit(n));
        private static long CountDigits(long n) => IsSingleDigit(n) ? 1 : ApplyFunctionToNumber.SumNPFI(n, IsSingleDigit, One, DivideBy10);
        private static bool IsSingleDigit(long n) => IsEqualToZero(DivideBy10(n));
        private static long SquareLastDigit(long n) => Square(LastDigit(n));
        private static long Square(long n) => n * n;
        private static long LastDigit(long n) => n % 10;
        private static long DivideBy10(long n) => n / 10;
        private static bool IsEqualToZero(long n) => n == 0;
        private static long Add2(long n) => n + 2;
        private static long Inc(long n) => n + 1;
        private static long Dec(long n) => n - 1;
        private static long Identity(long n) => n;
        private static long One(long n) => 1;


    }
}
