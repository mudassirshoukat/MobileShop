using MobileShop.Models.response;
using mymyapp.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.BL.Admin
{
    public class BL_OrderAdmin
    {
        public static OrderResponseViewModel GetOrders()
        
        {
            OrderResponseViewModel Model = new OrderResponseViewModel();
            List<OrderResponseModel> orders = new List<OrderResponseModel>();
            DataTable data = DataLayer.ExecuteTable("GetAllOrders");
            if (data != null)
            {
                foreach( DataRow row in data.Rows)
                {
                    OrderResponseModel model = new OrderResponseModel();
                    model.OrderID =Convert.ToInt16(row["OrderID"]);
                    model.UserID =Convert.ToInt16(row["UserID"]);
                    model.TotalAmount = Convert.ToDouble(row["TotalAmount"]);
                    model.BuyerName = row["BuyerName"].ToString();
                    model.ProductName.Add( row["ProductName"].ToString());
                    model.ShippingAddress = row["ShippingAddress"].ToString();
                    model.Status= row["Status"].ToString();
                    model.OrderDate=Convert.ToDateTime( row["OrderDate"]);

                    orders.Add(model);

                }


                var mergedOrders = orders
           .GroupBy(o => new { o.UserID, o.OrderDate })
           .Select(g => new OrderResponseModel
           {
               OrderID = g.First().OrderID,
               UserID = g.Key.UserID,
               BuyerName = g.First().BuyerName,
               OrderDate = g.Key.OrderDate,
               ShippingAddress = g.First().ShippingAddress,
               TotalAmount = g.Sum(o => o.TotalAmount),
               ProductName = g.SelectMany(o => o.ProductName).ToList(),
               Status = g.First().Status
           })
           .ToList();

               
              
                foreach (var order in mergedOrders)
                {
                    if (order.Status == "Pending") ++Model.PendingOrders;
                    if (order.Status == "Delivered") { 
                        ++Model.CompleatedOders; 
                        Model.TotalSale+=order.TotalAmount;
                    }
                    

                }
                Model.TotalOrders = mergedOrders.Count;
                Model.Listorder = mergedOrders;


            }
            return Model;


        }
    }
}
