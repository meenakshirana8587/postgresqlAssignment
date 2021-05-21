using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentalStoreApp.Data.Migrations
{
    public partial class configurePurchaseOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_PurchaseOrder_PurchaseOrderId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_PurchaseOrderId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ProductId",
                table: "PurchaseOrder",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Product_ProductId",
                table: "PurchaseOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Product_ProductId",
                table: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_ProductId",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<long>(
                name: "PurchaseOrderId",
                table: "Product",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PurchaseOrderId",
                table: "Product",
                column: "PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_PurchaseOrder_PurchaseOrderId",
                table: "Product",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
