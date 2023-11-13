using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
	public class ProductModel
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int BrandID { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageURL { get; set; }
		public string IMEI1 { get; set; }
		public string IMEI2 { get; set; }
		public int SpecificationID { get; set; }

        public SqlParameter[] toParams()
        {
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter("@ProductID", this.ProductID);
            prm[1] = new SqlParameter("@ProductName", this.ProductName);
            prm[2] = new SqlParameter("@BrandID", this.BrandID);
            prm[3] = new SqlParameter("@Description", this.Description);
            prm[4] = new SqlParameter("@Price", this.Price);
            prm[5] = new SqlParameter("@ImageURL", this.ImageURL);
            prm[6] = new SqlParameter("@IMEI1", this.IMEI1);
            prm[7] = new SqlParameter("@IMEI2", this.IMEI2);
            prm[8] = new SqlParameter("@SpecificationID", this.SpecificationID);
            return prm;
        }
    }
}
