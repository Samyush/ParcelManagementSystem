using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "productName",
                table: "addnewparcel",
                newName: "ProductName");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "addnewparcel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "addnewparcel",
                newName: "productName");

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "addnewparcel",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
