using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaMVC.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PedidoMateriaPrima()
        {
            return View();
        }

        public ActionResult RealizarPedido()
        {
            return View();
        }

        public ActionResult VerHistorialPedidos()
        {
            return View();
        }

        public ActionResult Action()
        {
            return View();
        }
    }
}