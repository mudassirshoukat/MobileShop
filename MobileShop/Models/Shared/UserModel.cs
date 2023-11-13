using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
	public class UserModel
	{
	 [Key]
		public int UserID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string ShippingAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string UserCnic { get; set; }

		public SqlParameter[] toPerams()
        {
            SqlParameter[] prm = new SqlParameter[7];
			prm[0] = new SqlParameter("@UserID", this.UserID);
			prm[1] = new SqlParameter("@Username", this.Username);
			prm[2] = new SqlParameter("@Password", this.Password);
			prm[3] = new SqlParameter("@ShippingAddress", this.ShippingAddress);
			prm[4] = new SqlParameter("@PhoneNumber", this.PhoneNumber);
			prm[5] = new SqlParameter("@UserCnic", this.UserCnic);
			prm[6] = new SqlParameter("@Email", this.Email);
			return prm;
        }

		

	
	}
}


