using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
	public class AdminModel
	{

		public int AdminID { get; set; }
		public string AdminName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string BusinessAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string AdminCNIC { get; set; }

		public SqlParameter[] toPerams()
		{
			SqlParameter[] prm = new SqlParameter[7];
			prm[0] = new SqlParameter("@AdminID", this.AdminID);
			prm[1] = new SqlParameter("@AdminName", this.AdminName);
			prm[2] = new SqlParameter("@Password", this.Password);
			prm[3] = new SqlParameter("@BusinessAddress", this.BusinessAddress);
			prm[4] = new SqlParameter("@PhoneNumber", this.PhoneNumber);
			prm[5] = new SqlParameter("@AdminCNIC", this.AdminCNIC);
			prm[6] = new SqlParameter("@Email", this.Email);
			return prm;
		}


	}
}
