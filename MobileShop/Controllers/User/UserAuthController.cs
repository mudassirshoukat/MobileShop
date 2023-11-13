using Microsoft.AspNetCore.Mvc;
using MobileShop.BL;
using MobileShop.Models;
using MobileShop.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult SignUp()
       {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            BL_UserAuth obj = new BL_UserAuth();
            obj.SignUp(model);
            return View();
        }

        public IActionResult LoginUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginUser(LoginModel model)
        {
            BL_UserAuth obj = new BL_UserAuth();
            //obj.SignUp(model);
            return View();
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            List<UserModel> list_  =  BL_UserAuth.GetUsers();
           
            return View(list_);
        }
        public IActionResult Edit(int id)
        {
            UserModel user= BL_UserAuth.GetSingleUser(id);

            return View(user);
        }

        public IActionResult Delete(int id)
        {
            BL_UserAuth.Delete(id);

            return View();
        }

    }
}
