﻿// <auto-generated />
using System;
using MVC.EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC.EFCore.Migrations.BooksDB
{
    [DbContext(typeof(BooksDBContext))]
    [Migration("20190720023151_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC.EFCore.Models.Auther", b =>
                {
                    b.Property<int>("AutherID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("AutherID");

                    b.ToTable("Authers");
                });

            modelBuilder.Entity("MVC.EFCore.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutherID");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Name");

                    b.HasKey("BookID");

                    b.HasIndex("AutherID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MVC.EFCore.Models.Book", b =>
                {
                    b.HasOne("MVC.EFCore.Models.Auther", "Auther")
                        .WithMany("Books")
                        .HasForeignKey("AutherID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
