using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class DetallePedidoService : EntityBaseRepository<DetallePedido>, IDetallePedidoService
    {
        public DetallePedidoService(EcommerceContext context) : base(context)
        {
        }
    }
}
