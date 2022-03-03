using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;
using System.Threading.Tasks;
using ViewModel;

namespace Service.Services
{
    public class PedidoService : EntityBaseRepository<Pedido>, IPedidoService
    {
        private readonly EcommerceContext _context;

        public PedidoService(EcommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Pedido> InsertPedido(PedidoViewModel model)
        {
            var order = new Pedido()
            {
                ClienteId = model.ClienteId,
                Estado = model.Estado,
                FechaPedido = model.FechaPedido,
                NumeroPedido = model.NumeroPedido,
                VendedorId = model.VendedorId
            };

            await _context.Pedidos.AddAsync(order);

            await _context.SaveChangesAsync();
            return order;
        }
    }
}
