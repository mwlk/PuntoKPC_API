using Interface.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly EcommerceContext _context;

        public PedidoService(EcommerceContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> GetAll()
        {
            var result = await _context.Pedidos.ToListAsync();

            return result;
        }
    }
}
