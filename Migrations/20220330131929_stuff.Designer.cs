﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using uas.Data;

namespace uas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220330131929_stuff")]
    partial class stuff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("uas.Models.Roles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tb_Roles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("uas.Models.Stuff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gambar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Harga")
                        .HasColumnType("int");

                    b.Property<string>("NamaBarang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.Property<int>("Terjual")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tb_Barang");
                });

            modelBuilder.Entity("uas.Models.User", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("RolesId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.HasIndex("RolesId");

                    b.ToTable("Tb_User");
                });

            modelBuilder.Entity("uas.Models.User", b =>
                {
                    b.HasOne("uas.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}