using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCard
{
    internal class PaymentCard
    {
        private double _balance;
        private double _amount;

        public PaymentCard(double balance)
        {
            _balance = balance;
        }

        public override string ToString()
        {
            var number = 5;
            number.ToString();

            return $"The card has balance of {_balance} Euros.";

        }

        public void EatLunch()
        {

            if (_balance > 10)
            {
                _balance -= 10.60;

            }
            else
            {
                _balance = 10;

            }
        }
        public void DrinkCoffee()
        {
            _balance -= 2.0;
        }

        public void AddMoney(double amount)
        {
            _amount = amount;

            if (_balance < 150)
            {
                if (_amount > 150)
                {
                    _balance = 150;
                }
                else
                {
                    _balance += amount;
                }

            }
        }
    }
}
