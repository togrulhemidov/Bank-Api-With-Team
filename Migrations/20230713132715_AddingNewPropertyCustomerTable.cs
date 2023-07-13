using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_App_With_Team.Migrations
{
    public partial class AddingNewPropertyCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CardCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CardCustomers_CustomerId",
                table: "CardCustomers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardCustomers_Customers_CustomerId",
                table: "CardCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardCustomers_Customers_CustomerId",
                table: "CardCustomers");

            migrationBuilder.DropIndex(
                name: "IX_CardCustomers_CustomerId",
                table: "CardCustomers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CardCustomers");
        }
    }
}
