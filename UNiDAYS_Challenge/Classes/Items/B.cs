// This is a sample class that is used to represent
// a real-life representation of an Item

namespace UNiDAYS_Challenge
{
    class B : Item
    {
        protected static double defaultPrice = 12;

        public B()
        {
            this.Price = B.defaultPrice;
        }

        public B(double price) : base(price)
        {
            this.Price = price;
        }
    }
}
