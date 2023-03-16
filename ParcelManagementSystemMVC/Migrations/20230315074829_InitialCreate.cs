using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
<<<<<<<< HEAD:ParcelManagementSystemMVC/Migrations/20230315164329_new.cs
                name: "Charges",
                columns: table => new
                {
                    Charge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Pay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuePaid = table.Column<int>(type: "int", nullable: false),
                    VAT = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Charge_Id);
========
                name: "AdminRole",
                columns: table => new
                {
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => x.Role_Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminUser",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsExternal = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUser", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_Id);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WayBillNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcelLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Parcel_Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Setting_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FontSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Setting_Id);
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/Migrations/20230315074829_InitialCreate.cs
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsExternal = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:ParcelManagementSystemMVC/Migrations/20230315164329_new.cs
                name: "Parcels",
                columns: table => new
                {
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WayBillNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcelLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivedatDestination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InTransit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaildDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Parcel_Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_Id);
                    table.ForeignKey(
                        name: "FK_Branches_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Parcel_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParcelHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NextNode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documents = table.Column<string>(type: "nvarchar(max)", nullable: false),
========
                name: "Charges",
                columns: table => new
                {
                    Charge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Pay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuePaid = table.Column<int>(type: "int", nullable: false),
                    VAT = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/Migrations/20230315074829_InitialCreate.cs
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
<<<<<<<< HEAD:ParcelManagementSystemMVC/Migrations/20230315164329_new.cs
                    table.PrimaryKey("PK_ParcelHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParcelHistory_Parcels_Parcel_Id",
========
                    table.PrimaryKey("PK_Charges", x => x.Charge_Id);
                    table.ForeignKey(
                        name: "FK_Charges_Parcels_Parcel_Id",
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/Migrations/20230315074829_InitialCreate.cs
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Parcel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcelPackages",
                columns: table => new
                {
                    Package_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacketsNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcutalWeight = table.Column<int>(type: "int", nullable: false),
                    ValueOfGoods = table.Column<int>(type: "int", nullable: false),
                    LorryNo = table.Column<int>(type: "int", nullable: false),
                    TIN_No = table.Column<int>(type: "int", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelPackages", x => x.Package_Id);
                    table.ForeignKey(
                        name: "FK_ParcelPackages_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Parcel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

<<<<<<<< HEAD:ParcelManagementSystemMVC/Migrations/20230315164329_new.cs
            migrationBuilder.CreateIndex(
                name: "IX_Branches_Parcel_Id",
                table: "Branches",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_User_Id",
                table: "Branches",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelHistory_Parcel_Id",
                table: "ParcelHistory",
========
            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Receiver_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Receiver_Id);
                    table.ForeignKey(
                        name: "FK_Receiver_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Parcel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sender",
                columns: table => new
                {
                    Sender_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sender", x => x.Sender_Id);
                    table.ForeignKey(
                        name: "FK_Sender_Parcels_Parcel_Id",
                        column: x => x.Parcel_Id,
                        principalTable: "Parcels",
                        principalColumn: "Parcel_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Charges_Parcel_Id",
                table: "Charges",
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/Migrations/20230315074829_InitialCreate.cs
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelPackages_Parcel_Id",
                table: "ParcelPackages",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:ParcelManagementSystemMVC/Migrations/20230315164329_new.cs
                name: "IX_Parcels_User_Id",
                table: "Parcels",
                column: "User_Id");
========
                name: "IX_Receiver_Parcel_Id",
                table: "Receiver",
                column: "Parcel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sender_Parcel_Id",
                table: "Sender",
                column: "Parcel_Id");
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/Migrations/20230315074829_InitialCreate.cs
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "ParcelHistory");

            migrationBuilder.DropTable(
                name: "ParcelPackages");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:ParcelManagementSystemMVC/Migrations/20230315164329_new.cs
                name: "Parcels");
========
                name: "Receiver");

            migrationBuilder.DropTable(
                name: "Sender");

            migrationBuilder.DropTable(
                name: "Setting");
>>>>>>>> 85b107f41a5c053c0cc18363d4e886d92a2d0902:ParcelManagementSystemMVC/Migrations/20230315074829_InitialCreate.cs

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Parcels");
        }
    }
}
