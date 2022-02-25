namespace WorkShopPOO

{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal GetValueToPay()
        {
            decimal Value = 0;
            foreach (Product product in Products)
            {
                Value += product.GetValueToPay();

            }
            return Value - (Value * (decimal)Discount);
        }

        public override string ToString()
        {

            string NameProduct = "";
            foreach (Product Product in Products)
            {
                NameProduct += Product.Description + ", ";

            }

            return $"{Id}\t{Description}" +
                   $"\n\tProducts.......:{NameProduct}" +
                   $"\n\tDiscount.......:{$"{Discount:P2}",15}" +
                   $"\n\tValue..........:{$"{GetValueToPay():C2}",15}";
        }


    }
}
