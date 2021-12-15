﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Test.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Test.Models.NTN0535", b =>
                {
                    b.Property<string>("NTNId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("NTNGender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NTNName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("NTNId");

                    b.ToTable("NTN0535s");
                });

            modelBuilder.Entity("Test.Models.PersonNTN535", b =>
                {
                    b.Property<string>("PersonId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("PersonNTN535s");
                });
#pragma warning restore 612, 618
        }
    }
}
