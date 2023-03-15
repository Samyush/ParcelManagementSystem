﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParcelManagementSystemMVC.DBContext.Parcel;

#nullable disable

namespace ParcelManagementSystemMVC.Migrations
{
    [DbContext(typeof(ParcelDBContext))]
    partial class ParcelDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Branch", b =>
                {
                    b.Property<int>("Branch_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Branch_Id"));

                    b.Property<string>("BranchCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parcel_Id")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Branch_Id");

                    b.HasIndex("Parcel_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.HistoryofParcel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Documents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedTS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextNode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parcel_Id")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Parcel_Id");

                    b.ToTable("ParcelHistory");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.Parcel", b =>
                {
                    b.Property<int>("Parcel_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Parcel_Id"));

                    b.Property<string>("ArrivedatDestination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FaildDelivery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InTransit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParcelLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipmentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<string>("WayBillNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Parcel_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.ParcelCharges", b =>
                {
                    b.Property<int>("Charge_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Charge_Id"));

                    b.Property<int>("DuePaid")
                        .HasColumnType("int");

                    b.Property<int>("Parcel_Id")
                        .HasColumnType("int");

                    b.Property<string>("Pay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("VAT")
                        .HasColumnType("int");

                    b.HasKey("Charge_Id");

                    b.HasIndex("Parcel_Id");

                    b.ToTable("Charges");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.ParcelPackage", b =>
                {
                    b.Property<int>("Package_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Package_Id"));

                    b.Property<int>("AcutalWeight")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LorryNo")
                        .HasColumnType("int");

                    b.Property<int>("PacketsNumber")
                        .HasColumnType("int");

                    b.Property<int>("Parcel_Id")
                        .HasColumnType("int");

                    b.Property<int>("TIN_No")
                        .HasColumnType("int");

                    b.Property<int>("ValueOfGoods")
                        .HasColumnType("int");

                    b.HasKey("Package_Id");

                    b.HasIndex("Parcel_Id");

                    b.ToTable("ParcelPackages");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.User.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<string>("AccessRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsExternal")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Branch", b =>
                {
                    b.HasOne("ParcelManagementSystemMVC.DBContext.Parcel.Parcel", "parcel")
                        .WithMany()
                        .HasForeignKey("Parcel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParcelManagementSystemMVC.DBContext.User.User", "UserBranch")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserBranch");

                    b.Navigation("parcel");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.HistoryofParcel", b =>
                {
                    b.HasOne("ParcelManagementSystemMVC.DBContext.Parcel.Parcel", "parcel")
                        .WithMany()
                        .HasForeignKey("Parcel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("parcel");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.Parcel", b =>
                {
                    b.HasOne("ParcelManagementSystemMVC.DBContext.User.User", "userParcel")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userParcel");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.ParcelCharges", b =>
                {
                    b.HasOne("ParcelManagementSystemMVC.DBContext.Parcel.Parcel", "parcel")
                        .WithMany()
                        .HasForeignKey("Parcel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("parcel");
                });

            modelBuilder.Entity("ParcelManagementSystemMVC.DBContext.Parcel.ParcelPackage", b =>
                {
                    b.HasOne("ParcelManagementSystemMVC.DBContext.Parcel.Parcel", "parcel")
                        .WithMany()
                        .HasForeignKey("Parcel_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("parcel");
                });
#pragma warning restore 612, 618
        }
    }
}
