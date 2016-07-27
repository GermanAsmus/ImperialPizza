using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaMVC.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public virtual ICollection<LineaPedido> LineasPedido { get; set; }
    }
}