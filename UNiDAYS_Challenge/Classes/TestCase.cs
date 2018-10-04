// A class specifically designed to be a test case.
// Simply instantiate it with a custom basket and `Run()` it

using System;

namespace UNiDAYS_Challenge
{
    class TestCase
    {
        private UnidaysDiscountChallenge challenge { get; set; }
        private Basket basket { get; set; }

        public TestCase(Basket basket)
        {
            this.challenge = new UnidaysDiscountChallenge(Program.DefaultRules, basket);
            this.basket = basket;
        }

        public void Run()
        {
            PriceResult result = this.challenge.CalculateTotalPrice();
            string[] items = new string[this.basket.Count];
            for (int i = 0; i < items.Length; i++)
                items[i] = this.basket[i].Name;

            Console.Write("\n\n================= [ BASKET ] ==================");

            Console.Write($"\nThis basket contains {this.basket.Count} items:");
            Console.Write($"\n{String.Join(", ", items)}");
            Console.Write($"\n\nThe total for this basket comes to £{Math.Round(result.Total, 2)}.");
            Console.Write($"\n{((result.DeliveryCharge > 0) ? $"There will be a delivery charge of £{Math.Round(result.DeliveryCharge, 2)}." : "There will be NO delivery charge for this order.")}");
        }
    }
}
