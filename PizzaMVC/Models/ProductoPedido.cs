using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public class ProductoPedido : Producto
    {
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Cantidad { get; set; }

        [Display(Name ="Pecio Total")]
        public decimal Valor { get { return Precio * (decimal)Cantidad; } }
    }
}