using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class Localidad
    {
        [Key]
        [Display(Name ="Localidad")]
        public int LocalidadID { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}