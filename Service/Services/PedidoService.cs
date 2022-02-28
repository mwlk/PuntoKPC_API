using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class PedidoService: EntityBaseRepository<Pedido>, IPedidoService
    {
        public PedidoService(EcommerceContext context): base(context) { }
        
    }
}
