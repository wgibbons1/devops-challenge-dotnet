using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsChallenge.SalesApi.Database.Migrations
{
    public partial class AddIndexToSaleEntityDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sale_Date",
                table: "Sale",
                column: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sale_Date",
                table: "Sale");
        }
    }
}
