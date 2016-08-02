using MoreLinq;
using PizzaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaMVC.ViewModels
{
    public class PedidosDestacadosViewModel
    {

        public IEnumerable<PedidoViewModel> PedidosDestacados
        {
            get
            {
                IEnumerable<ProductoPedido> listaProductosPedidos = PedidosDestacados.Select(p => p.ProductoPedido);
                return PedidosDestacados.Where(pedido => listaProductosPedidos.MaxBy(producto => producto.Cantidad).ProductoID == pedido.ProductoPedido.ProductoID).Take(4);
            }
            set
            {
                this.PedidosDestacados = value;
            }
        }
    }
}