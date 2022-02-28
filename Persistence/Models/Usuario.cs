using Repository;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Models
{
    public class Usuario: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
