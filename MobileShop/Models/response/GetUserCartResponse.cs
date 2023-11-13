using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models.response
{
    public class GetUserCartResponse
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int Quantity { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set; }
        
    }
}
