using MobileShop.Models;
using mymyapp.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.BL
{
    public class BL_AdminAuth
    {
        public static void save(AdminModel model)
        {
            DataLayer.ExecuteQuery("SaveAdmin", model.toPerams());
        }

        public static List<AdminModel> getAdmins()
        {

            DataTable data = DataLayer.ExecuteTable("GetAdmin");
            List<AdminModel> list = new List<AdminModel>();


            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {
                    AdminModel model = new AdminModel();
                    model.AdminID = Convert.ToInt16(rows["AdminID"]);
                    model.AdminName = rows["AdminName"].ToString() ?? "";
                    model.Email = rows["Email"].ToString() ?? "";
                    model.Password = rows["Password"].ToString() ?? "";
                    model.BusinessAddress = rows["BusinessAddress"].ToString() ?? "";
                    model.PhoneNumber = rows["PhoneNumber"].ToString() ?? "";
                    model.AdminCNIC = rows["AdminCNIC"].ToString() ?? "";
                    list.Add(model);
                }
            }
            return list;
        }

        public static AdminModel GetSingleAdmin(int id)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@AdminID", id);

            DataTable data = DataLayer.ExecuteTable("GetsingleAdmin",prm);
            AdminModel model= new AdminModel();


            if (data != null)
            {
                foreach (DataRow rows in data.Rows)
                {
                  
                    model.AdminID = Convert.ToInt16(rows["AdminID"]);
                    model.AdminName = rows["AdminName"].ToString() ?? "";
                    model.Email = rows["Email"].ToString() ?? "";
                    model.Password = rows["Password"].ToString() ?? "";
                    model.BusinessAddress = rows["BusinessAddress"].ToString() ?? "";
                    model.PhoneNumber = rows["PhoneNumber"].ToString() ?? "";
                    model.AdminCNIC = rows["AdminCNIC"].ToString() ?? "";
                   
                }
            }
            return model;
        }
        public static void DeleteAdmin(int id)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] =new  SqlParameter("@AdminID", id);
            DataLayer.ExecuteQuery("DeleteAdmin", prm);
        }

    }
}
