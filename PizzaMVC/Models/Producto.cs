using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaMVC.Models
{
    public class Producto
    {
        [Key]
        [Display(Name = "Producto")]
        public int ProductoID { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="Ingresar {0}")]
        [StringLength(80,MinimumLength =1)]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [StringLength(200, MinimumLength = 1)]
        public string Descripcion { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }


        [Display(Name = "Detalle Pedidos")]
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }

        [Display(Name = "Detalle Eventos")]
        public virtual ICollection<DetalleEvento> DetalleEventos { get; set; }
    }
}