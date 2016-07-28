using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class DetalleEvento
    {
        [Key]
        public int DetalleEventoID { get; set; }
        public int ProductoID { get; set; }
        public int EventID { get; set; }

        public virtual Event Event { get; set; }
        public virtual Producto Producto { get; set; }
    }
}