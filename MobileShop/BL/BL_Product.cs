using MobileShop.Models;
using MobileShop.Models.Request;
using MobileShop.Models.Response;
using mymyapp.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.BL
{
    public class BL_Product
    {
     

        public static void SaveProduct(ProductRequestModel model)
        {

            DataLayer.ExecuteQuery("SaveProduct",model.ToParams());

        }
    


        public static List<ProductModel> GetProducts()
        {

            DataTable data = DataLayer.ExecuteTable("GetAllProducts");
            List<ProductModel> list = new List<ProductModel>();


            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {
                    ProductModel model = new ProductModel();
                    model.ProductID = Convert.ToInt16(rows["ProductID"]);
                    model.ProductName = rows["ProductName"].ToString() ?? "";
                    model.BrandID = Convert.ToInt16(rows["BrandID"]);
                    model.Description = rows["Description"].ToString() ?? "";
                    model.ImageURL = rows["ImageURL"].ToString() ?? "";
                    model.IMEI1 = rows["IMEI1"].ToString() ?? "";
                    model.IMEI2 = rows["IMEI2"].ToString() ?? "";
                    model.SpecificationID= Convert.ToInt16( rows["SpecificationID"]);
                    model.Price =Convert.ToDecimal( rows["Price"]);
                    list.Add(model);
                }
            }
            return list;
        }

        public static ProductDetailResponseModel GetSingleProduct(int id)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ProductID", id);
            DataTable data = DataLayer.ExecuteTable("GetProductDetails", prm);
            ProductDetailResponseModel model = new ProductDetailResponseModel();


            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {
                  
                    model.ProductID = Convert.ToInt16(rows["ProductID"]);
                    model.ProductName = rows["ProductName"].ToString() ?? "";
                    model.Description = rows["Description"].ToString() ?? "";
                    model.ImageURL = rows["ImageURL"].ToString() ?? "";
                 
                    model.Price = Convert.ToDecimal(rows["Price"]);
                    model.DisplaySize = rows["DisplaySize"].ToString() ?? "";
                    model.RAM = rows["RAM"].ToString() ?? "";
                    model.Processor = rows["Processor"].ToString() ?? "";
                    model.StorageCapacity = rows["StorageCapacity"].ToString() ?? "";
                    model.OperatingSystem = rows["OperatingSystem"].ToString() ?? "";
                    model.BrandName = rows["BrandName"].ToString() ?? "";
                    model.Connectivity = rows["Connectivity"].ToString() ?? "";
                    model.CameraQuality = rows["CameraQuality"].ToString() ?? "";
                    model.BatteryCapacity = rows["BatteryCapacity"].ToString() ?? "";
                    model.AdditionalFeatures = rows["AdditionalFeatures"].ToString() ?? "";

                }
            }
            return model;
        }





        public static ProductRequestModel GetSingleProductdetail(int id)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ProductID", id);
            DataTable data = DataLayer.ExecuteTable("GetSingleProductFullDetail", prm);
            ProductRequestModel model = new ProductRequestModel();


            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {

                    model.ProductID = Convert.ToInt16(rows["ProductID"]);
                    model.ProductName = rows["ProductName"].ToString() ?? "";
                    model.Description = rows["Description"].ToString() ?? "";
                    model.ImageURL = rows["ImageURL"].ToString() ?? "";
                    model.IMEI1 = rows["IMEI1"].ToString() ?? "";
                    model.IMEI2 = rows["IMEI2"].ToString() ?? "";
                    model.BrandID = Convert.ToInt16(rows["BrandID"]);
                    model.SpecificationID = Convert.ToInt16(rows["SpecificationID"]);
                    model.Price = Convert.ToDecimal(rows["Price"]);
                    model.DisplaySize = rows["DisplaySize"].ToString() ?? "";
                    model.RAM = rows["RAM"].ToString() ?? "";
                    model.Processor = rows["Processor"].ToString() ?? "";
                    model.StorageCapacity = rows["StorageCapacity"].ToString() ?? "";
                    model.OperatingSystem = rows["OperatingSystem"].ToString() ?? "";
                   
                    model.Connectivity = rows["Connectivity"].ToString() ?? "";
                    model.CameraQuality = rows["CameraQuality"].ToString() ?? "";
                    model.BatteryCapacity = rows["BatteryCapacity"].ToString() ?? "";
                    model.AdditionalFeatures = rows["AdditionalFeatures"].ToString() ?? "";

                }
            }
            return model;
        }

    public static void DeleteProduct(int id)
        {
            SqlParameter[] prm = new SqlParameter[1] { new SqlParameter("ProductID", id) };
            DataLayer.ExecuteQuery("DeleteProduct", prm);
        }
    }
}
