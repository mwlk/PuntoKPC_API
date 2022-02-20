using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;
using Persistence.Models;

namespace Persistence.Data
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // add configs
            new FacturaConfig(builder.Entity<Factura>());
            new ClienteConfig(builder.Entity<Cliente>());
            new ProductoConfig(builder.Entity<Producto>());
            new PedidoConfig(builder.Entity<Pedido>());
        }

        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }



    }
}
