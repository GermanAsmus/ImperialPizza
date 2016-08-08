using PizzaMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MisPedidos()
        {
            return View();
        }

        public ActionResult EspecialidadesCliente()
        {
            return View();
        }

        public ActionResult VerPizza()
        {
            return View();
        }

        public ActionResult VerEmpanadas()
        {
            return View();
        }
    }
}