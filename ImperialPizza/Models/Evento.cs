using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImperialPizza.Models
{
    public class Evento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public Evento(string pNombre, string pDescripcion, DateTime pFecha)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Fecha = pFecha;
        }
    }
}