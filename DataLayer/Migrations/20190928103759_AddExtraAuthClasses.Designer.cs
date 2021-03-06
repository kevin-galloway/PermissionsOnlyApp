﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190928103759_AddExtraAuthClasses")]
    partial class AddExtraAuthClasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.ExtraAuthClasses.ModulesForUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<long>("AllowedPaidForModules")
                        .HasColumnType("bigint");

                    b.HasKey("UserId");

                    b.ToTable("ModulesForUsers");
                });

            modelBuilder.Entity("DataLayer.ExtraAuthClasses.RoleToPermissions", b =>
                {
                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_permissionsInRole")
                        .IsRequired()
                        .HasColumnName("PermissionsInRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleName");

                    b.ToTable("RolesToPermissions");
                });

            modelBuilder.Entity("DataLayer.ExtraAuthClasses.UserToRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(36)")
                        .HasMaxLength(36);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UserId", "RoleName");

                    b.HasIndex("RoleName");

                    b.ToTable("UserToRoles");
                });

            modelBuilder.Entity("DataLayer.ExtraAuthClasses.UserToRole", b =>
                {
                    b.HasOne("DataLayer.ExtraAuthClasses.RoleToPermissions", "Role")
                        .WithMany()
                        .HasForeignKey("RoleName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
