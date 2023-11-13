
using Microsoft.AspNetCore.Mvc;
using MobileShop.BL.Admin;
using MobileShop.Models.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers.Admin
{
    public class OrderController : Controller
    {
        public IActionResult orderpage()
        {
            
            OrderResponseViewModel model = BL_OrderAdmin.GetOrders();
            return View(model);
        }
    }
}
