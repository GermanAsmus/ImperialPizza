using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaMVC.Models
{
    public enum EstadoPedido
    {
        Creado,
        EnProgreso,
        Despachado,
        Entregado,
        Facturado
    }
}