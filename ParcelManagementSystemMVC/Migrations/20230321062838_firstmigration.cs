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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Parcel",
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
                    table.PrimaryKey("PK_Parcel", x => x.Percel_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
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
                    table.PrimaryKey("PK_User", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_chargedbs_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_HistoryParcel_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_packagedbs_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_receiverdetail_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_senderdetail_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_UpdateParcel_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_rolesdbs_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
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
                        name: "FK_totalStaffdbs_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
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
                        name: "FK_branches_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                        name: "FK_staff_Parcel_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcel",
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Branchdbs");

            migrationBuilder.DropTable(
                name: "totalStaffdbs");

            migrationBuilder.DropTable(
                name: "Parcel");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
