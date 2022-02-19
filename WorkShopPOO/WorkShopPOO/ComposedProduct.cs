namespace WorkShopPOO
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }

        public string Products { get; set; }

        public override decimal GetValueToPay()
        {
            return Price * (decimal)Discount;
        }

        public override string ToString()
        {
            return $"{Id}\t{Description}" +
                   $"\n\tProducts..........:{Products}" +
                   $"\n\tDiscount..........:{$"{Discount:P2}",15}" +
                   $"\n\tValue.............:{$"{GetValueToPay:C2}",15}";
        }


    }
}
