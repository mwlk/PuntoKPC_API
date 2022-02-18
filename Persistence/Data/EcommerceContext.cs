using Microsoft.EntityFrameworkCore;
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

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
