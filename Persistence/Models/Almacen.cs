using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Almacen
    {
        public int AlmacenId { get; set; }
        public int ProductoId { get; set; }
        public int Stock { get; set; }
    }
}
