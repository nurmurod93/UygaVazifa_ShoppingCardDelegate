namespace ShoppingCardDelegate
{
    public class ShoppingCard
    {
        public List<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// chegirma narxini olish
        /// </summary>
        /// <param name="totalPrice"></param>
        /// <returns></returns>

        public delegate decimal GetDiscountPrince(decimal totalPrice);

        /// <summary>
        /// oxirgi chegirmani olish
        /// </summary>
        /// <param name="finalPrice">oxirgi chegirma narxi</param>
        /// <param name="calculateTotalPrice">jami narxini xisoblash</param>
        /// <param name="printDiscountAmount">chegirma miqdorini chiqarish</param>
        /// <returns></returns>

        public decimal GetFinalPrice(
            GetDiscountPrince finalPrice,
            Func<List<Product>, decimal> calculateTotalPrice,
            Action<decimal, decimal> printDiscountAmount
            )
        {
            decimal total = calculateTotalPrice(Products);
            decimal FinalPrice = finalPrice(total);
            printDiscountAmount(total, FinalPrice);

            return FinalPrice;
        }
    }
}