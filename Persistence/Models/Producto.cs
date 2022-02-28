using Repository;
using System;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Models
{
    public class Producto: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Double PrecioUnitario { get; set; }
        public Double PrecioPack { get; set; }
        public int CantidadPack { get; set; }
        public int Estado { get; set; }
    }
}
