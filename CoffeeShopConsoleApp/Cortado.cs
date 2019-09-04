using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, Milk
    {
        public Cortado(int Discount) : base(Discount)
        {
            discount = Discount;
        }

        public override int price()
        {
            return 25 - discount;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }
    }
}
