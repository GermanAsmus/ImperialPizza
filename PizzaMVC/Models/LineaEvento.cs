using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class LineaEvento
    {
        [Key]
        public int LineaEventoID { get; set; }
        public int EventID { get; set; }
        public int PizzaID { get; set; }
        public virtual Event Event { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}