namespace ShoppingCardDelegate
{
    public class Program
    {
        private static ShoppingCard FillingCard()
        {
            ShoppingCard card = new ShoppingCard();

            card.Products.Add(new Product() { Name = "Krosovka", Price = 10.3M});
            card.Products.Add(new Product() { Name = "Fudbolka", Price = 8.5M});
            card.Products.Add(new Product() { Name = "Shortik", Price = 12.0M});
            card.Products.Add(new Product() { Name = "Kepka", Price = 5.8M});
            card.Products.Add(new Product() { Name = "Paypoq", Price = 2.3M});
            card.Products.Add(new Product() { Name = "Smartwatch", Price = 23.0M});

            return card;
        }

        private static decimal CalculateTotalProductPrice(List<Product> products)
        {
            var totalPrice = 0.0M;
            foreach (var product in products) 
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        private static void PrintTotalDiscountAmount(decimal totalPrice, decimal discountPrice)
        {
            Console.WriteLine($"% amount is: {totalPrice - discountPrice} OFF!");
        }
        public static void Main(string[] args)
        {
            IUser normalUser = new NormalUser() { FullName = "Botirov Sayfiddin"};
            IUser premiumUser = new PremiumUser() { FullName = "Elon Musk" };

            normalUser.Card = FillingCard();
            premiumUser.Card = FillingCard();

            decimal normalUserFinalPrince = normalUser.Card.GetFinalPrice(normalUser.GetPriceDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            Console.WriteLine($"> {normalUser.FullName} payment: ${normalUserFinalPrince}\n");

            decimal premiumUserFinalPrice = premiumUser.Card.GetFinalPrice(premiumUser.GetPriceDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            Console.WriteLine($"> {premiumUser.FullName} payment: ${premiumUserFinalPrice}\n");
        }
    }
}