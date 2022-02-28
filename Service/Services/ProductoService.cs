using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class ProductoService: EntityBaseRepository<Producto> ,IProductoService
    {
        public ProductoService(EcommerceContext context) : base(context) { }
    }
}
