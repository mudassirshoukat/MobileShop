using Microsoft.AspNetCore.Mvc.Rendering;
using MobileShop.BL.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models.Request
{
    public class ProductRequestModel
    {
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int BrandID { get; set; }
		public int SpecificationID { get; set; }
        public IEnumerable<SelectListItem> BrandList { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageURL { get; set; }
		public string IMEI1 { get; set; }
		public string IMEI2 { get; set; }
		
		public string DisplaySize { get; set; }
		public string RAM { get; set; }
		public string StorageCapacity { get; set; }
		public string CameraQuality { get; set; }
		public string BatteryCapacity { get; set; }
		public string Processor { get; set; }
		public string OperatingSystem { get; set; }
		public string Connectivity { get; set; }
		public string AdditionalFeatures { get; set; }


        public SqlParameter[] ToParams()
        {
            List<SqlParameter> prm = new List<SqlParameter>
        {
            new SqlParameter("@ProductID", this.ProductID),
            new SqlParameter("@ProductName", this.ProductName),
            new SqlParameter("@BrandID", this.BrandID),
            new SqlParameter("@Description", this.Description),
            new SqlParameter("@Price", this.Price),
            new SqlParameter("@ImageURL", this.ImageURL),
            new SqlParameter("@IMEI1", this.IMEI1),
            new SqlParameter("@IMEI2", this.IMEI2),
           new SqlParameter("@SpecificationID", this.SpecificationID),
            new SqlParameter("@DisplaySize", this.DisplaySize),
            new SqlParameter("@RAM", this.RAM),
            new SqlParameter("@StorageCapacity", this.StorageCapacity),
            new SqlParameter("@CameraQuality", this.CameraQuality),
            new SqlParameter("@BatteryCapacity", this.BatteryCapacity),
            new SqlParameter("@Processor", this.Processor),
            new SqlParameter("@OperatingSystem", this.OperatingSystem),
            new SqlParameter("@Connectivity", this.Connectivity),
            new SqlParameter("@AdditionalFeatures", this.AdditionalFeatures)
        };

            return prm.ToArray();
        }

    }

}
