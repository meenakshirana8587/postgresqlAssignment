using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentalStoreApp.Data.Migrations
{
    public partial class updatepurchaseorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId",
                unique: true);
        }
    }
}
