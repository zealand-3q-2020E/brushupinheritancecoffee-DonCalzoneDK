using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado()
        {
        }

        public Cortado(int discount)
        : base (discount)
        {
            
        }
        public override int Price()
        {
            return 25 - Discount();
        }
        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }

        public override string ToString()
        {
            return $"Cortado";
        }

        
    }
}
