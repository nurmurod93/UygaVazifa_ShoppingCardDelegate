using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCardDelegate
{
    public interface IUser
    {
        string FullName { get; set; }
        ShoppingCard Card { get; set; }

        /// <summary>
        /// Foydalanuvchi uchun chegirma narxini olish
        /// </summary>
        /// <param name="totalPrice"></param>
        /// <returns></returns>

        decimal GetPriceDiscountForUser(decimal totalPrice);
    }
}
