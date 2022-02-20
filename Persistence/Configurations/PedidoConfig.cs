using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class PedidoConfig
    {
        public PedidoConfig(EntityTypeBuilder<Pedido> builder)
        {
            builder.Property(x => x.NumeroPedido).IsRequired()
                                                  .HasMaxLength(10);

            builder.Property(x => x.Estado).IsRequired();

            builder.Property(x => x.FechaPedido).IsRequired();
        }
    }
}
