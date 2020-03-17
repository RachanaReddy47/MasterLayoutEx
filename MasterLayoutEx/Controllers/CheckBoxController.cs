using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class CheckBoxController : Controller
    {
        // GET: CheckBox
        public ActionResult Index()
        {
           ViewBag.L1= DBOps.GetAll();
            return View();
        }

        public ActionResult Index2(int[] CBK)
        {
         
         ViewBag.L2= DBOps.CBKGetEmp(CBK);
            return View();
        }
    }
}