using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhakaCreditGym.Models;

namespace DhakaCreditGym.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBL bl = new EmployeeBL();
        // GET: Employee
        public ActionResult Index()
        {
            return View(bl.GetAll());
        }
        // Create
        public ActionResult Create()
        {
            return View();
        }
        // Create
        [HttpPost]
        public ActionResult Create(Employees emp)
        {
            if(ModelState.IsValid)
            {
                bl.NewEmployee(emp);
                return RedirectToAction("Index");
            }
            return View();
        }
        // Edit
        public ActionResult Edit(int id)
        {
            return View(bl.Search(id));
        }
        // Edit
        [HttpPost]
        public ActionResult Edit(Employees e)
        {
            if(ModelState.IsValid)
            {
                bl.Update(e);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}