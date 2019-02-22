﻿// <auto-generated />
using System;
using DataManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataManager.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190221174510_intit15")]
    partial class intit15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataManager.Models.File", b =>
                {
                    b.Property<long>("FileId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<string>("FilePath");

                    b.Property<string>("PersonId");

                    b.Property<long?>("PersonId1");

                    b.HasKey("FileId");

                    b.HasIndex("PersonId1");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("DataManager.Models.Person", b =>
                {
                    b.Property<long>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("OrganisationName");

                    b.Property<string>("Password");

                    b.Property<string>("Rights");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DataManager.Models.File", b =>
                {
                    b.HasOne("DataManager.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId1");
                });
#pragma warning restore 612, 618
        }
    }
}
