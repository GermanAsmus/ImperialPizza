using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class LineaPedido
    {
        public int ID { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Pizza Pizza { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get { return this.Pizza.Precio * this.Cantidad; } set { this.Precio = value; } }
    }
}