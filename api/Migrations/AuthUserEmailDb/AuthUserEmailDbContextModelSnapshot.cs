﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.auth.Data;

#nullable disable

namespace api.Migrations.AuthUserEmailDb
{
    [DbContext(typeof(AuthUserEmailDbContext))]
    partial class AuthUserEmailDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api.auth.Model.AuthUserEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserAuthId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserAuthId")
                        .IsUnique();

                    b.ToTable("AuthenthicateUserEmail");
                });

            modelBuilder.Entity("api.Models.auth.Model.UsersAuth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("usersAuthenthicate");
                });

            modelBuilder.Entity("api.auth.Model.AuthUserEmail", b =>
                {
                    b.HasOne("api.Models.auth.Model.UsersAuth", "UsersAuth")
                        .WithOne("authUserEmail")
                        .HasForeignKey("api.auth.Model.AuthUserEmail", "UserAuthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsersAuth");
                });

            modelBuilder.Entity("api.Models.auth.Model.UsersAuth", b =>
                {
                    b.Navigation("authUserEmail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
