using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
	public class BrandModel
	{
		public int BrandID { get; set; }
		public string BrandName { get; set; }
	
    public SqlParameter[] toParams()
    {
        SqlParameter[] prm = new SqlParameter[2];
        prm[0] = new SqlParameter("@BrandID", this.BrandID);
        prm[1] = new SqlParameter("@BrandName", this.BrandName);
        return prm;
    }
}}
