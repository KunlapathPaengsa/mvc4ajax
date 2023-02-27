using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Step 1
        public JsonResult GetStudent()
        {
            Student std = new Student
            {
                Id = 1,
                Email = "ABC@gmail.com",
                Name = "Max"
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(std, JsonRequestBehavior.AllowGet);
        }
    }

    internal class Student
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}