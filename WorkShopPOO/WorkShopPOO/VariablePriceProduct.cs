namespace WorkShopPOO
{
    public class VariablePriceProduct : Product
    {

        public string Measurement { get; set; }
        public float Quantity { get; set; }


        public override decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id}\t{Description}" +
                   $"\n\tMeasurement....:{Measurement:N2}" +
                   $"\n\tQuantity.......:{$"{Price:C2}",15}" +
                   $"\n\tPrice..........:{$"{Price:C2}",15}" +
                   $"\n\tTax............:{$"{Tax:P2}",15}" +
                   $"\n\tValue..........:{$"{GetValueToPay():C2}",15}";

        }
    }
}
