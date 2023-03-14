using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Parcel_Id",
                table: "Sender",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parcel_Id",
                table: "Receiver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parcel_Id",
                table: "ParcelPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parcel_Id",
                table: "Charges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AdminUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sender_Parcel_Id",
                table: "Sender",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_Parcel_Id",
                table: "Receiver",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelPackages_Parcel_Id",
                table: "ParcelPackages",
                column: "Parcel_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ParcelPackages_Parcels_Parcel_Id",
                table: "ParcelPackages",
                column: "Parcel_Id",
                principalTable: "Parcels",
                principalColumn: "Parcel_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receiver_Parcels_Parcel_Id",
                table: "Receiver",
                column: "Parcel_Id",
                principalTable: "Parcels",
                principalColumn: "Parcel_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sender_Parcels_Parcel_Id",
                table: "Sender",
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

            migrationBuilder.DropForeignKey(
                name: "FK_ParcelPackages_Parcels_Parcel_Id",
                table: "ParcelPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Receiver_Parcels_Parcel_Id",
                table: "Receiver");

            migrationBuilder.DropForeignKey(
                name: "FK_Sender_Parcels_Parcel_Id",
                table: "Sender");

            migrationBuilder.DropIndex(
                name: "IX_Sender_Parcel_Id",
                table: "Sender");

            migrationBuilder.DropIndex(
                name: "IX_Receiver_Parcel_Id",
                table: "Receiver");

            migrationBuilder.DropIndex(
                name: "IX_ParcelPackages_Parcel_Id",
                table: "ParcelPackages");

            migrationBuilder.DropIndex(
                name: "IX_Charges_Parcel_Id",
                table: "Charges");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Parcel_Id",
                table: "Sender");

            migrationBuilder.DropColumn(
                name: "Parcel_Id",
                table: "Receiver");

            migrationBuilder.DropColumn(
                name: "Parcel_Id",
                table: "ParcelPackages");

            migrationBuilder.DropColumn(
                name: "Parcel_Id",
                table: "Charges");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AdminUser");
        }
    }
}
