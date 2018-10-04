// This is the class that represents the
// result of a calculation

namespace UNiDAYS_Challenge
{
    class PriceResult
    {
        public double Total { get; set; } = 0;
        // The delivery charge is automatically calculated
        // based on the Total
        public double DeliveryCharge
        {
            get
            {
                if (this.Total > 0 && this.Total < 50)
                    return 7;
                else
                    return 0;
            }
        }

        public PriceResult() { }
        public PriceResult(double total)
        {
            this.Total = total;
        }
    }
}
