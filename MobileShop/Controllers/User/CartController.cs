using Microsoft.AspNetCore.Mvc;
using MobileShop.BL.User;
using MobileShop.Models.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers.User
{
    public class CartController : Controller
    {
        
        public IActionResult CartScreen()
        {
            List<GetUserCartResponse> cartlistitems;
            cartlistitems = BL_Cart.GetUserCart();
            return View(cartlistitems);
        }

        public IActionResult ClearCart()
        {
             BL_Cart.ClearCart();
            return RedirectToAction("CartScreen");
        }
        public IActionResult RemoveItem(int id)
        {
         BL_Cart.RemoveItem(id);
            return RedirectToAction("CartScreen");
        }
        public IActionResult ItemIncrement(int cartid,int qty)
        {
            BL_Cart.ItemIncrement(cartid,qty);
            return RedirectToAction("CartScreen");
        }
        public IActionResult DecrementItem(int cartid ,int qty)
        {
            if (qty > 1)
                BL_Cart.ItemDecreament(cartid,qty);
            return RedirectToAction("CartScreen");
        }
      
    }
}
