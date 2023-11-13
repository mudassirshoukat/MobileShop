
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models.response
{
    public class OrderResponseModel
    {
        public int OrderID { get; set; }
		public int UserID { get; set; }
		public string BuyerName { get; set; }
		public DateTime OrderDate { get; set; }
		
		public string ShippingAddress { get; set; }
		public double TotalAmount { get; set; }
		public List<String> ProductName { get; set ; }=new List<string>();

		public string Status { get; set; }
    }
}
