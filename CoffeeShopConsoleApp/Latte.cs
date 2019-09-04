using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, Milk
    {
        public Latte(int Discount) : base(Discount)
        {
            discount = Discount;
        }

    public override int price()
        {
            return 40 - discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }
}
