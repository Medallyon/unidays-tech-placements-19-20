// This is a sample class that is used to represent
// a real-life representation of an Item

namespace UNiDAYS_Challenge
{
    class E : Item
    {
        protected static double defaultPrice = 5;

        public E()
        {
            this.Price = E.defaultPrice;
        }

        public E(double price) : base(price)
        {
            this.Price = price;
        }
    }
}
