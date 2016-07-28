using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class LineaPedido
    {
        [Key]
        public int LineaPedidoID { get; set; }
        public int PedidoID { get; set; }
        public int PizzaID { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Pizza Pizza { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get { return this.Pizza.Precio * this.Cantidad; } }
    }
}