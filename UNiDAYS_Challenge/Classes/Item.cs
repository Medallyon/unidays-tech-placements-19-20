// This is a base `Item` class used to represent
// real-life items in a virtual shopping basket

namespace UNiDAYS_Challenge
{
    class Item
    {
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public double Price { get; set; }

        public Item() { }

        public Item(double price)
        {
            this.Price = price;
        }
    }
}
