using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstAPIProject.Migrations
{
    public partial class MyFirstAPIProjectModelsCustomerManagementContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "IsOldCustomer", "Name", "Phone" },
                values: new object[] { 1, false, "Ramu", "987654321" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);
        }
    }
}
