﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using net.core.ef.Models;

namespace net.core.ef.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20190520035235_initalCreate")]
    partial class initalCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("net.core.ef.Models.Auther", b =>
                {
                    b.Property<int>("AutherID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("AutherID");

                    b.ToTable("Authers");
                });

            modelBuilder.Entity("net.core.ef.Models.Book", b =>
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

            modelBuilder.Entity("net.core.ef.Models.Book", b =>
                {
                    b.HasOne("net.core.ef.Models.Auther", "Auther")
                        .WithMany("Books")
                        .HasForeignKey("AutherID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}