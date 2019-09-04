using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(5),
                new Cortado(3),
                new Latte(0),
                new BlackCoffe(9),
                new Latte(10),
                new FlatWhite(6)
            };

            List<Coffee> milkList = new List<Coffee>();
            {
                foreach(Coffee cof in orderList)
                {
                    if (cof is Milk) milkList.Add(cof);
                }
            }


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price() + " strength of the coffee is:" + coffee.Strength());
            }

            foreach(var coffee in milkList)
            {
                Console.WriteLine("Milk List item:" + "the Price of the coffee is : " + coffee.price() + " strength of the coffee is:" + coffee.Strength());
            }

        }
    }
}
