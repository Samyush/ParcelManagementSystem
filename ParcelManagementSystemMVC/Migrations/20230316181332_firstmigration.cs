using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchdbs",
                columns: table => new
                {
                    Branch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCountry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchdbs", x => x.Branch_Id);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Percel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Way_Bill_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Next_Node = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_and_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sender_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Shipment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Percel_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "chargedbs",
                columns: table => new
                {
                    Charge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Due_Paid = table.Column<float>(type: "real", nullable: false),
                    Vat = table.Column<float>(type: "real", nullable: false),
                    G_Total = table.Column<float>(type: "real", nullable: false),
                    Percel_Id = table.Column<int>(type: "int", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chargedbs", x => x.Charge_Id);
                    table.ForeignKey(
                        name: "FK_chargedbs_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryParcel",
                columns: table => new
                {
                    History_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percel_Id = table.Column<int>(type: "int", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryParcel", x => x.History_Id);
                    table.ForeignKey(
                        name: "FK_HistoryParcel_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "packagedbs",
                columns: table => new
                {
                    Package_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No_of_Package = table.Column<int>(type: "int", nullable: false),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actual_Wait = table.Column<float>(type: "real", nullable: false),
                    Values_of_goods = table.Column<float>(type: "real", nullable: false),
                    Lorry_No = table.Column<int>(type: "int", nullable: false),
                    Tin = table.Column<int>(type: "int", nullable: false),
                    Percel_Id = table.Column<int>(type: "int", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packagedbs", x => x.Package_Id);
                    table.ForeignKey(
                        name: "FK_packagedbs_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "receiverdetail",
                columns: table => new
                {
                    receiverid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    receivername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receiverdetail", x => x.receiverid);
                    table.ForeignKey(
                        name: "FK_receiverdetail_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "senderdetail",
                columns: table => new
                {
                    senderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sendername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_senderdetail", x => x.senderid);
                    table.ForeignKey(
                        name: "FK_senderdetail_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpdateParcel",
                columns: table => new
                {
                    Update_Parcel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateParcel", x => x.Update_Parcel_Id);
                    table.ForeignKey(
                        name: "FK_UpdateParcel_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rolesdbs",
                columns: table => new
                {
                    Roll_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolesdbs", x => x.Roll_Id);
                    table.ForeignKey(
                        name: "FK_rolesdbs_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "totalStaffdbs",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    St_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    St_Salary = table.Column<float>(type: "real", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_totalStaffdbs", x => x.St_Id);
                    table.ForeignKey(
                        name: "FK_totalStaffdbs_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_Id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Id = table.Column<int>(type: "int", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.id);
                    table.ForeignKey(
                        name: "FK_branches_Branchdbs_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Branchdbs",
                        principalColumn: "Branch_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_branches_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_branches_totalStaffdbs_St_Id",
                        column: x => x.St_Id,
                        principalTable: "totalStaffdbs",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jobtitledbs",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    job_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    job_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobtitledbs", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_jobtitledbs_totalStaffdbs_St_Id",
                        column: x => x.St_Id,
                        principalTable: "totalStaffdbs",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false),
                    Create_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modify_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percel_Id = table.Column<int>(type: "int", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff", x => x.St_Id);
                    table.ForeignKey(
                        name: "FK_staff_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Percel_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_staff_totalStaffdbs_St_Id",
                        column: x => x.St_Id,
                        principalTable: "totalStaffdbs",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_branches_Branch_Id",
                table: "branches",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_branches_Parcel_Id",
                table: "branches",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_branches_St_Id",
                table: "branches",
                column: "St_Id");

            migrationBuilder.CreateIndex(
                name: "IX_chargedbs_Parcel_Id",
                table: "chargedbs",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParcel_Parcel_Id",
                table: "HistoryParcel",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_jobtitledbs_St_Id",
                table: "jobtitledbs",
                column: "St_Id");

            migrationBuilder.CreateIndex(
                name: "IX_packagedbs_Parcel_Id",
                table: "packagedbs",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_receiverdetail_Parcel_Id",
                table: "receiverdetail",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_rolesdbs_User_Id",
                table: "rolesdbs",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_senderdetail_Parcel_Id",
                table: "senderdetail",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_staff_Parcel_Id",
                table: "staff",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_totalStaffdbs_User_Id",
                table: "totalStaffdbs",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateParcel_Parcel_Id",
                table: "UpdateParcel",
                column: "Parcel_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "chargedbs");

            migrationBuilder.DropTable(
                name: "HistoryParcel");

            migrationBuilder.DropTable(
                name: "jobtitledbs");

            migrationBuilder.DropTable(
                name: "packagedbs");

            migrationBuilder.DropTable(
                name: "receiverdetail");

            migrationBuilder.DropTable(
                name: "rolesdbs");

            migrationBuilder.DropTable(
                name: "senderdetail");

            migrationBuilder.DropTable(
                name: "staff");

            migrationBuilder.DropTable(
                name: "UpdateParcel");

            migrationBuilder.DropTable(
                name: "Branchdbs");

            migrationBuilder.DropTable(
                name: "totalStaffdbs");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
