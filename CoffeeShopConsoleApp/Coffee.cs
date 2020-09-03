using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffee orders
    /// </summary>
    public abstract class Coffee
    {

        /// <summary>
        /// returns the Price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int Price()
        {
            return 20 - Discount();
        }

        protected int _discount { get; private set; }

        public Coffee() : this(0)
        {

        }

        public Coffee(int discount)
        {
            if (discount > 5)
                throw new ArgumentException("not a valid discount amount");
            else
            {
                this._discount = discount;
            }
        }

        public int Discount()
        {
            return _discount;
        }

        public abstract string Strength();


        public override string ToString()
        {
            return $"{Price()} + {Discount()}";
        }
        

        
    }
    
}
