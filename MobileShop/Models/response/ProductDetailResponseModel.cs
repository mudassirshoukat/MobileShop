using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models.Response
{
    public class ProductDetailResponseModel
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
        
        public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageURL { get; set; }
		public string DisplaySize { get; set; }
		public string RAM { get; set; }
		public string StorageCapacity { get; set; }
		public string CameraQuality { get; set; }
		public string BatteryCapacity { get; set; }
		public string Processor { get; set; }
		public string OperatingSystem { get; set; }
		public string Connectivity { get; set; }
		public string AdditionalFeatures { get; set; }
		
		public string BrandName { get; set; }
		
		public SqlParameter[] toParams()
		{
			SqlParameter[] prm = new SqlParameter[15];
			prm[0] = new SqlParameter("@ProductID", this.ProductID);
			prm[1] = new SqlParameter("@ProductName", this.ProductName);
			
			prm[2] = new SqlParameter("@Description", this.Description);
			prm[3] = new SqlParameter("@Price", this.Price);
			prm[4] = new SqlParameter("@ImageURL", this.ImageURL);
			
			
			prm[5] = new SqlParameter("@BrandName", this.BrandName);
			prm[6] = new SqlParameter("@DisplaySize", this.DisplaySize);
			prm[7] = new SqlParameter("@RAM", this.RAM);
			prm[8] = new SqlParameter("@StorageCapacity", this.StorageCapacity);
			prm[9] = new SqlParameter("@CameraQuality", this.CameraQuality);
			prm[10] = new SqlParameter("@BatteryCapacity", this.BatteryCapacity);
			prm[11] = new SqlParameter("@Processor", this.Processor);
			prm[12] = new SqlParameter("@OperatingSystem", this.OperatingSystem);
			prm[13] = new SqlParameter("@Connectivity", this.Connectivity);
			prm[14] = new SqlParameter("@AdditionalFeatures", this.AdditionalFeatures);
			
			
			
			return prm;
		}

	}
}
