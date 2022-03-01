using Persistence.Models;
using Repository;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IProductoService: IEntityBaseRepository<Producto>
    {
        public Task<Producto> DownAsync(int id);
    }
}
