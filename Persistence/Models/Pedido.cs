using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Models
{
    public class Pedido: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public string NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Estado { get; set; }

        public Factura Factura { get; set; }
        public List<DetallePedido> DetallePedidos { get; set; }
    }
}
