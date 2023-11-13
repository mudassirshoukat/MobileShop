using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MobileShop.BL;
using MobileShop.BL.Admin;
using MobileShop.Models;
using MobileShop.Models.Request;
using MobileShop.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers.Admin
{
    public class AdminProductController : Controller
    {
        public IActionResult AddProduct()
        {
            IEnumerable<SelectListItem> brands = BL_Brand.Getbrands();
            var model = new ProductRequestModel { BrandList = brands,BrandID=0 };
            return View(model);
        }


        [HttpPost]
        public IActionResult SaveProduct(ProductRequestModel model)
        {
            BL_Product.SaveProduct(model);
            return RedirectToAction("Products");
        }

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


        public IActionResult Edit(int id)
        {
            ProductRequestModel product = BL_Product.GetSingleProductdetail(id);
            product.BrandList = BL_Brand.Getbrands();
            return View(product);
        }
        public IActionResult Delete(int id)
        {
            BL_Product.DeleteProduct(id);
            return RedirectToAction("Products");
        }


    }
}
