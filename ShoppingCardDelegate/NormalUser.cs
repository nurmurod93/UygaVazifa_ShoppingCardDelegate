using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCardDelegate
{
    public class NormalUser : IUser
    {
        public string FullName { get; set; }
        public ShoppingCard Card { get; set; }

        public decimal GetPriceDiscountForUser(decimal totalPrice)
        {
            if(Card.Products.Count > 5)
            {
                return totalPrice * (1 - 0.30M);
            }
            else 
            {
                return totalPrice;
            }
        }
    }
}
