using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffe : Coffee
    {
        public BlackCoffe(int Discount) : base(Discount)
        {
            discount = Discount;
        }

        public override string Strength()
        {
            return "Strong";
        }

        public override int price()
        {
            return base.price() - discount;
        }
    }
}
