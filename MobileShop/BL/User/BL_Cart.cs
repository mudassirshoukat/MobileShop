using MobileShop.Models.response;
using MobileShop.Models.Response;
using mymyapp.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.BL.User
{
    public class BL_Cart
    {
        public static void ClearCart()
        {
            int userid = 1;
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserID", userid);
            DataLayer.ExecuteQuery("DeleteUserCart", prm);


        }
        public static void AddCartItem(int productid)
        {
            int userid = 1;
            SqlParameter[] prm = new SqlParameter[2] ;
                          prm[0] = new SqlParameter("@UserID", userid);
                prm[1] = new SqlParameter("@ProductID", productid);
            
            DataTable data = DataLayer.ExecuteTable("GetSingleCartItem", prm);
            if (data.Rows.Count!=0) {
                int cartid = Convert.ToInt16(data.Rows[0]["CartID"]);
                int quantity = Convert.ToInt16(data.Rows[0]["Quantity"])+1;
                //SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@CartID", cartid);
                prm[1] = new SqlParameter("@Quantity", quantity);
                DataLayer.ExecuteQuery("UpdateCartItem", prm);

            }
            else{
                
                prm[0] = new SqlParameter("@UserID", userid);
                prm[1] = new SqlParameter("@ProductID", productid);
                DataLayer.ExecuteQuery("AddToCart", prm);

              

            }


        }
        public static void RemoveItem(int cartid=1)
        {
            GetUserCartResponse item = new GetUserCartResponse();
          
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@CartID", cartid);
            DataLayer.ExecuteQuery("DeleteCartItem",prm);
            
           
        }
        public static void  ItemIncrement(int cartid,int quantity)
        {
           
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@CartID", cartid);
            prm[1] = new SqlParameter("@Quantity", quantity+1);
            DataLayer.ExecuteQuery("UpdateCartItem",prm);

           
        }

        public static void  ItemDecreament( int cartid,int quantity)
        {
           
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@CartID", cartid);
            prm[1] = new SqlParameter("@Quantity", quantity-1);
            DataLayer.ExecuteQuery("UpdateCartItem", prm);

          
        }
     

        public static List<GetUserCartResponse> GetUserCart()
        { int userid = 1;
            SqlParameter[] prm =new SqlParameter[1];
            prm[0] =new SqlParameter("@UserID", userid);
            DataTable data = DataLayer.ExecuteTable("GetUserCart",prm);
            List<GetUserCartResponse> list = new List<GetUserCartResponse>();


            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {
                    GetUserCartResponse model = new GetUserCartResponse();
                    model.CartID = Convert.ToInt16(rows["CartID"]);
                    model.ProductName = rows["ProductName"].ToString() ?? "";
                   
                    model.ImageURL = rows["ImageURL"].ToString() ?? "";
                   
                    model.Quantity = Convert.ToInt16(rows["Quantity"]);
                    model.ProductID= Convert.ToInt16(rows["ProductID"]);
                    model.Price = Convert.ToDecimal(rows["Price"]);
                    list.Add(model);
                }
            }
            return list;
        }

       
    }
}

