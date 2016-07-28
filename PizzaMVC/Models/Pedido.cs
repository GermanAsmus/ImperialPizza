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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hora { get; set; }

        [Display(Name ="Nombre y Apellido")]
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public EstadoPedido EstadoPedido { get; set; }

        [Display(Name ="Localidad")]
        public int LocalidadID { get; set; }

        public virtual Localidad Localidad { get; set; }
        public virtual ICollection<DetallePedido> DetallesPedidos { get; set; }

        //[DataType(DataType.EmailAdress)]
        //[DataType(DataType.URL)]
    }
}