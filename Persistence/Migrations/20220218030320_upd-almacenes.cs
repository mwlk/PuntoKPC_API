using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updalmacenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Almacenes_ProductoId",
                table: "Almacenes",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Almacenes_Productos_ProductoId",
                table: "Almacenes",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Almacenes_Productos_ProductoId",
                table: "Almacenes");

            migrationBuilder.DropIndex(
                name: "IX_Almacenes_ProductoId",
                table: "Almacenes");
        }
    }
}
