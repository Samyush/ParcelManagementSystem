using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    TotalStaff = table.Column<int>(type: "int", nullable: false),
                    Actions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "ListofUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    External = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchesBranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListofUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_ListofUsers_Branches_BranchesBranchId",
                        column: x => x.BranchesBranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receivers",
                columns: table => new
                {
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ParcelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivers", x => x.ReceiverId);
                    table.ForeignKey(
                        name: "FK_Receivers_ListofUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "ListofUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Senders",
                columns: table => new
                {
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ParcelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senders", x => x.SenderId);
                    table.ForeignKey(
                        name: "FK_Senders_ListofUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "ListofUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    ParcelId = table.Column<int>(type: "int", nullable: false),
                    WayBillNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.ParcelId);
                    table.ForeignKey(
                        name: "FK_Parcels_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parcels_Receivers_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Receivers",
                        principalColumn: "ReceiverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parcels_Senders_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Senders",
                        principalColumn: "SenderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sender_Receiver",
                columns: table => new
                {
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sender_Receiver", x => new { x.SenderId, x.ReceiverId });
                    table.ForeignKey(
                        name: "FK_Sender_Receiver_Receivers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Receivers",
                        principalColumn: "ReceiverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sender_Receiver_Senders_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Senders",
                        principalColumn: "SenderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HOP",
                columns: table => new
                {
                    ParcelId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextNode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HOP_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "ParcelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HOP_ParcelId",
                table: "HOP",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_ListofUsers_BranchesBranchId",
                table: "ListofUsers",
                column: "BranchesBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_BranchId",
                table: "Parcels",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Sender_Receiver_ReceiverId",
                table: "Sender_Receiver",
                column: "ReceiverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOP");

            migrationBuilder.DropTable(
                name: "Sender_Receiver");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "Receivers");

            migrationBuilder.DropTable(
                name: "Senders");

            migrationBuilder.DropTable(
                name: "ListofUsers");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
