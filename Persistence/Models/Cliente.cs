using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Models
{
    public class Cliente: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Estado { get; set; }
        public Double Mora { get; set; }

        //relationships
        public List<Pedido> Pedidos { get; set; }
    }
}
