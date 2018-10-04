// This is a sample class that is used to represent
// a real-life representation of an Item

namespace UNiDAYS_Challenge
{
    class A : Item
    {
        protected static double defaultPrice = 8;

        public A()
        {
            this.Price = A.defaultPrice;
        }

        public A(double price) : base(price)
        {
            this.Price = price;
        }
    }
}
