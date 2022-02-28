using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class ClienteService : EntityBaseRepository<Cliente>, IClienteService
    {
        public ClienteService(EcommerceContext context) : base(context)
        {
        }
    }
}
