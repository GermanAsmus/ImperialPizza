using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class DetallePedido
    {
        [Key]
        public int DetallePedidoID { get; set; }
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public float Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}