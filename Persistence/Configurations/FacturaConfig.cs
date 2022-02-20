using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;

namespace Persistence.Configurations
{
    class FacturaConfig
    {
        public FacturaConfig(EntityTypeBuilder<Factura> builder)
        {
            builder.Property(x => x.Monto).IsRequired();
            builder.Property(x => x.PedidoId).IsRequired();
        }
    }
}
