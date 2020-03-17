using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MasterLayoutEx.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(Login L)
        {
            if (ModelState.IsValid)
            {
                if (LoginValidationDB.Validation(L))
                    return View("index");
                else
                {
                    ViewBag.msg = "Enter Valid Credentials";
                    return View("LoginPage");
                }
            }
            else
                return View("LoginPage");
        }   

        public ActionResult index()
        {
            return View();
        }
    }
}