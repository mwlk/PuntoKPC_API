using System;

namespace ViewModel
{
    public class PedidoViewModel
    {
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public string NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Estado { get; set; }
    }
}
