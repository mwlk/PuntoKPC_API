using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class VendedorService : EntityBaseRepository<Vendedor>, IVendedorService
    {
        public VendedorService(EcommerceContext context) : base(context)
        {
        }
    }
}
