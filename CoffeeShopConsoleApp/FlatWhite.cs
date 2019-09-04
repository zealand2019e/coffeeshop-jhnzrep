using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, Milk
    {
        public FlatWhite(int Discount) : base(Discount)
        {
            discount = Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public override int price()
        {
            return 60 - discount;
        }

        public int mlMilk()
        { return 350; }
    }
}
