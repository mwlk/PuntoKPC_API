using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    public class OrderViewModel
    {
        [Required]
        public PedidoViewModel pedido { get; set; }
        [Required(ErrorMessage = "Ingrese Detalle de Pedido Por Favor")]
        public List<DetallePedidoViewModel> detalles { get; set; }
    }
}
