namespace WorkShopPOO
{
    public class Invoice : IPay
    {

        List<Product> _Products = new List<Product>();

        public Invoice()
        {
            
        }

       public void AddProduct (Product product)
        {
            _Products.Add(product);
           
        }


        public decimal GetValueToPay()
        {
            decimal Value = 0;

            foreach (Product product in _Products)
            {
                Value += product.GetValueToPay();
            }

            return Value;
        }

        public override string ToString()
        {
            string details = " ";
            foreach (Product product in _Products)
            {
                details += product.ToString() + "\n";
            }

            return $"RECEIPT\n" +
                    $"----------------------------------------------------------------" +
                    $"\n{details}" +
                    $"\n\t                ===============" +
                    $"\n\tTOTAL..........:{$"{GetValueToPay():C2}",15}";


        }
    }
}
