using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class main2controller : Controller
    {
        mainEntities db = new mainEntities();
        // GET: main2controller
        public ActionResult mainview1()
        {
            List<employee_salary_details> data = db.employee_salary_details.ToList();
            return View(data);
        }

        public ActionResult Create2()
        {
            var employeeslist = db.employees.ToList();
            ViewBag.employeeslist = new SelectList(employeeslist, "id", "name");
        
            return View();
        }
        public ActionResult edit(int id)
        {
            employee_salary_details data = db.employee_salary_details.Find( id);
            return View(data);// find data using primary key 
        }
        public ActionResult updatedata(employee_salary_details data)
        {

            db.Entry(data).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("mainview1");
        }

        public ActionResult savedata3(employee_salary_details id)
        {

            db.employee_salary_details.Add(id);
            db.SaveChanges();
            return RedirectToAction("mainview1");
        }


    }
}

