// This is a sample class that is used to represent
// a real-life representation of an Item

namespace UNiDAYS_Challenge
{
    class C : Item
    {
        protected static double defaultPrice = 4;

        public C()
        {
            this.Price = C.defaultPrice;
        }

        public C(double price) : base(price)
        {
            this.Price = price;
        }
    }
}
