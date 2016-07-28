using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaMVC.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoID { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }

        [NotMapped]
        public decimal PrecioTotal { get {
                decimal precio = 0;
                foreach(LineaPedido linea in LineasPedido)
                {
                    precio += linea.Precio;
                }
                return precio; } }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hora { get; set; }
        public virtual ICollection<LineaPedido> LineasPedido { get; set; }

        //[DataType(DataType.EmailAdress)]
        //[DataType(DataType.URL)]
    }
}