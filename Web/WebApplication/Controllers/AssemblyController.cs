using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinForms.Classes.Entity;

namespace WebApplication.Controllers
{
    public class AssemblyController : Controller
    {
        private EntityCustomer entityCustomer;
        private EntityFactory entityFactory;
        private EntityProperty entityProperty;

        public AssemblyController()
        {
            entityCustomer = new EntityCustomer();
            entityFactory = new EntityFactory();
            entityProperty = new EntityProperty();
        }

        // GET: Assembly
        public ActionResult Index()
        {
            var factories = entityFactory.List();
            var customers = entityCustomer.List();
            var properties = entityProperty.List();

            ViewBag.Customers = customers;
            ViewBag.Factories = factories;
            ViewBag.Properties = properties;

            return View();
        }

        [HttpPost]
        public ActionResult SaveInfo(string json)
        {
            return RedirectToAction("Index");
        }
    }
}