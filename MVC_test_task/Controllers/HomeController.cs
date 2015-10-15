using MVC_test_task.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_test_task.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View(db.Lists);
        }

        public ActionResult add_candidat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add_candidat(ListModel Lists)
        {
            if (ModelState.IsValid)
            {
                db.Lists.Add(Lists);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(Lists);
        }
    }
}