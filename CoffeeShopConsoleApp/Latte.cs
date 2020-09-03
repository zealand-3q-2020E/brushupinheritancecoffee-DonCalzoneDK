using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte : Coffee, IMilk
    {

        public Latte()
        {
        }

        public Latte(int discount)
        :base(discount)
        {

        }
        public int mlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            return 40 - Discount();
        }
        public override string Strength()
        {
            return "Weak";
        }
        public override string ToString()
        {
            return $"Latte";
        }
    }
}
