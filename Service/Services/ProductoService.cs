using Interface.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Data;
using Persistence.Models;
using Repository;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductoService : EntityBaseRepository<Producto>, IProductoService
    {
        private readonly EcommerceContext _context;

        public ProductoService(EcommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Producto> DownAsync(int id)
        {
            var result = await _context.Productos.FirstOrDefaultAsync(p => p.Id == id);

            if (result != null) result.Estado = 0;

            EntityEntry entityEntry = _context.Entry<Producto>(result);

            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return result;
        }
    }
}
