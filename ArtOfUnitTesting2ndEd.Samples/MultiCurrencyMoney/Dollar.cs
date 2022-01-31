using System;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        private int v;

        public Dollar(int v)
        {
            this.v = v;
        }

        public double amount { get; set; }

        public void Times(int v)
        {
            throw new NotImplementedException();
        }
    }
}