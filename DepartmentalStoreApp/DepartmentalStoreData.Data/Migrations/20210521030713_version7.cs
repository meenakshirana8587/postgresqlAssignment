using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentalStoreApp.Data.Migrations
{
    public partial class version7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Address",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
