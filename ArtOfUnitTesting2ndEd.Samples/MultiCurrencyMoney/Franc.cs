using System;

namespace MultiCurrencyMoney
{
    public class Franc
    {
        private int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount *= multiplier);
        }

        public override bool Equals(Object obj)
        {

            Franc franc = (Franc)obj;
            return _amount == franc._amount;
        }
    }
}