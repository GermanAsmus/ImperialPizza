using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}