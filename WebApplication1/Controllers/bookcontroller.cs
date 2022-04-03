using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class bookcontroller : Controller
    {
        mainEntities db= new mainEntities();
        // GET: bookcontroller
        public ActionResult bookview()
        {
            List<table_3> data = db.table_3.ToList();
            return View(data);
        }
        public ActionResult createbook()
        {
            return View();
        }
        public ActionResult savedata(table_3 table_3)
        {
            db.table_3.Add(table_3);    
            db.SaveChanges();
            return RedirectToAction("bookview");
        }
    }
}