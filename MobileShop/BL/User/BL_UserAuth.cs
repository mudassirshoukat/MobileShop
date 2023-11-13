using MobileShop.Models;
using mymyapp.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MobileShop.BL
{
    public class BL_UserAuth
    {
        public void SignUp(UserModel model)

        {

              DataLayer.ExecuteQuery("SaveUser", model.toPerams());



        }


        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserID", id);
           
            DataLayer.ExecuteQuery("DeleteUser", prm);
        }


        public static List<UserModel> GetUsers()
        {
           
            DataTable data = DataLayer.ExecuteTable("GetUsers");
            List<UserModel> list = new List<UserModel>();
            
            
            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {
                    UserModel model = new UserModel();
                    model.UserID= Convert.ToInt16(rows["UserID"]);
                    model.Username = rows["Username"].ToString() ?? "";
                    model.Email = rows["Email"].ToString() ?? "";
                    model.Password = rows["Password"].ToString() ?? "";
                    model.ShippingAddress = rows["ShippingAddress"].ToString() ?? "";
                    model.PhoneNumber = rows["PhoneNumber"].ToString() ?? "";
                    model.UserCnic = rows["UserCnic"].ToString() ?? "";
                    list.Add(model);
                }
            }
            return list;
        }

        public static UserModel GetSingleUser(int id)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserID", id);
            DataTable data = DataLayer.ExecuteTable("GetSingleUser", prm);
            UserModel model = new UserModel();
            

            model.UserID = Convert.ToInt16(data.Rows[0]["UserID"]);
            model.Username = data.Rows[0]["Username"].ToString() ?? "";
            model.Email = data.Rows[0]["Email"].ToString() ?? "";
            model.Password = data.Rows[0]["Password"].ToString() ?? "";
            model.ShippingAddress = data.Rows[0]["ShippingAddress"].ToString() ?? "";
            model.PhoneNumber = data.Rows[0]["PhoneNumber"].ToString() ?? "";
            model.UserCnic = data.Rows[0]["UserCnic"].ToString() ?? "";
            return model;
        }
    
    }
}
