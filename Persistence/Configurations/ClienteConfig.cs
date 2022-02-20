using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ClienteConfig
    {
        public ClienteConfig(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasAlternateKey(x => x.Nombre);
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(40);
        }
    }
}
