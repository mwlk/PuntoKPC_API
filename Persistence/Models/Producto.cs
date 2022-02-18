using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Double PrecioUnitario { get; set; }
        public Double PrecioPack { get; set; }
        public int CantidadPack { get; set; }
        public int Estado { get; set; }
    }
}
