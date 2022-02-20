using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ProductoConfig
    {
        public ProductoConfig(EntityTypeBuilder<Producto> builder)
        {
            builder.HasAlternateKey(x => x.Nombre);

            builder.Property(x => x.Nombre).IsRequired()
                                            .HasMaxLength(20);

            builder.Property(x => x.Descripcion).HasMaxLength(50);

            builder.Property(x => x.PrecioUnitario).IsRequired();

            builder.Property(x => x.PrecioPack).IsRequired();

            builder.Property(x => x.CantidadPack).IsRequired();

            builder.Property(x => x.Estado).IsRequired();
                                                    
        }
    }
}
