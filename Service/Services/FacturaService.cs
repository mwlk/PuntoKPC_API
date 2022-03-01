using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class FacturaService : EntityBaseRepository<Factura>, IFacturaService
    {
        public FacturaService(EcommerceContext context) : base(context)
        {
        }
    }
}
