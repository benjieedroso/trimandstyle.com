using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trimandstyle.com.Migrations
{
    public partial class RemoveConnectionFromCustomersInBarbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbers_Customers_CustomerFK",
                table: "Barbers");

            migrationBuilder.DropIndex(
                name: "IX_Barbers_CustomerFK",
                table: "Barbers");

            migrationBuilder.DropColumn(
                name: "CustomerFK",
                table: "Barbers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerFK",
                table: "Barbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Barbers_CustomerFK",
                table: "Barbers",
                column: "CustomerFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Barbers_Customers_CustomerFK",
                table: "Barbers",
                column: "CustomerFK",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
