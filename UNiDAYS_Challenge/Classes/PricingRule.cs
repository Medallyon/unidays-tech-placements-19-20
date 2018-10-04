// A simple class that defines rules to determine
// if a discount can be applied to a basket

using System;

namespace UNiDAYS_Challenge
{
    class PricingRule
    {
        // The class `Type` this rule applies to
        internal Type AssociatedClassType { get; set; }
        // The amount of `Item`s that have to be in a
        // basket in order for the discount to be eligible
        internal int ItemModifier { get; set; } = -1;
        // The price modifier that is eventually applied on a discount
        internal double PriceModifier { get; set; }

        public PricingRule(Type classType)
        {
            this.AssociatedClassType = classType;
        }

        public PricingRule(Type classType, int itemModifier, double priceModifier)
        {
            this.AssociatedClassType = classType;
            this.ItemModifier = itemModifier;
            this.PriceModifier = priceModifier;
        }
    }
}
