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
                name: "historydbs",
                columns: table => new
                {
                    historey_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    next_node = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    shipment_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modified_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modified_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    document = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historydbs", x => x.historey_id);
                });

            migrationBuilder.CreateTable(
                name: "rolesdbs",
                columns: table => new
                {
                    roll_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolesdbs", x => x.roll_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<int>(type: "int", nullable: false),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    External = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    rolesdbroll_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                    table.ForeignKey(
                        name: "FK_Users_rolesdbs_rolesdbroll_id",
                        column: x => x.rolesdbroll_id,
                        principalTable: "rolesdbs",
                        principalColumn: "roll_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branchdbs",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchdbs", x => x.Branch_ID);
                    table.ForeignKey(
                        name: "FK_Branchdbs_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "User_id");
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
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobtitledbs", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_jobtitledbs_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "totalStaffdbs",
                columns: table => new
                {
                    st_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    st_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    User_id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_totalStaffdbs", x => x.st_id);
                    table.ForeignKey(
                        name: "FK_totalStaffdbs_Users_User_id1",
                        column: x => x.User_id1,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Percel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parcel_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Receiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Original_Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_and_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Way_Bill_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_of_Delivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_of_Delivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No_of_Packets = table.Column<int>(type: "int", nullable: false),
                    Desciption_of_Goods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actual_Weight = table.Column<float>(type: "real", nullable: false),
                    Values_of_Goods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To_Pay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Due_Paid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    G_Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lolary_No = table.Column<int>(type: "int", nullable: false),
                    Tin_No = table.Column<int>(type: "int", nullable: false),
                    Branch_Code = table.Column<int>(type: "int", nullable: false),
                    Sender_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History_of_Parcel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_id = table.Column<int>(type: "int", nullable: false),
                    branchdbBranch_ID = table.Column<int>(type: "int", nullable: false),
                    roll_id = table.Column<int>(type: "int", nullable: false),
                    history_id = table.Column<int>(type: "int", nullable: false),
                    historydbshistorey_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Percel_Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Branchdbs_branchdbBranch_ID",
                        column: x => x.branchdbBranch_ID,
                        principalTable: "Branchdbs",
                        principalColumn: "Branch_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parcels_historydbs_historydbshistorey_id",
                        column: x => x.historydbshistorey_id,
                        principalTable: "historydbs",
                        principalColumn: "historey_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parcels_rolesdbs_roll_id",
                        column: x => x.roll_id,
                        principalTable: "rolesdbs",
                        principalColumn: "roll_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branchdbs_User_id",
                table: "Branchdbs",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_jobtitledbs_userId",
                table: "jobtitledbs",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_branchdbBranch_ID",
                table: "Parcels",
                column: "branchdbBranch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_historydbshistorey_id",
                table: "Parcels",
                column: "historydbshistorey_id");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_roll_id",
                table: "Parcels",
                column: "roll_id");

            migrationBuilder.CreateIndex(
                name: "IX_totalStaffdbs_User_id1",
                table: "totalStaffdbs",
                column: "User_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_rolesdbroll_id",
                table: "Users",
                column: "rolesdbroll_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobtitledbs");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "totalStaffdbs");

            migrationBuilder.DropTable(
                name: "Branchdbs");

            migrationBuilder.DropTable(
                name: "historydbs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "rolesdbs");
        }
    }
}
