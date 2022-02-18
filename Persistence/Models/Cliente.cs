using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Cliente
    {
        [Key]
        public int Clienteid { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Estado { get; set; }
        public Double Mora { get; set; }

        //relationships
        public List<Pedido> Pedidos { get; set; }
    }
}
