using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class MobileSpecificationModel

	{
		public int SpecificationID { get; set; }
		public string DisplaySize { get; set; }
		public string RAM { get; set; }
		public string StorageCapacity { get; set; }
		public string CameraQuality { get; set; }
		public string BatteryCapacity { get; set; }
		public string Processor { get; set; }
		public string OperatingSystem { get; set; }
		public string Connectivity { get; set; }
		public string AdditionalFeatures { get; set; }


        public SqlParameter[] toParams()
        {
            SqlParameter[] prm = new SqlParameter[10];
            prm[0] = new SqlParameter("@SpecificationID", this.SpecificationID);
            prm[1] = new SqlParameter("@DisplaySize", this.DisplaySize);
            prm[2] = new SqlParameter("@RAM", this.RAM);
            prm[3] = new SqlParameter("@StorageCapacity", this.StorageCapacity);
            prm[4] = new SqlParameter("@CameraQuality", this.CameraQuality);
            prm[5] = new SqlParameter("@BatteryCapacity", this.BatteryCapacity);
            prm[6] = new SqlParameter("@Processor", this.Processor);
            prm[7] = new SqlParameter("@OperatingSystem", this.OperatingSystem);
            prm[8] = new SqlParameter("@Connectivity", this.Connectivity);
            prm[9] = new SqlParameter("@AdditionalFeatures", this.AdditionalFeatures);
            return prm;
        }
    }
}
