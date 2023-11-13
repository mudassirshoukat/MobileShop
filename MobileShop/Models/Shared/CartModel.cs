using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class CartModel

    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public SqlParameter[] toParams()
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@CartID", this.CartID);
            prm[1] = new SqlParameter("@UserID", this.UserID);
            prm[2] = new SqlParameter("@ProductID", this.ProductID);
            prm[3] = new SqlParameter("@Quantity", this.Quantity);
            return prm;
        }
    }
}
