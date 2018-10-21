using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DhakaCreditGym.Models;
using DhakaCreditGym.Models.Business_Logic;

namespace DhakaCreditGym.Controllers
{
    public class MembersController : Controller
    {
        MemberBL bl = new MemberBL();
        // GET: Members
        public ActionResult Index()
        {
            return View(bl.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Members mem)
        {
            if(ModelState.IsValid)
            {
                bl.NewMember(mem);
                return RedirectToAction("Index");
            }
            else
            { 
            return View();
            }
        }
    }
}