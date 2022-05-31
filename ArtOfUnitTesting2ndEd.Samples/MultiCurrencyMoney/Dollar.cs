﻿using System;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        private int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public int Amount 
        { get => _amount;
          set => _amount = value; 
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount *= multiplier);
        }

        public override bool Equals(Object obj) 
        {

            Dollar dollar = (Dollar) obj;
            return _amount == dollar._amount;
        }


    }
}