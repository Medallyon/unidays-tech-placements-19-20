// This is a sample class that is used to represent
// a real-life representation of an Item

namespace UNiDAYS_Challenge
{
    class D : Item
    {
        protected static double defaultPrice = 7;

        public D()
        {
            this.Price = D.defaultPrice;
        }

        public D(double price) : base(price)
        {
            this.Price = price;
        }
    }
}
