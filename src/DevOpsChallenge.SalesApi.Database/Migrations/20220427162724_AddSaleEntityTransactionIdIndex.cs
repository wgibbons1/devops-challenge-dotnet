using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsChallenge.SalesApi.Database.Migrations
{
    public partial class AddSaleEntityTransactionIdIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sale_TransactionId",
                table: "Sale",
                column: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sale_TransactionId",
                table: "Sale");
        }
    }
}
