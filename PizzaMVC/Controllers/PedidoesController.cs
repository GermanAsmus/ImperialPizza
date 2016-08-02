using PizzaMVC.Models;
using PizzaMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PizzaMVC.Controllers
{
    public class PedidoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //GET: Index
        public ActionResult Index()
        {
            return View(db.Pedidoes.ToList());
        }

        // GET: Productoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedido pedido = db.Pedidoes.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }


        // GET: Pedidoes/NuevoPedido
        public ActionResult NuevoPedido()
        {
            var pedidoView = new PedidoViewModel();

            pedidoView.Productos = new List<ProductoPedido>();

            Session["pedidoView"] = pedidoView;

            var listaLocalidades = db.Localidads.ToList();
            listaLocalidades = listaLocalidades.OrderBy(l => l.Nombre).ToList();

            var listaProductos = db.Productoes.ToList();
            listaProductos = listaProductos.OrderBy(p => p.Nombre).ToList();

            ViewBag.LocalidadID = new SelectList(listaLocalidades, "LocalidadID", "Nombre");
            ViewBag.ProductoID = new SelectList(listaProductos, "ProductoID", "Nombre");
            ViewBag.Productos = db.Productoes.ToList();
            return View(pedidoView);
        }

        // POST: Pedidoes/NuevoPedido
        [HttpPost]
        public ActionResult NuevoPedido(PedidoViewModel pedidoView)
        {
            pedidoView = Session["pedidoView"] as PedidoViewModel;

            var localidadID = int.Parse(Request["LocalidadID"]);

            if (pedidoView.Productos.Count == 0)
            {
                var listaLocalidades = db.Localidads.ToList();
                listaLocalidades = listaLocalidades.OrderBy(l => l.Nombre).ToList();

                ViewBag.LocalidadID = new SelectList(listaLocalidades, "LocalidadID", "Nombre");
                ViewBag.Error = "Debe ingresar una cantidad";

                return View(pedidoView);
            }

            if (pedidoView.Direccion == string.Empty)
            {
                var listaLocalidades = db.Localidads.ToList();
                listaLocalidades = listaLocalidades.OrderBy(l => l.Nombre).ToList();

                ViewBag.LocalidadID = new SelectList(listaLocalidades, "LocalidadID", "Nombre");
                ViewBag.Error = "Debe escribir una direccion";

                return View(pedidoView);
            }

            if (pedidoView.Cliente == string.Empty)
            {
                var listaLocalidades = db.Localidads.ToList();
                listaLocalidades = listaLocalidades.OrderBy(l => l.Nombre).ToList();

                ViewBag.LocalidadID = new SelectList(listaLocalidades, "LocalidadID", "Nombre");
                ViewBag.Error = "Debe escribir una direccion";

                return View(pedidoView);
            }

            var pedido = new Pedido
            {
                Cliente = pedidoView.Cliente,
                Direccion = pedidoView.Direccion,
                LocalidadID = localidadID,
                Fecha = DateTime.Now,
                Hora = DateTime.Now,
                EstadoPedido = EstadoPedido.Creado,
            };

            db.Pedidoes.Add(pedido);
            db.SaveChanges();

            var pedidoID = db.Pedidoes.ToList().Select(p => p.PedidoID).Max();

            foreach (var item in pedidoView.Productos)
            {
                var pedidoDetalle = new DetallePedido
                {
                    Descripcion = item.Descripcion,
                    Cantidad = item.Cantidad,
                    Precio = item.Precio,
                    PedidoID = pedidoID
                };
                db.DetallePedidoes.Add(pedidoDetalle);
            }

            return View(pedidoView);
        }

        // GET: Pedidoes/AgregarProducto
        public ActionResult AgregarProducto()
        {
            var listaProductos = db.Productoes.ToList();
            listaProductos = listaProductos.OrderBy(p => p.Nombre).ToList();

            ViewBag.ProductoID = new SelectList(listaProductos, "ProductoID", "Nombre");

            return View();
        }

        // POST: Pedidoes/AgregarProducto
        [HttpPost]
        public ActionResult AgregarProducto(ProductoPedido productoPedido)
        {
            var pedidoView = Session["pedidoView"] as PedidoViewModel;

            var productoID = int.Parse(Request["ProductoID"]);

            if (productoID == 0)
            {
                var listaProductos = db.Productoes.ToList();
                listaProductos = listaProductos.OrderBy(p => p.Nombre).ToList();
                ViewBag.ProductoID = new SelectList(listaProductos, "ProductoID", "Nombre");
                ViewBag.Error = "Debe seleccionar un producto";

                return View(productoPedido);
            }

            var producto = db.Productoes.Find(productoID);

            if (producto == null)
            {
                var listaProductos = db.Productoes.ToList();
                listaProductos = listaProductos.OrderBy(p => p.Nombre).ToList();
                ViewBag.ProductoID = new SelectList(listaProductos, "ProductoID", "Nombre");
                ViewBag.Error = "El producto no existe";

                return View(productoPedido);
            }

            productoPedido = pedidoView.Productos.Find(p => p.ProductoID == productoID);

            if (productoPedido == null)
            {
                productoPedido = new ProductoPedido
                {
                    Nombre = producto.Nombre,
                    Precio = producto.Precio,
                    ProductoID = producto.ProductoID,
                    Cantidad = float.Parse(Request["Cantidad"]),
                };

                pedidoView.Productos.Add(productoPedido);
            }
            else
            {
                productoPedido.Cantidad += float.Parse(Request["Cantidad"]);
            }

            var listaLocalidades = db.Localidads.ToList();
            listaLocalidades = listaLocalidades.OrderBy(l => l.Nombre).ToList();

            ViewBag.LocalidadID = new SelectList(listaLocalidades, "LocalidadID", "Nombre");

            return View("NuevoPedido", pedidoView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}