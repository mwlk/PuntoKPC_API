using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class AlmacenService : EntityBaseRepository<Almacen>, IAlmacenService
    {
        public AlmacenService(EcommerceContext context) : base(context)
        {
        }
    }
}
