namespace WorkShopPOO
{
    public class VariablePriceProduct : Product
    {

        public string Measurement { get; set; }
        public float Quantity { get; set; }


        public override decimal GetValueToPay()
        {
            Price = Price * (Decimal)Quantity;
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{Id}\t{Description}" +
                   $"\n\tMeasurement....:\t{Measurement:N2}" +
                   $"\n\tQuantity.......:{$"{Quantity:N2}",15}" +
                   $"\n\tPrice..........:{$"{Price:C2}",15}" +
                   $"\n\tTax............:{$"{Tax:P2}",15}" +
                   $"\n\tValue..........:{$"{GetValueToPay():C2}",15}";

        }
    }
}
