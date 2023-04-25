using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class baseclassremove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Branch");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Branch",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Branch",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
