using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class Detalle
    {
        public int ID { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
    }
}