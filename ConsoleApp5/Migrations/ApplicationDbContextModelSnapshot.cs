﻿// <auto-generated />
using System;
using ConsoleApp5.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp5.Model.Entity.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfBorn")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Author_p");
                });

            modelBuilder.Entity("ConsoleApp5.Model.Entity.Picture", b =>
                {
                    b.Property<int>("Id_p")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_p"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Name_p")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year_p")
                        .HasColumnType("int");

                    b.HasKey("Id_p");

                    b.HasIndex("AuthorId");

                    b.ToTable("Picture_p");
                });

            modelBuilder.Entity("ConsoleApp5.Model.Entity.Picture", b =>
                {
                    b.HasOne("ConsoleApp5.Model.Entity.Author", "Author")
                        .WithMany("Pictures")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ConsoleApp5.Model.Entity.Author", b =>
                {
                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}
