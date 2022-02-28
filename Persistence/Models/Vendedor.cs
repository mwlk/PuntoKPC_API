using Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persistence.Models
{
    public class Vendedor: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }

        public List<Pedido> Pedidos { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Usuario Usuario { get; set; }


    }
}
