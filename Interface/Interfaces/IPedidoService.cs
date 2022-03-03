using Persistence.Models;
using Repository;
using System.Threading.Tasks;
using ViewModel;

namespace Interface.Interfaces
{
    public interface IPedidoService: IEntityBaseRepository<Pedido>
    {
        public Task<Pedido> InsertPedido(PedidoViewModel model);
    }
}
