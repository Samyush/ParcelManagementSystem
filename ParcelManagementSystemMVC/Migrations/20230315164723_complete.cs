using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class complete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Parcel_Id",
                table: "Charges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Charges_Parcel_Id",
                table: "Charges",
                column: "Parcel_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Charges_Parcels_Parcel_Id",
                table: "Charges",
                column: "Parcel_Id",
                principalTable: "Parcels",
                principalColumn: "Parcel_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charges_Parcels_Parcel_Id",
                table: "Charges");

            migrationBuilder.DropIndex(
                name: "IX_Charges_Parcel_Id",
                table: "Charges");

            migrationBuilder.DropColumn(
                name: "Parcel_Id",
                table: "Charges");
        }
    }
}
