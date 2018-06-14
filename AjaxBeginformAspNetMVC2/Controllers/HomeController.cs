using AjaxBeginformAspNetMVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginformAspNetMVC2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCountries(Countries objCountries)
        {
            if (Request.IsAjaxRequest())
            {
                if (objCountries.CountriesName != null)
                {
                    using (DbconnectionContext obj = new DbconnectionContext())
                    {
                        obj.Countries.Add(objCountries);
                        obj.SaveChanges();
                        return Json(new { votes = "Success" }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { votes = "Error" });
                }
            }
            return PartialView("_Message");
        }

        [HttpGet]
        public ActionResult AddCountries()
        {
            return View();
        }
        public ActionResult ViewCountry()
        {
            using (DbconnectionContext db = new DbconnectionContext())
            {
                List<Countries> list = db.Countries.ToList();
                return PartialView("_CountryList", list);
            }
        }
    }
}