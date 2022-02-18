using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiedoShopping.ProductApi.Migrations
{
    public partial class AtualizaNomeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Product",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "id");
        }
    }
}
