using System;

namespace LogAn_copy
{
    public class MemCalculator
    {
        private int sum = 0;

        public int Sum()
        {
            int temp = sum;
            sum = 0;
            return temp;
        }

        public void Add(int number)
        {
            sum += number;
        }
    }
}