using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {

        public BlackCoffee()
        {
        }

        public BlackCoffee(int discount)
        :base (discount)
        {
        
        }
        public override string Strength()
        {
            return "Strong";
        }

        public override string ToString()
        {
            return $"Black Coffee";
        }
       
    }
}
