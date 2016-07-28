using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaMVC.Models
{
    public class Pizza
    {
        [Key]        
        public int PizzaID { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="Ingresar {0}")]
        [StringLength(80,MinimumLength =1)]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [StringLength(200, MinimumLength = 1)]
        public string Descripcion { get; set; }

        [Display(Name = "Precio $")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }

        [Display(Name = "Receta")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [StringLength(800, MinimumLength = 1)]
        public string Receta { get; set; }

        [Display(Name = "Lineas")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public ICollection<LineaPedido> LineasPedido { get; set; }

        [Display(Name = "Eventos")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public ICollection<LineaEvento> LineasEvento { get; set; }
    }
}