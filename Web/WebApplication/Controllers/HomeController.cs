using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.ViewModel;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar(UsuarioViewModel usuarioViewModel)
        {
            if(string.IsNullOrEmpty(usuarioViewModel.Username) || string.IsNullOrEmpty(usuarioViewModel.Password))
            {
                TempData["Message"] = new UsuarioViewModel() { Username = "Curso DEV"};
            }

            return RedirectToAction("Index");
        }
    }
}