using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
	public class OrderModel
	{
		public int OrderID { get; set; }
		public int UserID { get; set; }
		public DateTime OrderDate { get; set; }
		public string ShippingAddress { get; set; }
		public decimal TotalAmount { get; set; }
		public int ProductID { get; set; }
		public string Status { get; set; }


        public SqlParameter[] toParams()
        {
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@OrderID", this.OrderID);
            prm[1] = new SqlParameter("@UserID", this.UserID);
            prm[2] = new SqlParameter("@OrderDate", this.OrderDate);
            prm[3] = new SqlParameter("@ShippingAddress", this.ShippingAddress);
            prm[4] = new SqlParameter("@TotalAmount", this.TotalAmount);
            prm[5] = new SqlParameter("@ProductID", this.ProductID);
            prm[6] = new SqlParameter("@Status", this.Status);
            return prm;
        }
    }

}
