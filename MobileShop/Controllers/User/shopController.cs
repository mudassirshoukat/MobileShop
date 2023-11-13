using Microsoft.AspNetCore.Mvc;
using MobileShop.BL;
using MobileShop.BL.User;
using MobileShop.Models;

using MobileShop.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers.User
{
    public class shopController : Controller
    {
        public IActionResult Products()
        {
            List<ProductModel> products = BL_Product.GetProducts();
            return View(products);
        }


        public IActionResult SingleProduct(int id)
        {
            ProductDetailResponseModel product = BL_Product.GetSingleProduct(id);
            return View(product);
        }

        public IActionResult AddToCart(int id)
        {
            BL_Cart.AddCartItem(id);

            return RedirectToAction("Products");
        }
    }
}
