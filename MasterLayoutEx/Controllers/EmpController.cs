using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        //static List<EMPDATA> E = null;
        public ActionResult Index()
        {
            List<EMPDATA> E = DBOps.GetAll();
            return View(E);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Insert(EMPDATA E)
        {
            ViewBag.msg=DBOps.InsertEmp(E);
            return View("Create");

        }

        public ActionResult Edit(int id)
        {
            return View(DBOps.EditEmp(id));
        }
        [HttpPost]
        public ActionResult Edit(EMPDATA E)
        {
            ViewBag.msg=DBOps.Update(E);
            return View();
        }

        public ActionResult Delete(int id)
        {
           ViewBag.msg= DBOps.DeleteEmp(id);
            return View("index", DBOps.GetAll());
        }

    }
}