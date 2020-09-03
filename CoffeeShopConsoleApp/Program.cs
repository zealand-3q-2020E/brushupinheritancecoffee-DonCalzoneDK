using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffee in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(1),
                new Latte(1),
                new BlackCoffee(4)

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the Price of the {coffee.ToString()} is : {coffee.Price()} \nYou have saved: {coffee.Discount()} dkk\n");
            }


        }
    }
}
