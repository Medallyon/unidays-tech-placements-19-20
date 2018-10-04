using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNiDAYS_Challenge
{
    class UnidaysDiscountChallenge
    {
        private Basket basket;
        internal PricingRules rules { get; set; }

        public UnidaysDiscountChallenge(PricingRules rules)
        {
            this.basket = new Basket();
            this.rules = rules;
        }

        // Create an overload that also accepts a custom basket
        public UnidaysDiscountChallenge(PricingRules rules, Basket basket)
        {
            this.basket = basket;
            this.rules = rules;
        }

        public Basket AddToBasket(Item item)
        {
            this.basket.Add(item);
            return this.basket;
        }

        public PriceResult CalculateTotalPrice()
        {
            // Calculates the number of unique items
            List<Type> differentTypes = this.basket.Select(x => x.GetType()).Distinct().ToList();
            // Creates a new `PriceResult` instance to collect the total
            PriceResult result = new PriceResult();
            
            foreach (Type type in differentTypes)
            {
                // Get the number of items of the current Type
                List<Item> items = this.basket.FindAll((x) => type == x.GetType());

                // This exists in case an item doesn't match any rules
                bool added = false;

                foreach (PricingRule rule in this.rules)
                {
                    // Skip this rule if the type of the item doesn't match the rule
                    // or if the item has no discounts associated with it
                    if (!(rule.AssociatedClassType == items[0].GetType() && rule.ItemsRequired != -1))
                        continue;

                    double numberOfDiscounts = Math.Floor((double)(items.Count / rule.ItemsRequired));
                    double numberOfRemainingItems = Math.Floor(items.Count - (numberOfDiscounts * rule.ItemsRequired));

                    // Add all discounted prices to total
                    for (int i = 0; i < numberOfDiscounts; i++)
                        result.Total += items[0].Price * rule.PriceModifier;

                    // Add all remaining items that don't apply for a discount
                    for (int i = 0; i < numberOfRemainingItems; i++)
                        result.Total += items[0].Price;

                    added = true;
                }

                if (!added)
                    result.Total += items[0].Price * items.Count;
            }
            
            return result;
        }
    }
}
