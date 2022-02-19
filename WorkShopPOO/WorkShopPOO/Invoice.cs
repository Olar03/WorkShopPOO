using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopPOO
{
    public class Invoice : IPay
    {
        ICollection<Product> _Products;


//        public void string AddProduct()
//        {
//            _Products = new List<Product> ();

//        }

        
//        public decimal GetValueToPay()
//        {
//            return _Products.Count;
//        }

//        public override string ToString()
//        {
//            return $"RECEIPT\n___________________________________" +
//                   $"\n\t{_Products}" +
//                   $"\n\t\t\t========================" +
//                   $"\n\tTOTAL:\t {$"{GetValueToPay()}",15}";
//        }
//    }
//}
