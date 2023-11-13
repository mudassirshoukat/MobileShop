using Microsoft.AspNetCore.Mvc.Rendering;
using MobileShop.Models;
using mymyapp.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.BL.Admin
{
    public class BL_Brand
    {
       
       public static IEnumerable<SelectListItem> Getbrands()
        {
            List<BrandModel> list = new List<BrandModel>();
            DataTable data = DataLayer.ExecuteTable("GetAllBrands");
            foreach(DataRow brand in data.Rows)
            {
                BrandModel model = new BrandModel();
                model.BrandID = Convert.ToInt16(brand["BrandID"]);
                model.BrandName = brand["BrandName"].ToString();

                list.Add(model);
            }
            IEnumerable<SelectListItem> selectList = list
    .Select(b => new SelectListItem
    {
        Value = b.BrandID.ToString(),
        Text = b.BrandName
    });

            return selectList;
        }
    }
}
