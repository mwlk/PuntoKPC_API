using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public string NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Estado { get; set; }

        public Factura Factura { get; set; }
        public List<DetallePedido> DetallePedidos { get; set; }
    }
}
