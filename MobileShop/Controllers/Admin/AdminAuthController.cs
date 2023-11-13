using Microsoft.AspNetCore.Mvc;
using MobileShop.BL;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class AdminAuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(AdminModel model)
        {
            BL_AdminAuth.save(model);
            return View();
        }

        public IActionResult GetAdmins()

        {
            List<AdminModel> list = BL_AdminAuth.getAdmins();
            return View(list);
        }
        public IActionResult Edit(int id)
        {

            AdminModel _admin = BL_AdminAuth.GetSingleAdmin(id);
            return View(_admin);
        }
        public IActionResult Delete(int id)
        {

             BL_AdminAuth.DeleteAdmin(id);
            return View();
        }


    }
}
