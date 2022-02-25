using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetAll();
    }
}
