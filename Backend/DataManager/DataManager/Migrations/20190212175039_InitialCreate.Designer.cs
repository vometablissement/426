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
    [Migration("20190212175039_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataManager.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<long?>("RightsRefIdRightsId");

                    b.HasKey("PersonId");

                    b.HasIndex("RightsRefIdRightsId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DataManager.Models.Rights", b =>
                {
                    b.Property<long>("RightsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RightsStatus");

                    b.HasKey("RightsId");

                    b.ToTable("Rights");
                });

            modelBuilder.Entity("DataManager.Models.Admin", b =>
                {
                    b.HasBaseType("DataManager.Models.Person");

                    b.Property<string>("BackupEmail");

                    b.ToTable("Admin");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("DataManager.Models.User", b =>
                {
                    b.HasBaseType("DataManager.Models.Person");

                    b.Property<int>("Money");

                    b.ToTable("User");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("DataManager.Models.Person", b =>
                {
                    b.HasOne("DataManager.Models.Rights", "RightsRefId")
                        .WithMany("Persons")
                        .HasForeignKey("RightsRefIdRightsId");
                });
#pragma warning restore 612, 618
        }
    }
}
