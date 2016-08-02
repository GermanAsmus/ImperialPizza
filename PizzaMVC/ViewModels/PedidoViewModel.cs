using PizzaMVC.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaMVC.ViewModels
{
    public class PedidoViewModel
    {
        [Display(Name ="Nombre y Apellido")]
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public Localidad Localidad { get; set; }
        public ProductoPedido ProductoPedido { get; set; }
        public List<ProductoPedido> Productos { get; set; }
    }
}