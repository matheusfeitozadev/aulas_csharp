using LogicaProgramacao.Classes.Assembly;
using Newtonsoft.Json;
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
        private EntityAssembly entityAssembly;
        private EntityAssemblyProperties entityAssemblyProperties;

        public AssemblyController()
        {
            entityCustomer = new EntityCustomer();
            entityFactory = new EntityFactory();
            entityProperty = new EntityProperty();
            entityAssembly = new EntityAssembly();
            entityAssemblyProperties = new EntityAssemblyProperties();
        }

        public ActionResult List()
        {
            var list = entityAssembly.List();

            return View(list);
        }

        // GET: Assembly
        public ActionResult New()
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
            var model = JsonConvert.DeserializeObject<AssemblyViewModel>(json);
            model.Active = true;

            var idAssembly = entityAssembly.Add(model);

            model.Properties.ForEach(x => x.FK_Assembly = idAssembly);

            foreach (var item in model.Properties)
            {
                entityAssemblyProperties.Add(item);
            }


            return RedirectToAction("Index");
        }
    }
}