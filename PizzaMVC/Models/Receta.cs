using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class Receta
    {
        public int ID { get; set; }
        public ICollection<Detalle> Detalles { get; set; }
    }
}