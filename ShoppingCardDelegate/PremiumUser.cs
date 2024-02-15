using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCardDelegate
{
    public class PremiumUser : IUser
    {
        public string FullName { get; set; }
        public ShoppingCard Card { get; set; }

        /// <summary>
        /// Foydalanuvchi uchun chegirma narxini olish
        /// </summary>
        /// <param name="totalPrice"></param>
        /// <returns></returns>
         public decimal GetPriceDiscountForUser(decimal totalPrice)
        {
            return totalPrice * (1 - 0.30M);
        }
    }
}
