using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.DB;
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

        public ActionResult Edit(int Id)
        {
            var model = entityCustomer.GetById(Id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Post(CustomerViewModel customerViewModel)
        {
            customerViewModel.Active = true;
            var id = entityCustomer.Add(customerViewModel);

            if(id > 0)
            {
                TempData["Success"] = true;
            }
            else
            {
                TempData["Success"] = false;
            }

            return RedirectToAction("Add");
        }

        [HttpPost]
        public ActionResult PostEdit(CustomerViewModel customerViewModel, string Active)
        {
            try
            {
                customerViewModel.Active = string.IsNullOrEmpty(Active) ? false : true;

                entityCustomer.Update(customerViewModel);
                TempData["Success"] = true;
            }
            catch(Exception ex)
            {
                TempData["Success"] = false;
                TempData["Message"] = ex.Message;
            }

            return RedirectToAction("List");
        }

        [HttpPost]
        public JsonResult PostAjax(CustomerViewModel customerViewModel)
        {
            var message = "";
            customerViewModel.Active = true;
            var id = entityCustomer.Add(customerViewModel);

            if (id > 0)
            {
                message = "Sucesso!";
            }
            else
            {
                message = "Erro!";
            }

            return Json(message, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            try
            {
                entityCustomer.Delete(Id);
                TempData["Success"] = true;
            }
            catch (Exception ex)
            {
                TempData["Success"] = false;
                TempData["Message"] = ex.Message;
            }

            return RedirectToAction("List");
        }
    }
}