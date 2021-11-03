using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinForms.Classes.Entity;

namespace WebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private EntityCustomer entityCustomer;

        public CustomerController()
        {
            entityCustomer = new EntityCustomer();
        }

        // GET: Customer
        public ActionResult List()
        {
            var list = entityCustomer.List();

            return View(list);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(CustomerViewModel customerViewModel)
        {
            return RedirectToAction("List");
        }
    }
}