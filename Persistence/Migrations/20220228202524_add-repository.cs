using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addrepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Vendedores",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Pedidos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "Facturas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DetallePedidoId",
                table: "DetallePedidos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AlmacenId",
                table: "Almacenes",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendedores",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productos",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pedidos",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Facturas",
                newName: "FacturaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DetallePedidos",
                newName: "DetallePedidoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "Clienteid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Almacenes",
                newName: "AlmacenId");
        }
    }
}
