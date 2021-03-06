using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        mainEntities db=new mainEntities(); 
        // GET: Main
        public ActionResult mainview()
        {
            List<employee> data = db.employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult edit(int employeeID)
        {
             employee data = db.employees.Find(employeeID);
            return View(data);// find data using primary key 
        }
        public ActionResult updatedata(employee data)
        {

            db.Entry(data).State = System.Data.Entity.EntityState.Modified;
         db.SaveChanges();
         return RedirectToAction("mainview");
        }

        public ActionResult savedata(employee employee)
        {

            db.employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("mainview");
        }

    }
   
    }
