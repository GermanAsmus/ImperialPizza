using System.ComponentModel.DataAnnotations;

namespace PizzaMVC.Models
{
    public class Pizza
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Receta { get; set; }
    }
}