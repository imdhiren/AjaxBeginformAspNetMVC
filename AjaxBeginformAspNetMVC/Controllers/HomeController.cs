using AjaxBeginformAspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginformAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [HandleError]
        public ActionResult Add(Employee empmodel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Sucess Message";
                ModelState.Clear();
                return PartialView("__EmployeePartial");
            }
            else
            {
                ViewBag.ErrorMessage = "Failure Message";
            }
            return PartialView("__EmployeePartial", empmodel);
        }
    }
}