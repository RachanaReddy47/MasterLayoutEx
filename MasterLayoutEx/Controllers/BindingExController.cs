using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class BindingExController : Controller
    {
        // GET: BindingEx
        [ActionName("Example")]
        public ActionResult Sample()
        {
            return View("Sample");
        }

        public ActionResult Index()
        {
            return View();
        }
        //Primitive type DataBinding
        public ActionResult Update(int id)
        {
            return View("Index",DBOps.EditEmp(id));
        }

        //Binding to Complex type
        //[HttpPost]
        //public ActionResult Update(EMPDATA E)
        //{
        //    ViewBag.msg = DBOps.Update(E);
        //    return View("Index");
        //}

        //BasicType not suggested
        //[HttpPost]
        //public ActionResult Update(int Empno,string Ename,string Job,int Mgr,DateTime Hiredate,int sal,int Comm,int deptno)
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Update(FormCollection F)
        //{
        //    int eno = int.Parse(F["EMPNO"]);
        //    string en = (F["ENAME"]);
        //    int mgr= int.Parse(F["MGR"]);
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Update([Bind(Include = "ENAME,JOB")] EMPDATA E)
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Update([Bind(Exclude = "ENAME,JOB")] EMPDATA E)
        {
            return View();
        }


    }


}