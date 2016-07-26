using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImperialPizza.Models
{
    public class Pizza
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Pizza()
        {

        }
    }
}