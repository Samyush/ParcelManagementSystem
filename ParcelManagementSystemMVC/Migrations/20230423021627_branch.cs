using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class branch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Branch",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "TotalStaff",
                table: "Branch",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalStaff",
                table: "Branch");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branch",
                newName: "id");
        }
    }
}
